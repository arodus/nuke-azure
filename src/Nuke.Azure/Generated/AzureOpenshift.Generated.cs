// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureOpenshift.json
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
    public static partial class AzureOpenshiftTasks
    {
        /// <summary>
        ///   Path to the AzureOpenshift executable.
        /// </summary>
        public static string AzureOpenshiftPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREOPENSHIFT_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureOpenshiftLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Red Hat OpenShift Services.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureOpenshift(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureOpenshiftPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureOpenshiftLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureOpenshiftCreate(AzureOpenshiftCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureOpenshiftCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--aad-client-app-id</c> via <see cref="AzureOpenshiftCreateSettings.AadClientAppId"/></li>
        ///     <li><c>--aad-client-app-secret</c> via <see cref="AzureOpenshiftCreateSettings.AadClientAppSecret"/></li>
        ///     <li><c>--aad-tenant-id</c> via <see cref="AzureOpenshiftCreateSettings.AadTenantId"/></li>
        ///     <li><c>--compute-count</c> via <see cref="AzureOpenshiftCreateSettings.ComputeCount"/></li>
        ///     <li><c>--compute-vm-size</c> via <see cref="AzureOpenshiftCreateSettings.ComputeVmSize"/></li>
        ///     <li><c>--customer-admin-group-id</c> via <see cref="AzureOpenshiftCreateSettings.CustomerAdminGroupId"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureOpenshiftCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureOpenshiftCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureOpenshiftCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureOpenshiftCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureOpenshiftCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureOpenshiftCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureOpenshiftCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureOpenshiftCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subnet-prefix</c> via <see cref="AzureOpenshiftCreateSettings.SubnetPrefix"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureOpenshiftCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureOpenshiftCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureOpenshiftCreateSettings.Verbose"/></li>
        ///     <li><c>--vnet-peer</c> via <see cref="AzureOpenshiftCreateSettings.VnetPeer"/></li>
        ///     <li><c>--vnet-prefix</c> via <see cref="AzureOpenshiftCreateSettings.VnetPrefix"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureOpenshiftCreate(Configure<AzureOpenshiftCreateSettings> configurator)
        {
            return AzureOpenshiftCreate(configurator(new AzureOpenshiftCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--aad-client-app-id</c> via <see cref="AzureOpenshiftCreateSettings.AadClientAppId"/></li>
        ///     <li><c>--aad-client-app-secret</c> via <see cref="AzureOpenshiftCreateSettings.AadClientAppSecret"/></li>
        ///     <li><c>--aad-tenant-id</c> via <see cref="AzureOpenshiftCreateSettings.AadTenantId"/></li>
        ///     <li><c>--compute-count</c> via <see cref="AzureOpenshiftCreateSettings.ComputeCount"/></li>
        ///     <li><c>--compute-vm-size</c> via <see cref="AzureOpenshiftCreateSettings.ComputeVmSize"/></li>
        ///     <li><c>--customer-admin-group-id</c> via <see cref="AzureOpenshiftCreateSettings.CustomerAdminGroupId"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureOpenshiftCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureOpenshiftCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureOpenshiftCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureOpenshiftCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureOpenshiftCreateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureOpenshiftCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureOpenshiftCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureOpenshiftCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subnet-prefix</c> via <see cref="AzureOpenshiftCreateSettings.SubnetPrefix"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureOpenshiftCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureOpenshiftCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureOpenshiftCreateSettings.Verbose"/></li>
        ///     <li><c>--vnet-peer</c> via <see cref="AzureOpenshiftCreateSettings.VnetPeer"/></li>
        ///     <li><c>--vnet-prefix</c> via <see cref="AzureOpenshiftCreateSettings.VnetPrefix"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureOpenshiftCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureOpenshiftCreate(CombinatorialConfigure<AzureOpenshiftCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureOpenshiftCreate, AzureOpenshiftLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureOpenshiftDelete(AzureOpenshiftDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureOpenshiftDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureOpenshiftDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureOpenshiftDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureOpenshiftDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureOpenshiftDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureOpenshiftDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureOpenshiftDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureOpenshiftDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureOpenshiftDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureOpenshiftDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureOpenshiftDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureOpenshiftDelete(Configure<AzureOpenshiftDeleteSettings> configurator)
        {
            return AzureOpenshiftDelete(configurator(new AzureOpenshiftDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureOpenshiftDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureOpenshiftDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureOpenshiftDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureOpenshiftDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureOpenshiftDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureOpenshiftDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureOpenshiftDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureOpenshiftDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureOpenshiftDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureOpenshiftDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureOpenshiftDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureOpenshiftDelete(CombinatorialConfigure<AzureOpenshiftDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureOpenshiftDelete, AzureOpenshiftLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureOpenshiftList(AzureOpenshiftListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureOpenshiftListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureOpenshiftListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureOpenshiftListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureOpenshiftListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureOpenshiftListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureOpenshiftListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureOpenshiftListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureOpenshiftListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureOpenshiftList(Configure<AzureOpenshiftListSettings> configurator)
        {
            return AzureOpenshiftList(configurator(new AzureOpenshiftListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureOpenshiftListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureOpenshiftListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureOpenshiftListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureOpenshiftListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureOpenshiftListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureOpenshiftListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureOpenshiftListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureOpenshiftListSettings Settings, IReadOnlyCollection<Output> Output)> AzureOpenshiftList(CombinatorialConfigure<AzureOpenshiftListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureOpenshiftList, AzureOpenshiftLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureOpenshiftScale(AzureOpenshiftScaleSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureOpenshiftScaleSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--compute-count</c> via <see cref="AzureOpenshiftScaleSettings.ComputeCount"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureOpenshiftScaleSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureOpenshiftScaleSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureOpenshiftScaleSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureOpenshiftScaleSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureOpenshiftScaleSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureOpenshiftScaleSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureOpenshiftScaleSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureOpenshiftScaleSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureOpenshiftScaleSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureOpenshiftScale(Configure<AzureOpenshiftScaleSettings> configurator)
        {
            return AzureOpenshiftScale(configurator(new AzureOpenshiftScaleSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--compute-count</c> via <see cref="AzureOpenshiftScaleSettings.ComputeCount"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureOpenshiftScaleSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureOpenshiftScaleSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureOpenshiftScaleSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureOpenshiftScaleSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureOpenshiftScaleSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureOpenshiftScaleSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureOpenshiftScaleSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureOpenshiftScaleSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureOpenshiftScaleSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureOpenshiftScaleSettings Settings, IReadOnlyCollection<Output> Output)> AzureOpenshiftScale(CombinatorialConfigure<AzureOpenshiftScaleSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureOpenshiftScale, AzureOpenshiftLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureOpenshiftShow(AzureOpenshiftShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureOpenshiftShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureOpenshiftShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureOpenshiftShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureOpenshiftShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureOpenshiftShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureOpenshiftShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureOpenshiftShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureOpenshiftShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureOpenshiftShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureOpenshiftShow(Configure<AzureOpenshiftShowSettings> configurator)
        {
            return AzureOpenshiftShow(configurator(new AzureOpenshiftShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureOpenshiftShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureOpenshiftShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureOpenshiftShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureOpenshiftShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureOpenshiftShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureOpenshiftShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureOpenshiftShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureOpenshiftShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureOpenshiftShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureOpenshiftShow(CombinatorialConfigure<AzureOpenshiftShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureOpenshiftShow, AzureOpenshiftLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureOpenshiftWait(AzureOpenshiftWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureOpenshiftWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureOpenshiftWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureOpenshiftWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureOpenshiftWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureOpenshiftWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureOpenshiftWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureOpenshiftWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureOpenshiftWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureOpenshiftWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureOpenshiftWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureOpenshiftWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureOpenshiftWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureOpenshiftWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureOpenshiftWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureOpenshiftWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureOpenshiftWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureOpenshiftWait(Configure<AzureOpenshiftWaitSettings> configurator)
        {
            return AzureOpenshiftWait(configurator(new AzureOpenshiftWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Red Hat OpenShift Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/openshift?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureOpenshiftWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureOpenshiftWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureOpenshiftWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureOpenshiftWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureOpenshiftWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureOpenshiftWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureOpenshiftWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureOpenshiftWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureOpenshiftWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureOpenshiftWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureOpenshiftWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureOpenshiftWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureOpenshiftWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureOpenshiftWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureOpenshiftWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureOpenshiftWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureOpenshiftWait(CombinatorialConfigure<AzureOpenshiftWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureOpenshiftWait, AzureOpenshiftLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureOpenshiftCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureOpenshiftTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureOpenshiftCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureOpenshift executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureOpenshiftTasks.AzureOpenshiftPath;
        public override Action<OutputType, string> CustomLogger => AzureOpenshiftTasks.AzureOpenshiftLogger;
        /// <summary>
        ///   Name of the managed OpenShift cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The ID of an Azure Active Directory client application. If not specified, a new Azure Active Directory client is created.
        /// </summary>
        public virtual string AadClientAppId { get; internal set; }
        /// <summary>
        ///   The secret of an Azure Active Directory client application.
        /// </summary>
        public virtual string AadClientAppSecret { get; internal set; }
        /// <summary>
        ///   The ID of an Azure Active Directory tenant.
        /// </summary>
        public virtual string AadTenantId { get; internal set; }
        /// <summary>
        ///   Number of nodes in the OpenShift node pool.
        /// </summary>
        public virtual int? ComputeCount { get; internal set; }
        /// <summary>
        ///   Size of Virtual Machines to create as OpenShift nodes.
        /// </summary>
        public virtual string ComputeVmSize { get; internal set; }
        /// <summary>
        ///   The Object ID of an Azure Active Directory Group that memberships will get synced into the OpenShift group "osa-customer-admins". If not specified, no cluster admin access will be granted.
        /// </summary>
        public virtual string CustomerAdminGroupId { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   The CIDR used on the Subnet into which to deploy the cluster.
        /// </summary>
        public virtual string SubnetPrefix { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   The ID or the name of a subnet in an existing VNet into which to peer the cluster.
        /// </summary>
        public virtual string VnetPeer { get; internal set; }
        /// <summary>
        ///   The CIDR used on the VNet into which to deploy the cluster.
        /// </summary>
        public virtual string VnetPrefix { get; internal set; }
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
              .Add("openshift create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--aad-client-app-id {value}", AadClientAppId)
              .Add("--aad-client-app-secret {value}", AadClientAppSecret, secret: true)
              .Add("--aad-tenant-id {value}", AadTenantId)
              .Add("--compute-count {value}", ComputeCount)
              .Add("--compute-vm-size {value}", ComputeVmSize)
              .Add("--customer-admin-group-id {value}", CustomerAdminGroupId)
              .Add("--location {value}", Location)
              .Add("--no-wait", NoWait)
              .Add("--subnet-prefix {value}", SubnetPrefix)
              .Add("--tags {value}", Tags)
              .Add("--vnet-peer {value}", VnetPeer)
              .Add("--vnet-prefix {value}", VnetPrefix)
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
    #region AzureOpenshiftDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureOpenshiftTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureOpenshiftDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureOpenshift executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureOpenshiftTasks.AzureOpenshiftPath;
        public override Action<OutputType, string> CustomLogger => AzureOpenshiftTasks.AzureOpenshiftLogger;
        /// <summary>
        ///   Name of the managed OpenShift cluster.
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
              .Add("openshift delete")
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
    #region AzureOpenshiftListSettings
    /// <summary>
    ///   Used within <see cref="AzureOpenshiftTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureOpenshiftListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureOpenshift executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureOpenshiftTasks.AzureOpenshiftPath;
        public override Action<OutputType, string> CustomLogger => AzureOpenshiftTasks.AzureOpenshiftLogger;
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
              .Add("openshift list")
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
    #region AzureOpenshiftScaleSettings
    /// <summary>
    ///   Used within <see cref="AzureOpenshiftTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureOpenshiftScaleSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureOpenshift executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureOpenshiftTasks.AzureOpenshiftPath;
        public override Action<OutputType, string> CustomLogger => AzureOpenshiftTasks.AzureOpenshiftLogger;
        /// <summary>
        ///   Number of nodes in the OpenShift compute pool.
        /// </summary>
        public virtual int? ComputeCount { get; internal set; }
        /// <summary>
        ///   Name of the managed OpenShift cluster.
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
              .Add("openshift scale")
              .Add("--compute-count {value}", ComputeCount)
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
    #region AzureOpenshiftShowSettings
    /// <summary>
    ///   Used within <see cref="AzureOpenshiftTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureOpenshiftShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureOpenshift executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureOpenshiftTasks.AzureOpenshiftPath;
        public override Action<OutputType, string> CustomLogger => AzureOpenshiftTasks.AzureOpenshiftLogger;
        /// <summary>
        ///   Name of the managed OpenShift cluster.
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
              .Add("openshift show")
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
    #region AzureOpenshiftWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureOpenshiftTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureOpenshiftWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureOpenshift executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureOpenshiftTasks.AzureOpenshiftPath;
        public override Action<OutputType, string> CustomLogger => AzureOpenshiftTasks.AzureOpenshiftLogger;
        /// <summary>
        ///   Name of the managed OpenShift cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
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
              .Add("openshift wait")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--created {value}", Created)
              .Add("--custom {value}", Custom)
              .Add("--deleted {value}", Deleted)
              .Add("--exists {value}", Exists)
              .Add("--interval {value}", Interval)
              .Add("--timeout {value}", Timeout)
              .Add("--updated {value}", Updated)
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
    #region AzureOpenshiftCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureOpenshiftTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureOpenshiftCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.Name"/></em></p>
        ///   <p>Name of the managed OpenShift cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetName(this AzureOpenshiftCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.Name"/></em></p>
        ///   <p>Name of the managed OpenShift cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetName(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetResourceGroup(this AzureOpenshiftCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetResourceGroup(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AadClientAppId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.AadClientAppId"/></em></p>
        ///   <p>The ID of an Azure Active Directory client application. If not specified, a new Azure Active Directory client is created.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetAadClientAppId(this AzureOpenshiftCreateSettings toolSettings, string aadClientAppId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientAppId = aadClientAppId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.AadClientAppId"/></em></p>
        ///   <p>The ID of an Azure Active Directory client application. If not specified, a new Azure Active Directory client is created.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetAadClientAppId(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientAppId = null;
            return toolSettings;
        }
        #endregion
        #region AadClientAppSecret
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.AadClientAppSecret"/></em></p>
        ///   <p>The secret of an Azure Active Directory client application.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetAadClientAppSecret(this AzureOpenshiftCreateSettings toolSettings, string aadClientAppSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientAppSecret = aadClientAppSecret;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.AadClientAppSecret"/></em></p>
        ///   <p>The secret of an Azure Active Directory client application.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetAadClientAppSecret(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientAppSecret = null;
            return toolSettings;
        }
        #endregion
        #region AadTenantId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.AadTenantId"/></em></p>
        ///   <p>The ID of an Azure Active Directory tenant.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetAadTenantId(this AzureOpenshiftCreateSettings toolSettings, string aadTenantId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadTenantId = aadTenantId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.AadTenantId"/></em></p>
        ///   <p>The ID of an Azure Active Directory tenant.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetAadTenantId(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadTenantId = null;
            return toolSettings;
        }
        #endregion
        #region ComputeCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.ComputeCount"/></em></p>
        ///   <p>Number of nodes in the OpenShift node pool.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetComputeCount(this AzureOpenshiftCreateSettings toolSettings, int? computeCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComputeCount = computeCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.ComputeCount"/></em></p>
        ///   <p>Number of nodes in the OpenShift node pool.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetComputeCount(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComputeCount = null;
            return toolSettings;
        }
        #endregion
        #region ComputeVmSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.ComputeVmSize"/></em></p>
        ///   <p>Size of Virtual Machines to create as OpenShift nodes.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetComputeVmSize(this AzureOpenshiftCreateSettings toolSettings, string computeVmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComputeVmSize = computeVmSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.ComputeVmSize"/></em></p>
        ///   <p>Size of Virtual Machines to create as OpenShift nodes.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetComputeVmSize(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComputeVmSize = null;
            return toolSettings;
        }
        #endregion
        #region CustomerAdminGroupId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.CustomerAdminGroupId"/></em></p>
        ///   <p>The Object ID of an Azure Active Directory Group that memberships will get synced into the OpenShift group "osa-customer-admins". If not specified, no cluster admin access will be granted.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetCustomerAdminGroupId(this AzureOpenshiftCreateSettings toolSettings, string customerAdminGroupId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomerAdminGroupId = customerAdminGroupId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.CustomerAdminGroupId"/></em></p>
        ///   <p>The Object ID of an Azure Active Directory Group that memberships will get synced into the OpenShift group "osa-customer-admins". If not specified, no cluster admin access will be granted.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetCustomerAdminGroupId(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomerAdminGroupId = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetLocation(this AzureOpenshiftCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetLocation(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetNoWait(this AzureOpenshiftCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetNoWait(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureOpenshiftCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings EnableNoWait(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureOpenshiftCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings DisableNoWait(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureOpenshiftCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ToggleNoWait(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region SubnetPrefix
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.SubnetPrefix"/></em></p>
        ///   <p>The CIDR used on the Subnet into which to deploy the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetSubnetPrefix(this AzureOpenshiftCreateSettings toolSettings, string subnetPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetPrefix = subnetPrefix;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.SubnetPrefix"/></em></p>
        ///   <p>The CIDR used on the Subnet into which to deploy the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetSubnetPrefix(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetPrefix = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetTags(this AzureOpenshiftCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetTags(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region VnetPeer
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.VnetPeer"/></em></p>
        ///   <p>The ID or the name of a subnet in an existing VNet into which to peer the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetVnetPeer(this AzureOpenshiftCreateSettings toolSettings, string vnetPeer)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetPeer = vnetPeer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.VnetPeer"/></em></p>
        ///   <p>The ID or the name of a subnet in an existing VNet into which to peer the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetVnetPeer(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetPeer = null;
            return toolSettings;
        }
        #endregion
        #region VnetPrefix
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.VnetPrefix"/></em></p>
        ///   <p>The CIDR used on the VNet into which to deploy the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetVnetPrefix(this AzureOpenshiftCreateSettings toolSettings, string vnetPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetPrefix = vnetPrefix;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.VnetPrefix"/></em></p>
        ///   <p>The CIDR used on the VNet into which to deploy the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetVnetPrefix(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetPrefix = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetSubscription(this AzureOpenshiftCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetSubscription(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetDebug(this AzureOpenshiftCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetDebug(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetHelp(this AzureOpenshiftCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetHelp(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetOutput(this AzureOpenshiftCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetOutput(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetQuery(this AzureOpenshiftCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetQuery(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings SetVerbose(this AzureOpenshiftCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftCreateSettings ResetVerbose(this AzureOpenshiftCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureOpenshiftDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureOpenshiftTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureOpenshiftDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftDeleteSettings.Name"/></em></p>
        ///   <p>Name of the managed OpenShift cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings SetName(this AzureOpenshiftDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftDeleteSettings.Name"/></em></p>
        ///   <p>Name of the managed OpenShift cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings ResetName(this AzureOpenshiftDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings SetResourceGroup(this AzureOpenshiftDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings ResetResourceGroup(this AzureOpenshiftDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings SetNoWait(this AzureOpenshiftDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings ResetNoWait(this AzureOpenshiftDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureOpenshiftDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings EnableNoWait(this AzureOpenshiftDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureOpenshiftDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings DisableNoWait(this AzureOpenshiftDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureOpenshiftDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings ToggleNoWait(this AzureOpenshiftDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings SetYes(this AzureOpenshiftDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings ResetYes(this AzureOpenshiftDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings SetSubscription(this AzureOpenshiftDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings ResetSubscription(this AzureOpenshiftDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings SetDebug(this AzureOpenshiftDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings ResetDebug(this AzureOpenshiftDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings SetHelp(this AzureOpenshiftDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings ResetHelp(this AzureOpenshiftDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings SetOutput(this AzureOpenshiftDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings ResetOutput(this AzureOpenshiftDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings SetQuery(this AzureOpenshiftDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings ResetQuery(this AzureOpenshiftDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings SetVerbose(this AzureOpenshiftDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftDeleteSettings ResetVerbose(this AzureOpenshiftDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureOpenshiftListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureOpenshiftTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureOpenshiftListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftListSettings SetResourceGroup(this AzureOpenshiftListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftListSettings ResetResourceGroup(this AzureOpenshiftListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftListSettings SetSubscription(this AzureOpenshiftListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftListSettings ResetSubscription(this AzureOpenshiftListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftListSettings SetDebug(this AzureOpenshiftListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftListSettings ResetDebug(this AzureOpenshiftListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftListSettings SetHelp(this AzureOpenshiftListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftListSettings ResetHelp(this AzureOpenshiftListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftListSettings SetOutput(this AzureOpenshiftListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftListSettings ResetOutput(this AzureOpenshiftListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftListSettings SetQuery(this AzureOpenshiftListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftListSettings ResetQuery(this AzureOpenshiftListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftListSettings SetVerbose(this AzureOpenshiftListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftListSettings ResetVerbose(this AzureOpenshiftListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureOpenshiftScaleSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureOpenshiftTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureOpenshiftScaleSettingsExtensions
    {
        #region ComputeCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftScaleSettings.ComputeCount"/></em></p>
        ///   <p>Number of nodes in the OpenShift compute pool.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings SetComputeCount(this AzureOpenshiftScaleSettings toolSettings, int? computeCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComputeCount = computeCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftScaleSettings.ComputeCount"/></em></p>
        ///   <p>Number of nodes in the OpenShift compute pool.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings ResetComputeCount(this AzureOpenshiftScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ComputeCount = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftScaleSettings.Name"/></em></p>
        ///   <p>Name of the managed OpenShift cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings SetName(this AzureOpenshiftScaleSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftScaleSettings.Name"/></em></p>
        ///   <p>Name of the managed OpenShift cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings ResetName(this AzureOpenshiftScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftScaleSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings SetResourceGroup(this AzureOpenshiftScaleSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftScaleSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings ResetResourceGroup(this AzureOpenshiftScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftScaleSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings SetNoWait(this AzureOpenshiftScaleSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftScaleSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings ResetNoWait(this AzureOpenshiftScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureOpenshiftScaleSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings EnableNoWait(this AzureOpenshiftScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureOpenshiftScaleSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings DisableNoWait(this AzureOpenshiftScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureOpenshiftScaleSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings ToggleNoWait(this AzureOpenshiftScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftScaleSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings SetSubscription(this AzureOpenshiftScaleSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftScaleSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings ResetSubscription(this AzureOpenshiftScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftScaleSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings SetDebug(this AzureOpenshiftScaleSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftScaleSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings ResetDebug(this AzureOpenshiftScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftScaleSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings SetHelp(this AzureOpenshiftScaleSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftScaleSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings ResetHelp(this AzureOpenshiftScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftScaleSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings SetOutput(this AzureOpenshiftScaleSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftScaleSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings ResetOutput(this AzureOpenshiftScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftScaleSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings SetQuery(this AzureOpenshiftScaleSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftScaleSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings ResetQuery(this AzureOpenshiftScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftScaleSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings SetVerbose(this AzureOpenshiftScaleSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftScaleSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftScaleSettings ResetVerbose(this AzureOpenshiftScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureOpenshiftShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureOpenshiftTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureOpenshiftShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftShowSettings.Name"/></em></p>
        ///   <p>Name of the managed OpenShift cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings SetName(this AzureOpenshiftShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftShowSettings.Name"/></em></p>
        ///   <p>Name of the managed OpenShift cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings ResetName(this AzureOpenshiftShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings SetResourceGroup(this AzureOpenshiftShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings ResetResourceGroup(this AzureOpenshiftShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings SetSubscription(this AzureOpenshiftShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings ResetSubscription(this AzureOpenshiftShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings SetDebug(this AzureOpenshiftShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings ResetDebug(this AzureOpenshiftShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings SetHelp(this AzureOpenshiftShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings ResetHelp(this AzureOpenshiftShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings SetOutput(this AzureOpenshiftShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings ResetOutput(this AzureOpenshiftShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings SetQuery(this AzureOpenshiftShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings ResetQuery(this AzureOpenshiftShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings SetVerbose(this AzureOpenshiftShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftShowSettings ResetVerbose(this AzureOpenshiftShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureOpenshiftWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureOpenshiftTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureOpenshiftWaitSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.Name"/></em></p>
        ///   <p>Name of the managed OpenShift cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetName(this AzureOpenshiftWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.Name"/></em></p>
        ///   <p>Name of the managed OpenShift cluster.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetName(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetResourceGroup(this AzureOpenshiftWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetResourceGroup(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetCreated(this AzureOpenshiftWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetCreated(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetCustom(this AzureOpenshiftWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetCustom(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetDeleted(this AzureOpenshiftWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetDeleted(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetExists(this AzureOpenshiftWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetExists(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetInterval(this AzureOpenshiftWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetInterval(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetTimeout(this AzureOpenshiftWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetTimeout(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetUpdated(this AzureOpenshiftWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetUpdated(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetSubscription(this AzureOpenshiftWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetSubscription(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetDebug(this AzureOpenshiftWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetDebug(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetHelp(this AzureOpenshiftWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetHelp(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetOutput(this AzureOpenshiftWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetOutput(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetQuery(this AzureOpenshiftWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetQuery(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureOpenshiftWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings SetVerbose(this AzureOpenshiftWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureOpenshiftWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureOpenshiftWaitSettings ResetVerbose(this AzureOpenshiftWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
