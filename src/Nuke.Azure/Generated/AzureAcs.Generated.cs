// Generated from https://github.com/totollygeek/azure/blob/master/src/Nuke.Azure/specifications/AzureAcs.json
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
    public static partial class AzureAcsTasks
    {
        /// <summary>
        ///   Path to the AzureAcs executable.
        /// </summary>
        public static string AzureAcsPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREACS_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureAcsLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Container Services.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAcs(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureAcsPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureAcsLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAcsBrowse(AzureAcsBrowseSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAcsBrowseSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsBrowseSettings.Debug"/></li>
        ///     <li><c>--disable-browser</c> via <see cref="AzureAcsBrowseSettings.DisableBrowser"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsBrowseSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsBrowseSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsBrowseSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsBrowseSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsBrowseSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-key-file</c> via <see cref="AzureAcsBrowseSettings.SshKeyFile"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsBrowseSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsBrowseSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAcsBrowse(Configure<AzureAcsBrowseSettings> configurator)
        {
            return AzureAcsBrowse(configurator(new AzureAcsBrowseSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsBrowseSettings.Debug"/></li>
        ///     <li><c>--disable-browser</c> via <see cref="AzureAcsBrowseSettings.DisableBrowser"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsBrowseSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsBrowseSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsBrowseSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsBrowseSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsBrowseSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-key-file</c> via <see cref="AzureAcsBrowseSettings.SshKeyFile"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsBrowseSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsBrowseSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAcsBrowseSettings Settings, IReadOnlyCollection<Output> Output)> AzureAcsBrowse(CombinatorialConfigure<AzureAcsBrowseSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAcsBrowse, AzureAcsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAcsCreate(AzureAcsCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAcsCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--admin-password</c> via <see cref="AzureAcsCreateSettings.AdminPassword"/></li>
        ///     <li><c>--admin-username</c> via <see cref="AzureAcsCreateSettings.AdminUsername"/></li>
        ///     <li><c>--agent-count</c> via <see cref="AzureAcsCreateSettings.AgentCount"/></li>
        ///     <li><c>--agent-osdisk-size</c> via <see cref="AzureAcsCreateSettings.AgentOsdiskSize"/></li>
        ///     <li><c>--agent-ports</c> via <see cref="AzureAcsCreateSettings.AgentPorts"/></li>
        ///     <li><c>--agent-profiles</c> via <see cref="AzureAcsCreateSettings.AgentProfiles"/></li>
        ///     <li><c>--agent-storage-profile</c> via <see cref="AzureAcsCreateSettings.AgentStorageProfile"/></li>
        ///     <li><c>--agent-vm-size</c> via <see cref="AzureAcsCreateSettings.AgentVmSize"/></li>
        ///     <li><c>--agent-vnet-subnet-id</c> via <see cref="AzureAcsCreateSettings.AgentVnetSubnetId"/></li>
        ///     <li><c>--api-version</c> via <see cref="AzureAcsCreateSettings.ApiVersion"/></li>
        ///     <li><c>--client-secret</c> via <see cref="AzureAcsCreateSettings.ClientSecret"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAcsCreateSettings.Debug"/></li>
        ///     <li><c>--dns-prefix</c> via <see cref="AzureAcsCreateSettings.DnsPrefix"/></li>
        ///     <li><c>--generate-ssh-keys</c> via <see cref="AzureAcsCreateSettings.GenerateSshKeys"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAcsCreateSettings.Location"/></li>
        ///     <li><c>--master-count</c> via <see cref="AzureAcsCreateSettings.MasterCount"/></li>
        ///     <li><c>--master-first-consecutive-static-ip</c> via <see cref="AzureAcsCreateSettings.MasterFirstConsecutiveStaticIp"/></li>
        ///     <li><c>--master-osdisk-size</c> via <see cref="AzureAcsCreateSettings.MasterOsdiskSize"/></li>
        ///     <li><c>--master-profile</c> via <see cref="AzureAcsCreateSettings.MasterProfile"/></li>
        ///     <li><c>--master-storage-profile</c> via <see cref="AzureAcsCreateSettings.MasterStorageProfile"/></li>
        ///     <li><c>--master-vm-size</c> via <see cref="AzureAcsCreateSettings.MasterVmSize"/></li>
        ///     <li><c>--master-vnet-subnet-id</c> via <see cref="AzureAcsCreateSettings.MasterVnetSubnetId"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAcsCreateSettings.NoWait"/></li>
        ///     <li><c>--orchestrator-type</c> via <see cref="AzureAcsCreateSettings.OrchestratorType"/></li>
        ///     <li><c>--orchestrator-version</c> via <see cref="AzureAcsCreateSettings.OrchestratorVersion"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-principal</c> via <see cref="AzureAcsCreateSettings.ServicePrincipal"/></li>
        ///     <li><c>--ssh-key-value</c> via <see cref="AzureAcsCreateSettings.SshKeyValue"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureAcsCreateSettings.Tags"/></li>
        ///     <li><c>--validate</c> via <see cref="AzureAcsCreateSettings.Validate"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsCreateSettings.Verbose"/></li>
        ///     <li><c>--windows</c> via <see cref="AzureAcsCreateSettings.Windows"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAcsCreate(Configure<AzureAcsCreateSettings> configurator)
        {
            return AzureAcsCreate(configurator(new AzureAcsCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--admin-password</c> via <see cref="AzureAcsCreateSettings.AdminPassword"/></li>
        ///     <li><c>--admin-username</c> via <see cref="AzureAcsCreateSettings.AdminUsername"/></li>
        ///     <li><c>--agent-count</c> via <see cref="AzureAcsCreateSettings.AgentCount"/></li>
        ///     <li><c>--agent-osdisk-size</c> via <see cref="AzureAcsCreateSettings.AgentOsdiskSize"/></li>
        ///     <li><c>--agent-ports</c> via <see cref="AzureAcsCreateSettings.AgentPorts"/></li>
        ///     <li><c>--agent-profiles</c> via <see cref="AzureAcsCreateSettings.AgentProfiles"/></li>
        ///     <li><c>--agent-storage-profile</c> via <see cref="AzureAcsCreateSettings.AgentStorageProfile"/></li>
        ///     <li><c>--agent-vm-size</c> via <see cref="AzureAcsCreateSettings.AgentVmSize"/></li>
        ///     <li><c>--agent-vnet-subnet-id</c> via <see cref="AzureAcsCreateSettings.AgentVnetSubnetId"/></li>
        ///     <li><c>--api-version</c> via <see cref="AzureAcsCreateSettings.ApiVersion"/></li>
        ///     <li><c>--client-secret</c> via <see cref="AzureAcsCreateSettings.ClientSecret"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAcsCreateSettings.Debug"/></li>
        ///     <li><c>--dns-prefix</c> via <see cref="AzureAcsCreateSettings.DnsPrefix"/></li>
        ///     <li><c>--generate-ssh-keys</c> via <see cref="AzureAcsCreateSettings.GenerateSshKeys"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAcsCreateSettings.Location"/></li>
        ///     <li><c>--master-count</c> via <see cref="AzureAcsCreateSettings.MasterCount"/></li>
        ///     <li><c>--master-first-consecutive-static-ip</c> via <see cref="AzureAcsCreateSettings.MasterFirstConsecutiveStaticIp"/></li>
        ///     <li><c>--master-osdisk-size</c> via <see cref="AzureAcsCreateSettings.MasterOsdiskSize"/></li>
        ///     <li><c>--master-profile</c> via <see cref="AzureAcsCreateSettings.MasterProfile"/></li>
        ///     <li><c>--master-storage-profile</c> via <see cref="AzureAcsCreateSettings.MasterStorageProfile"/></li>
        ///     <li><c>--master-vm-size</c> via <see cref="AzureAcsCreateSettings.MasterVmSize"/></li>
        ///     <li><c>--master-vnet-subnet-id</c> via <see cref="AzureAcsCreateSettings.MasterVnetSubnetId"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsCreateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAcsCreateSettings.NoWait"/></li>
        ///     <li><c>--orchestrator-type</c> via <see cref="AzureAcsCreateSettings.OrchestratorType"/></li>
        ///     <li><c>--orchestrator-version</c> via <see cref="AzureAcsCreateSettings.OrchestratorVersion"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-principal</c> via <see cref="AzureAcsCreateSettings.ServicePrincipal"/></li>
        ///     <li><c>--ssh-key-value</c> via <see cref="AzureAcsCreateSettings.SshKeyValue"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureAcsCreateSettings.Tags"/></li>
        ///     <li><c>--validate</c> via <see cref="AzureAcsCreateSettings.Validate"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsCreateSettings.Verbose"/></li>
        ///     <li><c>--windows</c> via <see cref="AzureAcsCreateSettings.Windows"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAcsCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAcsCreate(CombinatorialConfigure<AzureAcsCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAcsCreate, AzureAcsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAcsDelete(AzureAcsDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAcsDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAcsDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAcsDelete(Configure<AzureAcsDeleteSettings> configurator)
        {
            return AzureAcsDelete(configurator(new AzureAcsDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAcsDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAcsDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureAcsDelete(CombinatorialConfigure<AzureAcsDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAcsDelete, AzureAcsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAcsList(AzureAcsListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAcsListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAcsList(Configure<AzureAcsListSettings> configurator)
        {
            return AzureAcsList(configurator(new AzureAcsListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAcsListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAcsList(CombinatorialConfigure<AzureAcsListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAcsList, AzureAcsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAcsListLocations(AzureAcsListLocationsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAcsListLocationsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsListLocationsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsListLocationsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsListLocationsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsListLocationsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsListLocationsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsListLocationsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAcsListLocations(Configure<AzureAcsListLocationsSettings> configurator)
        {
            return AzureAcsListLocations(configurator(new AzureAcsListLocationsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsListLocationsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsListLocationsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsListLocationsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsListLocationsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsListLocationsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsListLocationsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAcsListLocationsSettings Settings, IReadOnlyCollection<Output> Output)> AzureAcsListLocations(CombinatorialConfigure<AzureAcsListLocationsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAcsListLocations, AzureAcsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAcsScale(AzureAcsScaleSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAcsScaleSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsScaleSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsScaleSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsScaleSettings.Name"/></li>
        ///     <li><c>--new-agent-count</c> via <see cref="AzureAcsScaleSettings.NewAgentCount"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsScaleSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsScaleSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsScaleSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsScaleSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsScaleSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAcsScale(Configure<AzureAcsScaleSettings> configurator)
        {
            return AzureAcsScale(configurator(new AzureAcsScaleSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsScaleSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsScaleSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsScaleSettings.Name"/></li>
        ///     <li><c>--new-agent-count</c> via <see cref="AzureAcsScaleSettings.NewAgentCount"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsScaleSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsScaleSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsScaleSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsScaleSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsScaleSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAcsScaleSettings Settings, IReadOnlyCollection<Output> Output)> AzureAcsScale(CombinatorialConfigure<AzureAcsScaleSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAcsScale, AzureAcsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAcsShow(AzureAcsShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAcsShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAcsShow(Configure<AzureAcsShowSettings> configurator)
        {
            return AzureAcsShow(configurator(new AzureAcsShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAcsShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureAcsShow(CombinatorialConfigure<AzureAcsShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAcsShow, AzureAcsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAcsWait(AzureAcsWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAcsWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureAcsWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureAcsWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAcsWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureAcsWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureAcsWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureAcsWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureAcsWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureAcsWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAcsWait(Configure<AzureAcsWaitSettings> configurator)
        {
            return AzureAcsWait(configurator(new AzureAcsWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureAcsWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureAcsWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAcsWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureAcsWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureAcsWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureAcsWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureAcsWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureAcsWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAcsWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureAcsWait(CombinatorialConfigure<AzureAcsWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAcsWait, AzureAcsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAcsDcosBrowse(AzureAcsDcosBrowseSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAcsDcosBrowseSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsDcosBrowseSettings.Debug"/></li>
        ///     <li><c>--disable-browser</c> via <see cref="AzureAcsDcosBrowseSettings.DisableBrowser"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsDcosBrowseSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsDcosBrowseSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsDcosBrowseSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsDcosBrowseSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsDcosBrowseSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-key-file</c> via <see cref="AzureAcsDcosBrowseSettings.SshKeyFile"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsDcosBrowseSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsDcosBrowseSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAcsDcosBrowse(Configure<AzureAcsDcosBrowseSettings> configurator)
        {
            return AzureAcsDcosBrowse(configurator(new AzureAcsDcosBrowseSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsDcosBrowseSettings.Debug"/></li>
        ///     <li><c>--disable-browser</c> via <see cref="AzureAcsDcosBrowseSettings.DisableBrowser"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsDcosBrowseSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsDcosBrowseSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsDcosBrowseSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsDcosBrowseSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsDcosBrowseSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-key-file</c> via <see cref="AzureAcsDcosBrowseSettings.SshKeyFile"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsDcosBrowseSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsDcosBrowseSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAcsDcosBrowseSettings Settings, IReadOnlyCollection<Output> Output)> AzureAcsDcosBrowse(CombinatorialConfigure<AzureAcsDcosBrowseSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAcsDcosBrowse, AzureAcsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAcsDcosInstallCli(AzureAcsDcosInstallCliSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAcsDcosInstallCliSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--client-version</c> via <see cref="AzureAcsDcosInstallCliSettings.ClientVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAcsDcosInstallCliSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsDcosInstallCliSettings.Help"/></li>
        ///     <li><c>--install-location</c> via <see cref="AzureAcsDcosInstallCliSettings.InstallLocation"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsDcosInstallCliSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsDcosInstallCliSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsDcosInstallCliSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsDcosInstallCliSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAcsDcosInstallCli(Configure<AzureAcsDcosInstallCliSettings> configurator)
        {
            return AzureAcsDcosInstallCli(configurator(new AzureAcsDcosInstallCliSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--client-version</c> via <see cref="AzureAcsDcosInstallCliSettings.ClientVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAcsDcosInstallCliSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsDcosInstallCliSettings.Help"/></li>
        ///     <li><c>--install-location</c> via <see cref="AzureAcsDcosInstallCliSettings.InstallLocation"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsDcosInstallCliSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsDcosInstallCliSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsDcosInstallCliSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsDcosInstallCliSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAcsDcosInstallCliSettings Settings, IReadOnlyCollection<Output> Output)> AzureAcsDcosInstallCli(CombinatorialConfigure<AzureAcsDcosInstallCliSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAcsDcosInstallCli, AzureAcsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAcsKubernetesBrowse(AzureAcsKubernetesBrowseSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAcsKubernetesBrowseSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsKubernetesBrowseSettings.Debug"/></li>
        ///     <li><c>--disable-browser</c> via <see cref="AzureAcsKubernetesBrowseSettings.DisableBrowser"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsKubernetesBrowseSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsKubernetesBrowseSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsKubernetesBrowseSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsKubernetesBrowseSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsKubernetesBrowseSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-key-file</c> via <see cref="AzureAcsKubernetesBrowseSettings.SshKeyFile"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsKubernetesBrowseSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsKubernetesBrowseSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAcsKubernetesBrowse(Configure<AzureAcsKubernetesBrowseSettings> configurator)
        {
            return AzureAcsKubernetesBrowse(configurator(new AzureAcsKubernetesBrowseSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsKubernetesBrowseSettings.Debug"/></li>
        ///     <li><c>--disable-browser</c> via <see cref="AzureAcsKubernetesBrowseSettings.DisableBrowser"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsKubernetesBrowseSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsKubernetesBrowseSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsKubernetesBrowseSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsKubernetesBrowseSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsKubernetesBrowseSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-key-file</c> via <see cref="AzureAcsKubernetesBrowseSettings.SshKeyFile"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsKubernetesBrowseSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsKubernetesBrowseSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAcsKubernetesBrowseSettings Settings, IReadOnlyCollection<Output> Output)> AzureAcsKubernetesBrowse(CombinatorialConfigure<AzureAcsKubernetesBrowseSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAcsKubernetesBrowse, AzureAcsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAcsKubernetesGetCredentials(AzureAcsKubernetesGetCredentialsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAcsKubernetesGetCredentialsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.Debug"/></li>
        ///     <li><c>--file</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.File"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.Output"/></li>
        ///     <li><c>--overwrite-existing</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.OverwriteExisting"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-key-file</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.SshKeyFile"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAcsKubernetesGetCredentials(Configure<AzureAcsKubernetesGetCredentialsSettings> configurator)
        {
            return AzureAcsKubernetesGetCredentials(configurator(new AzureAcsKubernetesGetCredentialsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.Debug"/></li>
        ///     <li><c>--file</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.File"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.Output"/></li>
        ///     <li><c>--overwrite-existing</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.OverwriteExisting"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.ResourceGroup"/></li>
        ///     <li><c>--ssh-key-file</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.SshKeyFile"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsKubernetesGetCredentialsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAcsKubernetesGetCredentialsSettings Settings, IReadOnlyCollection<Output> Output)> AzureAcsKubernetesGetCredentials(CombinatorialConfigure<AzureAcsKubernetesGetCredentialsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAcsKubernetesGetCredentials, AzureAcsLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAcsKubernetesInstallCli(AzureAcsKubernetesInstallCliSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAcsKubernetesInstallCliSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--client-version</c> via <see cref="AzureAcsKubernetesInstallCliSettings.ClientVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAcsKubernetesInstallCliSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsKubernetesInstallCliSettings.Help"/></li>
        ///     <li><c>--install-location</c> via <see cref="AzureAcsKubernetesInstallCliSettings.InstallLocation"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsKubernetesInstallCliSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsKubernetesInstallCliSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsKubernetesInstallCliSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsKubernetesInstallCliSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAcsKubernetesInstallCli(Configure<AzureAcsKubernetesInstallCliSettings> configurator)
        {
            return AzureAcsKubernetesInstallCli(configurator(new AzureAcsKubernetesInstallCliSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Container Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/acs?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--client-version</c> via <see cref="AzureAcsKubernetesInstallCliSettings.ClientVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAcsKubernetesInstallCliSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAcsKubernetesInstallCliSettings.Help"/></li>
        ///     <li><c>--install-location</c> via <see cref="AzureAcsKubernetesInstallCliSettings.InstallLocation"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAcsKubernetesInstallCliSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAcsKubernetesInstallCliSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAcsKubernetesInstallCliSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAcsKubernetesInstallCliSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAcsKubernetesInstallCliSettings Settings, IReadOnlyCollection<Output> Output)> AzureAcsKubernetesInstallCli(CombinatorialConfigure<AzureAcsKubernetesInstallCliSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAcsKubernetesInstallCli, AzureAcsLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureAcsBrowseSettings
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsBrowseSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAcs executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        public override Action<OutputType, string> CustomLogger => AzureAcsTasks.AzureAcsLogger;
        /// <summary>
        ///   Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Do not open browser after opening a proxy to the cluster web user interface.
        /// </summary>
        public virtual string DisableBrowser { get; internal set; }
        /// <summary>
        ///   If set a path to an SSH key to use, only applies to DCOS.
        /// </summary>
        public virtual string SshKeyFile { get; internal set; }
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
              .Add("acs browse")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--disable-browser {value}", DisableBrowser)
              .Add("--ssh-key-file {value}", SshKeyFile)
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
    #region AzureAcsCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAcs executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        public override Action<OutputType, string> CustomLogger => AzureAcsTasks.AzureAcsLogger;
        /// <summary>
        ///   Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The adminstration password for Windows nodes. Only available if --windows=true.
        /// </summary>
        public virtual string AdminPassword { get; internal set; }
        /// <summary>
        ///   User name for the Linux Virtual Machines.
        /// </summary>
        public virtual string AdminUsername { get; internal set; }
        /// <summary>
        ///   Set the default number of agents for the agent pools.
        /// </summary>
        public virtual string AgentCount { get; internal set; }
        /// <summary>
        ///   Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default disk size for agent pools vms. Unit in GB. Default: corresponding vmsize disk size.
        /// </summary>
        public virtual string AgentOsdiskSize { get; internal set; }
        /// <summary>
        ///   Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default ports exposed on the agent pools. Only usable for non-Kubernetes. Default: 8080,4000,80.
        /// </summary>
        public virtual string AgentPorts { get; internal set; }
        /// <summary>
        ///   Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The file or dictionary representation of the agent profiles. Note it will override any agent settings once set.
        /// </summary>
        public virtual string AgentProfiles { get; internal set; }
        /// <summary>
        ///   Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set default storage profile for agent pools. Default: varies based on Orchestrator.
        /// </summary>
        public virtual AcsCreateAgentStorageProfile AgentStorageProfile { get; internal set; }
        /// <summary>
        ///   Set the default size for agent pools vms.
        /// </summary>
        public virtual string AgentVmSize { get; internal set; }
        /// <summary>
        ///   Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default custom vnet subnet id for agent pools. Note agent need to used the same vnet if master set. Default: "".
        /// </summary>
        public virtual string AgentVnetSubnetId { get; internal set; }
        /// <summary>
        ///   Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Use API version of ACS to perform az acs operations. Available options: 2017-01-31, 2017-07-01. Default: the latest version for the location.
        /// </summary>
        public virtual string ApiVersion { get; internal set; }
        /// <summary>
        ///   Secret associated with the service principal. This argument is required if `--service-principal` is specified.
        /// </summary>
        public virtual string ClientSecret { get; internal set; }
        /// <summary>
        ///   Sets the Domain name prefix for the cluster. The concatenation of the domain name and the regionalized DNS zone make up the fully qualified domain name associated with the public IP address.
        /// </summary>
        public virtual string DnsPrefix { get; internal set; }
        /// <summary>
        ///   Generate SSH public and private key files if missing.
        /// </summary>
        public virtual string GenerateSshKeys { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The number of masters for the cluster.
        /// </summary>
        public virtual string MasterCount { get; internal set; }
        /// <summary>
        ///   Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The first consecutive ip used to specify static ip block.
        /// </summary>
        public virtual string MasterFirstConsecutiveStaticIp { get; internal set; }
        /// <summary>
        ///   Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The disk size for master pool vms. Unit in GB. Default: corresponding vmsize disk size.
        /// </summary>
        public virtual string MasterOsdiskSize { get; internal set; }
        /// <summary>
        ///   Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The file or dictionary representation of the master profile. Note it will override any master settings once set.
        /// </summary>
        public virtual string MasterProfile { get; internal set; }
        /// <summary>
        ///   Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Default: varies based on Orchestrator.
        /// </summary>
        public virtual AcsCreateAgentStorageProfile MasterStorageProfile { get; internal set; }
        /// <summary>
        ///   Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2.
        /// </summary>
        public virtual string MasterVmSize { get; internal set; }
        /// <summary>
        ///   Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The custom vnet subnet id. Note agent need to used the same vnet if master set. Default: "".
        /// </summary>
        public virtual string MasterVnetSubnetId { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   The type of orchestrator used to manage the applications on the cluster.
        /// </summary>
        public virtual AcsCreateOrchestratorType OrchestratorType { get; internal set; }
        /// <summary>
        ///   Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Use Orchestrator Version to specify the semantic version for your choice of orchestrator.
        /// </summary>
        public virtual string OrchestratorVersion { get; internal set; }
        /// <summary>
        ///   Service principal used for authentication to Azure APIs.
        /// </summary>
        public virtual bool? ServicePrincipal { get; internal set; }
        /// <summary>
        ///   Configure all linux machines with the SSH RSA public key string.  Your key should include three parts, for example 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm.
        /// </summary>
        public virtual string SshKeyValue { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   Generate and validate the ARM template without creating any resources.
        /// </summary>
        public virtual string Validate { get; internal set; }
        /// <summary>
        ///   If true, set the default osType of agent pools to be Windows.
        /// </summary>
        public virtual bool? Windows { get; internal set; }
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
              .Add("acs create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--admin-password {value}", AdminPassword, secret: true)
              .Add("--admin-username {value}", AdminUsername)
              .Add("--agent-count {value}", AgentCount)
              .Add("--agent-osdisk-size {value}", AgentOsdiskSize)
              .Add("--agent-ports {value}", AgentPorts)
              .Add("--agent-profiles {value}", AgentProfiles)
              .Add("--agent-storage-profile {value}", AgentStorageProfile)
              .Add("--agent-vm-size {value}", AgentVmSize)
              .Add("--agent-vnet-subnet-id {value}", AgentVnetSubnetId)
              .Add("--api-version {value}", ApiVersion)
              .Add("--client-secret {value}", ClientSecret, secret: true)
              .Add("--dns-prefix {value}", DnsPrefix)
              .Add("--generate-ssh-keys {value}", GenerateSshKeys)
              .Add("--location {value}", Location)
              .Add("--master-count {value}", MasterCount)
              .Add("--master-first-consecutive-static-ip {value}", MasterFirstConsecutiveStaticIp)
              .Add("--master-osdisk-size {value}", MasterOsdiskSize)
              .Add("--master-profile {value}", MasterProfile)
              .Add("--master-storage-profile {value}", MasterStorageProfile)
              .Add("--master-vm-size {value}", MasterVmSize)
              .Add("--master-vnet-subnet-id {value}", MasterVnetSubnetId)
              .Add("--no-wait", NoWait)
              .Add("--orchestrator-type {value}", OrchestratorType)
              .Add("--orchestrator-version {value}", OrchestratorVersion)
              .Add("--service-principal", ServicePrincipal)
              .Add("--ssh-key-value {value}", SshKeyValue)
              .Add("--tags {value}", Tags)
              .Add("--validate {value}", Validate)
              .Add("--windows", Windows)
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
    #region AzureAcsDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAcs executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        public override Action<OutputType, string> CustomLogger => AzureAcsTasks.AzureAcsLogger;
        /// <summary>
        ///   Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.
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
              .Add("acs delete")
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
    #region AzureAcsListSettings
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAcs executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        public override Action<OutputType, string> CustomLogger => AzureAcsTasks.AzureAcsLogger;
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
              .Add("acs list")
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
    #region AzureAcsListLocationsSettings
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsListLocationsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAcs executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        public override Action<OutputType, string> CustomLogger => AzureAcsTasks.AzureAcsLogger;
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
              .Add("acs list-locations")
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
    #region AzureAcsScaleSettings
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsScaleSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAcs executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        public override Action<OutputType, string> CustomLogger => AzureAcsTasks.AzureAcsLogger;
        /// <summary>
        ///   Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The number of agents for the container service.
        /// </summary>
        public virtual string NewAgentCount { get; internal set; }
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
              .Add("acs scale")
              .Add("--name {value}", Name)
              .Add("--new-agent-count {value}", NewAgentCount)
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
    #region AzureAcsShowSettings
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAcs executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        public override Action<OutputType, string> CustomLogger => AzureAcsTasks.AzureAcsLogger;
        /// <summary>
        ///   Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.
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
              .Add("acs show")
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
    #region AzureAcsWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAcs executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        public override Action<OutputType, string> CustomLogger => AzureAcsTasks.AzureAcsLogger;
        /// <summary>
        ///   Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.
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
              .Add("acs wait")
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
    #region AzureAcsDcosBrowseSettings
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsDcosBrowseSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAcs executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        public override Action<OutputType, string> CustomLogger => AzureAcsTasks.AzureAcsLogger;
        /// <summary>
        ///   Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Do not open browser after opening a proxy to the cluster web user interface.
        /// </summary>
        public virtual string DisableBrowser { get; internal set; }
        /// <summary>
        ///   Path to an SSH key file to use.
        /// </summary>
        public virtual string SshKeyFile { get; internal set; }
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
              .Add("acs dcos browse")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--disable-browser {value}", DisableBrowser)
              .Add("--ssh-key-file {value}", SshKeyFile)
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
    #region AzureAcsDcosInstallCliSettings
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsDcosInstallCliSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAcs executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        public override Action<OutputType, string> CustomLogger => AzureAcsTasks.AzureAcsLogger;
        /// <summary>
        ///   Version of the client to install.
        /// </summary>
        public virtual string ClientVersion { get; internal set; }
        /// <summary>
        ///   Path at which to install DC/OS.
        /// </summary>
        public virtual string InstallLocation { get; internal set; }
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
              .Add("acs dcos install-cli")
              .Add("--client-version {value}", ClientVersion)
              .Add("--install-location {value}", InstallLocation)
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
    #region AzureAcsKubernetesBrowseSettings
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsKubernetesBrowseSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAcs executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        public override Action<OutputType, string> CustomLogger => AzureAcsTasks.AzureAcsLogger;
        /// <summary>
        ///   Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Do not open browser after opening a proxy to the cluster web user interface.
        /// </summary>
        public virtual string DisableBrowser { get; internal set; }
        /// <summary>
        ///   Path to an SSH key file to use.
        /// </summary>
        public virtual string SshKeyFile { get; internal set; }
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
              .Add("acs kubernetes browse")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--disable-browser {value}", DisableBrowser)
              .Add("--ssh-key-file {value}", SshKeyFile)
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
    #region AzureAcsKubernetesGetCredentialsSettings
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsKubernetesGetCredentialsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAcs executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        public override Action<OutputType, string> CustomLogger => AzureAcsTasks.AzureAcsLogger;
        /// <summary>
        ///   Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Where to install the kubectl config file.
        /// </summary>
        public virtual string File { get; internal set; }
        /// <summary>
        ///   If specified, overwrite any existing credentials.
        /// </summary>
        public virtual string OverwriteExisting { get; internal set; }
        /// <summary>
        ///   Path to an SSH key file to use.
        /// </summary>
        public virtual string SshKeyFile { get; internal set; }
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
              .Add("acs kubernetes get-credentials")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--file {value}", File)
              .Add("--overwrite-existing {value}", OverwriteExisting)
              .Add("--ssh-key-file {value}", SshKeyFile)
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
    #region AzureAcsKubernetesInstallCliSettings
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAcsKubernetesInstallCliSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAcs executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAcsTasks.AzureAcsPath;
        public override Action<OutputType, string> CustomLogger => AzureAcsTasks.AzureAcsLogger;
        /// <summary>
        ///   Version of the client to install.
        /// </summary>
        public virtual string ClientVersion { get; internal set; }
        /// <summary>
        ///   Path at which to install DC/OS.
        /// </summary>
        public virtual string InstallLocation { get; internal set; }
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
              .Add("acs kubernetes install-cli")
              .Add("--client-version {value}", ClientVersion)
              .Add("--install-location {value}", InstallLocation)
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
    #region AzureAcsBrowseSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsBrowseSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsBrowseSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings SetName(this AzureAcsBrowseSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsBrowseSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetName(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsBrowseSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings SetResourceGroup(this AzureAcsBrowseSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsBrowseSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetResourceGroup(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region DisableBrowser
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsBrowseSettings.DisableBrowser"/></em></p>
        ///   <p>Do not open browser after opening a proxy to the cluster web user interface.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings SetDisableBrowser(this AzureAcsBrowseSettings toolSettings, string disableBrowser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = disableBrowser;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsBrowseSettings.DisableBrowser"/></em></p>
        ///   <p>Do not open browser after opening a proxy to the cluster web user interface.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetDisableBrowser(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = null;
            return toolSettings;
        }
        #endregion
        #region SshKeyFile
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsBrowseSettings.SshKeyFile"/></em></p>
        ///   <p>If set a path to an SSH key to use, only applies to DCOS.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings SetSshKeyFile(this AzureAcsBrowseSettings toolSettings, string sshKeyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = sshKeyFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsBrowseSettings.SshKeyFile"/></em></p>
        ///   <p>If set a path to an SSH key to use, only applies to DCOS.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetSshKeyFile(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsBrowseSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings SetSubscription(this AzureAcsBrowseSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsBrowseSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetSubscription(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsBrowseSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings SetDebug(this AzureAcsBrowseSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsBrowseSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetDebug(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsBrowseSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings SetHelp(this AzureAcsBrowseSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsBrowseSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetHelp(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsBrowseSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings SetOutput(this AzureAcsBrowseSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsBrowseSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetOutput(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsBrowseSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings SetQuery(this AzureAcsBrowseSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsBrowseSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetQuery(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsBrowseSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings SetVerbose(this AzureAcsBrowseSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsBrowseSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsBrowseSettings ResetVerbose(this AzureAcsBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetName(this AzureAcsCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetName(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetResourceGroup(this AzureAcsCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetResourceGroup(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AdminPassword
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.AdminPassword"/></em></p>
        ///   <p>The adminstration password for Windows nodes. Only available if --windows=true.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetAdminPassword(this AzureAcsCreateSettings toolSettings, string adminPassword)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = adminPassword;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.AdminPassword"/></em></p>
        ///   <p>The adminstration password for Windows nodes. Only available if --windows=true.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAdminPassword(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminPassword = null;
            return toolSettings;
        }
        #endregion
        #region AdminUsername
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.AdminUsername"/></em></p>
        ///   <p>User name for the Linux Virtual Machines.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetAdminUsername(this AzureAcsCreateSettings toolSettings, string adminUsername)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUsername = adminUsername;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.AdminUsername"/></em></p>
        ///   <p>User name for the Linux Virtual Machines.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAdminUsername(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUsername = null;
            return toolSettings;
        }
        #endregion
        #region AgentCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.AgentCount"/></em></p>
        ///   <p>Set the default number of agents for the agent pools.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetAgentCount(this AzureAcsCreateSettings toolSettings, string agentCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentCount = agentCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.AgentCount"/></em></p>
        ///   <p>Set the default number of agents for the agent pools.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAgentCount(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentCount = null;
            return toolSettings;
        }
        #endregion
        #region AgentOsdiskSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.AgentOsdiskSize"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default disk size for agent pools vms. Unit in GB. Default: corresponding vmsize disk size.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetAgentOsdiskSize(this AzureAcsCreateSettings toolSettings, string agentOsdiskSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentOsdiskSize = agentOsdiskSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.AgentOsdiskSize"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default disk size for agent pools vms. Unit in GB. Default: corresponding vmsize disk size.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAgentOsdiskSize(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentOsdiskSize = null;
            return toolSettings;
        }
        #endregion
        #region AgentPorts
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.AgentPorts"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default ports exposed on the agent pools. Only usable for non-Kubernetes. Default: 8080,4000,80.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetAgentPorts(this AzureAcsCreateSettings toolSettings, string agentPorts)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentPorts = agentPorts;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.AgentPorts"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default ports exposed on the agent pools. Only usable for non-Kubernetes. Default: 8080,4000,80.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAgentPorts(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentPorts = null;
            return toolSettings;
        }
        #endregion
        #region AgentProfiles
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.AgentProfiles"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The file or dictionary representation of the agent profiles. Note it will override any agent settings once set.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetAgentProfiles(this AzureAcsCreateSettings toolSettings, string agentProfiles)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentProfiles = agentProfiles;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.AgentProfiles"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The file or dictionary representation of the agent profiles. Note it will override any agent settings once set.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAgentProfiles(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentProfiles = null;
            return toolSettings;
        }
        #endregion
        #region AgentStorageProfile
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.AgentStorageProfile"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set default storage profile for agent pools. Default: varies based on Orchestrator.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetAgentStorageProfile(this AzureAcsCreateSettings toolSettings, AcsCreateAgentStorageProfile agentStorageProfile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentStorageProfile = agentStorageProfile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.AgentStorageProfile"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set default storage profile for agent pools. Default: varies based on Orchestrator.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAgentStorageProfile(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentStorageProfile = null;
            return toolSettings;
        }
        #endregion
        #region AgentVmSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.AgentVmSize"/></em></p>
        ///   <p>Set the default size for agent pools vms.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetAgentVmSize(this AzureAcsCreateSettings toolSettings, string agentVmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentVmSize = agentVmSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.AgentVmSize"/></em></p>
        ///   <p>Set the default size for agent pools vms.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAgentVmSize(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentVmSize = null;
            return toolSettings;
        }
        #endregion
        #region AgentVnetSubnetId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.AgentVnetSubnetId"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default custom vnet subnet id for agent pools. Note agent need to used the same vnet if master set. Default: "".</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetAgentVnetSubnetId(this AzureAcsCreateSettings toolSettings, string agentVnetSubnetId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentVnetSubnetId = agentVnetSubnetId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.AgentVnetSubnetId"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Set the default custom vnet subnet id for agent pools. Note agent need to used the same vnet if master set. Default: "".</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetAgentVnetSubnetId(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AgentVnetSubnetId = null;
            return toolSettings;
        }
        #endregion
        #region ApiVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.ApiVersion"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Use API version of ACS to perform az acs operations. Available options: 2017-01-31, 2017-07-01. Default: the latest version for the location.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetApiVersion(this AzureAcsCreateSettings toolSettings, string apiVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = apiVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.ApiVersion"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Use API version of ACS to perform az acs operations. Available options: 2017-01-31, 2017-07-01. Default: the latest version for the location.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetApiVersion(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiVersion = null;
            return toolSettings;
        }
        #endregion
        #region ClientSecret
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.ClientSecret"/></em></p>
        ///   <p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetClientSecret(this AzureAcsCreateSettings toolSettings, string clientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = clientSecret;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.ClientSecret"/></em></p>
        ///   <p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetClientSecret(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region DnsPrefix
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.DnsPrefix"/></em></p>
        ///   <p>Sets the Domain name prefix for the cluster. The concatenation of the domain name and the regionalized DNS zone make up the fully qualified domain name associated with the public IP address.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetDnsPrefix(this AzureAcsCreateSettings toolSettings, string dnsPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsPrefix = dnsPrefix;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.DnsPrefix"/></em></p>
        ///   <p>Sets the Domain name prefix for the cluster. The concatenation of the domain name and the regionalized DNS zone make up the fully qualified domain name associated with the public IP address.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetDnsPrefix(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsPrefix = null;
            return toolSettings;
        }
        #endregion
        #region GenerateSshKeys
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.GenerateSshKeys"/></em></p>
        ///   <p>Generate SSH public and private key files if missing.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetGenerateSshKeys(this AzureAcsCreateSettings toolSettings, string generateSshKeys)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = generateSshKeys;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.GenerateSshKeys"/></em></p>
        ///   <p>Generate SSH public and private key files if missing.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetGenerateSshKeys(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetLocation(this AzureAcsCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetLocation(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region MasterCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.MasterCount"/></em></p>
        ///   <p>The number of masters for the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetMasterCount(this AzureAcsCreateSettings toolSettings, string masterCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterCount = masterCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.MasterCount"/></em></p>
        ///   <p>The number of masters for the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetMasterCount(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterCount = null;
            return toolSettings;
        }
        #endregion
        #region MasterFirstConsecutiveStaticIp
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.MasterFirstConsecutiveStaticIp"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The first consecutive ip used to specify static ip block.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetMasterFirstConsecutiveStaticIp(this AzureAcsCreateSettings toolSettings, string masterFirstConsecutiveStaticIp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterFirstConsecutiveStaticIp = masterFirstConsecutiveStaticIp;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.MasterFirstConsecutiveStaticIp"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The first consecutive ip used to specify static ip block.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetMasterFirstConsecutiveStaticIp(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterFirstConsecutiveStaticIp = null;
            return toolSettings;
        }
        #endregion
        #region MasterOsdiskSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.MasterOsdiskSize"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The disk size for master pool vms. Unit in GB. Default: corresponding vmsize disk size.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetMasterOsdiskSize(this AzureAcsCreateSettings toolSettings, string masterOsdiskSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterOsdiskSize = masterOsdiskSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.MasterOsdiskSize"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The disk size for master pool vms. Unit in GB. Default: corresponding vmsize disk size.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetMasterOsdiskSize(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterOsdiskSize = null;
            return toolSettings;
        }
        #endregion
        #region MasterProfile
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.MasterProfile"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The file or dictionary representation of the master profile. Note it will override any master settings once set.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetMasterProfile(this AzureAcsCreateSettings toolSettings, string masterProfile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterProfile = masterProfile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.MasterProfile"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The file or dictionary representation of the master profile. Note it will override any master settings once set.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetMasterProfile(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterProfile = null;
            return toolSettings;
        }
        #endregion
        #region MasterStorageProfile
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.MasterStorageProfile"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Default: varies based on Orchestrator.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetMasterStorageProfile(this AzureAcsCreateSettings toolSettings, AcsCreateAgentStorageProfile masterStorageProfile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterStorageProfile = masterStorageProfile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.MasterStorageProfile"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Default: varies based on Orchestrator.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetMasterStorageProfile(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterStorageProfile = null;
            return toolSettings;
        }
        #endregion
        #region MasterVmSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.MasterVmSize"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetMasterVmSize(this AzureAcsCreateSettings toolSettings, string masterVmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterVmSize = masterVmSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.MasterVmSize"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetMasterVmSize(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterVmSize = null;
            return toolSettings;
        }
        #endregion
        #region MasterVnetSubnetId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.MasterVnetSubnetId"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The custom vnet subnet id. Note agent need to used the same vnet if master set. Default: "".</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetMasterVnetSubnetId(this AzureAcsCreateSettings toolSettings, string masterVnetSubnetId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterVnetSubnetId = masterVnetSubnetId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.MasterVnetSubnetId"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. The custom vnet subnet id. Note agent need to used the same vnet if master set. Default: "".</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetMasterVnetSubnetId(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MasterVnetSubnetId = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetNoWait(this AzureAcsCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetNoWait(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAcsCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings EnableNoWait(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAcsCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings DisableNoWait(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAcsCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ToggleNoWait(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region OrchestratorType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.OrchestratorType"/></em></p>
        ///   <p>The type of orchestrator used to manage the applications on the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetOrchestratorType(this AzureAcsCreateSettings toolSettings, AcsCreateOrchestratorType orchestratorType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrchestratorType = orchestratorType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.OrchestratorType"/></em></p>
        ///   <p>The type of orchestrator used to manage the applications on the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetOrchestratorType(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrchestratorType = null;
            return toolSettings;
        }
        #endregion
        #region OrchestratorVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.OrchestratorVersion"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Use Orchestrator Version to specify the semantic version for your choice of orchestrator.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetOrchestratorVersion(this AzureAcsCreateSettings toolSettings, string orchestratorVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrchestratorVersion = orchestratorVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.OrchestratorVersion"/></em></p>
        ///   <p>Feature in preview, only in canadacentral, canadaeast, centralindia, koreasouth, koreacentral, southindia, uksouth, ukwest, westcentralus, westindia, westus2. Use Orchestrator Version to specify the semantic version for your choice of orchestrator.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetOrchestratorVersion(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OrchestratorVersion = null;
            return toolSettings;
        }
        #endregion
        #region ServicePrincipal
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetServicePrincipal(this AzureAcsCreateSettings toolSettings, bool? servicePrincipal)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = servicePrincipal;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetServicePrincipal(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAcsCreateSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings EnableServicePrincipal(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAcsCreateSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings DisableServicePrincipal(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAcsCreateSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ToggleServicePrincipal(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = !toolSettings.ServicePrincipal;
            return toolSettings;
        }
        #endregion
        #region SshKeyValue
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.SshKeyValue"/></em></p>
        ///   <p>Configure all linux machines with the SSH RSA public key string.  Your key should include three parts, for example 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetSshKeyValue(this AzureAcsCreateSettings toolSettings, string sshKeyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyValue = sshKeyValue;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.SshKeyValue"/></em></p>
        ///   <p>Configure all linux machines with the SSH RSA public key string.  Your key should include three parts, for example 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetSshKeyValue(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyValue = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetTags(this AzureAcsCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetTags(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Validate
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.Validate"/></em></p>
        ///   <p>Generate and validate the ARM template without creating any resources.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetValidate(this AzureAcsCreateSettings toolSettings, string validate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Validate = validate;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.Validate"/></em></p>
        ///   <p>Generate and validate the ARM template without creating any resources.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetValidate(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Validate = null;
            return toolSettings;
        }
        #endregion
        #region Windows
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.Windows"/></em></p>
        ///   <p>If true, set the default osType of agent pools to be Windows.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetWindows(this AzureAcsCreateSettings toolSettings, bool? windows)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Windows = windows;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.Windows"/></em></p>
        ///   <p>If true, set the default osType of agent pools to be Windows.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetWindows(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Windows = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAcsCreateSettings.Windows"/></em></p>
        ///   <p>If true, set the default osType of agent pools to be Windows.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings EnableWindows(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Windows = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAcsCreateSettings.Windows"/></em></p>
        ///   <p>If true, set the default osType of agent pools to be Windows.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings DisableWindows(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Windows = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAcsCreateSettings.Windows"/></em></p>
        ///   <p>If true, set the default osType of agent pools to be Windows.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ToggleWindows(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Windows = !toolSettings.Windows;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetSubscription(this AzureAcsCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetSubscription(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetDebug(this AzureAcsCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetDebug(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetHelp(this AzureAcsCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetHelp(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetOutput(this AzureAcsCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetOutput(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetQuery(this AzureAcsCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetQuery(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings SetVerbose(this AzureAcsCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsCreateSettings ResetVerbose(this AzureAcsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDeleteSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings SetName(this AzureAcsDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDeleteSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetName(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings SetResourceGroup(this AzureAcsDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetResourceGroup(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings SetYes(this AzureAcsDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetYes(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings SetSubscription(this AzureAcsDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetSubscription(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings SetDebug(this AzureAcsDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetDebug(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings SetHelp(this AzureAcsDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetHelp(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings SetOutput(this AzureAcsDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetOutput(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings SetQuery(this AzureAcsDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetQuery(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings SetVerbose(this AzureAcsDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDeleteSettings ResetVerbose(this AzureAcsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListSettings SetResourceGroup(this AzureAcsListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListSettings ResetResourceGroup(this AzureAcsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListSettings SetSubscription(this AzureAcsListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListSettings ResetSubscription(this AzureAcsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListSettings SetDebug(this AzureAcsListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListSettings ResetDebug(this AzureAcsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListSettings SetHelp(this AzureAcsListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListSettings ResetHelp(this AzureAcsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListSettings SetOutput(this AzureAcsListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListSettings ResetOutput(this AzureAcsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListSettings SetQuery(this AzureAcsListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListSettings ResetQuery(this AzureAcsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListSettings SetVerbose(this AzureAcsListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListSettings ResetVerbose(this AzureAcsListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsListLocationsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsListLocationsSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsListLocationsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListLocationsSettings SetSubscription(this AzureAcsListLocationsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsListLocationsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListLocationsSettings ResetSubscription(this AzureAcsListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsListLocationsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListLocationsSettings SetDebug(this AzureAcsListLocationsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsListLocationsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListLocationsSettings ResetDebug(this AzureAcsListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsListLocationsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListLocationsSettings SetHelp(this AzureAcsListLocationsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsListLocationsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListLocationsSettings ResetHelp(this AzureAcsListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsListLocationsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListLocationsSettings SetOutput(this AzureAcsListLocationsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsListLocationsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListLocationsSettings ResetOutput(this AzureAcsListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsListLocationsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListLocationsSettings SetQuery(this AzureAcsListLocationsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsListLocationsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListLocationsSettings ResetQuery(this AzureAcsListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsListLocationsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListLocationsSettings SetVerbose(this AzureAcsListLocationsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsListLocationsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsListLocationsSettings ResetVerbose(this AzureAcsListLocationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsScaleSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsScaleSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsScaleSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings SetName(this AzureAcsScaleSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsScaleSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings ResetName(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NewAgentCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsScaleSettings.NewAgentCount"/></em></p>
        ///   <p>The number of agents for the container service.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings SetNewAgentCount(this AzureAcsScaleSettings toolSettings, string newAgentCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NewAgentCount = newAgentCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsScaleSettings.NewAgentCount"/></em></p>
        ///   <p>The number of agents for the container service.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings ResetNewAgentCount(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NewAgentCount = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsScaleSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings SetResourceGroup(this AzureAcsScaleSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsScaleSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings ResetResourceGroup(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsScaleSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings SetSubscription(this AzureAcsScaleSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsScaleSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings ResetSubscription(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsScaleSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings SetDebug(this AzureAcsScaleSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsScaleSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings ResetDebug(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsScaleSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings SetHelp(this AzureAcsScaleSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsScaleSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings ResetHelp(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsScaleSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings SetOutput(this AzureAcsScaleSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsScaleSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings ResetOutput(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsScaleSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings SetQuery(this AzureAcsScaleSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsScaleSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings ResetQuery(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsScaleSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings SetVerbose(this AzureAcsScaleSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsScaleSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsScaleSettings ResetVerbose(this AzureAcsScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsShowSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings SetName(this AzureAcsShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsShowSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings ResetName(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings SetResourceGroup(this AzureAcsShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings ResetResourceGroup(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings SetSubscription(this AzureAcsShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings ResetSubscription(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings SetDebug(this AzureAcsShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings ResetDebug(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings SetHelp(this AzureAcsShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings ResetHelp(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings SetOutput(this AzureAcsShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings ResetOutput(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings SetQuery(this AzureAcsShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings ResetQuery(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings SetVerbose(this AzureAcsShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsShowSettings ResetVerbose(this AzureAcsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsWaitSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetName(this AzureAcsWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetName(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetResourceGroup(this AzureAcsWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetResourceGroup(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetCreated(this AzureAcsWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetCreated(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetCustom(this AzureAcsWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetCustom(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetDeleted(this AzureAcsWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetDeleted(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetExists(this AzureAcsWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetExists(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetInterval(this AzureAcsWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetInterval(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetTimeout(this AzureAcsWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetTimeout(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetUpdated(this AzureAcsWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetUpdated(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetSubscription(this AzureAcsWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetSubscription(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetDebug(this AzureAcsWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetDebug(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetHelp(this AzureAcsWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetHelp(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetOutput(this AzureAcsWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetOutput(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetQuery(this AzureAcsWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetQuery(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings SetVerbose(this AzureAcsWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsWaitSettings ResetVerbose(this AzureAcsWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsDcosBrowseSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsDcosBrowseSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosBrowseSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetName(this AzureAcsDcosBrowseSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosBrowseSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetName(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosBrowseSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetResourceGroup(this AzureAcsDcosBrowseSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosBrowseSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetResourceGroup(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region DisableBrowser
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosBrowseSettings.DisableBrowser"/></em></p>
        ///   <p>Do not open browser after opening a proxy to the cluster web user interface.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetDisableBrowser(this AzureAcsDcosBrowseSettings toolSettings, string disableBrowser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = disableBrowser;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosBrowseSettings.DisableBrowser"/></em></p>
        ///   <p>Do not open browser after opening a proxy to the cluster web user interface.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetDisableBrowser(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = null;
            return toolSettings;
        }
        #endregion
        #region SshKeyFile
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosBrowseSettings.SshKeyFile"/></em></p>
        ///   <p>Path to an SSH key file to use.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetSshKeyFile(this AzureAcsDcosBrowseSettings toolSettings, string sshKeyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = sshKeyFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosBrowseSettings.SshKeyFile"/></em></p>
        ///   <p>Path to an SSH key file to use.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetSshKeyFile(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosBrowseSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetSubscription(this AzureAcsDcosBrowseSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosBrowseSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetSubscription(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosBrowseSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetDebug(this AzureAcsDcosBrowseSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosBrowseSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetDebug(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosBrowseSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetHelp(this AzureAcsDcosBrowseSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosBrowseSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetHelp(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosBrowseSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetOutput(this AzureAcsDcosBrowseSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosBrowseSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetOutput(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosBrowseSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetQuery(this AzureAcsDcosBrowseSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosBrowseSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetQuery(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosBrowseSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings SetVerbose(this AzureAcsDcosBrowseSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosBrowseSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosBrowseSettings ResetVerbose(this AzureAcsDcosBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsDcosInstallCliSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsDcosInstallCliSettingsExtensions
    {
        #region ClientVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.ClientVersion"/></em></p>
        ///   <p>Version of the client to install.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetClientVersion(this AzureAcsDcosInstallCliSettings toolSettings, string clientVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientVersion = clientVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.ClientVersion"/></em></p>
        ///   <p>Version of the client to install.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetClientVersion(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientVersion = null;
            return toolSettings;
        }
        #endregion
        #region InstallLocation
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.InstallLocation"/></em></p>
        ///   <p>Path at which to install DC/OS.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetInstallLocation(this AzureAcsDcosInstallCliSettings toolSettings, string installLocation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallLocation = installLocation;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.InstallLocation"/></em></p>
        ///   <p>Path at which to install DC/OS.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetInstallLocation(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallLocation = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetSubscription(this AzureAcsDcosInstallCliSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetSubscription(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetDebug(this AzureAcsDcosInstallCliSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetDebug(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetHelp(this AzureAcsDcosInstallCliSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetHelp(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetOutput(this AzureAcsDcosInstallCliSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetOutput(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetQuery(this AzureAcsDcosInstallCliSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetQuery(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsDcosInstallCliSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings SetVerbose(this AzureAcsDcosInstallCliSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsDcosInstallCliSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsDcosInstallCliSettings ResetVerbose(this AzureAcsDcosInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsKubernetesBrowseSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsKubernetesBrowseSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetName(this AzureAcsKubernetesBrowseSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetName(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetResourceGroup(this AzureAcsKubernetesBrowseSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetResourceGroup(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region DisableBrowser
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.DisableBrowser"/></em></p>
        ///   <p>Do not open browser after opening a proxy to the cluster web user interface.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetDisableBrowser(this AzureAcsKubernetesBrowseSettings toolSettings, string disableBrowser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = disableBrowser;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.DisableBrowser"/></em></p>
        ///   <p>Do not open browser after opening a proxy to the cluster web user interface.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetDisableBrowser(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = null;
            return toolSettings;
        }
        #endregion
        #region SshKeyFile
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.SshKeyFile"/></em></p>
        ///   <p>Path to an SSH key file to use.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetSshKeyFile(this AzureAcsKubernetesBrowseSettings toolSettings, string sshKeyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = sshKeyFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.SshKeyFile"/></em></p>
        ///   <p>Path to an SSH key file to use.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetSshKeyFile(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetSubscription(this AzureAcsKubernetesBrowseSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetSubscription(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetDebug(this AzureAcsKubernetesBrowseSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetDebug(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetHelp(this AzureAcsKubernetesBrowseSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetHelp(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetOutput(this AzureAcsKubernetesBrowseSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetOutput(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetQuery(this AzureAcsKubernetesBrowseSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetQuery(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesBrowseSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings SetVerbose(this AzureAcsKubernetesBrowseSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesBrowseSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesBrowseSettings ResetVerbose(this AzureAcsKubernetesBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsKubernetesGetCredentialsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsKubernetesGetCredentialsSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetName(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.Name"/></em></p>
        ///   <p>Name of the container service. You can configure the default using `az configure --defaults acs=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetName(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetResourceGroup(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetResourceGroup(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region File
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.File"/></em></p>
        ///   <p>Where to install the kubectl config file.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetFile(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.File"/></em></p>
        ///   <p>Where to install the kubectl config file.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetFile(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region OverwriteExisting
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.OverwriteExisting"/></em></p>
        ///   <p>If specified, overwrite any existing credentials.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetOverwriteExisting(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string overwriteExisting)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OverwriteExisting = overwriteExisting;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.OverwriteExisting"/></em></p>
        ///   <p>If specified, overwrite any existing credentials.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetOverwriteExisting(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OverwriteExisting = null;
            return toolSettings;
        }
        #endregion
        #region SshKeyFile
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.SshKeyFile"/></em></p>
        ///   <p>Path to an SSH key file to use.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetSshKeyFile(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string sshKeyFile)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = sshKeyFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.SshKeyFile"/></em></p>
        ///   <p>Path to an SSH key file to use.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetSshKeyFile(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyFile = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetSubscription(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetSubscription(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetDebug(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetDebug(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetHelp(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetHelp(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetOutput(this AzureAcsKubernetesGetCredentialsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetOutput(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetQuery(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetQuery(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesGetCredentialsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings SetVerbose(this AzureAcsKubernetesGetCredentialsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesGetCredentialsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesGetCredentialsSettings ResetVerbose(this AzureAcsKubernetesGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAcsKubernetesInstallCliSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAcsKubernetesInstallCliSettingsExtensions
    {
        #region ClientVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.ClientVersion"/></em></p>
        ///   <p>Version of the client to install.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetClientVersion(this AzureAcsKubernetesInstallCliSettings toolSettings, string clientVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientVersion = clientVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.ClientVersion"/></em></p>
        ///   <p>Version of the client to install.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetClientVersion(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientVersion = null;
            return toolSettings;
        }
        #endregion
        #region InstallLocation
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.InstallLocation"/></em></p>
        ///   <p>Path at which to install DC/OS.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetInstallLocation(this AzureAcsKubernetesInstallCliSettings toolSettings, string installLocation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallLocation = installLocation;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.InstallLocation"/></em></p>
        ///   <p>Path at which to install DC/OS.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetInstallLocation(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallLocation = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetSubscription(this AzureAcsKubernetesInstallCliSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetSubscription(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetDebug(this AzureAcsKubernetesInstallCliSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetDebug(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetHelp(this AzureAcsKubernetesInstallCliSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetHelp(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetOutput(this AzureAcsKubernetesInstallCliSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetOutput(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetQuery(this AzureAcsKubernetesInstallCliSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetQuery(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAcsKubernetesInstallCliSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings SetVerbose(this AzureAcsKubernetesInstallCliSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAcsKubernetesInstallCliSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAcsKubernetesInstallCliSettings ResetVerbose(this AzureAcsKubernetesInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AcsCreateAgentStorageProfile
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AcsCreateAgentStorageProfile>))]
    public partial class AcsCreateAgentStorageProfile : Enumeration
    {
        public static AcsCreateAgentStorageProfile manageddisks = new AcsCreateAgentStorageProfile { Value = "manageddisks" };
        public static AcsCreateAgentStorageProfile storageaccount = new AcsCreateAgentStorageProfile { Value = "storageaccount" };
    }
    #endregion
    #region AcsCreateOrchestratorType
    /// <summary>
    ///   Used within <see cref="AzureAcsTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AcsCreateOrchestratorType>))]
    public partial class AcsCreateOrchestratorType : Enumeration
    {
        public static AcsCreateOrchestratorType custom = new AcsCreateOrchestratorType { Value = "custom" };
        public static AcsCreateOrchestratorType dcos = new AcsCreateOrchestratorType { Value = "dcos" };
        public static AcsCreateOrchestratorType dockerce = new AcsCreateOrchestratorType { Value = "dockerce" };
        public static AcsCreateOrchestratorType kubernetes = new AcsCreateOrchestratorType { Value = "kubernetes" };
        public static AcsCreateOrchestratorType swarm = new AcsCreateOrchestratorType { Value = "swarm" };
    }
    #endregion
}
