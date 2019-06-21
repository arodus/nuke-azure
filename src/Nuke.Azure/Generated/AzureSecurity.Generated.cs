// Generated from https://github.com/totollygeek/azure/blob/master/src/Nuke.Azure/specifications/AzureSecurity.json
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
    public static partial class AzureSecurityTasks
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public static string AzureSecurityPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURESECURITY_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureSecurityLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage your security posture with Azure Security Center.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurity(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureSecurityPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureSecurityLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurity(AzureSecuritySettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecuritySettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecuritySettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecuritySettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecuritySettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecuritySettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecuritySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurity(Configure<AzureSecuritySettings> configurator)
        {
            return AzureSecurity(configurator(new AzureSecuritySettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecuritySettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecuritySettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecuritySettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecuritySettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecuritySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecuritySettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurity(CombinatorialConfigure<AzureSecuritySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurity, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityAlertList(AzureSecurityAlertListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityAlertListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityAlertListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityAlertListSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSecurityAlertListSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityAlertListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityAlertListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityAlertListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityAlertListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityAlertListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityAlertList(Configure<AzureSecurityAlertListSettings> configurator)
        {
            return AzureSecurityAlertList(configurator(new AzureSecurityAlertListSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityAlertListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityAlertListSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSecurityAlertListSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityAlertListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityAlertListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityAlertListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityAlertListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityAlertListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityAlertListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityAlertList(CombinatorialConfigure<AzureSecurityAlertListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityAlertList, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityAlertShow(AzureSecurityAlertShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityAlertShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityAlertShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityAlertShowSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSecurityAlertShowSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityAlertShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityAlertShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityAlertShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityAlertShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityAlertShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityAlertShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityAlertShow(Configure<AzureSecurityAlertShowSettings> configurator)
        {
            return AzureSecurityAlertShow(configurator(new AzureSecurityAlertShowSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityAlertShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityAlertShowSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSecurityAlertShowSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityAlertShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityAlertShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityAlertShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityAlertShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityAlertShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityAlertShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityAlertShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityAlertShow(CombinatorialConfigure<AzureSecurityAlertShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityAlertShow, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityAlertUpdate(AzureSecurityAlertUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityAlertUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityAlertUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityAlertUpdateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSecurityAlertUpdateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityAlertUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityAlertUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityAlertUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityAlertUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--status</c> via <see cref="AzureSecurityAlertUpdateSettings.Status"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityAlertUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityAlertUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityAlertUpdate(Configure<AzureSecurityAlertUpdateSettings> configurator)
        {
            return AzureSecurityAlertUpdate(configurator(new AzureSecurityAlertUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityAlertUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityAlertUpdateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSecurityAlertUpdateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityAlertUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityAlertUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityAlertUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityAlertUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--status</c> via <see cref="AzureSecurityAlertUpdateSettings.Status"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityAlertUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityAlertUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityAlertUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityAlertUpdate(CombinatorialConfigure<AzureSecurityAlertUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityAlertUpdate, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityAutoProvisioningSettingList(AzureSecurityAutoProvisioningSettingListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityAutoProvisioningSettingListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityAutoProvisioningSettingListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityAutoProvisioningSettingListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityAutoProvisioningSettingListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityAutoProvisioningSettingListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityAutoProvisioningSettingListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityAutoProvisioningSettingListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityAutoProvisioningSettingList(Configure<AzureSecurityAutoProvisioningSettingListSettings> configurator)
        {
            return AzureSecurityAutoProvisioningSettingList(configurator(new AzureSecurityAutoProvisioningSettingListSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityAutoProvisioningSettingListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityAutoProvisioningSettingListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityAutoProvisioningSettingListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityAutoProvisioningSettingListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityAutoProvisioningSettingListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityAutoProvisioningSettingListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityAutoProvisioningSettingListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityAutoProvisioningSettingList(CombinatorialConfigure<AzureSecurityAutoProvisioningSettingListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityAutoProvisioningSettingList, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityAutoProvisioningSettingShow(AzureSecurityAutoProvisioningSettingShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityAutoProvisioningSettingShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityAutoProvisioningSettingShow(Configure<AzureSecurityAutoProvisioningSettingShowSettings> configurator)
        {
            return AzureSecurityAutoProvisioningSettingShow(configurator(new AzureSecurityAutoProvisioningSettingShowSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityAutoProvisioningSettingShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityAutoProvisioningSettingShow(CombinatorialConfigure<AzureSecurityAutoProvisioningSettingShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityAutoProvisioningSettingShow, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityAutoProvisioningSettingUpdate(AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityAutoProvisioningSettingUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--auto-provision</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.AutoProvision"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityAutoProvisioningSettingUpdate(Configure<AzureSecurityAutoProvisioningSettingUpdateSettings> configurator)
        {
            return AzureSecurityAutoProvisioningSettingUpdate(configurator(new AzureSecurityAutoProvisioningSettingUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--auto-provision</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.AutoProvision"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityAutoProvisioningSettingUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityAutoProvisioningSettingUpdate(CombinatorialConfigure<AzureSecurityAutoProvisioningSettingUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityAutoProvisioningSettingUpdate, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityContactCreate(AzureSecurityContactCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityContactCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--alert-notifications</c> via <see cref="AzureSecurityContactCreateSettings.AlertNotifications"/></li>
        ///     <li><c>--alerts-admins</c> via <see cref="AzureSecurityContactCreateSettings.AlertsAdmins"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityContactCreateSettings.Debug"/></li>
        ///     <li><c>--email</c> via <see cref="AzureSecurityContactCreateSettings.Email"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityContactCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityContactCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityContactCreateSettings.Output"/></li>
        ///     <li><c>--phone</c> via <see cref="AzureSecurityContactCreateSettings.Phone"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityContactCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityContactCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityContactCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityContactCreate(Configure<AzureSecurityContactCreateSettings> configurator)
        {
            return AzureSecurityContactCreate(configurator(new AzureSecurityContactCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--alert-notifications</c> via <see cref="AzureSecurityContactCreateSettings.AlertNotifications"/></li>
        ///     <li><c>--alerts-admins</c> via <see cref="AzureSecurityContactCreateSettings.AlertsAdmins"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityContactCreateSettings.Debug"/></li>
        ///     <li><c>--email</c> via <see cref="AzureSecurityContactCreateSettings.Email"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityContactCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityContactCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityContactCreateSettings.Output"/></li>
        ///     <li><c>--phone</c> via <see cref="AzureSecurityContactCreateSettings.Phone"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityContactCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityContactCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityContactCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityContactCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityContactCreate(CombinatorialConfigure<AzureSecurityContactCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityContactCreate, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityContactDelete(AzureSecurityContactDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityContactDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityContactDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityContactDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityContactDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityContactDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityContactDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityContactDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityContactDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityContactDelete(Configure<AzureSecurityContactDeleteSettings> configurator)
        {
            return AzureSecurityContactDelete(configurator(new AzureSecurityContactDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityContactDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityContactDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityContactDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityContactDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityContactDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityContactDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityContactDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityContactDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityContactDelete(CombinatorialConfigure<AzureSecurityContactDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityContactDelete, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityContactList(AzureSecurityContactListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityContactListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityContactListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityContactListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityContactListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityContactListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityContactListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityContactListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityContactList(Configure<AzureSecurityContactListSettings> configurator)
        {
            return AzureSecurityContactList(configurator(new AzureSecurityContactListSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityContactListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityContactListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityContactListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityContactListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityContactListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityContactListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityContactListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityContactList(CombinatorialConfigure<AzureSecurityContactListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityContactList, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityContactShow(AzureSecurityContactShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityContactShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityContactShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityContactShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityContactShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityContactShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityContactShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityContactShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityContactShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityContactShow(Configure<AzureSecurityContactShowSettings> configurator)
        {
            return AzureSecurityContactShow(configurator(new AzureSecurityContactShowSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityContactShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityContactShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityContactShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityContactShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityContactShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityContactShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityContactShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityContactShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityContactShow(CombinatorialConfigure<AzureSecurityContactShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityContactShow, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityDiscoveredSecuritySolutionList(AzureSecurityDiscoveredSecuritySolutionListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityDiscoveredSecuritySolutionListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityDiscoveredSecuritySolutionList(Configure<AzureSecurityDiscoveredSecuritySolutionListSettings> configurator)
        {
            return AzureSecurityDiscoveredSecuritySolutionList(configurator(new AzureSecurityDiscoveredSecuritySolutionListSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityDiscoveredSecuritySolutionListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityDiscoveredSecuritySolutionList(CombinatorialConfigure<AzureSecurityDiscoveredSecuritySolutionListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityDiscoveredSecuritySolutionList, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityDiscoveredSecuritySolutionShow(AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityDiscoveredSecuritySolutionShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityDiscoveredSecuritySolutionShow(Configure<AzureSecurityDiscoveredSecuritySolutionShowSettings> configurator)
        {
            return AzureSecurityDiscoveredSecuritySolutionShow(configurator(new AzureSecurityDiscoveredSecuritySolutionShowSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityDiscoveredSecuritySolutionShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityDiscoveredSecuritySolutionShow(CombinatorialConfigure<AzureSecurityDiscoveredSecuritySolutionShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityDiscoveredSecuritySolutionShow, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityExternalSecuritySolutionList(AzureSecurityExternalSecuritySolutionListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityExternalSecuritySolutionListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityExternalSecuritySolutionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityExternalSecuritySolutionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityExternalSecuritySolutionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityExternalSecuritySolutionListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityExternalSecuritySolutionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityExternalSecuritySolutionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityExternalSecuritySolutionList(Configure<AzureSecurityExternalSecuritySolutionListSettings> configurator)
        {
            return AzureSecurityExternalSecuritySolutionList(configurator(new AzureSecurityExternalSecuritySolutionListSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityExternalSecuritySolutionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityExternalSecuritySolutionListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityExternalSecuritySolutionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityExternalSecuritySolutionListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityExternalSecuritySolutionListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityExternalSecuritySolutionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityExternalSecuritySolutionListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityExternalSecuritySolutionList(CombinatorialConfigure<AzureSecurityExternalSecuritySolutionListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityExternalSecuritySolutionList, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityExternalSecuritySolutionShow(AzureSecurityExternalSecuritySolutionShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityExternalSecuritySolutionShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityExternalSecuritySolutionShow(Configure<AzureSecurityExternalSecuritySolutionShowSettings> configurator)
        {
            return AzureSecurityExternalSecuritySolutionShow(configurator(new AzureSecurityExternalSecuritySolutionShowSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityExternalSecuritySolutionShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityExternalSecuritySolutionShow(CombinatorialConfigure<AzureSecurityExternalSecuritySolutionShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityExternalSecuritySolutionShow, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityJitPolicyList(AzureSecurityJitPolicyListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityJitPolicyListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityJitPolicyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityJitPolicyListSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSecurityJitPolicyListSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityJitPolicyListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityJitPolicyListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityJitPolicyListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityJitPolicyListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityJitPolicyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityJitPolicyList(Configure<AzureSecurityJitPolicyListSettings> configurator)
        {
            return AzureSecurityJitPolicyList(configurator(new AzureSecurityJitPolicyListSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityJitPolicyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityJitPolicyListSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSecurityJitPolicyListSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityJitPolicyListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityJitPolicyListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityJitPolicyListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityJitPolicyListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityJitPolicyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityJitPolicyListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityJitPolicyList(CombinatorialConfigure<AzureSecurityJitPolicyListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityJitPolicyList, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityJitPolicyShow(AzureSecurityJitPolicyShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityJitPolicyShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityJitPolicyShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityJitPolicyShowSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSecurityJitPolicyShowSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityJitPolicyShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityJitPolicyShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityJitPolicyShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityJitPolicyShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityJitPolicyShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityJitPolicyShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityJitPolicyShow(Configure<AzureSecurityJitPolicyShowSettings> configurator)
        {
            return AzureSecurityJitPolicyShow(configurator(new AzureSecurityJitPolicyShowSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityJitPolicyShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityJitPolicyShowSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureSecurityJitPolicyShowSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityJitPolicyShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityJitPolicyShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityJitPolicyShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityJitPolicyShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityJitPolicyShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityJitPolicyShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityJitPolicyShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityJitPolicyShow(CombinatorialConfigure<AzureSecurityJitPolicyShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityJitPolicyShow, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityLocationList(AzureSecurityLocationListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityLocationListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityLocationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityLocationListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityLocationListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityLocationListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityLocationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityLocationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityLocationList(Configure<AzureSecurityLocationListSettings> configurator)
        {
            return AzureSecurityLocationList(configurator(new AzureSecurityLocationListSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityLocationListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityLocationListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityLocationListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityLocationListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityLocationListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityLocationListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityLocationListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityLocationList(CombinatorialConfigure<AzureSecurityLocationListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityLocationList, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityLocationShow(AzureSecurityLocationShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityLocationShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityLocationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityLocationShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityLocationShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityLocationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityLocationShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityLocationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityLocationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityLocationShow(Configure<AzureSecurityLocationShowSettings> configurator)
        {
            return AzureSecurityLocationShow(configurator(new AzureSecurityLocationShowSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityLocationShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityLocationShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityLocationShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityLocationShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityLocationShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityLocationShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityLocationShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityLocationShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityLocationShow(CombinatorialConfigure<AzureSecurityLocationShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityLocationShow, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityPricingCreate(AzureSecurityPricingCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityPricingCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityPricingCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityPricingCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityPricingCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityPricingCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityPricingCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityPricingCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityPricingCreateSettings.Subscription"/></li>
        ///     <li><c>--tier</c> via <see cref="AzureSecurityPricingCreateSettings.Tier"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityPricingCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityPricingCreate(Configure<AzureSecurityPricingCreateSettings> configurator)
        {
            return AzureSecurityPricingCreate(configurator(new AzureSecurityPricingCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityPricingCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityPricingCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityPricingCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityPricingCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityPricingCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityPricingCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityPricingCreateSettings.Subscription"/></li>
        ///     <li><c>--tier</c> via <see cref="AzureSecurityPricingCreateSettings.Tier"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityPricingCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityPricingCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityPricingCreate(CombinatorialConfigure<AzureSecurityPricingCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityPricingCreate, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityPricingList(AzureSecurityPricingListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityPricingListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityPricingListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityPricingListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityPricingListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityPricingListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityPricingListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityPricingListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityPricingList(Configure<AzureSecurityPricingListSettings> configurator)
        {
            return AzureSecurityPricingList(configurator(new AzureSecurityPricingListSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityPricingListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityPricingListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityPricingListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityPricingListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityPricingListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityPricingListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityPricingListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityPricingList(CombinatorialConfigure<AzureSecurityPricingListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityPricingList, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityPricingShow(AzureSecurityPricingShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityPricingShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityPricingShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityPricingShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityPricingShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityPricingShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityPricingShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityPricingShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityPricingShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityPricingShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityPricingShow(Configure<AzureSecurityPricingShowSettings> configurator)
        {
            return AzureSecurityPricingShow(configurator(new AzureSecurityPricingShowSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityPricingShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityPricingShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityPricingShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityPricingShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityPricingShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityPricingShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityPricingShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityPricingShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityPricingShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityPricingShow(CombinatorialConfigure<AzureSecurityPricingShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityPricingShow, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecuritySettingList(AzureSecuritySettingListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecuritySettingListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecuritySettingListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecuritySettingListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecuritySettingListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecuritySettingListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecuritySettingListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecuritySettingListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecuritySettingList(Configure<AzureSecuritySettingListSettings> configurator)
        {
            return AzureSecuritySettingList(configurator(new AzureSecuritySettingListSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecuritySettingListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecuritySettingListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecuritySettingListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecuritySettingListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecuritySettingListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecuritySettingListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecuritySettingListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecuritySettingList(CombinatorialConfigure<AzureSecuritySettingListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecuritySettingList, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecuritySettingShow(AzureSecuritySettingShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecuritySettingShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecuritySettingShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecuritySettingShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecuritySettingShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecuritySettingShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecuritySettingShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecuritySettingShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecuritySettingShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecuritySettingShow(Configure<AzureSecuritySettingShowSettings> configurator)
        {
            return AzureSecuritySettingShow(configurator(new AzureSecuritySettingShowSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecuritySettingShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecuritySettingShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecuritySettingShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecuritySettingShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecuritySettingShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecuritySettingShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecuritySettingShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecuritySettingShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecuritySettingShow(CombinatorialConfigure<AzureSecuritySettingShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecuritySettingShow, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityTaskList(AzureSecurityTaskListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityTaskListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityTaskListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityTaskListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityTaskListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityTaskListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityTaskListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityTaskListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityTaskListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityTaskList(Configure<AzureSecurityTaskListSettings> configurator)
        {
            return AzureSecurityTaskList(configurator(new AzureSecurityTaskListSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityTaskListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityTaskListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityTaskListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityTaskListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityTaskListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityTaskListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityTaskListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityTaskListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityTaskList(CombinatorialConfigure<AzureSecurityTaskListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityTaskList, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityTaskShow(AzureSecurityTaskShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityTaskShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityTaskShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityTaskShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityTaskShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityTaskShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityTaskShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityTaskShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityTaskShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityTaskShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityTaskShow(Configure<AzureSecurityTaskShowSettings> configurator)
        {
            return AzureSecurityTaskShow(configurator(new AzureSecurityTaskShowSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityTaskShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityTaskShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityTaskShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityTaskShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityTaskShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityTaskShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityTaskShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityTaskShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityTaskShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityTaskShow(CombinatorialConfigure<AzureSecurityTaskShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityTaskShow, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityTopologyList(AzureSecurityTopologyListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityTopologyListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityTopologyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityTopologyListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityTopologyListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityTopologyListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityTopologyListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityTopologyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityTopologyList(Configure<AzureSecurityTopologyListSettings> configurator)
        {
            return AzureSecurityTopologyList(configurator(new AzureSecurityTopologyListSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityTopologyListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityTopologyListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityTopologyListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityTopologyListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityTopologyListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityTopologyListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityTopologyListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityTopologyList(CombinatorialConfigure<AzureSecurityTopologyListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityTopologyList, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityTopologyShow(AzureSecurityTopologyShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityTopologyShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityTopologyShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityTopologyShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityTopologyShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityTopologyShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityTopologyShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityTopologyShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityTopologyShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityTopologyShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityTopologyShow(Configure<AzureSecurityTopologyShowSettings> configurator)
        {
            return AzureSecurityTopologyShow(configurator(new AzureSecurityTopologyShowSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityTopologyShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityTopologyShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityTopologyShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityTopologyShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityTopologyShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureSecurityTopologyShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityTopologyShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityTopologyShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityTopologyShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityTopologyShow(CombinatorialConfigure<AzureSecurityTopologyShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityTopologyShow, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityWorkspaceSettingCreate(AzureSecurityWorkspaceSettingCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityWorkspaceSettingCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.Subscription"/></li>
        ///     <li><c>--target-workspace</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.TargetWorkspace"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityWorkspaceSettingCreate(Configure<AzureSecurityWorkspaceSettingCreateSettings> configurator)
        {
            return AzureSecurityWorkspaceSettingCreate(configurator(new AzureSecurityWorkspaceSettingCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.Subscription"/></li>
        ///     <li><c>--target-workspace</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.TargetWorkspace"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityWorkspaceSettingCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityWorkspaceSettingCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityWorkspaceSettingCreate(CombinatorialConfigure<AzureSecurityWorkspaceSettingCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityWorkspaceSettingCreate, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityWorkspaceSettingDelete(AzureSecurityWorkspaceSettingDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityWorkspaceSettingDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityWorkspaceSettingDelete(Configure<AzureSecurityWorkspaceSettingDeleteSettings> configurator)
        {
            return AzureSecurityWorkspaceSettingDelete(configurator(new AzureSecurityWorkspaceSettingDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityWorkspaceSettingDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityWorkspaceSettingDelete(CombinatorialConfigure<AzureSecurityWorkspaceSettingDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityWorkspaceSettingDelete, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityWorkspaceSettingList(AzureSecurityWorkspaceSettingListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityWorkspaceSettingListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityWorkspaceSettingListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityWorkspaceSettingListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityWorkspaceSettingListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityWorkspaceSettingListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityWorkspaceSettingListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityWorkspaceSettingListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityWorkspaceSettingList(Configure<AzureSecurityWorkspaceSettingListSettings> configurator)
        {
            return AzureSecurityWorkspaceSettingList(configurator(new AzureSecurityWorkspaceSettingListSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityWorkspaceSettingListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityWorkspaceSettingListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityWorkspaceSettingListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityWorkspaceSettingListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityWorkspaceSettingListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityWorkspaceSettingListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityWorkspaceSettingListSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityWorkspaceSettingList(CombinatorialConfigure<AzureSecurityWorkspaceSettingListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityWorkspaceSettingList, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureSecurityWorkspaceSettingShow(AzureSecurityWorkspaceSettingShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureSecurityWorkspaceSettingShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityWorkspaceSettingShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityWorkspaceSettingShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityWorkspaceSettingShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityWorkspaceSettingShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityWorkspaceSettingShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityWorkspaceSettingShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityWorkspaceSettingShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureSecurityWorkspaceSettingShow(Configure<AzureSecurityWorkspaceSettingShowSettings> configurator)
        {
            return AzureSecurityWorkspaceSettingShow(configurator(new AzureSecurityWorkspaceSettingShowSettings()));
        }
        /// <summary>
        ///   <p>Manage your security posture with Azure Security Center.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/security?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureSecurityWorkspaceSettingShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureSecurityWorkspaceSettingShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureSecurityWorkspaceSettingShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureSecurityWorkspaceSettingShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureSecurityWorkspaceSettingShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureSecurityWorkspaceSettingShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureSecurityWorkspaceSettingShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureSecurityWorkspaceSettingShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureSecurityWorkspaceSettingShow(CombinatorialConfigure<AzureSecurityWorkspaceSettingShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureSecurityWorkspaceSettingShow, AzureSecurityLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureSecuritySettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecuritySettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
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
              .Add("security")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureSecurityAlertListSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityAlertListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Location of the resource.
        /// </summary>
        public virtual string Location { get; internal set; }
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
              .Add("security alert list")
              .Add("--location {value}", Location)
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
    #region AzureSecurityAlertShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityAlertShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Location of the resource.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security alert show")
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
    #region AzureSecurityAlertUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityAlertUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Location of the resource.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Name of the resource to be fetched.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Target status of the alert. possible values are "dismiss" and "activate".
        /// </summary>
        public virtual string Status { get; internal set; }
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
              .Add("security alert update")
              .Add("--location {value}", Location)
              .Add("--name {value}", Name)
              .Add("--status {value}", Status)
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
    #region AzureSecurityAutoProvisioningSettingListSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityAutoProvisioningSettingListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
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
              .Add("security auto-provisioning-setting list")
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
    #region AzureSecurityAutoProvisioningSettingShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityAutoProvisioningSettingShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security auto-provisioning-setting show")
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
    #region AzureSecurityAutoProvisioningSettingUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityAutoProvisioningSettingUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Automatic provisioning toggle. possible values are "on" or "off".
        /// </summary>
        public virtual string AutoProvision { get; internal set; }
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security auto-provisioning-setting update")
              .Add("--auto-provision {value}", AutoProvision)
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
    #region AzureSecurityContactCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityContactCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   E-mail of the security contact.
        /// </summary>
        public virtual string Email { get; internal set; }
        /// <summary>
        ///   Name of the resource to be fetched.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Whether to send mail notifications to the security contacts.
        /// </summary>
        public virtual string AlertNotifications { get; internal set; }
        /// <summary>
        ///   Whether to send mail notifications to the subscription administrators.
        /// </summary>
        public virtual string AlertsAdmins { get; internal set; }
        /// <summary>
        ///   Phone of the security contact.
        /// </summary>
        public virtual string Phone { get; internal set; }
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
              .Add("security contact create")
              .Add("--email {value}", Email)
              .Add("--name {value}", Name)
              .Add("--alert-notifications {value}", AlertNotifications)
              .Add("--alerts-admins {value}", AlertsAdmins)
              .Add("--phone {value}", Phone)
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
    #region AzureSecurityContactDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityContactDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security contact delete")
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
    #region AzureSecurityContactListSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityContactListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
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
              .Add("security contact list")
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
    #region AzureSecurityContactShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityContactShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security contact show")
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
    #region AzureSecurityDiscoveredSecuritySolutionListSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityDiscoveredSecuritySolutionListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
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
              .Add("security discovered-security-solution list")
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
    #region AzureSecurityDiscoveredSecuritySolutionShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityDiscoveredSecuritySolutionShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security discovered-security-solution show")
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
    #region AzureSecurityExternalSecuritySolutionListSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityExternalSecuritySolutionListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
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
              .Add("security external-security-solution list")
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
    #region AzureSecurityExternalSecuritySolutionShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityExternalSecuritySolutionShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security external-security-solution show")
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
    #region AzureSecurityJitPolicyListSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityJitPolicyListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Location of the resource.
        /// </summary>
        public virtual string Location { get; internal set; }
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
              .Add("security jit-policy list")
              .Add("--location {value}", Location)
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
    #region AzureSecurityJitPolicyShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityJitPolicyShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Location of the resource.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security jit-policy show")
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
    #region AzureSecurityLocationListSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityLocationListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
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
              .Add("security location list")
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
    #region AzureSecurityLocationShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityLocationShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security location show")
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
    #region AzureSecurityPricingCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityPricingCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Name of the resource to be fetched.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Pricing tier type.
        /// </summary>
        public virtual string Tier { get; internal set; }
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
              .Add("security pricing create")
              .Add("--name {value}", Name)
              .Add("--tier {value}", Tier)
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
    #region AzureSecurityPricingListSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityPricingListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
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
              .Add("security pricing list")
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
    #region AzureSecurityPricingShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityPricingShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security pricing show")
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
    #region AzureSecuritySettingListSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecuritySettingListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
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
              .Add("security setting list")
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
    #region AzureSecuritySettingShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecuritySettingShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security setting show")
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
    #region AzureSecurityTaskListSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityTaskListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
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
              .Add("security task list")
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
    #region AzureSecurityTaskShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityTaskShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security task show")
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
    #region AzureSecurityTopologyListSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityTopologyListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
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
              .Add("security topology list")
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
    #region AzureSecurityTopologyShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityTopologyShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security topology show")
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
    #region AzureSecurityWorkspaceSettingCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityWorkspaceSettingCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Name of the resource to be fetched.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   An ID of the workspace resource that will hold the security data.
        /// </summary>
        public virtual string TargetWorkspace { get; internal set; }
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
              .Add("security workspace-setting create")
              .Add("--name {value}", Name)
              .Add("--target-workspace {value}", TargetWorkspace)
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
    #region AzureSecurityWorkspaceSettingDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityWorkspaceSettingDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security workspace-setting delete")
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
    #region AzureSecurityWorkspaceSettingListSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityWorkspaceSettingListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
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
              .Add("security workspace-setting list")
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
    #region AzureSecurityWorkspaceSettingShowSettings
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureSecurityWorkspaceSettingShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureSecurity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureSecurityTasks.AzureSecurityPath;
        public override Action<OutputType, string> CustomLogger => AzureSecurityTasks.AzureSecurityLogger;
        /// <summary>
        ///   Name of the resource to be fetched.
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
              .Add("security workspace-setting show")
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
    #region AzureSecuritySettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecuritySettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettings SetDebug(this AzureSecuritySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettings ResetDebug(this AzureSecuritySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettings SetHelp(this AzureSecuritySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettings ResetHelp(this AzureSecuritySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettings SetOutput(this AzureSecuritySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettings ResetOutput(this AzureSecuritySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettings SetQuery(this AzureSecuritySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettings ResetQuery(this AzureSecuritySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettings SetVerbose(this AzureSecuritySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettings ResetVerbose(this AzureSecuritySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityAlertListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityAlertListSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertListSettings.Location"/></em></p>
        ///   <p>Location of the resource.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings SetLocation(this AzureSecurityAlertListSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertListSettings.Location"/></em></p>
        ///   <p>Location of the resource.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings ResetLocation(this AzureSecurityAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings SetResourceGroup(this AzureSecurityAlertListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings ResetResourceGroup(this AzureSecurityAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings SetSubscription(this AzureSecurityAlertListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings ResetSubscription(this AzureSecurityAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings SetDebug(this AzureSecurityAlertListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings ResetDebug(this AzureSecurityAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings SetHelp(this AzureSecurityAlertListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings ResetHelp(this AzureSecurityAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings SetOutput(this AzureSecurityAlertListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings ResetOutput(this AzureSecurityAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings SetQuery(this AzureSecurityAlertListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings ResetQuery(this AzureSecurityAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings SetVerbose(this AzureSecurityAlertListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertListSettings ResetVerbose(this AzureSecurityAlertListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityAlertShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityAlertShowSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertShowSettings.Location"/></em></p>
        ///   <p>Location of the resource.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings SetLocation(this AzureSecurityAlertShowSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertShowSettings.Location"/></em></p>
        ///   <p>Location of the resource.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings ResetLocation(this AzureSecurityAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings SetName(this AzureSecurityAlertShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings ResetName(this AzureSecurityAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings SetResourceGroup(this AzureSecurityAlertShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings ResetResourceGroup(this AzureSecurityAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings SetSubscription(this AzureSecurityAlertShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings ResetSubscription(this AzureSecurityAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings SetDebug(this AzureSecurityAlertShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings ResetDebug(this AzureSecurityAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings SetHelp(this AzureSecurityAlertShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings ResetHelp(this AzureSecurityAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings SetOutput(this AzureSecurityAlertShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings ResetOutput(this AzureSecurityAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings SetQuery(this AzureSecurityAlertShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings ResetQuery(this AzureSecurityAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings SetVerbose(this AzureSecurityAlertShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertShowSettings ResetVerbose(this AzureSecurityAlertShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityAlertUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityAlertUpdateSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertUpdateSettings.Location"/></em></p>
        ///   <p>Location of the resource.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings SetLocation(this AzureSecurityAlertUpdateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertUpdateSettings.Location"/></em></p>
        ///   <p>Location of the resource.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings ResetLocation(this AzureSecurityAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertUpdateSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings SetName(this AzureSecurityAlertUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertUpdateSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings ResetName(this AzureSecurityAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Status
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertUpdateSettings.Status"/></em></p>
        ///   <p>Target status of the alert. possible values are "dismiss" and "activate".</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings SetStatus(this AzureSecurityAlertUpdateSettings toolSettings, string status)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = status;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertUpdateSettings.Status"/></em></p>
        ///   <p>Target status of the alert. possible values are "dismiss" and "activate".</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings ResetStatus(this AzureSecurityAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Status = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings SetResourceGroup(this AzureSecurityAlertUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings ResetResourceGroup(this AzureSecurityAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings SetSubscription(this AzureSecurityAlertUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings ResetSubscription(this AzureSecurityAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings SetDebug(this AzureSecurityAlertUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings ResetDebug(this AzureSecurityAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings SetHelp(this AzureSecurityAlertUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings ResetHelp(this AzureSecurityAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings SetOutput(this AzureSecurityAlertUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings ResetOutput(this AzureSecurityAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings SetQuery(this AzureSecurityAlertUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings ResetQuery(this AzureSecurityAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAlertUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings SetVerbose(this AzureSecurityAlertUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAlertUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAlertUpdateSettings ResetVerbose(this AzureSecurityAlertUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityAutoProvisioningSettingListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityAutoProvisioningSettingListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingListSettings SetSubscription(this AzureSecurityAutoProvisioningSettingListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingListSettings ResetSubscription(this AzureSecurityAutoProvisioningSettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingListSettings SetDebug(this AzureSecurityAutoProvisioningSettingListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingListSettings ResetDebug(this AzureSecurityAutoProvisioningSettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingListSettings SetHelp(this AzureSecurityAutoProvisioningSettingListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingListSettings ResetHelp(this AzureSecurityAutoProvisioningSettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingListSettings SetOutput(this AzureSecurityAutoProvisioningSettingListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingListSettings ResetOutput(this AzureSecurityAutoProvisioningSettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingListSettings SetQuery(this AzureSecurityAutoProvisioningSettingListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingListSettings ResetQuery(this AzureSecurityAutoProvisioningSettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingListSettings SetVerbose(this AzureSecurityAutoProvisioningSettingListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingListSettings ResetVerbose(this AzureSecurityAutoProvisioningSettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityAutoProvisioningSettingShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityAutoProvisioningSettingShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingShowSettings SetName(this AzureSecurityAutoProvisioningSettingShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingShowSettings ResetName(this AzureSecurityAutoProvisioningSettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingShowSettings SetSubscription(this AzureSecurityAutoProvisioningSettingShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingShowSettings ResetSubscription(this AzureSecurityAutoProvisioningSettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingShowSettings SetDebug(this AzureSecurityAutoProvisioningSettingShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingShowSettings ResetDebug(this AzureSecurityAutoProvisioningSettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingShowSettings SetHelp(this AzureSecurityAutoProvisioningSettingShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingShowSettings ResetHelp(this AzureSecurityAutoProvisioningSettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingShowSettings SetOutput(this AzureSecurityAutoProvisioningSettingShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingShowSettings ResetOutput(this AzureSecurityAutoProvisioningSettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingShowSettings SetQuery(this AzureSecurityAutoProvisioningSettingShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingShowSettings ResetQuery(this AzureSecurityAutoProvisioningSettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingShowSettings SetVerbose(this AzureSecurityAutoProvisioningSettingShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingShowSettings ResetVerbose(this AzureSecurityAutoProvisioningSettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityAutoProvisioningSettingUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityAutoProvisioningSettingUpdateSettingsExtensions
    {
        #region AutoProvision
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.AutoProvision"/></em></p>
        ///   <p>Automatic provisioning toggle. possible values are "on" or "off".</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings SetAutoProvision(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings, string autoProvision)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoProvision = autoProvision;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.AutoProvision"/></em></p>
        ///   <p>Automatic provisioning toggle. possible values are "on" or "off".</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings ResetAutoProvision(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AutoProvision = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings SetName(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings ResetName(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings SetSubscription(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings ResetSubscription(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings SetDebug(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings ResetDebug(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings SetHelp(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings ResetHelp(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings SetOutput(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings ResetOutput(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings SetQuery(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings ResetQuery(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings SetVerbose(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityAutoProvisioningSettingUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityAutoProvisioningSettingUpdateSettings ResetVerbose(this AzureSecurityAutoProvisioningSettingUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityContactCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityContactCreateSettingsExtensions
    {
        #region Email
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactCreateSettings.Email"/></em></p>
        ///   <p>E-mail of the security contact.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings SetEmail(this AzureSecurityContactCreateSettings toolSettings, string email)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Email = email;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactCreateSettings.Email"/></em></p>
        ///   <p>E-mail of the security contact.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings ResetEmail(this AzureSecurityContactCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Email = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactCreateSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings SetName(this AzureSecurityContactCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactCreateSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings ResetName(this AzureSecurityContactCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region AlertNotifications
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactCreateSettings.AlertNotifications"/></em></p>
        ///   <p>Whether to send mail notifications to the security contacts.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings SetAlertNotifications(this AzureSecurityContactCreateSettings toolSettings, string alertNotifications)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlertNotifications = alertNotifications;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactCreateSettings.AlertNotifications"/></em></p>
        ///   <p>Whether to send mail notifications to the security contacts.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings ResetAlertNotifications(this AzureSecurityContactCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlertNotifications = null;
            return toolSettings;
        }
        #endregion
        #region AlertsAdmins
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactCreateSettings.AlertsAdmins"/></em></p>
        ///   <p>Whether to send mail notifications to the subscription administrators.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings SetAlertsAdmins(this AzureSecurityContactCreateSettings toolSettings, string alertsAdmins)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlertsAdmins = alertsAdmins;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactCreateSettings.AlertsAdmins"/></em></p>
        ///   <p>Whether to send mail notifications to the subscription administrators.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings ResetAlertsAdmins(this AzureSecurityContactCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlertsAdmins = null;
            return toolSettings;
        }
        #endregion
        #region Phone
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactCreateSettings.Phone"/></em></p>
        ///   <p>Phone of the security contact.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings SetPhone(this AzureSecurityContactCreateSettings toolSettings, string phone)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Phone = phone;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactCreateSettings.Phone"/></em></p>
        ///   <p>Phone of the security contact.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings ResetPhone(this AzureSecurityContactCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Phone = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings SetSubscription(this AzureSecurityContactCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings ResetSubscription(this AzureSecurityContactCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings SetDebug(this AzureSecurityContactCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings ResetDebug(this AzureSecurityContactCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings SetHelp(this AzureSecurityContactCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings ResetHelp(this AzureSecurityContactCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings SetOutput(this AzureSecurityContactCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings ResetOutput(this AzureSecurityContactCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings SetQuery(this AzureSecurityContactCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings ResetQuery(this AzureSecurityContactCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings SetVerbose(this AzureSecurityContactCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactCreateSettings ResetVerbose(this AzureSecurityContactCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityContactDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityContactDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactDeleteSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactDeleteSettings SetName(this AzureSecurityContactDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactDeleteSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactDeleteSettings ResetName(this AzureSecurityContactDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactDeleteSettings SetSubscription(this AzureSecurityContactDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactDeleteSettings ResetSubscription(this AzureSecurityContactDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactDeleteSettings SetDebug(this AzureSecurityContactDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactDeleteSettings ResetDebug(this AzureSecurityContactDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactDeleteSettings SetHelp(this AzureSecurityContactDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactDeleteSettings ResetHelp(this AzureSecurityContactDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactDeleteSettings SetOutput(this AzureSecurityContactDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactDeleteSettings ResetOutput(this AzureSecurityContactDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactDeleteSettings SetQuery(this AzureSecurityContactDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactDeleteSettings ResetQuery(this AzureSecurityContactDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactDeleteSettings SetVerbose(this AzureSecurityContactDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactDeleteSettings ResetVerbose(this AzureSecurityContactDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityContactListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityContactListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactListSettings SetSubscription(this AzureSecurityContactListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactListSettings ResetSubscription(this AzureSecurityContactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactListSettings SetDebug(this AzureSecurityContactListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactListSettings ResetDebug(this AzureSecurityContactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactListSettings SetHelp(this AzureSecurityContactListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactListSettings ResetHelp(this AzureSecurityContactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactListSettings SetOutput(this AzureSecurityContactListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactListSettings ResetOutput(this AzureSecurityContactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactListSettings SetQuery(this AzureSecurityContactListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactListSettings ResetQuery(this AzureSecurityContactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactListSettings SetVerbose(this AzureSecurityContactListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactListSettings ResetVerbose(this AzureSecurityContactListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityContactShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityContactShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactShowSettings SetName(this AzureSecurityContactShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactShowSettings ResetName(this AzureSecurityContactShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactShowSettings SetSubscription(this AzureSecurityContactShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactShowSettings ResetSubscription(this AzureSecurityContactShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactShowSettings SetDebug(this AzureSecurityContactShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactShowSettings ResetDebug(this AzureSecurityContactShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactShowSettings SetHelp(this AzureSecurityContactShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactShowSettings ResetHelp(this AzureSecurityContactShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactShowSettings SetOutput(this AzureSecurityContactShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactShowSettings ResetOutput(this AzureSecurityContactShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactShowSettings SetQuery(this AzureSecurityContactShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactShowSettings ResetQuery(this AzureSecurityContactShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityContactShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactShowSettings SetVerbose(this AzureSecurityContactShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityContactShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityContactShowSettings ResetVerbose(this AzureSecurityContactShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityDiscoveredSecuritySolutionListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityDiscoveredSecuritySolutionListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionListSettings SetSubscription(this AzureSecurityDiscoveredSecuritySolutionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionListSettings ResetSubscription(this AzureSecurityDiscoveredSecuritySolutionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionListSettings SetDebug(this AzureSecurityDiscoveredSecuritySolutionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionListSettings ResetDebug(this AzureSecurityDiscoveredSecuritySolutionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionListSettings SetHelp(this AzureSecurityDiscoveredSecuritySolutionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionListSettings ResetHelp(this AzureSecurityDiscoveredSecuritySolutionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionListSettings SetOutput(this AzureSecurityDiscoveredSecuritySolutionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionListSettings ResetOutput(this AzureSecurityDiscoveredSecuritySolutionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionListSettings SetQuery(this AzureSecurityDiscoveredSecuritySolutionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionListSettings ResetQuery(this AzureSecurityDiscoveredSecuritySolutionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionListSettings SetVerbose(this AzureSecurityDiscoveredSecuritySolutionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityDiscoveredSecuritySolutionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionListSettings ResetVerbose(this AzureSecurityDiscoveredSecuritySolutionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityDiscoveredSecuritySolutionShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityDiscoveredSecuritySolutionShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings SetName(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings ResetName(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings SetResourceGroup(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings ResetResourceGroup(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings SetSubscription(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings ResetSubscription(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings SetDebug(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings ResetDebug(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings SetHelp(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings ResetHelp(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings SetOutput(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings ResetOutput(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings SetQuery(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings ResetQuery(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings SetVerbose(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityDiscoveredSecuritySolutionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityDiscoveredSecuritySolutionShowSettings ResetVerbose(this AzureSecurityDiscoveredSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityExternalSecuritySolutionListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityExternalSecuritySolutionListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityExternalSecuritySolutionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionListSettings SetSubscription(this AzureSecurityExternalSecuritySolutionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityExternalSecuritySolutionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionListSettings ResetSubscription(this AzureSecurityExternalSecuritySolutionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityExternalSecuritySolutionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionListSettings SetDebug(this AzureSecurityExternalSecuritySolutionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityExternalSecuritySolutionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionListSettings ResetDebug(this AzureSecurityExternalSecuritySolutionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityExternalSecuritySolutionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionListSettings SetHelp(this AzureSecurityExternalSecuritySolutionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityExternalSecuritySolutionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionListSettings ResetHelp(this AzureSecurityExternalSecuritySolutionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityExternalSecuritySolutionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionListSettings SetOutput(this AzureSecurityExternalSecuritySolutionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityExternalSecuritySolutionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionListSettings ResetOutput(this AzureSecurityExternalSecuritySolutionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityExternalSecuritySolutionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionListSettings SetQuery(this AzureSecurityExternalSecuritySolutionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityExternalSecuritySolutionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionListSettings ResetQuery(this AzureSecurityExternalSecuritySolutionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityExternalSecuritySolutionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionListSettings SetVerbose(this AzureSecurityExternalSecuritySolutionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityExternalSecuritySolutionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionListSettings ResetVerbose(this AzureSecurityExternalSecuritySolutionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityExternalSecuritySolutionShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityExternalSecuritySolutionShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings SetName(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings ResetName(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings SetResourceGroup(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings ResetResourceGroup(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings SetSubscription(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings ResetSubscription(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings SetDebug(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings ResetDebug(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings SetHelp(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings ResetHelp(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings SetOutput(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings ResetOutput(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings SetQuery(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings ResetQuery(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings SetVerbose(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityExternalSecuritySolutionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityExternalSecuritySolutionShowSettings ResetVerbose(this AzureSecurityExternalSecuritySolutionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityJitPolicyListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityJitPolicyListSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyListSettings.Location"/></em></p>
        ///   <p>Location of the resource.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings SetLocation(this AzureSecurityJitPolicyListSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyListSettings.Location"/></em></p>
        ///   <p>Location of the resource.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings ResetLocation(this AzureSecurityJitPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings SetResourceGroup(this AzureSecurityJitPolicyListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings ResetResourceGroup(this AzureSecurityJitPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings SetSubscription(this AzureSecurityJitPolicyListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings ResetSubscription(this AzureSecurityJitPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings SetDebug(this AzureSecurityJitPolicyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings ResetDebug(this AzureSecurityJitPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings SetHelp(this AzureSecurityJitPolicyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings ResetHelp(this AzureSecurityJitPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings SetOutput(this AzureSecurityJitPolicyListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings ResetOutput(this AzureSecurityJitPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings SetQuery(this AzureSecurityJitPolicyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings ResetQuery(this AzureSecurityJitPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings SetVerbose(this AzureSecurityJitPolicyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyListSettings ResetVerbose(this AzureSecurityJitPolicyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityJitPolicyShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityJitPolicyShowSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyShowSettings.Location"/></em></p>
        ///   <p>Location of the resource.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings SetLocation(this AzureSecurityJitPolicyShowSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyShowSettings.Location"/></em></p>
        ///   <p>Location of the resource.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings ResetLocation(this AzureSecurityJitPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings SetName(this AzureSecurityJitPolicyShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings ResetName(this AzureSecurityJitPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings SetResourceGroup(this AzureSecurityJitPolicyShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings ResetResourceGroup(this AzureSecurityJitPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings SetSubscription(this AzureSecurityJitPolicyShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings ResetSubscription(this AzureSecurityJitPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings SetDebug(this AzureSecurityJitPolicyShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings ResetDebug(this AzureSecurityJitPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings SetHelp(this AzureSecurityJitPolicyShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings ResetHelp(this AzureSecurityJitPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings SetOutput(this AzureSecurityJitPolicyShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings ResetOutput(this AzureSecurityJitPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings SetQuery(this AzureSecurityJitPolicyShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings ResetQuery(this AzureSecurityJitPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityJitPolicyShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings SetVerbose(this AzureSecurityJitPolicyShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityJitPolicyShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityJitPolicyShowSettings ResetVerbose(this AzureSecurityJitPolicyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityLocationListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityLocationListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityLocationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationListSettings SetSubscription(this AzureSecurityLocationListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityLocationListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationListSettings ResetSubscription(this AzureSecurityLocationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityLocationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationListSettings SetDebug(this AzureSecurityLocationListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityLocationListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationListSettings ResetDebug(this AzureSecurityLocationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityLocationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationListSettings SetHelp(this AzureSecurityLocationListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityLocationListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationListSettings ResetHelp(this AzureSecurityLocationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityLocationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationListSettings SetOutput(this AzureSecurityLocationListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityLocationListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationListSettings ResetOutput(this AzureSecurityLocationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityLocationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationListSettings SetQuery(this AzureSecurityLocationListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityLocationListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationListSettings ResetQuery(this AzureSecurityLocationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityLocationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationListSettings SetVerbose(this AzureSecurityLocationListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityLocationListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationListSettings ResetVerbose(this AzureSecurityLocationListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityLocationShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityLocationShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityLocationShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationShowSettings SetName(this AzureSecurityLocationShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityLocationShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationShowSettings ResetName(this AzureSecurityLocationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityLocationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationShowSettings SetSubscription(this AzureSecurityLocationShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityLocationShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationShowSettings ResetSubscription(this AzureSecurityLocationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityLocationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationShowSettings SetDebug(this AzureSecurityLocationShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityLocationShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationShowSettings ResetDebug(this AzureSecurityLocationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityLocationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationShowSettings SetHelp(this AzureSecurityLocationShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityLocationShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationShowSettings ResetHelp(this AzureSecurityLocationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityLocationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationShowSettings SetOutput(this AzureSecurityLocationShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityLocationShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationShowSettings ResetOutput(this AzureSecurityLocationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityLocationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationShowSettings SetQuery(this AzureSecurityLocationShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityLocationShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationShowSettings ResetQuery(this AzureSecurityLocationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityLocationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationShowSettings SetVerbose(this AzureSecurityLocationShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityLocationShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityLocationShowSettings ResetVerbose(this AzureSecurityLocationShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityPricingCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityPricingCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingCreateSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings SetName(this AzureSecurityPricingCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingCreateSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings ResetName(this AzureSecurityPricingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Tier
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingCreateSettings.Tier"/></em></p>
        ///   <p>Pricing tier type.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings SetTier(this AzureSecurityPricingCreateSettings toolSettings, string tier)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tier = tier;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingCreateSettings.Tier"/></em></p>
        ///   <p>Pricing tier type.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings ResetTier(this AzureSecurityPricingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tier = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings SetResourceGroup(this AzureSecurityPricingCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings ResetResourceGroup(this AzureSecurityPricingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings SetSubscription(this AzureSecurityPricingCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings ResetSubscription(this AzureSecurityPricingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings SetDebug(this AzureSecurityPricingCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings ResetDebug(this AzureSecurityPricingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings SetHelp(this AzureSecurityPricingCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings ResetHelp(this AzureSecurityPricingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings SetOutput(this AzureSecurityPricingCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings ResetOutput(this AzureSecurityPricingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings SetQuery(this AzureSecurityPricingCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings ResetQuery(this AzureSecurityPricingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings SetVerbose(this AzureSecurityPricingCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingCreateSettings ResetVerbose(this AzureSecurityPricingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityPricingListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityPricingListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingListSettings SetSubscription(this AzureSecurityPricingListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingListSettings ResetSubscription(this AzureSecurityPricingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingListSettings SetDebug(this AzureSecurityPricingListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingListSettings ResetDebug(this AzureSecurityPricingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingListSettings SetHelp(this AzureSecurityPricingListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingListSettings ResetHelp(this AzureSecurityPricingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingListSettings SetOutput(this AzureSecurityPricingListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingListSettings ResetOutput(this AzureSecurityPricingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingListSettings SetQuery(this AzureSecurityPricingListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingListSettings ResetQuery(this AzureSecurityPricingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingListSettings SetVerbose(this AzureSecurityPricingListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingListSettings ResetVerbose(this AzureSecurityPricingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityPricingShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityPricingShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings SetName(this AzureSecurityPricingShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings ResetName(this AzureSecurityPricingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings SetResourceGroup(this AzureSecurityPricingShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings ResetResourceGroup(this AzureSecurityPricingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings SetSubscription(this AzureSecurityPricingShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings ResetSubscription(this AzureSecurityPricingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings SetDebug(this AzureSecurityPricingShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings ResetDebug(this AzureSecurityPricingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings SetHelp(this AzureSecurityPricingShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings ResetHelp(this AzureSecurityPricingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings SetOutput(this AzureSecurityPricingShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings ResetOutput(this AzureSecurityPricingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings SetQuery(this AzureSecurityPricingShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings ResetQuery(this AzureSecurityPricingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityPricingShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings SetVerbose(this AzureSecurityPricingShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityPricingShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityPricingShowSettings ResetVerbose(this AzureSecurityPricingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecuritySettingListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecuritySettingListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettingListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingListSettings SetSubscription(this AzureSecuritySettingListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettingListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingListSettings ResetSubscription(this AzureSecuritySettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettingListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingListSettings SetDebug(this AzureSecuritySettingListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettingListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingListSettings ResetDebug(this AzureSecuritySettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettingListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingListSettings SetHelp(this AzureSecuritySettingListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettingListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingListSettings ResetHelp(this AzureSecuritySettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettingListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingListSettings SetOutput(this AzureSecuritySettingListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettingListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingListSettings ResetOutput(this AzureSecuritySettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettingListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingListSettings SetQuery(this AzureSecuritySettingListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettingListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingListSettings ResetQuery(this AzureSecuritySettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettingListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingListSettings SetVerbose(this AzureSecuritySettingListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettingListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingListSettings ResetVerbose(this AzureSecuritySettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecuritySettingShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecuritySettingShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettingShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingShowSettings SetName(this AzureSecuritySettingShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettingShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingShowSettings ResetName(this AzureSecuritySettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettingShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingShowSettings SetSubscription(this AzureSecuritySettingShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettingShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingShowSettings ResetSubscription(this AzureSecuritySettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettingShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingShowSettings SetDebug(this AzureSecuritySettingShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettingShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingShowSettings ResetDebug(this AzureSecuritySettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettingShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingShowSettings SetHelp(this AzureSecuritySettingShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettingShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingShowSettings ResetHelp(this AzureSecuritySettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettingShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingShowSettings SetOutput(this AzureSecuritySettingShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettingShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingShowSettings ResetOutput(this AzureSecuritySettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettingShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingShowSettings SetQuery(this AzureSecuritySettingShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettingShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingShowSettings ResetQuery(this AzureSecuritySettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecuritySettingShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingShowSettings SetVerbose(this AzureSecuritySettingShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecuritySettingShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecuritySettingShowSettings ResetVerbose(this AzureSecuritySettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityTaskListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityTaskListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskListSettings SetResourceGroup(this AzureSecurityTaskListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskListSettings ResetResourceGroup(this AzureSecurityTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskListSettings SetSubscription(this AzureSecurityTaskListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskListSettings ResetSubscription(this AzureSecurityTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskListSettings SetDebug(this AzureSecurityTaskListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskListSettings ResetDebug(this AzureSecurityTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskListSettings SetHelp(this AzureSecurityTaskListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskListSettings ResetHelp(this AzureSecurityTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskListSettings SetOutput(this AzureSecurityTaskListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskListSettings ResetOutput(this AzureSecurityTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskListSettings SetQuery(this AzureSecurityTaskListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskListSettings ResetQuery(this AzureSecurityTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskListSettings SetVerbose(this AzureSecurityTaskListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskListSettings ResetVerbose(this AzureSecurityTaskListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityTaskShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityTaskShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings SetName(this AzureSecurityTaskShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings ResetName(this AzureSecurityTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings SetResourceGroup(this AzureSecurityTaskShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings ResetResourceGroup(this AzureSecurityTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings SetSubscription(this AzureSecurityTaskShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings ResetSubscription(this AzureSecurityTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings SetDebug(this AzureSecurityTaskShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings ResetDebug(this AzureSecurityTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings SetHelp(this AzureSecurityTaskShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings ResetHelp(this AzureSecurityTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings SetOutput(this AzureSecurityTaskShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings ResetOutput(this AzureSecurityTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings SetQuery(this AzureSecurityTaskShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings ResetQuery(this AzureSecurityTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTaskShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings SetVerbose(this AzureSecurityTaskShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTaskShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTaskShowSettings ResetVerbose(this AzureSecurityTaskShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityTopologyListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityTopologyListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTopologyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyListSettings SetSubscription(this AzureSecurityTopologyListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTopologyListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyListSettings ResetSubscription(this AzureSecurityTopologyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTopologyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyListSettings SetDebug(this AzureSecurityTopologyListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTopologyListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyListSettings ResetDebug(this AzureSecurityTopologyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTopologyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyListSettings SetHelp(this AzureSecurityTopologyListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTopologyListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyListSettings ResetHelp(this AzureSecurityTopologyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTopologyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyListSettings SetOutput(this AzureSecurityTopologyListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTopologyListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyListSettings ResetOutput(this AzureSecurityTopologyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTopologyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyListSettings SetQuery(this AzureSecurityTopologyListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTopologyListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyListSettings ResetQuery(this AzureSecurityTopologyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTopologyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyListSettings SetVerbose(this AzureSecurityTopologyListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTopologyListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyListSettings ResetVerbose(this AzureSecurityTopologyListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityTopologyShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityTopologyShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTopologyShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings SetName(this AzureSecurityTopologyShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTopologyShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings ResetName(this AzureSecurityTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTopologyShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings SetResourceGroup(this AzureSecurityTopologyShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTopologyShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings ResetResourceGroup(this AzureSecurityTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTopologyShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings SetSubscription(this AzureSecurityTopologyShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTopologyShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings ResetSubscription(this AzureSecurityTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTopologyShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings SetDebug(this AzureSecurityTopologyShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTopologyShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings ResetDebug(this AzureSecurityTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTopologyShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings SetHelp(this AzureSecurityTopologyShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTopologyShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings ResetHelp(this AzureSecurityTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTopologyShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings SetOutput(this AzureSecurityTopologyShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTopologyShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings ResetOutput(this AzureSecurityTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTopologyShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings SetQuery(this AzureSecurityTopologyShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTopologyShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings ResetQuery(this AzureSecurityTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityTopologyShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings SetVerbose(this AzureSecurityTopologyShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityTopologyShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityTopologyShowSettings ResetVerbose(this AzureSecurityTopologyShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityWorkspaceSettingCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityWorkspaceSettingCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingCreateSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings SetName(this AzureSecurityWorkspaceSettingCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingCreateSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings ResetName(this AzureSecurityWorkspaceSettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region TargetWorkspace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingCreateSettings.TargetWorkspace"/></em></p>
        ///   <p>An ID of the workspace resource that will hold the security data.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings SetTargetWorkspace(this AzureSecurityWorkspaceSettingCreateSettings toolSettings, string targetWorkspace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetWorkspace = targetWorkspace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingCreateSettings.TargetWorkspace"/></em></p>
        ///   <p>An ID of the workspace resource that will hold the security data.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings ResetTargetWorkspace(this AzureSecurityWorkspaceSettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TargetWorkspace = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings SetSubscription(this AzureSecurityWorkspaceSettingCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings ResetSubscription(this AzureSecurityWorkspaceSettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings SetDebug(this AzureSecurityWorkspaceSettingCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings ResetDebug(this AzureSecurityWorkspaceSettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings SetHelp(this AzureSecurityWorkspaceSettingCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings ResetHelp(this AzureSecurityWorkspaceSettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings SetOutput(this AzureSecurityWorkspaceSettingCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings ResetOutput(this AzureSecurityWorkspaceSettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings SetQuery(this AzureSecurityWorkspaceSettingCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings ResetQuery(this AzureSecurityWorkspaceSettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings SetVerbose(this AzureSecurityWorkspaceSettingCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingCreateSettings ResetVerbose(this AzureSecurityWorkspaceSettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityWorkspaceSettingDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityWorkspaceSettingDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingDeleteSettings SetName(this AzureSecurityWorkspaceSettingDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingDeleteSettings ResetName(this AzureSecurityWorkspaceSettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingDeleteSettings SetSubscription(this AzureSecurityWorkspaceSettingDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingDeleteSettings ResetSubscription(this AzureSecurityWorkspaceSettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingDeleteSettings SetDebug(this AzureSecurityWorkspaceSettingDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingDeleteSettings ResetDebug(this AzureSecurityWorkspaceSettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingDeleteSettings SetHelp(this AzureSecurityWorkspaceSettingDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingDeleteSettings ResetHelp(this AzureSecurityWorkspaceSettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingDeleteSettings SetOutput(this AzureSecurityWorkspaceSettingDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingDeleteSettings ResetOutput(this AzureSecurityWorkspaceSettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingDeleteSettings SetQuery(this AzureSecurityWorkspaceSettingDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingDeleteSettings ResetQuery(this AzureSecurityWorkspaceSettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingDeleteSettings SetVerbose(this AzureSecurityWorkspaceSettingDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingDeleteSettings ResetVerbose(this AzureSecurityWorkspaceSettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityWorkspaceSettingListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityWorkspaceSettingListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingListSettings SetSubscription(this AzureSecurityWorkspaceSettingListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingListSettings ResetSubscription(this AzureSecurityWorkspaceSettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingListSettings SetDebug(this AzureSecurityWorkspaceSettingListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingListSettings ResetDebug(this AzureSecurityWorkspaceSettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingListSettings SetHelp(this AzureSecurityWorkspaceSettingListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingListSettings ResetHelp(this AzureSecurityWorkspaceSettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingListSettings SetOutput(this AzureSecurityWorkspaceSettingListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingListSettings ResetOutput(this AzureSecurityWorkspaceSettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingListSettings SetQuery(this AzureSecurityWorkspaceSettingListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingListSettings ResetQuery(this AzureSecurityWorkspaceSettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingListSettings SetVerbose(this AzureSecurityWorkspaceSettingListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingListSettings ResetVerbose(this AzureSecurityWorkspaceSettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureSecurityWorkspaceSettingShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureSecurityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureSecurityWorkspaceSettingShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingShowSettings SetName(this AzureSecurityWorkspaceSettingShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingShowSettings.Name"/></em></p>
        ///   <p>Name of the resource to be fetched.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingShowSettings ResetName(this AzureSecurityWorkspaceSettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingShowSettings SetSubscription(this AzureSecurityWorkspaceSettingShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingShowSettings ResetSubscription(this AzureSecurityWorkspaceSettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingShowSettings SetDebug(this AzureSecurityWorkspaceSettingShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingShowSettings ResetDebug(this AzureSecurityWorkspaceSettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingShowSettings SetHelp(this AzureSecurityWorkspaceSettingShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingShowSettings ResetHelp(this AzureSecurityWorkspaceSettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingShowSettings SetOutput(this AzureSecurityWorkspaceSettingShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingShowSettings ResetOutput(this AzureSecurityWorkspaceSettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingShowSettings SetQuery(this AzureSecurityWorkspaceSettingShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingShowSettings ResetQuery(this AzureSecurityWorkspaceSettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureSecurityWorkspaceSettingShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingShowSettings SetVerbose(this AzureSecurityWorkspaceSettingShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureSecurityWorkspaceSettingShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureSecurityWorkspaceSettingShowSettings ResetVerbose(this AzureSecurityWorkspaceSettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
