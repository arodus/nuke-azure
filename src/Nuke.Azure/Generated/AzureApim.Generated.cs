// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureApim.json
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
    public static partial class AzureApimTasks
    {
        /// <summary>
        ///   Path to the AzureApim executable.
        /// </summary>
        public static string AzureApimPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREAPIM_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureApimLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure API Management services.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureApim(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureApimPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureApimLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureApimApplyNetworkUpdates(AzureApimApplyNetworkUpdatesSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureApimApplyNetworkUpdatesSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureApimApplyNetworkUpdates(Configure<AzureApimApplyNetworkUpdatesSettings> configurator)
        {
            return AzureApimApplyNetworkUpdates(configurator(new AzureApimApplyNetworkUpdatesSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimApplyNetworkUpdatesSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureApimApplyNetworkUpdatesSettings Settings, IReadOnlyCollection<Output> Output)> AzureApimApplyNetworkUpdates(CombinatorialConfigure<AzureApimApplyNetworkUpdatesSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureApimApplyNetworkUpdates, AzureApimLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureApimBackup(AzureApimBackupSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureApimBackupSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureApimBackupSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimBackupSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureApimBackupSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureApimBackupSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimBackupSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimBackupSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureApimBackupSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimBackupSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimBackupSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureApimBackup(Configure<AzureApimBackupSettings> configurator)
        {
            return AzureApimBackup(configurator(new AzureApimBackupSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureApimBackupSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimBackupSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureApimBackupSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureApimBackupSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimBackupSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimBackupSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureApimBackupSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimBackupSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimBackupSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureApimBackupSettings Settings, IReadOnlyCollection<Output> Output)> AzureApimBackup(CombinatorialConfigure<AzureApimBackupSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureApimBackup, AzureApimLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureApimCheckName(AzureApimCheckNameSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureApimCheckNameSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureApimCheckNameSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimCheckNameSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureApimCheckNameSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimCheckNameSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimCheckNameSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimCheckNameSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimCheckNameSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureApimCheckName(Configure<AzureApimCheckNameSettings> configurator)
        {
            return AzureApimCheckName(configurator(new AzureApimCheckNameSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureApimCheckNameSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimCheckNameSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureApimCheckNameSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimCheckNameSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimCheckNameSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimCheckNameSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimCheckNameSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureApimCheckNameSettings Settings, IReadOnlyCollection<Output> Output)> AzureApimCheckName(CombinatorialConfigure<AzureApimCheckNameSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureApimCheckName, AzureApimLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureApimCreate(AzureApimCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureApimCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureApimCreateSettings.Debug"/></li>
        ///     <li><c>--enable-client-certificate</c> via <see cref="AzureApimCreateSettings.EnableClientCertificate"/></li>
        ///     <li><c>--enable-managed-identity</c> via <see cref="AzureApimCreateSettings.EnableManagedIdentity"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureApimCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureApimCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureApimCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimCreateSettings.Output"/></li>
        ///     <li><c>--publisher-email</c> via <see cref="AzureApimCreateSettings.PublisherEmail"/></li>
        ///     <li><c>--publisher-name</c> via <see cref="AzureApimCreateSettings.PublisherName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureApimCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-capacity</c> via <see cref="AzureApimCreateSettings.SkuCapacity"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureApimCreateSettings.SkuName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureApimCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimCreateSettings.Verbose"/></li>
        ///     <li><c>--virtual-network</c> via <see cref="AzureApimCreateSettings.VirtualNetwork"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureApimCreate(Configure<AzureApimCreateSettings> configurator)
        {
            return AzureApimCreate(configurator(new AzureApimCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureApimCreateSettings.Debug"/></li>
        ///     <li><c>--enable-client-certificate</c> via <see cref="AzureApimCreateSettings.EnableClientCertificate"/></li>
        ///     <li><c>--enable-managed-identity</c> via <see cref="AzureApimCreateSettings.EnableManagedIdentity"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureApimCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureApimCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureApimCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimCreateSettings.Output"/></li>
        ///     <li><c>--publisher-email</c> via <see cref="AzureApimCreateSettings.PublisherEmail"/></li>
        ///     <li><c>--publisher-name</c> via <see cref="AzureApimCreateSettings.PublisherName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureApimCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku-capacity</c> via <see cref="AzureApimCreateSettings.SkuCapacity"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureApimCreateSettings.SkuName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureApimCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimCreateSettings.Verbose"/></li>
        ///     <li><c>--virtual-network</c> via <see cref="AzureApimCreateSettings.VirtualNetwork"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureApimCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureApimCreate(CombinatorialConfigure<AzureApimCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureApimCreate, AzureApimLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureApimDelete(AzureApimDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureApimDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureApimDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureApimDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureApimDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureApimDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureApimDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureApimDelete(Configure<AzureApimDeleteSettings> configurator)
        {
            return AzureApimDelete(configurator(new AzureApimDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureApimDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureApimDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureApimDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureApimDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureApimDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureApimDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureApimDelete(CombinatorialConfigure<AzureApimDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureApimDelete, AzureApimLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureApimList(AzureApimListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureApimListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureApimListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureApimListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureApimList(Configure<AzureApimListSettings> configurator)
        {
            return AzureApimList(configurator(new AzureApimListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureApimListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureApimListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureApimListSettings Settings, IReadOnlyCollection<Output> Output)> AzureApimList(CombinatorialConfigure<AzureApimListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureApimList, AzureApimLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureApimShow(AzureApimShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureApimShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureApimShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureApimShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureApimShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureApimShow(Configure<AzureApimShowSettings> configurator)
        {
            return AzureApimShow(configurator(new AzureApimShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureApimShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureApimShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureApimShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureApimShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureApimShow(CombinatorialConfigure<AzureApimShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureApimShow, AzureApimLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureApimUpdate(AzureApimUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureApimUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureApimUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureApimUpdateSettings.Debug"/></li>
        ///     <li><c>--enable-client-certificate</c> via <see cref="AzureApimUpdateSettings.EnableClientCertificate"/></li>
        ///     <li><c>--enable-managed-identity</c> via <see cref="AzureApimUpdateSettings.EnableManagedIdentity"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureApimUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureApimUpdateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureApimUpdateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimUpdateSettings.Output"/></li>
        ///     <li><c>--publisher-email</c> via <see cref="AzureApimUpdateSettings.PublisherEmail"/></li>
        ///     <li><c>--publisher-name</c> via <see cref="AzureApimUpdateSettings.PublisherName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureApimUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureApimUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureApimUpdateSettings.Set"/></li>
        ///     <li><c>--sku-capacity</c> via <see cref="AzureApimUpdateSettings.SkuCapacity"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureApimUpdateSettings.SkuName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureApimUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimUpdateSettings.Verbose"/></li>
        ///     <li><c>--virtual-network</c> via <see cref="AzureApimUpdateSettings.VirtualNetwork"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureApimUpdate(Configure<AzureApimUpdateSettings> configurator)
        {
            return AzureApimUpdate(configurator(new AzureApimUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure API Management services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/apim?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureApimUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureApimUpdateSettings.Debug"/></li>
        ///     <li><c>--enable-client-certificate</c> via <see cref="AzureApimUpdateSettings.EnableClientCertificate"/></li>
        ///     <li><c>--enable-managed-identity</c> via <see cref="AzureApimUpdateSettings.EnableManagedIdentity"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureApimUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureApimUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureApimUpdateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureApimUpdateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureApimUpdateSettings.Output"/></li>
        ///     <li><c>--publisher-email</c> via <see cref="AzureApimUpdateSettings.PublisherEmail"/></li>
        ///     <li><c>--publisher-name</c> via <see cref="AzureApimUpdateSettings.PublisherName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureApimUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureApimUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureApimUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureApimUpdateSettings.Set"/></li>
        ///     <li><c>--sku-capacity</c> via <see cref="AzureApimUpdateSettings.SkuCapacity"/></li>
        ///     <li><c>--sku-name</c> via <see cref="AzureApimUpdateSettings.SkuName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureApimUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureApimUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureApimUpdateSettings.Verbose"/></li>
        ///     <li><c>--virtual-network</c> via <see cref="AzureApimUpdateSettings.VirtualNetwork"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureApimUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureApimUpdate(CombinatorialConfigure<AzureApimUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureApimUpdate, AzureApimLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureApimApplyNetworkUpdatesSettings
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureApimApplyNetworkUpdatesSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureApim executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureApimTasks.AzureApimPath;
        public override Action<OutputType, string> CustomLogger => AzureApimTasks.AzureApimLogger;
        /// <summary>
        ///   The name of the api management service instance.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
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
              .Add("apim apply-network-updates")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--location {value}", Location)
              .Add("--no-wait", NoWait)
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
    #region AzureApimBackupSettings
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureApimBackupSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureApim executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureApimTasks.AzureApimPath;
        public override Action<OutputType, string> CustomLogger => AzureApimTasks.AzureApimLogger;
        /// <summary>
        ///   The name of the api management service instance.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
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
              .Add("apim backup")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
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
    #region AzureApimCheckNameSettings
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureApimCheckNameSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureApim executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureApimTasks.AzureApimPath;
        public override Action<OutputType, string> CustomLogger => AzureApimTasks.AzureApimLogger;
        /// <summary>
        ///   The name of the api management service instance.
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
              .Add("apim check-name")
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
    #region AzureApimCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureApimCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureApim executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureApimTasks.AzureApimPath;
        public override Action<OutputType, string> CustomLogger => AzureApimTasks.AzureApimLogger;
        /// <summary>
        ///   Unique name of the service instance to be created.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The e-mail address to receive all system notifications.
        /// </summary>
        public virtual string PublisherEmail { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Enforces a client certificate to be presented on each request to the gateway and also enables the ability to authenticate the certificate in the policy on the gateway.
        /// </summary>
        public virtual bool? EnableClientCertificate { get; internal set; }
        /// <summary>
        ///   Create a managed identity for the API Management service to access other Azure resources.
        /// </summary>
        public virtual bool? EnableManagedIdentity { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   The name of your organization for use in the developer portal and e-mail notifications.
        /// </summary>
        public virtual string PublisherName { get; internal set; }
        /// <summary>
        ///   The number of deployed units of the SKU.
        /// </summary>
        public virtual string SkuCapacity { get; internal set; }
        /// <summary>
        ///   The sku of the api management instance.
        /// </summary>
        public virtual ApimSkuName SkuName { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   The virtual network type.
        /// </summary>
        public virtual ApimVirtualNetwork VirtualNetwork { get; internal set; }
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
              .Add("apim create")
              .Add("--name {value}", Name)
              .Add("--publisher-email {value}", PublisherEmail)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--enable-client-certificate", EnableClientCertificate)
              .Add("--enable-managed-identity", EnableManagedIdentity)
              .Add("--location {value}", Location)
              .Add("--no-wait", NoWait)
              .Add("--publisher-name {value}", PublisherName)
              .Add("--sku-capacity {value}", SkuCapacity)
              .Add("--sku-name {value}", SkuName)
              .Add("--tags {value}", Tags)
              .Add("--virtual-network {value}", VirtualNetwork)
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
    #region AzureApimDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureApimDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureApim executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureApimTasks.AzureApimPath;
        public override Action<OutputType, string> CustomLogger => AzureApimTasks.AzureApimLogger;
        /// <summary>
        ///   The name of the api management service instance.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
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
              .Add("apim delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
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
    #region AzureApimListSettings
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureApimListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureApim executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureApimTasks.AzureApimPath;
        public override Action<OutputType, string> CustomLogger => AzureApimTasks.AzureApimLogger;
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
              .Add("apim list")
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
    #region AzureApimShowSettings
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureApimShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureApim executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureApimTasks.AzureApimPath;
        public override Action<OutputType, string> CustomLogger => AzureApimTasks.AzureApimLogger;
        /// <summary>
        ///   The name of the api management service instance.
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
              .Add("apim show")
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
    #region AzureApimUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureApimUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureApim executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureApimTasks.AzureApimPath;
        public override Action<OutputType, string> CustomLogger => AzureApimTasks.AzureApimLogger;
        /// <summary>
        ///   The name of the api management service instance.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Enforces a client certificate to be presented on each request to the gateway and also enables the ability to authenticate the certificate in the policy on the gateway.
        /// </summary>
        public virtual bool? EnableClientCertificate { get; internal set; }
        /// <summary>
        ///   Create a managed identity for the API Management service to access other Azure resources.
        /// </summary>
        public virtual bool? EnableManagedIdentity { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   The e-mail address to receive all system notifications.
        /// </summary>
        public virtual string PublisherEmail { get; internal set; }
        /// <summary>
        ///   The name of your organization for use in the developer portal and e-mail notifications.
        /// </summary>
        public virtual string PublisherName { get; internal set; }
        /// <summary>
        ///   The number of deployed units of the SKU.
        /// </summary>
        public virtual string SkuCapacity { get; internal set; }
        /// <summary>
        ///   The sku of the api management instance.
        /// </summary>
        public virtual ApimSkuName SkuName { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   The virtual network type.
        /// </summary>
        public virtual ApimVirtualNetwork VirtualNetwork { get; internal set; }
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
              .Add("apim update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--enable-client-certificate", EnableClientCertificate)
              .Add("--enable-managed-identity", EnableManagedIdentity)
              .Add("--no-wait", NoWait)
              .Add("--publisher-email {value}", PublisherEmail)
              .Add("--publisher-name {value}", PublisherName)
              .Add("--sku-capacity {value}", SkuCapacity)
              .Add("--sku-name {value}", SkuName)
              .Add("--tags {value}", Tags)
              .Add("--virtual-network {value}", VirtualNetwork)
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
    #region AzureApimApplyNetworkUpdatesSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureApimApplyNetworkUpdatesSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimApplyNetworkUpdatesSettings.Name"/></em></p>
        ///   <p>The name of the api management service instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings SetName(this AzureApimApplyNetworkUpdatesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimApplyNetworkUpdatesSettings.Name"/></em></p>
        ///   <p>The name of the api management service instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings ResetName(this AzureApimApplyNetworkUpdatesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimApplyNetworkUpdatesSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings SetResourceGroup(this AzureApimApplyNetworkUpdatesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimApplyNetworkUpdatesSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings ResetResourceGroup(this AzureApimApplyNetworkUpdatesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimApplyNetworkUpdatesSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings SetLocation(this AzureApimApplyNetworkUpdatesSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimApplyNetworkUpdatesSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings ResetLocation(this AzureApimApplyNetworkUpdatesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimApplyNetworkUpdatesSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings SetNoWait(this AzureApimApplyNetworkUpdatesSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimApplyNetworkUpdatesSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings ResetNoWait(this AzureApimApplyNetworkUpdatesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureApimApplyNetworkUpdatesSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings EnableNoWait(this AzureApimApplyNetworkUpdatesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureApimApplyNetworkUpdatesSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings DisableNoWait(this AzureApimApplyNetworkUpdatesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureApimApplyNetworkUpdatesSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings ToggleNoWait(this AzureApimApplyNetworkUpdatesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimApplyNetworkUpdatesSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings SetSubscription(this AzureApimApplyNetworkUpdatesSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimApplyNetworkUpdatesSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings ResetSubscription(this AzureApimApplyNetworkUpdatesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimApplyNetworkUpdatesSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings SetDebug(this AzureApimApplyNetworkUpdatesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimApplyNetworkUpdatesSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings ResetDebug(this AzureApimApplyNetworkUpdatesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimApplyNetworkUpdatesSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings SetHelp(this AzureApimApplyNetworkUpdatesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimApplyNetworkUpdatesSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings ResetHelp(this AzureApimApplyNetworkUpdatesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimApplyNetworkUpdatesSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings SetOutput(this AzureApimApplyNetworkUpdatesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimApplyNetworkUpdatesSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings ResetOutput(this AzureApimApplyNetworkUpdatesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimApplyNetworkUpdatesSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings SetQuery(this AzureApimApplyNetworkUpdatesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimApplyNetworkUpdatesSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings ResetQuery(this AzureApimApplyNetworkUpdatesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimApplyNetworkUpdatesSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings SetVerbose(this AzureApimApplyNetworkUpdatesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimApplyNetworkUpdatesSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimApplyNetworkUpdatesSettings ResetVerbose(this AzureApimApplyNetworkUpdatesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureApimBackupSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureApimBackupSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimBackupSettings.Name"/></em></p>
        ///   <p>The name of the api management service instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings SetName(this AzureApimBackupSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimBackupSettings.Name"/></em></p>
        ///   <p>The name of the api management service instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings ResetName(this AzureApimBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimBackupSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings SetResourceGroup(this AzureApimBackupSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimBackupSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings ResetResourceGroup(this AzureApimBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimBackupSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings SetNoWait(this AzureApimBackupSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimBackupSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings ResetNoWait(this AzureApimBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureApimBackupSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings EnableNoWait(this AzureApimBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureApimBackupSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings DisableNoWait(this AzureApimBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureApimBackupSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings ToggleNoWait(this AzureApimBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimBackupSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings SetSubscription(this AzureApimBackupSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimBackupSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings ResetSubscription(this AzureApimBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimBackupSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings SetDebug(this AzureApimBackupSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimBackupSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings ResetDebug(this AzureApimBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimBackupSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings SetHelp(this AzureApimBackupSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimBackupSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings ResetHelp(this AzureApimBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimBackupSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings SetOutput(this AzureApimBackupSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimBackupSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings ResetOutput(this AzureApimBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimBackupSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings SetQuery(this AzureApimBackupSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimBackupSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings ResetQuery(this AzureApimBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimBackupSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings SetVerbose(this AzureApimBackupSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimBackupSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimBackupSettings ResetVerbose(this AzureApimBackupSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureApimCheckNameSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureApimCheckNameSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCheckNameSettings.Name"/></em></p>
        ///   <p>The name of the api management service instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimCheckNameSettings SetName(this AzureApimCheckNameSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCheckNameSettings.Name"/></em></p>
        ///   <p>The name of the api management service instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimCheckNameSettings ResetName(this AzureApimCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCheckNameSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimCheckNameSettings SetSubscription(this AzureApimCheckNameSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCheckNameSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimCheckNameSettings ResetSubscription(this AzureApimCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCheckNameSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimCheckNameSettings SetDebug(this AzureApimCheckNameSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCheckNameSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimCheckNameSettings ResetDebug(this AzureApimCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCheckNameSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimCheckNameSettings SetHelp(this AzureApimCheckNameSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCheckNameSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimCheckNameSettings ResetHelp(this AzureApimCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCheckNameSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimCheckNameSettings SetOutput(this AzureApimCheckNameSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCheckNameSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimCheckNameSettings ResetOutput(this AzureApimCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCheckNameSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimCheckNameSettings SetQuery(this AzureApimCheckNameSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCheckNameSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimCheckNameSettings ResetQuery(this AzureApimCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCheckNameSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimCheckNameSettings SetVerbose(this AzureApimCheckNameSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCheckNameSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimCheckNameSettings ResetVerbose(this AzureApimCheckNameSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureApimCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureApimCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.Name"/></em></p>
        ///   <p>Unique name of the service instance to be created.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetName(this AzureApimCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.Name"/></em></p>
        ///   <p>Unique name of the service instance to be created.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetName(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PublisherEmail
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.PublisherEmail"/></em></p>
        ///   <p>The e-mail address to receive all system notifications.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetPublisherEmail(this AzureApimCreateSettings toolSettings, string publisherEmail)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublisherEmail = publisherEmail;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.PublisherEmail"/></em></p>
        ///   <p>The e-mail address to receive all system notifications.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetPublisherEmail(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublisherEmail = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetResourceGroup(this AzureApimCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetResourceGroup(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region EnableClientCertificate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.EnableClientCertificate"/></em></p>
        ///   <p>Enforces a client certificate to be presented on each request to the gateway and also enables the ability to authenticate the certificate in the policy on the gateway.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetEnableClientCertificate(this AzureApimCreateSettings toolSettings, bool? enableClientCertificate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableClientCertificate = enableClientCertificate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.EnableClientCertificate"/></em></p>
        ///   <p>Enforces a client certificate to be presented on each request to the gateway and also enables the ability to authenticate the certificate in the policy on the gateway.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetEnableClientCertificate(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableClientCertificate = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureApimCreateSettings.EnableClientCertificate"/></em></p>
        ///   <p>Enforces a client certificate to be presented on each request to the gateway and also enables the ability to authenticate the certificate in the policy on the gateway.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings EnableEnableClientCertificate(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableClientCertificate = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureApimCreateSettings.EnableClientCertificate"/></em></p>
        ///   <p>Enforces a client certificate to be presented on each request to the gateway and also enables the ability to authenticate the certificate in the policy on the gateway.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings DisableEnableClientCertificate(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableClientCertificate = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureApimCreateSettings.EnableClientCertificate"/></em></p>
        ///   <p>Enforces a client certificate to be presented on each request to the gateway and also enables the ability to authenticate the certificate in the policy on the gateway.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ToggleEnableClientCertificate(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableClientCertificate = !toolSettings.EnableClientCertificate;
            return toolSettings;
        }
        #endregion
        #region EnableManagedIdentity
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.EnableManagedIdentity"/></em></p>
        ///   <p>Create a managed identity for the API Management service to access other Azure resources.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetEnableManagedIdentity(this AzureApimCreateSettings toolSettings, bool? enableManagedIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableManagedIdentity = enableManagedIdentity;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.EnableManagedIdentity"/></em></p>
        ///   <p>Create a managed identity for the API Management service to access other Azure resources.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetEnableManagedIdentity(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableManagedIdentity = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureApimCreateSettings.EnableManagedIdentity"/></em></p>
        ///   <p>Create a managed identity for the API Management service to access other Azure resources.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings EnableEnableManagedIdentity(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableManagedIdentity = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureApimCreateSettings.EnableManagedIdentity"/></em></p>
        ///   <p>Create a managed identity for the API Management service to access other Azure resources.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings DisableEnableManagedIdentity(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableManagedIdentity = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureApimCreateSettings.EnableManagedIdentity"/></em></p>
        ///   <p>Create a managed identity for the API Management service to access other Azure resources.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ToggleEnableManagedIdentity(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableManagedIdentity = !toolSettings.EnableManagedIdentity;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetLocation(this AzureApimCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetLocation(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetNoWait(this AzureApimCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetNoWait(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureApimCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings EnableNoWait(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureApimCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings DisableNoWait(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureApimCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ToggleNoWait(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region PublisherName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.PublisherName"/></em></p>
        ///   <p>The name of your organization for use in the developer portal and e-mail notifications.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetPublisherName(this AzureApimCreateSettings toolSettings, string publisherName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublisherName = publisherName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.PublisherName"/></em></p>
        ///   <p>The name of your organization for use in the developer portal and e-mail notifications.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetPublisherName(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublisherName = null;
            return toolSettings;
        }
        #endregion
        #region SkuCapacity
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.SkuCapacity"/></em></p>
        ///   <p>The number of deployed units of the SKU.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetSkuCapacity(this AzureApimCreateSettings toolSettings, string skuCapacity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuCapacity = skuCapacity;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.SkuCapacity"/></em></p>
        ///   <p>The number of deployed units of the SKU.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetSkuCapacity(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuCapacity = null;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.SkuName"/></em></p>
        ///   <p>The sku of the api management instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetSkuName(this AzureApimCreateSettings toolSettings, ApimSkuName skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.SkuName"/></em></p>
        ///   <p>The sku of the api management instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetSkuName(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetTags(this AzureApimCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetTags(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region VirtualNetwork
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.VirtualNetwork"/></em></p>
        ///   <p>The virtual network type.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetVirtualNetwork(this AzureApimCreateSettings toolSettings, ApimVirtualNetwork virtualNetwork)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetwork = virtualNetwork;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.VirtualNetwork"/></em></p>
        ///   <p>The virtual network type.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetVirtualNetwork(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetwork = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetSubscription(this AzureApimCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetSubscription(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetDebug(this AzureApimCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetDebug(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetHelp(this AzureApimCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetHelp(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetOutput(this AzureApimCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetOutput(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetQuery(this AzureApimCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetQuery(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings SetVerbose(this AzureApimCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimCreateSettings ResetVerbose(this AzureApimCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureApimDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureApimDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimDeleteSettings.Name"/></em></p>
        ///   <p>The name of the api management service instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings SetName(this AzureApimDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimDeleteSettings.Name"/></em></p>
        ///   <p>The name of the api management service instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings ResetName(this AzureApimDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings SetResourceGroup(this AzureApimDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings ResetResourceGroup(this AzureApimDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings SetNoWait(this AzureApimDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings ResetNoWait(this AzureApimDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureApimDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings EnableNoWait(this AzureApimDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureApimDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings DisableNoWait(this AzureApimDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureApimDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings ToggleNoWait(this AzureApimDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings SetYes(this AzureApimDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings ResetYes(this AzureApimDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings SetSubscription(this AzureApimDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings ResetSubscription(this AzureApimDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings SetDebug(this AzureApimDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings ResetDebug(this AzureApimDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings SetHelp(this AzureApimDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings ResetHelp(this AzureApimDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings SetOutput(this AzureApimDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings ResetOutput(this AzureApimDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings SetQuery(this AzureApimDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings ResetQuery(this AzureApimDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings SetVerbose(this AzureApimDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimDeleteSettings ResetVerbose(this AzureApimDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureApimListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureApimListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimListSettings SetResourceGroup(this AzureApimListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimListSettings ResetResourceGroup(this AzureApimListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimListSettings SetSubscription(this AzureApimListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimListSettings ResetSubscription(this AzureApimListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimListSettings SetDebug(this AzureApimListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimListSettings ResetDebug(this AzureApimListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimListSettings SetHelp(this AzureApimListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimListSettings ResetHelp(this AzureApimListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimListSettings SetOutput(this AzureApimListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimListSettings ResetOutput(this AzureApimListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimListSettings SetQuery(this AzureApimListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimListSettings ResetQuery(this AzureApimListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimListSettings SetVerbose(this AzureApimListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimListSettings ResetVerbose(this AzureApimListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureApimShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureApimShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimShowSettings.Name"/></em></p>
        ///   <p>The name of the api management service instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings SetName(this AzureApimShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimShowSettings.Name"/></em></p>
        ///   <p>The name of the api management service instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings ResetName(this AzureApimShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings SetResourceGroup(this AzureApimShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings ResetResourceGroup(this AzureApimShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings SetSubscription(this AzureApimShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings ResetSubscription(this AzureApimShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings SetDebug(this AzureApimShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings ResetDebug(this AzureApimShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings SetHelp(this AzureApimShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings ResetHelp(this AzureApimShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings SetOutput(this AzureApimShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings ResetOutput(this AzureApimShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings SetQuery(this AzureApimShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings ResetQuery(this AzureApimShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings SetVerbose(this AzureApimShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimShowSettings ResetVerbose(this AzureApimShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureApimUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureApimUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.Name"/></em></p>
        ///   <p>The name of the api management service instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetName(this AzureApimUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.Name"/></em></p>
        ///   <p>The name of the api management service instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetName(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetResourceGroup(this AzureApimUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetResourceGroup(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region EnableClientCertificate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.EnableClientCertificate"/></em></p>
        ///   <p>Enforces a client certificate to be presented on each request to the gateway and also enables the ability to authenticate the certificate in the policy on the gateway.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetEnableClientCertificate(this AzureApimUpdateSettings toolSettings, bool? enableClientCertificate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableClientCertificate = enableClientCertificate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.EnableClientCertificate"/></em></p>
        ///   <p>Enforces a client certificate to be presented on each request to the gateway and also enables the ability to authenticate the certificate in the policy on the gateway.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetEnableClientCertificate(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableClientCertificate = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureApimUpdateSettings.EnableClientCertificate"/></em></p>
        ///   <p>Enforces a client certificate to be presented on each request to the gateway and also enables the ability to authenticate the certificate in the policy on the gateway.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings EnableEnableClientCertificate(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableClientCertificate = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureApimUpdateSettings.EnableClientCertificate"/></em></p>
        ///   <p>Enforces a client certificate to be presented on each request to the gateway and also enables the ability to authenticate the certificate in the policy on the gateway.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings DisableEnableClientCertificate(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableClientCertificate = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureApimUpdateSettings.EnableClientCertificate"/></em></p>
        ///   <p>Enforces a client certificate to be presented on each request to the gateway and also enables the ability to authenticate the certificate in the policy on the gateway.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ToggleEnableClientCertificate(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableClientCertificate = !toolSettings.EnableClientCertificate;
            return toolSettings;
        }
        #endregion
        #region EnableManagedIdentity
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.EnableManagedIdentity"/></em></p>
        ///   <p>Create a managed identity for the API Management service to access other Azure resources.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetEnableManagedIdentity(this AzureApimUpdateSettings toolSettings, bool? enableManagedIdentity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableManagedIdentity = enableManagedIdentity;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.EnableManagedIdentity"/></em></p>
        ///   <p>Create a managed identity for the API Management service to access other Azure resources.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetEnableManagedIdentity(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableManagedIdentity = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureApimUpdateSettings.EnableManagedIdentity"/></em></p>
        ///   <p>Create a managed identity for the API Management service to access other Azure resources.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings EnableEnableManagedIdentity(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableManagedIdentity = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureApimUpdateSettings.EnableManagedIdentity"/></em></p>
        ///   <p>Create a managed identity for the API Management service to access other Azure resources.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings DisableEnableManagedIdentity(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableManagedIdentity = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureApimUpdateSettings.EnableManagedIdentity"/></em></p>
        ///   <p>Create a managed identity for the API Management service to access other Azure resources.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ToggleEnableManagedIdentity(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableManagedIdentity = !toolSettings.EnableManagedIdentity;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetNoWait(this AzureApimUpdateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetNoWait(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureApimUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings EnableNoWait(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureApimUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings DisableNoWait(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureApimUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ToggleNoWait(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region PublisherEmail
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.PublisherEmail"/></em></p>
        ///   <p>The e-mail address to receive all system notifications.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetPublisherEmail(this AzureApimUpdateSettings toolSettings, string publisherEmail)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublisherEmail = publisherEmail;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.PublisherEmail"/></em></p>
        ///   <p>The e-mail address to receive all system notifications.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetPublisherEmail(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublisherEmail = null;
            return toolSettings;
        }
        #endregion
        #region PublisherName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.PublisherName"/></em></p>
        ///   <p>The name of your organization for use in the developer portal and e-mail notifications.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetPublisherName(this AzureApimUpdateSettings toolSettings, string publisherName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublisherName = publisherName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.PublisherName"/></em></p>
        ///   <p>The name of your organization for use in the developer portal and e-mail notifications.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetPublisherName(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PublisherName = null;
            return toolSettings;
        }
        #endregion
        #region SkuCapacity
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.SkuCapacity"/></em></p>
        ///   <p>The number of deployed units of the SKU.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetSkuCapacity(this AzureApimUpdateSettings toolSettings, string skuCapacity)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuCapacity = skuCapacity;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.SkuCapacity"/></em></p>
        ///   <p>The number of deployed units of the SKU.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetSkuCapacity(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuCapacity = null;
            return toolSettings;
        }
        #endregion
        #region SkuName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.SkuName"/></em></p>
        ///   <p>The sku of the api management instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetSkuName(this AzureApimUpdateSettings toolSettings, ApimSkuName skuName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = skuName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.SkuName"/></em></p>
        ///   <p>The sku of the api management instance.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetSkuName(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkuName = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetTags(this AzureApimUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetTags(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region VirtualNetwork
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.VirtualNetwork"/></em></p>
        ///   <p>The virtual network type.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetVirtualNetwork(this AzureApimUpdateSettings toolSettings, ApimVirtualNetwork virtualNetwork)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetwork = virtualNetwork;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.VirtualNetwork"/></em></p>
        ///   <p>The virtual network type.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetVirtualNetwork(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetwork = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetAdd(this AzureApimUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetAdd(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetForceString(this AzureApimUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetForceString(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetRemove(this AzureApimUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetRemove(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetSet(this AzureApimUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetSet(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetSubscription(this AzureApimUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetSubscription(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetDebug(this AzureApimUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetDebug(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetHelp(this AzureApimUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetHelp(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetOutput(this AzureApimUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetOutput(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetQuery(this AzureApimUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetQuery(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureApimUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings SetVerbose(this AzureApimUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureApimUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureApimUpdateSettings ResetVerbose(this AzureApimUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region ApimSkuName
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ApimSkuName>))]
    public partial class ApimSkuName : Enumeration
    {
        public static ApimSkuName basic = new ApimSkuName { Value = "basic" };
        public static ApimSkuName consumption = new ApimSkuName { Value = "consumption" };
        public static ApimSkuName developer = new ApimSkuName { Value = "developer" };
        public static ApimSkuName premium = new ApimSkuName { Value = "premium" };
        public static ApimSkuName standard = new ApimSkuName { Value = "standard" };
    }
    #endregion
    #region ApimVirtualNetwork
    /// <summary>
    ///   Used within <see cref="AzureApimTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<ApimVirtualNetwork>))]
    public partial class ApimVirtualNetwork : Enumeration
    {
        public static ApimVirtualNetwork external = new ApimVirtualNetwork { Value = "external" };
        public static ApimVirtualNetwork internal_ = new ApimVirtualNetwork { Value = "internal" };
        public static ApimVirtualNetwork none = new ApimVirtualNetwork { Value = "none" };
    }
    #endregion
}
