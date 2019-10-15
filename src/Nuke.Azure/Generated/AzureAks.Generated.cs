// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureAks.json
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
    public static partial class AzureAksTasks
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public static string AzureAksPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREAKS_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureAksLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Kubernetes Services.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAks(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureAksPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureAksLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksBrowse(AzureAksBrowseSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksBrowseSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksBrowseSettings.Debug"/></li>
        ///     <li><c>--disable-browser</c> via <see cref="AzureAksBrowseSettings.DisableBrowser"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksBrowseSettings.Help"/></li>
        ///     <li><c>--listen-address</c> via <see cref="AzureAksBrowseSettings.ListenAddress"/></li>
        ///     <li><c>--listen-port</c> via <see cref="AzureAksBrowseSettings.ListenPort"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksBrowseSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksBrowseSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksBrowseSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksBrowseSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksBrowseSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksBrowseSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksBrowse(Configure<AzureAksBrowseSettings> configurator)
        {
            return AzureAksBrowse(configurator(new AzureAksBrowseSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksBrowseSettings.Debug"/></li>
        ///     <li><c>--disable-browser</c> via <see cref="AzureAksBrowseSettings.DisableBrowser"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksBrowseSettings.Help"/></li>
        ///     <li><c>--listen-address</c> via <see cref="AzureAksBrowseSettings.ListenAddress"/></li>
        ///     <li><c>--listen-port</c> via <see cref="AzureAksBrowseSettings.ListenPort"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksBrowseSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksBrowseSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksBrowseSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksBrowseSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksBrowseSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksBrowseSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksBrowseSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksBrowse(CombinatorialConfigure<AzureAksBrowseSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksBrowse, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksCreate(AzureAksCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--aad-client-app-id</c> via <see cref="AzureAksCreateSettings.AadClientAppId"/></li>
        ///     <li><c>--aad-server-app-id</c> via <see cref="AzureAksCreateSettings.AadServerAppId"/></li>
        ///     <li><c>--aad-server-app-secret</c> via <see cref="AzureAksCreateSettings.AadServerAppSecret"/></li>
        ///     <li><c>--aad-tenant-id</c> via <see cref="AzureAksCreateSettings.AadTenantId"/></li>
        ///     <li><c>--admin-username</c> via <see cref="AzureAksCreateSettings.AdminUsername"/></li>
        ///     <li><c>--attach-acr</c> via <see cref="AzureAksCreateSettings.AttachAcr"/></li>
        ///     <li><c>--client-secret</c> via <see cref="AzureAksCreateSettings.ClientSecret"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksCreateSettings.Debug"/></li>
        ///     <li><c>--disable-rbac</c> via <see cref="AzureAksCreateSettings.DisableRbac"/></li>
        ///     <li><c>--dns-name-prefix</c> via <see cref="AzureAksCreateSettings.DnsNamePrefix"/></li>
        ///     <li><c>--dns-service-ip</c> via <see cref="AzureAksCreateSettings.DnsServiceIp"/></li>
        ///     <li><c>--docker-bridge-address</c> via <see cref="AzureAksCreateSettings.DockerBridgeAddress"/></li>
        ///     <li><c>--enable-addons</c> via <see cref="AzureAksCreateSettings.EnableAddons"/></li>
        ///     <li><c>--enable-rbac</c> via <see cref="AzureAksCreateSettings.EnableRbac"/></li>
        ///     <li><c>--generate-ssh-keys</c> via <see cref="AzureAksCreateSettings.GenerateSshKeys"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksCreateSettings.Help"/></li>
        ///     <li><c>--kubernetes-version</c> via <see cref="AzureAksCreateSettings.KubernetesVersion"/></li>
        ///     <li><c>--load-balancer-managed-outbound-ip-count</c> via <see cref="AzureAksCreateSettings.LoadBalancerManagedOutboundIpCount"/></li>
        ///     <li><c>--load-balancer-outbound-ip-prefixes</c> via <see cref="AzureAksCreateSettings.LoadBalancerOutboundIpPrefixes"/></li>
        ///     <li><c>--load-balancer-outbound-ips</c> via <see cref="AzureAksCreateSettings.LoadBalancerOutboundIps"/></li>
        ///     <li><c>--load-balancer-sku</c> via <see cref="AzureAksCreateSettings.LoadBalancerSku"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAksCreateSettings.Location"/></li>
        ///     <li><c>--max-pods</c> via <see cref="AzureAksCreateSettings.MaxPods"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksCreateSettings.Name"/></li>
        ///     <li><c>--network-plugin</c> via <see cref="AzureAksCreateSettings.NetworkPlugin"/></li>
        ///     <li><c>--network-policy</c> via <see cref="AzureAksCreateSettings.NetworkPolicy"/></li>
        ///     <li><c>--no-ssh-key</c> via <see cref="AzureAksCreateSettings.NoSshKey"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksCreateSettings.NoWait"/></li>
        ///     <li><c>--node-count</c> via <see cref="AzureAksCreateSettings.NodeCount"/></li>
        ///     <li><c>--node-osdisk-size</c> via <see cref="AzureAksCreateSettings.NodeOsdiskSize"/></li>
        ///     <li><c>--node-vm-size</c> via <see cref="AzureAksCreateSettings.NodeVmSize"/></li>
        ///     <li><c>--nodepool-name</c> via <see cref="AzureAksCreateSettings.NodepoolName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksCreateSettings.Output"/></li>
        ///     <li><c>--pod-cidr</c> via <see cref="AzureAksCreateSettings.PodCidr"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-cidr</c> via <see cref="AzureAksCreateSettings.ServiceCidr"/></li>
        ///     <li><c>--service-principal</c> via <see cref="AzureAksCreateSettings.ServicePrincipal"/></li>
        ///     <li><c>--skip-subnet-role-assignment</c> via <see cref="AzureAksCreateSettings.SkipSubnetRoleAssignment"/></li>
        ///     <li><c>--ssh-key-value</c> via <see cref="AzureAksCreateSettings.SshKeyValue"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureAksCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksCreateSettings.Verbose"/></li>
        ///     <li><c>--vm-set-type</c> via <see cref="AzureAksCreateSettings.VmSetType"/></li>
        ///     <li><c>--vnet-subnet-id</c> via <see cref="AzureAksCreateSettings.VnetSubnetId"/></li>
        ///     <li><c>--workspace-resource-id</c> via <see cref="AzureAksCreateSettings.WorkspaceResourceId"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksCreate(Configure<AzureAksCreateSettings> configurator)
        {
            return AzureAksCreate(configurator(new AzureAksCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--aad-client-app-id</c> via <see cref="AzureAksCreateSettings.AadClientAppId"/></li>
        ///     <li><c>--aad-server-app-id</c> via <see cref="AzureAksCreateSettings.AadServerAppId"/></li>
        ///     <li><c>--aad-server-app-secret</c> via <see cref="AzureAksCreateSettings.AadServerAppSecret"/></li>
        ///     <li><c>--aad-tenant-id</c> via <see cref="AzureAksCreateSettings.AadTenantId"/></li>
        ///     <li><c>--admin-username</c> via <see cref="AzureAksCreateSettings.AdminUsername"/></li>
        ///     <li><c>--attach-acr</c> via <see cref="AzureAksCreateSettings.AttachAcr"/></li>
        ///     <li><c>--client-secret</c> via <see cref="AzureAksCreateSettings.ClientSecret"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksCreateSettings.Debug"/></li>
        ///     <li><c>--disable-rbac</c> via <see cref="AzureAksCreateSettings.DisableRbac"/></li>
        ///     <li><c>--dns-name-prefix</c> via <see cref="AzureAksCreateSettings.DnsNamePrefix"/></li>
        ///     <li><c>--dns-service-ip</c> via <see cref="AzureAksCreateSettings.DnsServiceIp"/></li>
        ///     <li><c>--docker-bridge-address</c> via <see cref="AzureAksCreateSettings.DockerBridgeAddress"/></li>
        ///     <li><c>--enable-addons</c> via <see cref="AzureAksCreateSettings.EnableAddons"/></li>
        ///     <li><c>--enable-rbac</c> via <see cref="AzureAksCreateSettings.EnableRbac"/></li>
        ///     <li><c>--generate-ssh-keys</c> via <see cref="AzureAksCreateSettings.GenerateSshKeys"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksCreateSettings.Help"/></li>
        ///     <li><c>--kubernetes-version</c> via <see cref="AzureAksCreateSettings.KubernetesVersion"/></li>
        ///     <li><c>--load-balancer-managed-outbound-ip-count</c> via <see cref="AzureAksCreateSettings.LoadBalancerManagedOutboundIpCount"/></li>
        ///     <li><c>--load-balancer-outbound-ip-prefixes</c> via <see cref="AzureAksCreateSettings.LoadBalancerOutboundIpPrefixes"/></li>
        ///     <li><c>--load-balancer-outbound-ips</c> via <see cref="AzureAksCreateSettings.LoadBalancerOutboundIps"/></li>
        ///     <li><c>--load-balancer-sku</c> via <see cref="AzureAksCreateSettings.LoadBalancerSku"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAksCreateSettings.Location"/></li>
        ///     <li><c>--max-pods</c> via <see cref="AzureAksCreateSettings.MaxPods"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksCreateSettings.Name"/></li>
        ///     <li><c>--network-plugin</c> via <see cref="AzureAksCreateSettings.NetworkPlugin"/></li>
        ///     <li><c>--network-policy</c> via <see cref="AzureAksCreateSettings.NetworkPolicy"/></li>
        ///     <li><c>--no-ssh-key</c> via <see cref="AzureAksCreateSettings.NoSshKey"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksCreateSettings.NoWait"/></li>
        ///     <li><c>--node-count</c> via <see cref="AzureAksCreateSettings.NodeCount"/></li>
        ///     <li><c>--node-osdisk-size</c> via <see cref="AzureAksCreateSettings.NodeOsdiskSize"/></li>
        ///     <li><c>--node-vm-size</c> via <see cref="AzureAksCreateSettings.NodeVmSize"/></li>
        ///     <li><c>--nodepool-name</c> via <see cref="AzureAksCreateSettings.NodepoolName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksCreateSettings.Output"/></li>
        ///     <li><c>--pod-cidr</c> via <see cref="AzureAksCreateSettings.PodCidr"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--service-cidr</c> via <see cref="AzureAksCreateSettings.ServiceCidr"/></li>
        ///     <li><c>--service-principal</c> via <see cref="AzureAksCreateSettings.ServicePrincipal"/></li>
        ///     <li><c>--skip-subnet-role-assignment</c> via <see cref="AzureAksCreateSettings.SkipSubnetRoleAssignment"/></li>
        ///     <li><c>--ssh-key-value</c> via <see cref="AzureAksCreateSettings.SshKeyValue"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureAksCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksCreateSettings.Verbose"/></li>
        ///     <li><c>--vm-set-type</c> via <see cref="AzureAksCreateSettings.VmSetType"/></li>
        ///     <li><c>--vnet-subnet-id</c> via <see cref="AzureAksCreateSettings.VnetSubnetId"/></li>
        ///     <li><c>--workspace-resource-id</c> via <see cref="AzureAksCreateSettings.WorkspaceResourceId"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksCreate(CombinatorialConfigure<AzureAksCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksCreate, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksDelete(AzureAksDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAksDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksDelete(Configure<AzureAksDeleteSettings> configurator)
        {
            return AzureAksDelete(configurator(new AzureAksDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksDeleteSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAksDeleteSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksDelete(CombinatorialConfigure<AzureAksDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksDelete, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksDisableAddons(AzureAksDisableAddonsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksDisableAddonsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--addons</c> via <see cref="AzureAksDisableAddonsSettings.Addons"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksDisableAddonsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksDisableAddonsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksDisableAddonsSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksDisableAddonsSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksDisableAddonsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksDisableAddonsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksDisableAddonsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksDisableAddonsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksDisableAddonsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksDisableAddons(Configure<AzureAksDisableAddonsSettings> configurator)
        {
            return AzureAksDisableAddons(configurator(new AzureAksDisableAddonsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--addons</c> via <see cref="AzureAksDisableAddonsSettings.Addons"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksDisableAddonsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksDisableAddonsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksDisableAddonsSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksDisableAddonsSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksDisableAddonsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksDisableAddonsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksDisableAddonsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksDisableAddonsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksDisableAddonsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksDisableAddonsSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksDisableAddons(CombinatorialConfigure<AzureAksDisableAddonsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksDisableAddons, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksEnableAddons(AzureAksEnableAddonsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksEnableAddonsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--addons</c> via <see cref="AzureAksEnableAddonsSettings.Addons"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksEnableAddonsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksEnableAddonsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksEnableAddonsSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksEnableAddonsSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksEnableAddonsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksEnableAddonsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksEnableAddonsSettings.ResourceGroup"/></li>
        ///     <li><c>--subnet-name</c> via <see cref="AzureAksEnableAddonsSettings.SubnetName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksEnableAddonsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksEnableAddonsSettings.Verbose"/></li>
        ///     <li><c>--workspace-resource-id</c> via <see cref="AzureAksEnableAddonsSettings.WorkspaceResourceId"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksEnableAddons(Configure<AzureAksEnableAddonsSettings> configurator)
        {
            return AzureAksEnableAddons(configurator(new AzureAksEnableAddonsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--addons</c> via <see cref="AzureAksEnableAddonsSettings.Addons"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksEnableAddonsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksEnableAddonsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksEnableAddonsSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksEnableAddonsSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksEnableAddonsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksEnableAddonsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksEnableAddonsSettings.ResourceGroup"/></li>
        ///     <li><c>--subnet-name</c> via <see cref="AzureAksEnableAddonsSettings.SubnetName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksEnableAddonsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksEnableAddonsSettings.Verbose"/></li>
        ///     <li><c>--workspace-resource-id</c> via <see cref="AzureAksEnableAddonsSettings.WorkspaceResourceId"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksEnableAddonsSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksEnableAddons(CombinatorialConfigure<AzureAksEnableAddonsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksEnableAddons, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksGetCredentials(AzureAksGetCredentialsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksGetCredentialsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--admin</c> via <see cref="AzureAksGetCredentialsSettings.Admin"/></li>
        ///     <li><c>--context</c> via <see cref="AzureAksGetCredentialsSettings.Context"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksGetCredentialsSettings.Debug"/></li>
        ///     <li><c>--file</c> via <see cref="AzureAksGetCredentialsSettings.File"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksGetCredentialsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksGetCredentialsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksGetCredentialsSettings.Output"/></li>
        ///     <li><c>--overwrite-existing</c> via <see cref="AzureAksGetCredentialsSettings.OverwriteExisting"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksGetCredentialsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksGetCredentialsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksGetCredentialsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksGetCredentialsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksGetCredentials(Configure<AzureAksGetCredentialsSettings> configurator)
        {
            return AzureAksGetCredentials(configurator(new AzureAksGetCredentialsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--admin</c> via <see cref="AzureAksGetCredentialsSettings.Admin"/></li>
        ///     <li><c>--context</c> via <see cref="AzureAksGetCredentialsSettings.Context"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksGetCredentialsSettings.Debug"/></li>
        ///     <li><c>--file</c> via <see cref="AzureAksGetCredentialsSettings.File"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksGetCredentialsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksGetCredentialsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksGetCredentialsSettings.Output"/></li>
        ///     <li><c>--overwrite-existing</c> via <see cref="AzureAksGetCredentialsSettings.OverwriteExisting"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksGetCredentialsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksGetCredentialsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksGetCredentialsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksGetCredentialsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksGetCredentialsSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksGetCredentials(CombinatorialConfigure<AzureAksGetCredentialsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksGetCredentials, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksGetUpgrades(AzureAksGetUpgradesSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksGetUpgradesSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksGetUpgradesSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksGetUpgradesSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksGetUpgradesSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksGetUpgradesSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksGetUpgradesSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksGetUpgradesSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksGetUpgradesSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksGetUpgradesSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksGetUpgrades(Configure<AzureAksGetUpgradesSettings> configurator)
        {
            return AzureAksGetUpgrades(configurator(new AzureAksGetUpgradesSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksGetUpgradesSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksGetUpgradesSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksGetUpgradesSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksGetUpgradesSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksGetUpgradesSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksGetUpgradesSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksGetUpgradesSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksGetUpgradesSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksGetUpgradesSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksGetUpgrades(CombinatorialConfigure<AzureAksGetUpgradesSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksGetUpgrades, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksGetVersions(AzureAksGetVersionsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksGetVersionsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksGetVersionsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksGetVersionsSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAksGetVersionsSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksGetVersionsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksGetVersionsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksGetVersionsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksGetVersionsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksGetVersions(Configure<AzureAksGetVersionsSettings> configurator)
        {
            return AzureAksGetVersions(configurator(new AzureAksGetVersionsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksGetVersionsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksGetVersionsSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAksGetVersionsSettings.Location"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksGetVersionsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksGetVersionsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksGetVersionsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksGetVersionsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksGetVersionsSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksGetVersions(CombinatorialConfigure<AzureAksGetVersionsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksGetVersions, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksInstallCli(AzureAksInstallCliSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksInstallCliSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--client-version</c> via <see cref="AzureAksInstallCliSettings.ClientVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksInstallCliSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksInstallCliSettings.Help"/></li>
        ///     <li><c>--install-location</c> via <see cref="AzureAksInstallCliSettings.InstallLocation"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksInstallCliSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksInstallCliSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksInstallCliSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksInstallCliSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksInstallCli(Configure<AzureAksInstallCliSettings> configurator)
        {
            return AzureAksInstallCli(configurator(new AzureAksInstallCliSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--client-version</c> via <see cref="AzureAksInstallCliSettings.ClientVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksInstallCliSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksInstallCliSettings.Help"/></li>
        ///     <li><c>--install-location</c> via <see cref="AzureAksInstallCliSettings.InstallLocation"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksInstallCliSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksInstallCliSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksInstallCliSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksInstallCliSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksInstallCliSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksInstallCli(CombinatorialConfigure<AzureAksInstallCliSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksInstallCli, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksInstallConnector(AzureAksInstallConnectorSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksInstallConnectorSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--aci-resource-group</c> via <see cref="AzureAksInstallConnectorSettings.AciResourceGroup"/></li>
        ///     <li><c>--chart-url</c> via <see cref="AzureAksInstallConnectorSettings.ChartUrl"/></li>
        ///     <li><c>--client-secret</c> via <see cref="AzureAksInstallConnectorSettings.ClientSecret"/></li>
        ///     <li><c>--connector-name</c> via <see cref="AzureAksInstallConnectorSettings.ConnectorName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksInstallConnectorSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksInstallConnectorSettings.Help"/></li>
        ///     <li><c>--image-tag</c> via <see cref="AzureAksInstallConnectorSettings.ImageTag"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAksInstallConnectorSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksInstallConnectorSettings.Name"/></li>
        ///     <li><c>--os-type</c> via <see cref="AzureAksInstallConnectorSettings.OsType"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksInstallConnectorSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksInstallConnectorSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksInstallConnectorSettings.ResourceGroup"/></li>
        ///     <li><c>--service-principal</c> via <see cref="AzureAksInstallConnectorSettings.ServicePrincipal"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksInstallConnectorSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksInstallConnectorSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksInstallConnector(Configure<AzureAksInstallConnectorSettings> configurator)
        {
            return AzureAksInstallConnector(configurator(new AzureAksInstallConnectorSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--aci-resource-group</c> via <see cref="AzureAksInstallConnectorSettings.AciResourceGroup"/></li>
        ///     <li><c>--chart-url</c> via <see cref="AzureAksInstallConnectorSettings.ChartUrl"/></li>
        ///     <li><c>--client-secret</c> via <see cref="AzureAksInstallConnectorSettings.ClientSecret"/></li>
        ///     <li><c>--connector-name</c> via <see cref="AzureAksInstallConnectorSettings.ConnectorName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksInstallConnectorSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksInstallConnectorSettings.Help"/></li>
        ///     <li><c>--image-tag</c> via <see cref="AzureAksInstallConnectorSettings.ImageTag"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAksInstallConnectorSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksInstallConnectorSettings.Name"/></li>
        ///     <li><c>--os-type</c> via <see cref="AzureAksInstallConnectorSettings.OsType"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksInstallConnectorSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksInstallConnectorSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksInstallConnectorSettings.ResourceGroup"/></li>
        ///     <li><c>--service-principal</c> via <see cref="AzureAksInstallConnectorSettings.ServicePrincipal"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksInstallConnectorSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksInstallConnectorSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksInstallConnectorSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksInstallConnector(CombinatorialConfigure<AzureAksInstallConnectorSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksInstallConnector, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksList(AzureAksListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksList(Configure<AzureAksListSettings> configurator)
        {
            return AzureAksList(configurator(new AzureAksListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksListSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksList(CombinatorialConfigure<AzureAksListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksList, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksRemoveConnector(AzureAksRemoveConnectorSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksRemoveConnectorSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--connector-name</c> via <see cref="AzureAksRemoveConnectorSettings.ConnectorName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksRemoveConnectorSettings.Debug"/></li>
        ///     <li><c>--graceful</c> via <see cref="AzureAksRemoveConnectorSettings.Graceful"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksRemoveConnectorSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAksRemoveConnectorSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksRemoveConnectorSettings.Name"/></li>
        ///     <li><c>--os-type</c> via <see cref="AzureAksRemoveConnectorSettings.OsType"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksRemoveConnectorSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksRemoveConnectorSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksRemoveConnectorSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksRemoveConnectorSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksRemoveConnectorSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksRemoveConnector(Configure<AzureAksRemoveConnectorSettings> configurator)
        {
            return AzureAksRemoveConnector(configurator(new AzureAksRemoveConnectorSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--connector-name</c> via <see cref="AzureAksRemoveConnectorSettings.ConnectorName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksRemoveConnectorSettings.Debug"/></li>
        ///     <li><c>--graceful</c> via <see cref="AzureAksRemoveConnectorSettings.Graceful"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksRemoveConnectorSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAksRemoveConnectorSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksRemoveConnectorSettings.Name"/></li>
        ///     <li><c>--os-type</c> via <see cref="AzureAksRemoveConnectorSettings.OsType"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksRemoveConnectorSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksRemoveConnectorSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksRemoveConnectorSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksRemoveConnectorSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksRemoveConnectorSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksRemoveConnectorSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksRemoveConnector(CombinatorialConfigure<AzureAksRemoveConnectorSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksRemoveConnector, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksRemoveDevSpaces(AzureAksRemoveDevSpacesSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksRemoveDevSpacesSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksRemoveDevSpacesSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksRemoveDevSpacesSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksRemoveDevSpacesSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksRemoveDevSpacesSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksRemoveDevSpacesSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksRemoveDevSpacesSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksRemoveDevSpacesSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksRemoveDevSpacesSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAksRemoveDevSpacesSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksRemoveDevSpaces(Configure<AzureAksRemoveDevSpacesSettings> configurator)
        {
            return AzureAksRemoveDevSpaces(configurator(new AzureAksRemoveDevSpacesSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksRemoveDevSpacesSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksRemoveDevSpacesSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksRemoveDevSpacesSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksRemoveDevSpacesSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksRemoveDevSpacesSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksRemoveDevSpacesSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksRemoveDevSpacesSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksRemoveDevSpacesSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAksRemoveDevSpacesSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksRemoveDevSpacesSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksRemoveDevSpaces(CombinatorialConfigure<AzureAksRemoveDevSpacesSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksRemoveDevSpaces, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksScale(AzureAksScaleSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksScaleSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksScaleSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksScaleSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksScaleSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksScaleSettings.NoWait"/></li>
        ///     <li><c>--node-count</c> via <see cref="AzureAksScaleSettings.NodeCount"/></li>
        ///     <li><c>--nodepool-name</c> via <see cref="AzureAksScaleSettings.NodepoolName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksScaleSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksScaleSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksScaleSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksScaleSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksScaleSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksScale(Configure<AzureAksScaleSettings> configurator)
        {
            return AzureAksScale(configurator(new AzureAksScaleSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksScaleSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksScaleSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksScaleSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksScaleSettings.NoWait"/></li>
        ///     <li><c>--node-count</c> via <see cref="AzureAksScaleSettings.NodeCount"/></li>
        ///     <li><c>--nodepool-name</c> via <see cref="AzureAksScaleSettings.NodepoolName"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksScaleSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksScaleSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksScaleSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksScaleSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksScaleSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksScaleSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksScale(CombinatorialConfigure<AzureAksScaleSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksScale, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksShow(AzureAksShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksShow(Configure<AzureAksShowSettings> configurator)
        {
            return AzureAksShow(configurator(new AzureAksShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksShow(CombinatorialConfigure<AzureAksShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksShow, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksUpdate(AzureAksUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--attach-acr</c> via <see cref="AzureAksUpdateSettings.AttachAcr"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksUpdateSettings.Debug"/></li>
        ///     <li><c>--detach-acr</c> via <see cref="AzureAksUpdateSettings.DetachAcr"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksUpdateSettings.Help"/></li>
        ///     <li><c>--load-balancer-managed-outbound-ip-count</c> via <see cref="AzureAksUpdateSettings.LoadBalancerManagedOutboundIpCount"/></li>
        ///     <li><c>--load-balancer-outbound-ip-prefixes</c> via <see cref="AzureAksUpdateSettings.LoadBalancerOutboundIpPrefixes"/></li>
        ///     <li><c>--load-balancer-outbound-ips</c> via <see cref="AzureAksUpdateSettings.LoadBalancerOutboundIps"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksUpdateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksUpdateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksUpdate(Configure<AzureAksUpdateSettings> configurator)
        {
            return AzureAksUpdate(configurator(new AzureAksUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--attach-acr</c> via <see cref="AzureAksUpdateSettings.AttachAcr"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksUpdateSettings.Debug"/></li>
        ///     <li><c>--detach-acr</c> via <see cref="AzureAksUpdateSettings.DetachAcr"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksUpdateSettings.Help"/></li>
        ///     <li><c>--load-balancer-managed-outbound-ip-count</c> via <see cref="AzureAksUpdateSettings.LoadBalancerManagedOutboundIpCount"/></li>
        ///     <li><c>--load-balancer-outbound-ip-prefixes</c> via <see cref="AzureAksUpdateSettings.LoadBalancerOutboundIpPrefixes"/></li>
        ///     <li><c>--load-balancer-outbound-ips</c> via <see cref="AzureAksUpdateSettings.LoadBalancerOutboundIps"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksUpdateSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksUpdateSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksUpdateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksUpdate(CombinatorialConfigure<AzureAksUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksUpdate, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksUpdateCredentials(AzureAksUpdateCredentialsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksUpdateCredentialsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--aad-client-app-id</c> via <see cref="AzureAksUpdateCredentialsSettings.AadClientAppId"/></li>
        ///     <li><c>--aad-server-app-id</c> via <see cref="AzureAksUpdateCredentialsSettings.AadServerAppId"/></li>
        ///     <li><c>--aad-server-app-secret</c> via <see cref="AzureAksUpdateCredentialsSettings.AadServerAppSecret"/></li>
        ///     <li><c>--aad-tenant-id</c> via <see cref="AzureAksUpdateCredentialsSettings.AadTenantId"/></li>
        ///     <li><c>--client-secret</c> via <see cref="AzureAksUpdateCredentialsSettings.ClientSecret"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksUpdateCredentialsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksUpdateCredentialsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksUpdateCredentialsSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksUpdateCredentialsSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksUpdateCredentialsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksUpdateCredentialsSettings.Query"/></li>
        ///     <li><c>--reset-aad</c> via <see cref="AzureAksUpdateCredentialsSettings.ResetAad"/></li>
        ///     <li><c>--reset-service-principal</c> via <see cref="AzureAksUpdateCredentialsSettings.ResetServicePrincipal"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksUpdateCredentialsSettings.ResourceGroup"/></li>
        ///     <li><c>--service-principal</c> via <see cref="AzureAksUpdateCredentialsSettings.ServicePrincipal"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksUpdateCredentialsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksUpdateCredentialsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksUpdateCredentials(Configure<AzureAksUpdateCredentialsSettings> configurator)
        {
            return AzureAksUpdateCredentials(configurator(new AzureAksUpdateCredentialsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--aad-client-app-id</c> via <see cref="AzureAksUpdateCredentialsSettings.AadClientAppId"/></li>
        ///     <li><c>--aad-server-app-id</c> via <see cref="AzureAksUpdateCredentialsSettings.AadServerAppId"/></li>
        ///     <li><c>--aad-server-app-secret</c> via <see cref="AzureAksUpdateCredentialsSettings.AadServerAppSecret"/></li>
        ///     <li><c>--aad-tenant-id</c> via <see cref="AzureAksUpdateCredentialsSettings.AadTenantId"/></li>
        ///     <li><c>--client-secret</c> via <see cref="AzureAksUpdateCredentialsSettings.ClientSecret"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksUpdateCredentialsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksUpdateCredentialsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksUpdateCredentialsSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksUpdateCredentialsSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksUpdateCredentialsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksUpdateCredentialsSettings.Query"/></li>
        ///     <li><c>--reset-aad</c> via <see cref="AzureAksUpdateCredentialsSettings.ResetAad"/></li>
        ///     <li><c>--reset-service-principal</c> via <see cref="AzureAksUpdateCredentialsSettings.ResetServicePrincipal"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksUpdateCredentialsSettings.ResourceGroup"/></li>
        ///     <li><c>--service-principal</c> via <see cref="AzureAksUpdateCredentialsSettings.ServicePrincipal"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksUpdateCredentialsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksUpdateCredentialsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksUpdateCredentialsSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksUpdateCredentials(CombinatorialConfigure<AzureAksUpdateCredentialsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksUpdateCredentials, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksUpgrade(AzureAksUpgradeSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksUpgradeSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--control-plane-only</c> via <see cref="AzureAksUpgradeSettings.ControlPlaneOnly"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksUpgradeSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksUpgradeSettings.Help"/></li>
        ///     <li><c>--kubernetes-version</c> via <see cref="AzureAksUpgradeSettings.KubernetesVersion"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksUpgradeSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksUpgradeSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksUpgradeSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksUpgradeSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksUpgradeSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksUpgradeSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksUpgradeSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAksUpgradeSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksUpgrade(Configure<AzureAksUpgradeSettings> configurator)
        {
            return AzureAksUpgrade(configurator(new AzureAksUpgradeSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--control-plane-only</c> via <see cref="AzureAksUpgradeSettings.ControlPlaneOnly"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksUpgradeSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksUpgradeSettings.Help"/></li>
        ///     <li><c>--kubernetes-version</c> via <see cref="AzureAksUpgradeSettings.KubernetesVersion"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksUpgradeSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureAksUpgradeSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksUpgradeSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksUpgradeSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksUpgradeSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksUpgradeSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksUpgradeSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAksUpgradeSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksUpgradeSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksUpgrade(CombinatorialConfigure<AzureAksUpgradeSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksUpgrade, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksUpgradeConnector(AzureAksUpgradeConnectorSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksUpgradeConnectorSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--aci-resource-group</c> via <see cref="AzureAksUpgradeConnectorSettings.AciResourceGroup"/></li>
        ///     <li><c>--chart-url</c> via <see cref="AzureAksUpgradeConnectorSettings.ChartUrl"/></li>
        ///     <li><c>--client-secret</c> via <see cref="AzureAksUpgradeConnectorSettings.ClientSecret"/></li>
        ///     <li><c>--connector-name</c> via <see cref="AzureAksUpgradeConnectorSettings.ConnectorName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksUpgradeConnectorSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksUpgradeConnectorSettings.Help"/></li>
        ///     <li><c>--image-tag</c> via <see cref="AzureAksUpgradeConnectorSettings.ImageTag"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAksUpgradeConnectorSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksUpgradeConnectorSettings.Name"/></li>
        ///     <li><c>--os-type</c> via <see cref="AzureAksUpgradeConnectorSettings.OsType"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksUpgradeConnectorSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksUpgradeConnectorSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksUpgradeConnectorSettings.ResourceGroup"/></li>
        ///     <li><c>--service-principal</c> via <see cref="AzureAksUpgradeConnectorSettings.ServicePrincipal"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksUpgradeConnectorSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksUpgradeConnectorSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksUpgradeConnector(Configure<AzureAksUpgradeConnectorSettings> configurator)
        {
            return AzureAksUpgradeConnector(configurator(new AzureAksUpgradeConnectorSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--aci-resource-group</c> via <see cref="AzureAksUpgradeConnectorSettings.AciResourceGroup"/></li>
        ///     <li><c>--chart-url</c> via <see cref="AzureAksUpgradeConnectorSettings.ChartUrl"/></li>
        ///     <li><c>--client-secret</c> via <see cref="AzureAksUpgradeConnectorSettings.ClientSecret"/></li>
        ///     <li><c>--connector-name</c> via <see cref="AzureAksUpgradeConnectorSettings.ConnectorName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksUpgradeConnectorSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksUpgradeConnectorSettings.Help"/></li>
        ///     <li><c>--image-tag</c> via <see cref="AzureAksUpgradeConnectorSettings.ImageTag"/></li>
        ///     <li><c>--location</c> via <see cref="AzureAksUpgradeConnectorSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksUpgradeConnectorSettings.Name"/></li>
        ///     <li><c>--os-type</c> via <see cref="AzureAksUpgradeConnectorSettings.OsType"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksUpgradeConnectorSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksUpgradeConnectorSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksUpgradeConnectorSettings.ResourceGroup"/></li>
        ///     <li><c>--service-principal</c> via <see cref="AzureAksUpgradeConnectorSettings.ServicePrincipal"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksUpgradeConnectorSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksUpgradeConnectorSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksUpgradeConnectorSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksUpgradeConnector(CombinatorialConfigure<AzureAksUpgradeConnectorSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksUpgradeConnector, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksUseDevSpaces(AzureAksUseDevSpacesSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksUseDevSpacesSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksUseDevSpacesSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksUseDevSpacesSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksUseDevSpacesSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksUseDevSpacesSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksUseDevSpacesSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksUseDevSpacesSettings.ResourceGroup"/></li>
        ///     <li><c>--space</c> via <see cref="AzureAksUseDevSpacesSettings.Space"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksUseDevSpacesSettings.Subscription"/></li>
        ///     <li><c>--update</c> via <see cref="AzureAksUseDevSpacesSettings.Update"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksUseDevSpacesSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAksUseDevSpacesSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksUseDevSpaces(Configure<AzureAksUseDevSpacesSettings> configurator)
        {
            return AzureAksUseDevSpaces(configurator(new AzureAksUseDevSpacesSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureAksUseDevSpacesSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksUseDevSpacesSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksUseDevSpacesSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksUseDevSpacesSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksUseDevSpacesSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksUseDevSpacesSettings.ResourceGroup"/></li>
        ///     <li><c>--space</c> via <see cref="AzureAksUseDevSpacesSettings.Space"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksUseDevSpacesSettings.Subscription"/></li>
        ///     <li><c>--update</c> via <see cref="AzureAksUseDevSpacesSettings.Update"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksUseDevSpacesSettings.Verbose"/></li>
        ///     <li><c>--yes</c> via <see cref="AzureAksUseDevSpacesSettings.Yes"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksUseDevSpacesSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksUseDevSpaces(CombinatorialConfigure<AzureAksUseDevSpacesSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksUseDevSpaces, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureAksWait(AzureAksWaitSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureAksWaitSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureAksWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureAksWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureAksWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureAksWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureAksWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureAksWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureAksWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureAksWait(Configure<AzureAksWaitSettings> configurator)
        {
            return AzureAksWait(configurator(new AzureAksWaitSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Kubernetes Services.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/aks?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--created</c> via <see cref="AzureAksWaitSettings.Created"/></li>
        ///     <li><c>--custom</c> via <see cref="AzureAksWaitSettings.Custom"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureAksWaitSettings.Debug"/></li>
        ///     <li><c>--deleted</c> via <see cref="AzureAksWaitSettings.Deleted"/></li>
        ///     <li><c>--exists</c> via <see cref="AzureAksWaitSettings.Exists"/></li>
        ///     <li><c>--help</c> via <see cref="AzureAksWaitSettings.Help"/></li>
        ///     <li><c>--interval</c> via <see cref="AzureAksWaitSettings.Interval"/></li>
        ///     <li><c>--name</c> via <see cref="AzureAksWaitSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureAksWaitSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureAksWaitSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureAksWaitSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureAksWaitSettings.Subscription"/></li>
        ///     <li><c>--timeout</c> via <see cref="AzureAksWaitSettings.Timeout"/></li>
        ///     <li><c>--updated</c> via <see cref="AzureAksWaitSettings.Updated"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureAksWaitSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureAksWaitSettings Settings, IReadOnlyCollection<Output> Output)> AzureAksWait(CombinatorialConfigure<AzureAksWaitSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureAksWait, AzureAksLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureAksBrowseSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksBrowseSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Don't launch a web browser after establishing port-forwarding.
        /// </summary>
        public virtual string DisableBrowser { get; internal set; }
        /// <summary>
        ///   The listening address for the dashboard.
        /// </summary>
        public virtual string ListenAddress { get; internal set; }
        /// <summary>
        ///   The listening port for the dashboard.
        /// </summary>
        public virtual string ListenPort { get; internal set; }
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
              .Add("aks browse")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--disable-browser {value}", DisableBrowser)
              .Add("--listen-address {value}", ListenAddress)
              .Add("--listen-port {value}", ListenPort)
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
    #region AzureAksCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The ID of an Azure Active Directory client application of type "Native". This application is for user login via kubectl.
        /// </summary>
        public virtual string AadClientAppId { get; internal set; }
        /// <summary>
        ///   The ID of an Azure Active Directory server application of type "Web app/API". This application represents the managed cluster's apiserver (Server application).
        /// </summary>
        public virtual string AadServerAppId { get; internal set; }
        /// <summary>
        ///   The secret of an Azure Active Directory server application.
        /// </summary>
        public virtual string AadServerAppSecret { get; internal set; }
        /// <summary>
        ///   The ID of an Azure Active Directory tenant.
        /// </summary>
        public virtual string AadTenantId { get; internal set; }
        /// <summary>
        ///   User account to create on node VMs for SSH access.
        /// </summary>
        public virtual string AdminUsername { get; internal set; }
        /// <summary>
        ///   Grant the 'acrpull' role assignment to the ACR specified by name or resource ID.
        /// </summary>
        public virtual string AttachAcr { get; internal set; }
        /// <summary>
        ///   Secret associated with the service principal. This argument is required if `--service-principal` is specified.
        /// </summary>
        public virtual string ClientSecret { get; internal set; }
        /// <summary>
        ///   Disable Kubernetes Role-Based Access Control.
        /// </summary>
        public virtual string DisableRbac { get; internal set; }
        /// <summary>
        ///   Prefix for hostnames that are created. If not specified, generate a hostname using the managed cluster and resource group names.
        /// </summary>
        public virtual string DnsNamePrefix { get; internal set; }
        /// <summary>
        ///   An IP address assigned to the Kubernetes DNS service.
        /// </summary>
        public virtual string DnsServiceIp { get; internal set; }
        /// <summary>
        ///   A specific IP address and netmask for the Docker bridge, using standard CIDR notation.
        /// </summary>
        public virtual string DockerBridgeAddress { get; internal set; }
        /// <summary>
        ///   Enable the Kubernetes addons in a comma-separated list.
        /// </summary>
        public virtual IReadOnlyList<string> EnableAddons => EnableAddonsInternal.AsReadOnly();
        internal List<string> EnableAddonsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Enable Kubernetes Role-Based Access Control. Default: enabled.
        /// </summary>
        public virtual string EnableRbac { get; internal set; }
        /// <summary>
        ///   Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.
        /// </summary>
        public virtual string GenerateSshKeys { get; internal set; }
        /// <summary>
        ///   Version of Kubernetes to use for creating the cluster, such as "1.11.8" or "1.12.6".
        /// </summary>
        public virtual string KubernetesVersion { get; internal set; }
        /// <summary>
        ///   Load balancer managed outbound IP count.
        /// </summary>
        public virtual string LoadBalancerManagedOutboundIpCount { get; internal set; }
        /// <summary>
        ///   Load balancer outbound IP prefix resource IDs.
        /// </summary>
        public virtual string LoadBalancerOutboundIpPrefixes { get; internal set; }
        /// <summary>
        ///   Load balancer outbound IP resource IDs.
        /// </summary>
        public virtual string LoadBalancerOutboundIps { get; internal set; }
        /// <summary>
        ///   Azure Load Balancer SKU selection for your cluster. basic or standard.
        /// </summary>
        public virtual string LoadBalancerSku { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   The maximum number of pods deployable to a node.
        /// </summary>
        public virtual int? MaxPods { get; internal set; }
        /// <summary>
        ///   The Kubernetes network plugin to use.
        /// </summary>
        public virtual string NetworkPlugin { get; internal set; }
        /// <summary>
        ///   The Kubernetes network policy to use.
        /// </summary>
        public virtual string NetworkPolicy { get; internal set; }
        /// <summary>
        ///   Do not use or create a local SSH key.
        /// </summary>
        public virtual bool? NoSshKey { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Number of nodes in the Kubernetes node pool. After creating a cluster, you can change the size of its node pool with `az aks scale`.
        /// </summary>
        public virtual int? NodeCount { get; internal set; }
        /// <summary>
        ///   Size in GB of the OS disk for each node in the node pool. Minimum 30 GB.
        /// </summary>
        public virtual string NodeOsdiskSize { get; internal set; }
        /// <summary>
        ///   Size of Virtual Machines to create as Kubernetes nodes.
        /// </summary>
        public virtual string NodeVmSize { get; internal set; }
        /// <summary>
        ///   Node pool name, upto 12 alphanumeric characters.
        /// </summary>
        public virtual string NodepoolName { get; internal set; }
        /// <summary>
        ///   A CIDR notation IP range from which to assign pod IPs when kubenet is used.
        /// </summary>
        public virtual string PodCidr { get; internal set; }
        /// <summary>
        ///   A CIDR notation IP range from which to assign service cluster IPs.
        /// </summary>
        public virtual string ServiceCidr { get; internal set; }
        /// <summary>
        ///   Service principal used for authentication to Azure APIs.
        /// </summary>
        public virtual bool? ServicePrincipal { get; internal set; }
        /// <summary>
        ///   Skip role assignment for subnet (advanced networking).
        /// </summary>
        public virtual string SkipSubnetRoleAssignment { get; internal set; }
        /// <summary>
        ///   Public key path or key contents to install on node VMs for SSH access. For example, 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm'.
        /// </summary>
        public virtual string SshKeyValue { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   Agent pool vm set type. VirtualMachineScaleSets or AvailabilitySet.
        /// </summary>
        public virtual string VmSetType { get; internal set; }
        /// <summary>
        ///   The ID of a subnet in an existing VNet into which to deploy the cluster.
        /// </summary>
        public virtual string VnetSubnetId { get; internal set; }
        /// <summary>
        ///   The resource ID of an existing Log Analytics Workspace to use for storing monitoring data. If not specified, uses the default Log Analytics Workspace if it exists, otherwise creates one.
        /// </summary>
        public virtual string WorkspaceResourceId { get; internal set; }
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
              .Add("aks create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--aad-client-app-id {value}", AadClientAppId)
              .Add("--aad-server-app-id {value}", AadServerAppId)
              .Add("--aad-server-app-secret {value}", AadServerAppSecret, secret: true)
              .Add("--aad-tenant-id {value}", AadTenantId)
              .Add("--admin-username {value}", AdminUsername)
              .Add("--attach-acr {value}", AttachAcr)
              .Add("--client-secret {value}", ClientSecret, secret: true)
              .Add("--disable-rbac {value}", DisableRbac)
              .Add("--dns-name-prefix {value}", DnsNamePrefix)
              .Add("--dns-service-ip {value}", DnsServiceIp)
              .Add("--docker-bridge-address {value}", DockerBridgeAddress)
              .Add("--enable-addons {value}", EnableAddons, separator: ',')
              .Add("--enable-rbac {value}", EnableRbac)
              .Add("--generate-ssh-keys {value}", GenerateSshKeys)
              .Add("--kubernetes-version {value}", KubernetesVersion)
              .Add("--load-balancer-managed-outbound-ip-count {value}", LoadBalancerManagedOutboundIpCount)
              .Add("--load-balancer-outbound-ip-prefixes {value}", LoadBalancerOutboundIpPrefixes)
              .Add("--load-balancer-outbound-ips {value}", LoadBalancerOutboundIps)
              .Add("--load-balancer-sku {value}", LoadBalancerSku)
              .Add("--location {value}", Location)
              .Add("--max-pods {value}", MaxPods)
              .Add("--network-plugin {value}", NetworkPlugin)
              .Add("--network-policy {value}", NetworkPolicy)
              .Add("--no-ssh-key", NoSshKey)
              .Add("--no-wait", NoWait)
              .Add("--node-count {value}", NodeCount)
              .Add("--node-osdisk-size {value}", NodeOsdiskSize)
              .Add("--node-vm-size {value}", NodeVmSize)
              .Add("--nodepool-name {value}", NodepoolName)
              .Add("--pod-cidr {value}", PodCidr)
              .Add("--service-cidr {value}", ServiceCidr)
              .Add("--service-principal", ServicePrincipal)
              .Add("--skip-subnet-role-assignment {value}", SkipSubnetRoleAssignment)
              .Add("--ssh-key-value {value}", SshKeyValue)
              .Add("--tags {value}", Tags)
              .Add("--vm-set-type {value}", VmSetType)
              .Add("--vnet-subnet-id {value}", VnetSubnetId)
              .Add("--workspace-resource-id {value}", WorkspaceResourceId)
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
    #region AzureAksDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
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
              .Add("aks delete")
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
    #region AzureAksDisableAddonsSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksDisableAddonsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Disable the Kubernetes addons in a comma-separated list.
        /// </summary>
        public virtual IReadOnlyList<string> Addons => AddonsInternal.AsReadOnly();
        internal List<string> AddonsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the managed cluster.
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
              .Add("aks disable-addons")
              .Add("--addons {value}", Addons, separator: ',')
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
    #region AzureAksEnableAddonsSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksEnableAddonsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Enable the Kubernetes addons in a comma-separated list.
        /// </summary>
        public virtual IReadOnlyList<string> Addons => AddonsInternal.AsReadOnly();
        internal List<string> AddonsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the managed cluster.
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
        ///   Name of an existing subnet to use with the virtual-node add-on.
        /// </summary>
        public virtual string SubnetName { get; internal set; }
        /// <summary>
        ///   The resource ID of an existing Log Analytics Workspace to use for storing monitoring data.
        /// </summary>
        public virtual string WorkspaceResourceId { get; internal set; }
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
              .Add("aks enable-addons")
              .Add("--addons {value}", Addons, separator: ',')
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
              .Add("--subnet-name {value}", SubnetName)
              .Add("--workspace-resource-id {value}", WorkspaceResourceId)
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
    #region AzureAksGetCredentialsSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksGetCredentialsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Get cluster administrator credentials.  Default: cluster user credentials.
        /// </summary>
        public virtual string Admin { get; internal set; }
        /// <summary>
        ///   If specified, overwrite the default context name.
        /// </summary>
        public virtual string Context { get; internal set; }
        /// <summary>
        ///   Kubernetes configuration file to update. Use "-" to print YAML to stdout instead.
        /// </summary>
        public virtual string File { get; internal set; }
        /// <summary>
        ///   Overwrite any existing cluster entry with the same name.
        /// </summary>
        public virtual string OverwriteExisting { get; internal set; }
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
              .Add("aks get-credentials")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--admin {value}", Admin)
              .Add("--context {value}", Context)
              .Add("--file {value}", File)
              .Add("--overwrite-existing {value}", OverwriteExisting)
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
    #region AzureAksGetUpgradesSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksGetUpgradesSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
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
              .Add("aks get-upgrades")
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
    #region AzureAksGetVersionsSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksGetVersionsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
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
              .Add("aks get-versions")
              .Add("--location {value}", Location)
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
    #region AzureAksInstallCliSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksInstallCliSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
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
              .Add("aks install-cli")
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
    #region AzureAksInstallConnectorSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksInstallConnectorSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource group to create the ACI container groups. Use the MC_\* resource group if it is not specified.
        /// </summary>
        public virtual string AciResourceGroup { get; internal set; }
        /// <summary>
        ///   URL of a Helm chart that installs ACI Connector.
        /// </summary>
        public virtual string ChartUrl { get; internal set; }
        /// <summary>
        ///   Secret associated with the service principal. This argument is required if `--service-principal` is specified.
        /// </summary>
        public virtual string ClientSecret { get; internal set; }
        /// <summary>
        ///   Name of the ACI Connector.
        /// </summary>
        public virtual string ConnectorName { get; internal set; }
        /// <summary>
        ///   The image tag of the virtual kubelet. Use 'latest' if it is not specified.
        /// </summary>
        public virtual string ImageTag { get; internal set; }
        /// <summary>
        ///   The location to create the ACI container groups. Use the location of the MC_\* resource group if it is not specified.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Install support for deploying ACIs of this operating system type.
        /// </summary>
        public virtual AksOsType OsType { get; internal set; }
        /// <summary>
        ///   Service principal used for authentication to Azure APIs.
        /// </summary>
        public virtual bool? ServicePrincipal { get; internal set; }
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
              .Add("aks install-connector")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--aci-resource-group {value}", AciResourceGroup)
              .Add("--chart-url {value}", ChartUrl)
              .Add("--client-secret {value}", ClientSecret, secret: true)
              .Add("--connector-name {value}", ConnectorName)
              .Add("--image-tag {value}", ImageTag)
              .Add("--location {value}", Location)
              .Add("--os-type {value}", OsType)
              .Add("--service-principal", ServicePrincipal)
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
    #region AzureAksListSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
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
              .Add("aks list")
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
    #region AzureAksRemoveConnectorSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksRemoveConnectorSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the ACI Connector.
        /// </summary>
        public virtual string ConnectorName { get; internal set; }
        /// <summary>
        ///   Use a "cordon and drain" strategy to evict pods safely before removing the ACI node.
        /// </summary>
        public virtual string Graceful { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Remove support for deploying ACIs of this operating system type.
        /// </summary>
        public virtual AksOsType OsType { get; internal set; }
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
              .Add("aks remove-connector")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--connector-name {value}", ConnectorName)
              .Add("--graceful {value}", Graceful)
              .Add("--location {value}", Location)
              .Add("--os-type {value}", OsType)
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
    #region AzureAksRemoveDevSpacesSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksRemoveDevSpacesSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
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
              .Add("aks remove-dev-spaces")
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
    #region AzureAksScaleSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksScaleSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Number of nodes in the Kubernetes node pool.
        /// </summary>
        public virtual int? NodeCount { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   Node pool name, upto 12 alphanumeric characters.
        /// </summary>
        public virtual string NodepoolName { get; internal set; }
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
              .Add("aks scale")
              .Add("--name {value}", Name)
              .Add("--node-count {value}", NodeCount)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
              .Add("--nodepool-name {value}", NodepoolName)
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
    #region AzureAksShowSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
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
              .Add("aks show")
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
    #region AzureAksUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Grant the 'acrpull' role assignment to the ACR specified by name or resource ID.
        /// </summary>
        public virtual string AttachAcr { get; internal set; }
        /// <summary>
        ///   Disable the 'acrpull' role assignment to the ACR specified by name or resource ID.
        /// </summary>
        public virtual string DetachAcr { get; internal set; }
        /// <summary>
        ///   Load balancer managed outbound IP count.
        /// </summary>
        public virtual string LoadBalancerManagedOutboundIpCount { get; internal set; }
        /// <summary>
        ///   Load balancer outbound IP prefix resource IDs.
        /// </summary>
        public virtual string LoadBalancerOutboundIpPrefixes { get; internal set; }
        /// <summary>
        ///   Load balancer outbound IP resource IDs.
        /// </summary>
        public virtual string LoadBalancerOutboundIps { get; internal set; }
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
              .Add("aks update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--attach-acr {value}", AttachAcr)
              .Add("--detach-acr {value}", DetachAcr)
              .Add("--load-balancer-managed-outbound-ip-count {value}", LoadBalancerManagedOutboundIpCount)
              .Add("--load-balancer-outbound-ip-prefixes {value}", LoadBalancerOutboundIpPrefixes)
              .Add("--load-balancer-outbound-ips {value}", LoadBalancerOutboundIps)
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
    #region AzureAksUpdateCredentialsSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksUpdateCredentialsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
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
        ///   The ID of an Azure Active Directory client application. This argument is required if `--reset-aad` is specified.
        /// </summary>
        public virtual string AadClientAppId { get; internal set; }
        /// <summary>
        ///   The ID of an Azure Active Directory server application. This argument is required if `--reset-aad` is specified.
        /// </summary>
        public virtual string AadServerAppId { get; internal set; }
        /// <summary>
        ///   The secret of an Azure Active Directory server application. This argument is required if `--reset-aad` is specified.
        /// </summary>
        public virtual string AadServerAppSecret { get; internal set; }
        /// <summary>
        ///   Tenant ID associated with Azure Active Directory.
        /// </summary>
        public virtual string AadTenantId { get; internal set; }
        /// <summary>
        ///   Reset Azure Active Directory configuration for a managed cluster.
        /// </summary>
        public virtual string ResetAad { get; internal set; }
        /// <summary>
        ///   Secret associated with the service principal. This argument is required if `--service-principal` is specified.
        /// </summary>
        public virtual string ClientSecret { get; internal set; }
        /// <summary>
        ///   Reset service principal for a managed cluster.
        /// </summary>
        public virtual string ResetServicePrincipal { get; internal set; }
        /// <summary>
        ///   Service principal used for authentication to Azure APIs. This argument is required if `--reset-service-principal` is specified.
        /// </summary>
        public virtual bool? ServicePrincipal { get; internal set; }
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
              .Add("aks update-credentials")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--no-wait", NoWait)
              .Add("--aad-client-app-id {value}", AadClientAppId)
              .Add("--aad-server-app-id {value}", AadServerAppId)
              .Add("--aad-server-app-secret {value}", AadServerAppSecret, secret: true)
              .Add("--aad-tenant-id {value}", AadTenantId)
              .Add("--reset-aad {value}", ResetAad)
              .Add("--client-secret {value}", ClientSecret, secret: true)
              .Add("--reset-service-principal {value}", ResetServicePrincipal)
              .Add("--service-principal", ServicePrincipal)
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
    #region AzureAksUpgradeSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksUpgradeSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Version of Kubernetes to upgrade the cluster to, such as "1.11.8" or "1.12.6".
        /// </summary>
        public virtual string KubernetesVersion { get; internal set; }
        /// <summary>
        ///   Name of the managed cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Upgrade the cluster control plane only. If not specified, both control plane AND all node pools will be upgraded.
        /// </summary>
        public virtual string ControlPlaneOnly { get; internal set; }
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
              .Add("aks upgrade")
              .Add("--kubernetes-version {value}", KubernetesVersion)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--control-plane-only {value}", ControlPlaneOnly)
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
    #region AzureAksUpgradeConnectorSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksUpgradeConnectorSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The resource group to create the ACI container groups. Use the MC_\* resource group if it is not specified.
        /// </summary>
        public virtual string AciResourceGroup { get; internal set; }
        /// <summary>
        ///   URL of a Helm chart that installs ACI Connector.
        /// </summary>
        public virtual string ChartUrl { get; internal set; }
        /// <summary>
        ///   Secret associated with the service principal. This argument is required if `--service-principal` is specified.
        /// </summary>
        public virtual string ClientSecret { get; internal set; }
        /// <summary>
        ///   Name of the ACI Connector.
        /// </summary>
        public virtual string ConnectorName { get; internal set; }
        /// <summary>
        ///   The image tag of the virtual kubelet. Use 'latest' if it is not specified.
        /// </summary>
        public virtual string ImageTag { get; internal set; }
        /// <summary>
        ///   The location to create the ACI container groups. Use the location of the MC_\* resource group if it is not specified.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Install support for deploying ACIs of this operating system type.
        /// </summary>
        public virtual AksOsType OsType { get; internal set; }
        /// <summary>
        ///   Service principal used for authentication to Azure APIs.
        /// </summary>
        public virtual bool? ServicePrincipal { get; internal set; }
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
              .Add("aks upgrade-connector")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--aci-resource-group {value}", AciResourceGroup)
              .Add("--chart-url {value}", ChartUrl)
              .Add("--client-secret {value}", ClientSecret, secret: true)
              .Add("--connector-name {value}", ConnectorName)
              .Add("--image-tag {value}", ImageTag)
              .Add("--location {value}", Location)
              .Add("--os-type {value}", OsType)
              .Add("--service-principal", ServicePrincipal)
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
    #region AzureAksUseDevSpacesSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksUseDevSpacesSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Name of the new or existing dev space to select. Defaults to an interactive selection experience.
        /// </summary>
        public virtual string Space { get; internal set; }
        /// <summary>
        ///   Update to the latest Azure Dev Spaces client components.
        /// </summary>
        public virtual string Update { get; internal set; }
        /// <summary>
        ///   Do not prompt for confirmation. Requires --space.
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
              .Add("aks use-dev-spaces")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--space {value}", Space)
              .Add("--update {value}", Update)
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
    #region AzureAksWaitSettings
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAksWaitSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureAks executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureAksTasks.AzureAksPath;
        public override Action<OutputType, string> CustomLogger => AzureAksTasks.AzureAksLogger;
        /// <summary>
        ///   Name of the managed cluster.
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
              .Add("aks wait")
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
    #region AzureAksBrowseSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksBrowseSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksBrowseSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings SetName(this AzureAksBrowseSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksBrowseSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings ResetName(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksBrowseSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings SetResourceGroup(this AzureAksBrowseSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksBrowseSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings ResetResourceGroup(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region DisableBrowser
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksBrowseSettings.DisableBrowser"/></em></p>
        ///   <p>Don't launch a web browser after establishing port-forwarding.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings SetDisableBrowser(this AzureAksBrowseSettings toolSettings, string disableBrowser)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = disableBrowser;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksBrowseSettings.DisableBrowser"/></em></p>
        ///   <p>Don't launch a web browser after establishing port-forwarding.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings ResetDisableBrowser(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableBrowser = null;
            return toolSettings;
        }
        #endregion
        #region ListenAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksBrowseSettings.ListenAddress"/></em></p>
        ///   <p>The listening address for the dashboard.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings SetListenAddress(this AzureAksBrowseSettings toolSettings, string listenAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListenAddress = listenAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksBrowseSettings.ListenAddress"/></em></p>
        ///   <p>The listening address for the dashboard.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings ResetListenAddress(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListenAddress = null;
            return toolSettings;
        }
        #endregion
        #region ListenPort
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksBrowseSettings.ListenPort"/></em></p>
        ///   <p>The listening port for the dashboard.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings SetListenPort(this AzureAksBrowseSettings toolSettings, string listenPort)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListenPort = listenPort;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksBrowseSettings.ListenPort"/></em></p>
        ///   <p>The listening port for the dashboard.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings ResetListenPort(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ListenPort = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksBrowseSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings SetSubscription(this AzureAksBrowseSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksBrowseSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings ResetSubscription(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksBrowseSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings SetDebug(this AzureAksBrowseSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksBrowseSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings ResetDebug(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksBrowseSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings SetHelp(this AzureAksBrowseSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksBrowseSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings ResetHelp(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksBrowseSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings SetOutput(this AzureAksBrowseSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksBrowseSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings ResetOutput(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksBrowseSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings SetQuery(this AzureAksBrowseSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksBrowseSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings ResetQuery(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksBrowseSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings SetVerbose(this AzureAksBrowseSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksBrowseSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksBrowseSettings ResetVerbose(this AzureAksBrowseSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetName(this AzureAksCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetName(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetResourceGroup(this AzureAksCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetResourceGroup(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AadClientAppId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.AadClientAppId"/></em></p>
        ///   <p>The ID of an Azure Active Directory client application of type "Native". This application is for user login via kubectl.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetAadClientAppId(this AzureAksCreateSettings toolSettings, string aadClientAppId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientAppId = aadClientAppId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.AadClientAppId"/></em></p>
        ///   <p>The ID of an Azure Active Directory client application of type "Native". This application is for user login via kubectl.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetAadClientAppId(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientAppId = null;
            return toolSettings;
        }
        #endregion
        #region AadServerAppId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.AadServerAppId"/></em></p>
        ///   <p>The ID of an Azure Active Directory server application of type "Web app/API". This application represents the managed cluster's apiserver (Server application).</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetAadServerAppId(this AzureAksCreateSettings toolSettings, string aadServerAppId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadServerAppId = aadServerAppId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.AadServerAppId"/></em></p>
        ///   <p>The ID of an Azure Active Directory server application of type "Web app/API". This application represents the managed cluster's apiserver (Server application).</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetAadServerAppId(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadServerAppId = null;
            return toolSettings;
        }
        #endregion
        #region AadServerAppSecret
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.AadServerAppSecret"/></em></p>
        ///   <p>The secret of an Azure Active Directory server application.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetAadServerAppSecret(this AzureAksCreateSettings toolSettings, string aadServerAppSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadServerAppSecret = aadServerAppSecret;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.AadServerAppSecret"/></em></p>
        ///   <p>The secret of an Azure Active Directory server application.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetAadServerAppSecret(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadServerAppSecret = null;
            return toolSettings;
        }
        #endregion
        #region AadTenantId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.AadTenantId"/></em></p>
        ///   <p>The ID of an Azure Active Directory tenant.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetAadTenantId(this AzureAksCreateSettings toolSettings, string aadTenantId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadTenantId = aadTenantId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.AadTenantId"/></em></p>
        ///   <p>The ID of an Azure Active Directory tenant.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetAadTenantId(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadTenantId = null;
            return toolSettings;
        }
        #endregion
        #region AdminUsername
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.AdminUsername"/></em></p>
        ///   <p>User account to create on node VMs for SSH access.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetAdminUsername(this AzureAksCreateSettings toolSettings, string adminUsername)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUsername = adminUsername;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.AdminUsername"/></em></p>
        ///   <p>User account to create on node VMs for SSH access.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetAdminUsername(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdminUsername = null;
            return toolSettings;
        }
        #endregion
        #region AttachAcr
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.AttachAcr"/></em></p>
        ///   <p>Grant the 'acrpull' role assignment to the ACR specified by name or resource ID.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetAttachAcr(this AzureAksCreateSettings toolSettings, string attachAcr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AttachAcr = attachAcr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.AttachAcr"/></em></p>
        ///   <p>Grant the 'acrpull' role assignment to the ACR specified by name or resource ID.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetAttachAcr(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AttachAcr = null;
            return toolSettings;
        }
        #endregion
        #region ClientSecret
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.ClientSecret"/></em></p>
        ///   <p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetClientSecret(this AzureAksCreateSettings toolSettings, string clientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = clientSecret;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.ClientSecret"/></em></p>
        ///   <p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetClientSecret(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region DisableRbac
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.DisableRbac"/></em></p>
        ///   <p>Disable Kubernetes Role-Based Access Control.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetDisableRbac(this AzureAksCreateSettings toolSettings, string disableRbac)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableRbac = disableRbac;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.DisableRbac"/></em></p>
        ///   <p>Disable Kubernetes Role-Based Access Control.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetDisableRbac(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableRbac = null;
            return toolSettings;
        }
        #endregion
        #region DnsNamePrefix
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.DnsNamePrefix"/></em></p>
        ///   <p>Prefix for hostnames that are created. If not specified, generate a hostname using the managed cluster and resource group names.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetDnsNamePrefix(this AzureAksCreateSettings toolSettings, string dnsNamePrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsNamePrefix = dnsNamePrefix;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.DnsNamePrefix"/></em></p>
        ///   <p>Prefix for hostnames that are created. If not specified, generate a hostname using the managed cluster and resource group names.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetDnsNamePrefix(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsNamePrefix = null;
            return toolSettings;
        }
        #endregion
        #region DnsServiceIp
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.DnsServiceIp"/></em></p>
        ///   <p>An IP address assigned to the Kubernetes DNS service.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetDnsServiceIp(this AzureAksCreateSettings toolSettings, string dnsServiceIp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsServiceIp = dnsServiceIp;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.DnsServiceIp"/></em></p>
        ///   <p>An IP address assigned to the Kubernetes DNS service.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetDnsServiceIp(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DnsServiceIp = null;
            return toolSettings;
        }
        #endregion
        #region DockerBridgeAddress
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.DockerBridgeAddress"/></em></p>
        ///   <p>A specific IP address and netmask for the Docker bridge, using standard CIDR notation.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetDockerBridgeAddress(this AzureAksCreateSettings toolSettings, string dockerBridgeAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DockerBridgeAddress = dockerBridgeAddress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.DockerBridgeAddress"/></em></p>
        ///   <p>A specific IP address and netmask for the Docker bridge, using standard CIDR notation.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetDockerBridgeAddress(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DockerBridgeAddress = null;
            return toolSettings;
        }
        #endregion
        #region EnableAddons
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.EnableAddons"/> to a new list</em></p>
        ///   <p>Enable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetEnableAddons(this AzureAksCreateSettings toolSettings, params string[] enableAddons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAddonsInternal = enableAddons.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.EnableAddons"/> to a new list</em></p>
        ///   <p>Enable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetEnableAddons(this AzureAksCreateSettings toolSettings, IEnumerable<string> enableAddons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAddonsInternal = enableAddons.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAksCreateSettings.EnableAddons"/></em></p>
        ///   <p>Enable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings AddEnableAddons(this AzureAksCreateSettings toolSettings, params string[] enableAddons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAddonsInternal.AddRange(enableAddons);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAksCreateSettings.EnableAddons"/></em></p>
        ///   <p>Enable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings AddEnableAddons(this AzureAksCreateSettings toolSettings, IEnumerable<string> enableAddons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAddonsInternal.AddRange(enableAddons);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAksCreateSettings.EnableAddons"/></em></p>
        ///   <p>Enable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ClearEnableAddons(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAddonsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAksCreateSettings.EnableAddons"/></em></p>
        ///   <p>Enable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings RemoveEnableAddons(this AzureAksCreateSettings toolSettings, params string[] enableAddons)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(enableAddons);
            toolSettings.EnableAddonsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAksCreateSettings.EnableAddons"/></em></p>
        ///   <p>Enable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings RemoveEnableAddons(this AzureAksCreateSettings toolSettings, IEnumerable<string> enableAddons)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(enableAddons);
            toolSettings.EnableAddonsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region EnableRbac
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.EnableRbac"/></em></p>
        ///   <p>Enable Kubernetes Role-Based Access Control. Default: enabled.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetEnableRbac(this AzureAksCreateSettings toolSettings, string enableRbac)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableRbac = enableRbac;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.EnableRbac"/></em></p>
        ///   <p>Enable Kubernetes Role-Based Access Control. Default: enabled.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetEnableRbac(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableRbac = null;
            return toolSettings;
        }
        #endregion
        #region GenerateSshKeys
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.GenerateSshKeys"/></em></p>
        ///   <p>Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetGenerateSshKeys(this AzureAksCreateSettings toolSettings, string generateSshKeys)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = generateSshKeys;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.GenerateSshKeys"/></em></p>
        ///   <p>Generate SSH public and private key files if missing. The keys will be stored in the ~/.ssh directory.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetGenerateSshKeys(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateSshKeys = null;
            return toolSettings;
        }
        #endregion
        #region KubernetesVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.KubernetesVersion"/></em></p>
        ///   <p>Version of Kubernetes to use for creating the cluster, such as "1.11.8" or "1.12.6".</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetKubernetesVersion(this AzureAksCreateSettings toolSettings, string kubernetesVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KubernetesVersion = kubernetesVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.KubernetesVersion"/></em></p>
        ///   <p>Version of Kubernetes to use for creating the cluster, such as "1.11.8" or "1.12.6".</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetKubernetesVersion(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KubernetesVersion = null;
            return toolSettings;
        }
        #endregion
        #region LoadBalancerManagedOutboundIpCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.LoadBalancerManagedOutboundIpCount"/></em></p>
        ///   <p>Load balancer managed outbound IP count.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetLoadBalancerManagedOutboundIpCount(this AzureAksCreateSettings toolSettings, string loadBalancerManagedOutboundIpCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LoadBalancerManagedOutboundIpCount = loadBalancerManagedOutboundIpCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.LoadBalancerManagedOutboundIpCount"/></em></p>
        ///   <p>Load balancer managed outbound IP count.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetLoadBalancerManagedOutboundIpCount(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LoadBalancerManagedOutboundIpCount = null;
            return toolSettings;
        }
        #endregion
        #region LoadBalancerOutboundIpPrefixes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.LoadBalancerOutboundIpPrefixes"/></em></p>
        ///   <p>Load balancer outbound IP prefix resource IDs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetLoadBalancerOutboundIpPrefixes(this AzureAksCreateSettings toolSettings, string loadBalancerOutboundIpPrefixes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LoadBalancerOutboundIpPrefixes = loadBalancerOutboundIpPrefixes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.LoadBalancerOutboundIpPrefixes"/></em></p>
        ///   <p>Load balancer outbound IP prefix resource IDs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetLoadBalancerOutboundIpPrefixes(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LoadBalancerOutboundIpPrefixes = null;
            return toolSettings;
        }
        #endregion
        #region LoadBalancerOutboundIps
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.LoadBalancerOutboundIps"/></em></p>
        ///   <p>Load balancer outbound IP resource IDs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetLoadBalancerOutboundIps(this AzureAksCreateSettings toolSettings, string loadBalancerOutboundIps)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LoadBalancerOutboundIps = loadBalancerOutboundIps;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.LoadBalancerOutboundIps"/></em></p>
        ///   <p>Load balancer outbound IP resource IDs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetLoadBalancerOutboundIps(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LoadBalancerOutboundIps = null;
            return toolSettings;
        }
        #endregion
        #region LoadBalancerSku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.LoadBalancerSku"/></em></p>
        ///   <p>Azure Load Balancer SKU selection for your cluster. basic or standard.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetLoadBalancerSku(this AzureAksCreateSettings toolSettings, string loadBalancerSku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LoadBalancerSku = loadBalancerSku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.LoadBalancerSku"/></em></p>
        ///   <p>Azure Load Balancer SKU selection for your cluster. basic or standard.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetLoadBalancerSku(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LoadBalancerSku = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetLocation(this AzureAksCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetLocation(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region MaxPods
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.MaxPods"/></em></p>
        ///   <p>The maximum number of pods deployable to a node.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetMaxPods(this AzureAksCreateSettings toolSettings, int? maxPods)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxPods = maxPods;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.MaxPods"/></em></p>
        ///   <p>The maximum number of pods deployable to a node.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetMaxPods(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxPods = null;
            return toolSettings;
        }
        #endregion
        #region NetworkPlugin
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.NetworkPlugin"/></em></p>
        ///   <p>The Kubernetes network plugin to use.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetNetworkPlugin(this AzureAksCreateSettings toolSettings, string networkPlugin)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetworkPlugin = networkPlugin;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.NetworkPlugin"/></em></p>
        ///   <p>The Kubernetes network plugin to use.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetNetworkPlugin(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetworkPlugin = null;
            return toolSettings;
        }
        #endregion
        #region NetworkPolicy
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.NetworkPolicy"/></em></p>
        ///   <p>The Kubernetes network policy to use.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetNetworkPolicy(this AzureAksCreateSettings toolSettings, string networkPolicy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetworkPolicy = networkPolicy;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.NetworkPolicy"/></em></p>
        ///   <p>The Kubernetes network policy to use.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetNetworkPolicy(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NetworkPolicy = null;
            return toolSettings;
        }
        #endregion
        #region NoSshKey
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.NoSshKey"/></em></p>
        ///   <p>Do not use or create a local SSH key.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetNoSshKey(this AzureAksCreateSettings toolSettings, bool? noSshKey)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSshKey = noSshKey;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.NoSshKey"/></em></p>
        ///   <p>Do not use or create a local SSH key.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetNoSshKey(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSshKey = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAksCreateSettings.NoSshKey"/></em></p>
        ///   <p>Do not use or create a local SSH key.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings EnableNoSshKey(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSshKey = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAksCreateSettings.NoSshKey"/></em></p>
        ///   <p>Do not use or create a local SSH key.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings DisableNoSshKey(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSshKey = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAksCreateSettings.NoSshKey"/></em></p>
        ///   <p>Do not use or create a local SSH key.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ToggleNoSshKey(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSshKey = !toolSettings.NoSshKey;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetNoWait(this AzureAksCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetNoWait(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAksCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings EnableNoWait(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAksCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings DisableNoWait(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAksCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ToggleNoWait(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region NodeCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.NodeCount"/></em></p>
        ///   <p>Number of nodes in the Kubernetes node pool. After creating a cluster, you can change the size of its node pool with `az aks scale`.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetNodeCount(this AzureAksCreateSettings toolSettings, int? nodeCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeCount = nodeCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.NodeCount"/></em></p>
        ///   <p>Number of nodes in the Kubernetes node pool. After creating a cluster, you can change the size of its node pool with `az aks scale`.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetNodeCount(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeCount = null;
            return toolSettings;
        }
        #endregion
        #region NodeOsdiskSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.NodeOsdiskSize"/></em></p>
        ///   <p>Size in GB of the OS disk for each node in the node pool. Minimum 30 GB.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetNodeOsdiskSize(this AzureAksCreateSettings toolSettings, string nodeOsdiskSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeOsdiskSize = nodeOsdiskSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.NodeOsdiskSize"/></em></p>
        ///   <p>Size in GB of the OS disk for each node in the node pool. Minimum 30 GB.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetNodeOsdiskSize(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeOsdiskSize = null;
            return toolSettings;
        }
        #endregion
        #region NodeVmSize
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.NodeVmSize"/></em></p>
        ///   <p>Size of Virtual Machines to create as Kubernetes nodes.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetNodeVmSize(this AzureAksCreateSettings toolSettings, string nodeVmSize)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeVmSize = nodeVmSize;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.NodeVmSize"/></em></p>
        ///   <p>Size of Virtual Machines to create as Kubernetes nodes.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetNodeVmSize(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeVmSize = null;
            return toolSettings;
        }
        #endregion
        #region NodepoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.NodepoolName"/></em></p>
        ///   <p>Node pool name, upto 12 alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetNodepoolName(this AzureAksCreateSettings toolSettings, string nodepoolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodepoolName = nodepoolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.NodepoolName"/></em></p>
        ///   <p>Node pool name, upto 12 alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetNodepoolName(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodepoolName = null;
            return toolSettings;
        }
        #endregion
        #region PodCidr
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.PodCidr"/></em></p>
        ///   <p>A CIDR notation IP range from which to assign pod IPs when kubenet is used.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetPodCidr(this AzureAksCreateSettings toolSettings, string podCidr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PodCidr = podCidr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.PodCidr"/></em></p>
        ///   <p>A CIDR notation IP range from which to assign pod IPs when kubenet is used.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetPodCidr(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PodCidr = null;
            return toolSettings;
        }
        #endregion
        #region ServiceCidr
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.ServiceCidr"/></em></p>
        ///   <p>A CIDR notation IP range from which to assign service cluster IPs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetServiceCidr(this AzureAksCreateSettings toolSettings, string serviceCidr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceCidr = serviceCidr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.ServiceCidr"/></em></p>
        ///   <p>A CIDR notation IP range from which to assign service cluster IPs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetServiceCidr(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServiceCidr = null;
            return toolSettings;
        }
        #endregion
        #region ServicePrincipal
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetServicePrincipal(this AzureAksCreateSettings toolSettings, bool? servicePrincipal)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = servicePrincipal;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetServicePrincipal(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAksCreateSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings EnableServicePrincipal(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAksCreateSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings DisableServicePrincipal(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAksCreateSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ToggleServicePrincipal(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = !toolSettings.ServicePrincipal;
            return toolSettings;
        }
        #endregion
        #region SkipSubnetRoleAssignment
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.SkipSubnetRoleAssignment"/></em></p>
        ///   <p>Skip role assignment for subnet (advanced networking).</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetSkipSubnetRoleAssignment(this AzureAksCreateSettings toolSettings, string skipSubnetRoleAssignment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipSubnetRoleAssignment = skipSubnetRoleAssignment;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.SkipSubnetRoleAssignment"/></em></p>
        ///   <p>Skip role assignment for subnet (advanced networking).</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetSkipSubnetRoleAssignment(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipSubnetRoleAssignment = null;
            return toolSettings;
        }
        #endregion
        #region SshKeyValue
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.SshKeyValue"/></em></p>
        ///   <p>Public key path or key contents to install on node VMs for SSH access. For example, 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm'.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetSshKeyValue(this AzureAksCreateSettings toolSettings, string sshKeyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyValue = sshKeyValue;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.SshKeyValue"/></em></p>
        ///   <p>Public key path or key contents to install on node VMs for SSH access. For example, 'ssh-rsa AAAAB...snip...UcyupgH azureuser@linuxvm'.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetSshKeyValue(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SshKeyValue = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetTags(this AzureAksCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetTags(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region VmSetType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.VmSetType"/></em></p>
        ///   <p>Agent pool vm set type. VirtualMachineScaleSets or AvailabilitySet.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetVmSetType(this AzureAksCreateSettings toolSettings, string vmSetType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSetType = vmSetType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.VmSetType"/></em></p>
        ///   <p>Agent pool vm set type. VirtualMachineScaleSets or AvailabilitySet.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetVmSetType(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VmSetType = null;
            return toolSettings;
        }
        #endregion
        #region VnetSubnetId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.VnetSubnetId"/></em></p>
        ///   <p>The ID of a subnet in an existing VNet into which to deploy the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetVnetSubnetId(this AzureAksCreateSettings toolSettings, string vnetSubnetId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetSubnetId = vnetSubnetId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.VnetSubnetId"/></em></p>
        ///   <p>The ID of a subnet in an existing VNet into which to deploy the cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetVnetSubnetId(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VnetSubnetId = null;
            return toolSettings;
        }
        #endregion
        #region WorkspaceResourceId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.WorkspaceResourceId"/></em></p>
        ///   <p>The resource ID of an existing Log Analytics Workspace to use for storing monitoring data. If not specified, uses the default Log Analytics Workspace if it exists, otherwise creates one.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetWorkspaceResourceId(this AzureAksCreateSettings toolSettings, string workspaceResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkspaceResourceId = workspaceResourceId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.WorkspaceResourceId"/></em></p>
        ///   <p>The resource ID of an existing Log Analytics Workspace to use for storing monitoring data. If not specified, uses the default Log Analytics Workspace if it exists, otherwise creates one.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetWorkspaceResourceId(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkspaceResourceId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetSubscription(this AzureAksCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetSubscription(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetDebug(this AzureAksCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetDebug(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetHelp(this AzureAksCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetHelp(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetOutput(this AzureAksCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetOutput(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetQuery(this AzureAksCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetQuery(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings SetVerbose(this AzureAksCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksCreateSettings ResetVerbose(this AzureAksCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDeleteSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings SetName(this AzureAksDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDeleteSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings ResetName(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings SetResourceGroup(this AzureAksDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings ResetResourceGroup(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings SetNoWait(this AzureAksDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings ResetNoWait(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAksDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings EnableNoWait(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAksDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings DisableNoWait(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAksDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings ToggleNoWait(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings SetYes(this AzureAksDeleteSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDeleteSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings ResetYes(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings SetSubscription(this AzureAksDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings ResetSubscription(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings SetDebug(this AzureAksDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings ResetDebug(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings SetHelp(this AzureAksDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings ResetHelp(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings SetOutput(this AzureAksDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings ResetOutput(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings SetQuery(this AzureAksDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings ResetQuery(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings SetVerbose(this AzureAksDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksDeleteSettings ResetVerbose(this AzureAksDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksDisableAddonsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksDisableAddonsSettingsExtensions
    {
        #region Addons
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDisableAddonsSettings.Addons"/> to a new list</em></p>
        ///   <p>Disable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetAddons(this AzureAksDisableAddonsSettings toolSettings, params string[] addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal = addons.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDisableAddonsSettings.Addons"/> to a new list</em></p>
        ///   <p>Disable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetAddons(this AzureAksDisableAddonsSettings toolSettings, IEnumerable<string> addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal = addons.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAksDisableAddonsSettings.Addons"/></em></p>
        ///   <p>Disable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings AddAddons(this AzureAksDisableAddonsSettings toolSettings, params string[] addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal.AddRange(addons);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAksDisableAddonsSettings.Addons"/></em></p>
        ///   <p>Disable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings AddAddons(this AzureAksDisableAddonsSettings toolSettings, IEnumerable<string> addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal.AddRange(addons);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAksDisableAddonsSettings.Addons"/></em></p>
        ///   <p>Disable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ClearAddons(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAksDisableAddonsSettings.Addons"/></em></p>
        ///   <p>Disable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings RemoveAddons(this AzureAksDisableAddonsSettings toolSettings, params string[] addons)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(addons);
            toolSettings.AddonsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAksDisableAddonsSettings.Addons"/></em></p>
        ///   <p>Disable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings RemoveAddons(this AzureAksDisableAddonsSettings toolSettings, IEnumerable<string> addons)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(addons);
            toolSettings.AddonsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDisableAddonsSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetName(this AzureAksDisableAddonsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDisableAddonsSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetName(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDisableAddonsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetResourceGroup(this AzureAksDisableAddonsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDisableAddonsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetResourceGroup(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDisableAddonsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetNoWait(this AzureAksDisableAddonsSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDisableAddonsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetNoWait(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAksDisableAddonsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings EnableNoWait(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAksDisableAddonsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings DisableNoWait(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAksDisableAddonsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ToggleNoWait(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDisableAddonsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetSubscription(this AzureAksDisableAddonsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDisableAddonsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetSubscription(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDisableAddonsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetDebug(this AzureAksDisableAddonsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDisableAddonsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetDebug(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDisableAddonsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetHelp(this AzureAksDisableAddonsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDisableAddonsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetHelp(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDisableAddonsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetOutput(this AzureAksDisableAddonsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDisableAddonsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetOutput(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDisableAddonsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetQuery(this AzureAksDisableAddonsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDisableAddonsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetQuery(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksDisableAddonsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings SetVerbose(this AzureAksDisableAddonsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksDisableAddonsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksDisableAddonsSettings ResetVerbose(this AzureAksDisableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksEnableAddonsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksEnableAddonsSettingsExtensions
    {
        #region Addons
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksEnableAddonsSettings.Addons"/> to a new list</em></p>
        ///   <p>Enable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetAddons(this AzureAksEnableAddonsSettings toolSettings, params string[] addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal = addons.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksEnableAddonsSettings.Addons"/> to a new list</em></p>
        ///   <p>Enable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetAddons(this AzureAksEnableAddonsSettings toolSettings, IEnumerable<string> addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal = addons.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAksEnableAddonsSettings.Addons"/></em></p>
        ///   <p>Enable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings AddAddons(this AzureAksEnableAddonsSettings toolSettings, params string[] addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal.AddRange(addons);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureAksEnableAddonsSettings.Addons"/></em></p>
        ///   <p>Enable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings AddAddons(this AzureAksEnableAddonsSettings toolSettings, IEnumerable<string> addons)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal.AddRange(addons);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureAksEnableAddonsSettings.Addons"/></em></p>
        ///   <p>Enable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ClearAddons(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddonsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAksEnableAddonsSettings.Addons"/></em></p>
        ///   <p>Enable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings RemoveAddons(this AzureAksEnableAddonsSettings toolSettings, params string[] addons)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(addons);
            toolSettings.AddonsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureAksEnableAddonsSettings.Addons"/></em></p>
        ///   <p>Enable the Kubernetes addons in a comma-separated list.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings RemoveAddons(this AzureAksEnableAddonsSettings toolSettings, IEnumerable<string> addons)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(addons);
            toolSettings.AddonsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksEnableAddonsSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetName(this AzureAksEnableAddonsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksEnableAddonsSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetName(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksEnableAddonsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetResourceGroup(this AzureAksEnableAddonsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksEnableAddonsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetResourceGroup(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksEnableAddonsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetNoWait(this AzureAksEnableAddonsSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksEnableAddonsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetNoWait(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAksEnableAddonsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings EnableNoWait(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAksEnableAddonsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings DisableNoWait(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAksEnableAddonsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ToggleNoWait(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region SubnetName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksEnableAddonsSettings.SubnetName"/></em></p>
        ///   <p>Name of an existing subnet to use with the virtual-node add-on.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetSubnetName(this AzureAksEnableAddonsSettings toolSettings, string subnetName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetName = subnetName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksEnableAddonsSettings.SubnetName"/></em></p>
        ///   <p>Name of an existing subnet to use with the virtual-node add-on.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetSubnetName(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SubnetName = null;
            return toolSettings;
        }
        #endregion
        #region WorkspaceResourceId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksEnableAddonsSettings.WorkspaceResourceId"/></em></p>
        ///   <p>The resource ID of an existing Log Analytics Workspace to use for storing monitoring data.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetWorkspaceResourceId(this AzureAksEnableAddonsSettings toolSettings, string workspaceResourceId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkspaceResourceId = workspaceResourceId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksEnableAddonsSettings.WorkspaceResourceId"/></em></p>
        ///   <p>The resource ID of an existing Log Analytics Workspace to use for storing monitoring data.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetWorkspaceResourceId(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WorkspaceResourceId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksEnableAddonsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetSubscription(this AzureAksEnableAddonsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksEnableAddonsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetSubscription(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksEnableAddonsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetDebug(this AzureAksEnableAddonsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksEnableAddonsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetDebug(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksEnableAddonsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetHelp(this AzureAksEnableAddonsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksEnableAddonsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetHelp(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksEnableAddonsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetOutput(this AzureAksEnableAddonsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksEnableAddonsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetOutput(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksEnableAddonsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetQuery(this AzureAksEnableAddonsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksEnableAddonsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetQuery(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksEnableAddonsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings SetVerbose(this AzureAksEnableAddonsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksEnableAddonsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksEnableAddonsSettings ResetVerbose(this AzureAksEnableAddonsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksGetCredentialsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksGetCredentialsSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetCredentialsSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetName(this AzureAksGetCredentialsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetCredentialsSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetName(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetCredentialsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetResourceGroup(this AzureAksGetCredentialsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetCredentialsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetResourceGroup(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Admin
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetCredentialsSettings.Admin"/></em></p>
        ///   <p>Get cluster administrator credentials.  Default: cluster user credentials.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetAdmin(this AzureAksGetCredentialsSettings toolSettings, string admin)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Admin = admin;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetCredentialsSettings.Admin"/></em></p>
        ///   <p>Get cluster administrator credentials.  Default: cluster user credentials.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetAdmin(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Admin = null;
            return toolSettings;
        }
        #endregion
        #region Context
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetCredentialsSettings.Context"/></em></p>
        ///   <p>If specified, overwrite the default context name.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetContext(this AzureAksGetCredentialsSettings toolSettings, string context)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Context = context;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetCredentialsSettings.Context"/></em></p>
        ///   <p>If specified, overwrite the default context name.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetContext(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Context = null;
            return toolSettings;
        }
        #endregion
        #region File
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetCredentialsSettings.File"/></em></p>
        ///   <p>Kubernetes configuration file to update. Use "-" to print YAML to stdout instead.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetFile(this AzureAksGetCredentialsSettings toolSettings, string file)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetCredentialsSettings.File"/></em></p>
        ///   <p>Kubernetes configuration file to update. Use "-" to print YAML to stdout instead.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetFile(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region OverwriteExisting
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetCredentialsSettings.OverwriteExisting"/></em></p>
        ///   <p>Overwrite any existing cluster entry with the same name.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetOverwriteExisting(this AzureAksGetCredentialsSettings toolSettings, string overwriteExisting)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OverwriteExisting = overwriteExisting;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetCredentialsSettings.OverwriteExisting"/></em></p>
        ///   <p>Overwrite any existing cluster entry with the same name.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetOverwriteExisting(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OverwriteExisting = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetCredentialsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetSubscription(this AzureAksGetCredentialsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetCredentialsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetSubscription(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetCredentialsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetDebug(this AzureAksGetCredentialsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetCredentialsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetDebug(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetCredentialsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetHelp(this AzureAksGetCredentialsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetCredentialsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetHelp(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetCredentialsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetOutput(this AzureAksGetCredentialsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetCredentialsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetOutput(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetCredentialsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetQuery(this AzureAksGetCredentialsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetCredentialsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetQuery(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetCredentialsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings SetVerbose(this AzureAksGetCredentialsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetCredentialsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetCredentialsSettings ResetVerbose(this AzureAksGetCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksGetUpgradesSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksGetUpgradesSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetUpgradesSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetName(this AzureAksGetUpgradesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetUpgradesSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetName(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetUpgradesSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetResourceGroup(this AzureAksGetUpgradesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetUpgradesSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetResourceGroup(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetUpgradesSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetSubscription(this AzureAksGetUpgradesSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetUpgradesSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetSubscription(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetUpgradesSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetDebug(this AzureAksGetUpgradesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetUpgradesSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetDebug(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetUpgradesSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetHelp(this AzureAksGetUpgradesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetUpgradesSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetHelp(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetUpgradesSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetOutput(this AzureAksGetUpgradesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetUpgradesSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetOutput(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetUpgradesSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetQuery(this AzureAksGetUpgradesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetUpgradesSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetQuery(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetUpgradesSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings SetVerbose(this AzureAksGetUpgradesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetUpgradesSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetUpgradesSettings ResetVerbose(this AzureAksGetUpgradesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksGetVersionsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksGetVersionsSettingsExtensions
    {
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetVersionsSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetVersionsSettings SetLocation(this AzureAksGetVersionsSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetVersionsSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetVersionsSettings ResetLocation(this AzureAksGetVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetVersionsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetVersionsSettings SetSubscription(this AzureAksGetVersionsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetVersionsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetVersionsSettings ResetSubscription(this AzureAksGetVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetVersionsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetVersionsSettings SetDebug(this AzureAksGetVersionsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetVersionsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetVersionsSettings ResetDebug(this AzureAksGetVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetVersionsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetVersionsSettings SetHelp(this AzureAksGetVersionsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetVersionsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetVersionsSettings ResetHelp(this AzureAksGetVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetVersionsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetVersionsSettings SetOutput(this AzureAksGetVersionsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetVersionsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetVersionsSettings ResetOutput(this AzureAksGetVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetVersionsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetVersionsSettings SetQuery(this AzureAksGetVersionsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetVersionsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetVersionsSettings ResetQuery(this AzureAksGetVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksGetVersionsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetVersionsSettings SetVerbose(this AzureAksGetVersionsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksGetVersionsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksGetVersionsSettings ResetVerbose(this AzureAksGetVersionsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksInstallCliSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksInstallCliSettingsExtensions
    {
        #region ClientVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallCliSettings.ClientVersion"/></em></p>
        ///   <p>Version of the client to install.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings SetClientVersion(this AzureAksInstallCliSettings toolSettings, string clientVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientVersion = clientVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallCliSettings.ClientVersion"/></em></p>
        ///   <p>Version of the client to install.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetClientVersion(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientVersion = null;
            return toolSettings;
        }
        #endregion
        #region InstallLocation
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallCliSettings.InstallLocation"/></em></p>
        ///   <p>Path at which to install DC/OS.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings SetInstallLocation(this AzureAksInstallCliSettings toolSettings, string installLocation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallLocation = installLocation;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallCliSettings.InstallLocation"/></em></p>
        ///   <p>Path at which to install DC/OS.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetInstallLocation(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InstallLocation = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallCliSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings SetSubscription(this AzureAksInstallCliSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallCliSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetSubscription(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallCliSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings SetDebug(this AzureAksInstallCliSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallCliSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetDebug(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallCliSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings SetHelp(this AzureAksInstallCliSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallCliSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetHelp(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallCliSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings SetOutput(this AzureAksInstallCliSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallCliSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetOutput(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallCliSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings SetQuery(this AzureAksInstallCliSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallCliSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetQuery(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallCliSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings SetVerbose(this AzureAksInstallCliSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallCliSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallCliSettings ResetVerbose(this AzureAksInstallCliSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksInstallConnectorSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksInstallConnectorSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetName(this AzureAksInstallConnectorSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetName(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetResourceGroup(this AzureAksInstallConnectorSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetResourceGroup(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AciResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.AciResourceGroup"/></em></p>
        ///   <p>The resource group to create the ACI container groups. Use the MC_\* resource group if it is not specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetAciResourceGroup(this AzureAksInstallConnectorSettings toolSettings, string aciResourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AciResourceGroup = aciResourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.AciResourceGroup"/></em></p>
        ///   <p>The resource group to create the ACI container groups. Use the MC_\* resource group if it is not specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetAciResourceGroup(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AciResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ChartUrl
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.ChartUrl"/></em></p>
        ///   <p>URL of a Helm chart that installs ACI Connector.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetChartUrl(this AzureAksInstallConnectorSettings toolSettings, string chartUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartUrl = chartUrl;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.ChartUrl"/></em></p>
        ///   <p>URL of a Helm chart that installs ACI Connector.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetChartUrl(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartUrl = null;
            return toolSettings;
        }
        #endregion
        #region ClientSecret
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.ClientSecret"/></em></p>
        ///   <p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetClientSecret(this AzureAksInstallConnectorSettings toolSettings, string clientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = clientSecret;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.ClientSecret"/></em></p>
        ///   <p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetClientSecret(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region ConnectorName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.ConnectorName"/></em></p>
        ///   <p>Name of the ACI Connector.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetConnectorName(this AzureAksInstallConnectorSettings toolSettings, string connectorName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectorName = connectorName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.ConnectorName"/></em></p>
        ///   <p>Name of the ACI Connector.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetConnectorName(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectorName = null;
            return toolSettings;
        }
        #endregion
        #region ImageTag
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.ImageTag"/></em></p>
        ///   <p>The image tag of the virtual kubelet. Use 'latest' if it is not specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetImageTag(this AzureAksInstallConnectorSettings toolSettings, string imageTag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImageTag = imageTag;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.ImageTag"/></em></p>
        ///   <p>The image tag of the virtual kubelet. Use 'latest' if it is not specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetImageTag(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImageTag = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.Location"/></em></p>
        ///   <p>The location to create the ACI container groups. Use the location of the MC_\* resource group if it is not specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetLocation(this AzureAksInstallConnectorSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.Location"/></em></p>
        ///   <p>The location to create the ACI container groups. Use the location of the MC_\* resource group if it is not specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetLocation(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.OsType"/></em></p>
        ///   <p>Install support for deploying ACIs of this operating system type.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetOsType(this AzureAksInstallConnectorSettings toolSettings, AksOsType osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.OsType"/></em></p>
        ///   <p>Install support for deploying ACIs of this operating system type.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetOsType(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region ServicePrincipal
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetServicePrincipal(this AzureAksInstallConnectorSettings toolSettings, bool? servicePrincipal)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = servicePrincipal;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetServicePrincipal(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAksInstallConnectorSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings EnableServicePrincipal(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAksInstallConnectorSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings DisableServicePrincipal(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAksInstallConnectorSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ToggleServicePrincipal(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = !toolSettings.ServicePrincipal;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetSubscription(this AzureAksInstallConnectorSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetSubscription(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetDebug(this AzureAksInstallConnectorSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetDebug(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetHelp(this AzureAksInstallConnectorSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetHelp(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetOutput(this AzureAksInstallConnectorSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetOutput(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetQuery(this AzureAksInstallConnectorSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetQuery(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksInstallConnectorSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings SetVerbose(this AzureAksInstallConnectorSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksInstallConnectorSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksInstallConnectorSettings ResetVerbose(this AzureAksInstallConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksListSettings SetResourceGroup(this AzureAksListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksListSettings ResetResourceGroup(this AzureAksListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksListSettings SetSubscription(this AzureAksListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksListSettings ResetSubscription(this AzureAksListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksListSettings SetDebug(this AzureAksListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksListSettings ResetDebug(this AzureAksListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksListSettings SetHelp(this AzureAksListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksListSettings ResetHelp(this AzureAksListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksListSettings SetOutput(this AzureAksListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksListSettings ResetOutput(this AzureAksListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksListSettings SetQuery(this AzureAksListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksListSettings ResetQuery(this AzureAksListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksListSettings SetVerbose(this AzureAksListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksListSettings ResetVerbose(this AzureAksListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksRemoveConnectorSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksRemoveConnectorSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetName(this AzureAksRemoveConnectorSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetName(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveConnectorSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetResourceGroup(this AzureAksRemoveConnectorSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveConnectorSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetResourceGroup(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ConnectorName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveConnectorSettings.ConnectorName"/></em></p>
        ///   <p>Name of the ACI Connector.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetConnectorName(this AzureAksRemoveConnectorSettings toolSettings, string connectorName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectorName = connectorName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveConnectorSettings.ConnectorName"/></em></p>
        ///   <p>Name of the ACI Connector.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetConnectorName(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectorName = null;
            return toolSettings;
        }
        #endregion
        #region Graceful
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Graceful"/></em></p>
        ///   <p>Use a "cordon and drain" strategy to evict pods safely before removing the ACI node.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetGraceful(this AzureAksRemoveConnectorSettings toolSettings, string graceful)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Graceful = graceful;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Graceful"/></em></p>
        ///   <p>Use a "cordon and drain" strategy to evict pods safely before removing the ACI node.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetGraceful(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Graceful = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetLocation(this AzureAksRemoveConnectorSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetLocation(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveConnectorSettings.OsType"/></em></p>
        ///   <p>Remove support for deploying ACIs of this operating system type.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetOsType(this AzureAksRemoveConnectorSettings toolSettings, AksOsType osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveConnectorSettings.OsType"/></em></p>
        ///   <p>Remove support for deploying ACIs of this operating system type.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetOsType(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetSubscription(this AzureAksRemoveConnectorSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetSubscription(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetDebug(this AzureAksRemoveConnectorSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetDebug(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetHelp(this AzureAksRemoveConnectorSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetHelp(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetOutput(this AzureAksRemoveConnectorSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetOutput(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetQuery(this AzureAksRemoveConnectorSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetQuery(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveConnectorSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings SetVerbose(this AzureAksRemoveConnectorSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveConnectorSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveConnectorSettings ResetVerbose(this AzureAksRemoveConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksRemoveDevSpacesSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksRemoveDevSpacesSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetName(this AzureAksRemoveDevSpacesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetName(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetResourceGroup(this AzureAksRemoveDevSpacesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetResourceGroup(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetYes(this AzureAksRemoveDevSpacesSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetYes(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetSubscription(this AzureAksRemoveDevSpacesSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetSubscription(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetDebug(this AzureAksRemoveDevSpacesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetDebug(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetHelp(this AzureAksRemoveDevSpacesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetHelp(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetOutput(this AzureAksRemoveDevSpacesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetOutput(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetQuery(this AzureAksRemoveDevSpacesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetQuery(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksRemoveDevSpacesSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings SetVerbose(this AzureAksRemoveDevSpacesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksRemoveDevSpacesSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksRemoveDevSpacesSettings ResetVerbose(this AzureAksRemoveDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksScaleSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksScaleSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksScaleSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings SetName(this AzureAksScaleSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksScaleSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings ResetName(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region NodeCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksScaleSettings.NodeCount"/></em></p>
        ///   <p>Number of nodes in the Kubernetes node pool.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings SetNodeCount(this AzureAksScaleSettings toolSettings, int? nodeCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeCount = nodeCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksScaleSettings.NodeCount"/></em></p>
        ///   <p>Number of nodes in the Kubernetes node pool.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings ResetNodeCount(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodeCount = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksScaleSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings SetResourceGroup(this AzureAksScaleSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksScaleSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings ResetResourceGroup(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksScaleSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings SetNoWait(this AzureAksScaleSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksScaleSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings ResetNoWait(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAksScaleSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings EnableNoWait(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAksScaleSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings DisableNoWait(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAksScaleSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings ToggleNoWait(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region NodepoolName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksScaleSettings.NodepoolName"/></em></p>
        ///   <p>Node pool name, upto 12 alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings SetNodepoolName(this AzureAksScaleSettings toolSettings, string nodepoolName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodepoolName = nodepoolName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksScaleSettings.NodepoolName"/></em></p>
        ///   <p>Node pool name, upto 12 alphanumeric characters.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings ResetNodepoolName(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NodepoolName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksScaleSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings SetSubscription(this AzureAksScaleSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksScaleSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings ResetSubscription(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksScaleSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings SetDebug(this AzureAksScaleSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksScaleSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings ResetDebug(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksScaleSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings SetHelp(this AzureAksScaleSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksScaleSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings ResetHelp(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksScaleSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings SetOutput(this AzureAksScaleSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksScaleSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings ResetOutput(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksScaleSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings SetQuery(this AzureAksScaleSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksScaleSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings ResetQuery(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksScaleSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings SetVerbose(this AzureAksScaleSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksScaleSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksScaleSettings ResetVerbose(this AzureAksScaleSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksShowSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings SetName(this AzureAksShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksShowSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings ResetName(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings SetResourceGroup(this AzureAksShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings ResetResourceGroup(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings SetSubscription(this AzureAksShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings ResetSubscription(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings SetDebug(this AzureAksShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings ResetDebug(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings SetHelp(this AzureAksShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings ResetHelp(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings SetOutput(this AzureAksShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings ResetOutput(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings SetQuery(this AzureAksShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings ResetQuery(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings SetVerbose(this AzureAksShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksShowSettings ResetVerbose(this AzureAksShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksUpdateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings SetName(this AzureAksUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ResetName(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings SetResourceGroup(this AzureAksUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ResetResourceGroup(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AttachAcr
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateSettings.AttachAcr"/></em></p>
        ///   <p>Grant the 'acrpull' role assignment to the ACR specified by name or resource ID.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings SetAttachAcr(this AzureAksUpdateSettings toolSettings, string attachAcr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AttachAcr = attachAcr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateSettings.AttachAcr"/></em></p>
        ///   <p>Grant the 'acrpull' role assignment to the ACR specified by name or resource ID.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ResetAttachAcr(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AttachAcr = null;
            return toolSettings;
        }
        #endregion
        #region DetachAcr
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateSettings.DetachAcr"/></em></p>
        ///   <p>Disable the 'acrpull' role assignment to the ACR specified by name or resource ID.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings SetDetachAcr(this AzureAksUpdateSettings toolSettings, string detachAcr)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DetachAcr = detachAcr;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateSettings.DetachAcr"/></em></p>
        ///   <p>Disable the 'acrpull' role assignment to the ACR specified by name or resource ID.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ResetDetachAcr(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DetachAcr = null;
            return toolSettings;
        }
        #endregion
        #region LoadBalancerManagedOutboundIpCount
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateSettings.LoadBalancerManagedOutboundIpCount"/></em></p>
        ///   <p>Load balancer managed outbound IP count.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings SetLoadBalancerManagedOutboundIpCount(this AzureAksUpdateSettings toolSettings, string loadBalancerManagedOutboundIpCount)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LoadBalancerManagedOutboundIpCount = loadBalancerManagedOutboundIpCount;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateSettings.LoadBalancerManagedOutboundIpCount"/></em></p>
        ///   <p>Load balancer managed outbound IP count.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ResetLoadBalancerManagedOutboundIpCount(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LoadBalancerManagedOutboundIpCount = null;
            return toolSettings;
        }
        #endregion
        #region LoadBalancerOutboundIpPrefixes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateSettings.LoadBalancerOutboundIpPrefixes"/></em></p>
        ///   <p>Load balancer outbound IP prefix resource IDs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings SetLoadBalancerOutboundIpPrefixes(this AzureAksUpdateSettings toolSettings, string loadBalancerOutboundIpPrefixes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LoadBalancerOutboundIpPrefixes = loadBalancerOutboundIpPrefixes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateSettings.LoadBalancerOutboundIpPrefixes"/></em></p>
        ///   <p>Load balancer outbound IP prefix resource IDs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ResetLoadBalancerOutboundIpPrefixes(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LoadBalancerOutboundIpPrefixes = null;
            return toolSettings;
        }
        #endregion
        #region LoadBalancerOutboundIps
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateSettings.LoadBalancerOutboundIps"/></em></p>
        ///   <p>Load balancer outbound IP resource IDs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings SetLoadBalancerOutboundIps(this AzureAksUpdateSettings toolSettings, string loadBalancerOutboundIps)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LoadBalancerOutboundIps = loadBalancerOutboundIps;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateSettings.LoadBalancerOutboundIps"/></em></p>
        ///   <p>Load balancer outbound IP resource IDs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ResetLoadBalancerOutboundIps(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LoadBalancerOutboundIps = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings SetNoWait(this AzureAksUpdateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ResetNoWait(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAksUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings EnableNoWait(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAksUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings DisableNoWait(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAksUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ToggleNoWait(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings SetSubscription(this AzureAksUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ResetSubscription(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings SetDebug(this AzureAksUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ResetDebug(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings SetHelp(this AzureAksUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ResetHelp(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings SetOutput(this AzureAksUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ResetOutput(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings SetQuery(this AzureAksUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ResetQuery(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings SetVerbose(this AzureAksUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateSettings ResetVerbose(this AzureAksUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksUpdateCredentialsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksUpdateCredentialsSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetName(this AzureAksUpdateCredentialsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetName(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetResourceGroup(this AzureAksUpdateCredentialsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetResourceGroup(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetNoWait(this AzureAksUpdateCredentialsSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetNoWait(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAksUpdateCredentialsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings EnableNoWait(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAksUpdateCredentialsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings DisableNoWait(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAksUpdateCredentialsSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ToggleNoWait(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region AadClientAppId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.AadClientAppId"/></em></p>
        ///   <p>The ID of an Azure Active Directory client application. This argument is required if `--reset-aad` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetAadClientAppId(this AzureAksUpdateCredentialsSettings toolSettings, string aadClientAppId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientAppId = aadClientAppId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.AadClientAppId"/></em></p>
        ///   <p>The ID of an Azure Active Directory client application. This argument is required if `--reset-aad` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetAadClientAppId(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadClientAppId = null;
            return toolSettings;
        }
        #endregion
        #region AadServerAppId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.AadServerAppId"/></em></p>
        ///   <p>The ID of an Azure Active Directory server application. This argument is required if `--reset-aad` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetAadServerAppId(this AzureAksUpdateCredentialsSettings toolSettings, string aadServerAppId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadServerAppId = aadServerAppId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.AadServerAppId"/></em></p>
        ///   <p>The ID of an Azure Active Directory server application. This argument is required if `--reset-aad` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetAadServerAppId(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadServerAppId = null;
            return toolSettings;
        }
        #endregion
        #region AadServerAppSecret
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.AadServerAppSecret"/></em></p>
        ///   <p>The secret of an Azure Active Directory server application. This argument is required if `--reset-aad` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetAadServerAppSecret(this AzureAksUpdateCredentialsSettings toolSettings, string aadServerAppSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadServerAppSecret = aadServerAppSecret;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.AadServerAppSecret"/></em></p>
        ///   <p>The secret of an Azure Active Directory server application. This argument is required if `--reset-aad` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetAadServerAppSecret(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadServerAppSecret = null;
            return toolSettings;
        }
        #endregion
        #region AadTenantId
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.AadTenantId"/></em></p>
        ///   <p>Tenant ID associated with Azure Active Directory.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetAadTenantId(this AzureAksUpdateCredentialsSettings toolSettings, string aadTenantId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadTenantId = aadTenantId;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.AadTenantId"/></em></p>
        ///   <p>Tenant ID associated with Azure Active Directory.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetAadTenantId(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AadTenantId = null;
            return toolSettings;
        }
        #endregion
        #region ResetAad
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.ResetAad"/></em></p>
        ///   <p>Reset Azure Active Directory configuration for a managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetResetAad(this AzureAksUpdateCredentialsSettings toolSettings, string resetAad)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResetAad = resetAad;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.ResetAad"/></em></p>
        ///   <p>Reset Azure Active Directory configuration for a managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetResetAad(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResetAad = null;
            return toolSettings;
        }
        #endregion
        #region ClientSecret
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.ClientSecret"/></em></p>
        ///   <p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetClientSecret(this AzureAksUpdateCredentialsSettings toolSettings, string clientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = clientSecret;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.ClientSecret"/></em></p>
        ///   <p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetClientSecret(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region ResetServicePrincipal
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.ResetServicePrincipal"/></em></p>
        ///   <p>Reset service principal for a managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetResetServicePrincipal(this AzureAksUpdateCredentialsSettings toolSettings, string resetServicePrincipal)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResetServicePrincipal = resetServicePrincipal;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.ResetServicePrincipal"/></em></p>
        ///   <p>Reset service principal for a managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetResetServicePrincipal(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResetServicePrincipal = null;
            return toolSettings;
        }
        #endregion
        #region ServicePrincipal
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs. This argument is required if `--reset-service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetServicePrincipal(this AzureAksUpdateCredentialsSettings toolSettings, bool? servicePrincipal)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = servicePrincipal;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs. This argument is required if `--reset-service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetServicePrincipal(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAksUpdateCredentialsSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs. This argument is required if `--reset-service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings EnableServicePrincipal(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAksUpdateCredentialsSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs. This argument is required if `--reset-service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings DisableServicePrincipal(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAksUpdateCredentialsSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs. This argument is required if `--reset-service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ToggleServicePrincipal(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = !toolSettings.ServicePrincipal;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetSubscription(this AzureAksUpdateCredentialsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetSubscription(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetDebug(this AzureAksUpdateCredentialsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetDebug(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetHelp(this AzureAksUpdateCredentialsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetHelp(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetOutput(this AzureAksUpdateCredentialsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetOutput(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetQuery(this AzureAksUpdateCredentialsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetQuery(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpdateCredentialsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings SetVerbose(this AzureAksUpdateCredentialsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpdateCredentialsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpdateCredentialsSettings ResetVerbose(this AzureAksUpdateCredentialsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksUpgradeSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksUpgradeSettingsExtensions
    {
        #region KubernetesVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeSettings.KubernetesVersion"/></em></p>
        ///   <p>Version of Kubernetes to upgrade the cluster to, such as "1.11.8" or "1.12.6".</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings SetKubernetesVersion(this AzureAksUpgradeSettings toolSettings, string kubernetesVersion)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KubernetesVersion = kubernetesVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeSettings.KubernetesVersion"/></em></p>
        ///   <p>Version of Kubernetes to upgrade the cluster to, such as "1.11.8" or "1.12.6".</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetKubernetesVersion(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KubernetesVersion = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings SetName(this AzureAksUpgradeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetName(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings SetResourceGroup(this AzureAksUpgradeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetResourceGroup(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ControlPlaneOnly
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeSettings.ControlPlaneOnly"/></em></p>
        ///   <p>Upgrade the cluster control plane only. If not specified, both control plane AND all node pools will be upgraded.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings SetControlPlaneOnly(this AzureAksUpgradeSettings toolSettings, string controlPlaneOnly)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ControlPlaneOnly = controlPlaneOnly;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeSettings.ControlPlaneOnly"/></em></p>
        ///   <p>Upgrade the cluster control plane only. If not specified, both control plane AND all node pools will be upgraded.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetControlPlaneOnly(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ControlPlaneOnly = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings SetNoWait(this AzureAksUpgradeSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetNoWait(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAksUpgradeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings EnableNoWait(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAksUpgradeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings DisableNoWait(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAksUpgradeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings ToggleNoWait(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings SetYes(this AzureAksUpgradeSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetYes(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings SetSubscription(this AzureAksUpgradeSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetSubscription(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings SetDebug(this AzureAksUpgradeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetDebug(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings SetHelp(this AzureAksUpgradeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetHelp(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings SetOutput(this AzureAksUpgradeSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetOutput(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings SetQuery(this AzureAksUpgradeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetQuery(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings SetVerbose(this AzureAksUpgradeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeSettings ResetVerbose(this AzureAksUpgradeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksUpgradeConnectorSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksUpgradeConnectorSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetName(this AzureAksUpgradeConnectorSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetName(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetResourceGroup(this AzureAksUpgradeConnectorSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetResourceGroup(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AciResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.AciResourceGroup"/></em></p>
        ///   <p>The resource group to create the ACI container groups. Use the MC_\* resource group if it is not specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetAciResourceGroup(this AzureAksUpgradeConnectorSettings toolSettings, string aciResourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AciResourceGroup = aciResourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.AciResourceGroup"/></em></p>
        ///   <p>The resource group to create the ACI container groups. Use the MC_\* resource group if it is not specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetAciResourceGroup(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AciResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ChartUrl
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.ChartUrl"/></em></p>
        ///   <p>URL of a Helm chart that installs ACI Connector.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetChartUrl(this AzureAksUpgradeConnectorSettings toolSettings, string chartUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartUrl = chartUrl;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.ChartUrl"/></em></p>
        ///   <p>URL of a Helm chart that installs ACI Connector.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetChartUrl(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ChartUrl = null;
            return toolSettings;
        }
        #endregion
        #region ClientSecret
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.ClientSecret"/></em></p>
        ///   <p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetClientSecret(this AzureAksUpgradeConnectorSettings toolSettings, string clientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = clientSecret;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.ClientSecret"/></em></p>
        ///   <p>Secret associated with the service principal. This argument is required if `--service-principal` is specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetClientSecret(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region ConnectorName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.ConnectorName"/></em></p>
        ///   <p>Name of the ACI Connector.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetConnectorName(this AzureAksUpgradeConnectorSettings toolSettings, string connectorName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectorName = connectorName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.ConnectorName"/></em></p>
        ///   <p>Name of the ACI Connector.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetConnectorName(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ConnectorName = null;
            return toolSettings;
        }
        #endregion
        #region ImageTag
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.ImageTag"/></em></p>
        ///   <p>The image tag of the virtual kubelet. Use 'latest' if it is not specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetImageTag(this AzureAksUpgradeConnectorSettings toolSettings, string imageTag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImageTag = imageTag;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.ImageTag"/></em></p>
        ///   <p>The image tag of the virtual kubelet. Use 'latest' if it is not specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetImageTag(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImageTag = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Location"/></em></p>
        ///   <p>The location to create the ACI container groups. Use the location of the MC_\* resource group if it is not specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetLocation(this AzureAksUpgradeConnectorSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Location"/></em></p>
        ///   <p>The location to create the ACI container groups. Use the location of the MC_\* resource group if it is not specified.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetLocation(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region OsType
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.OsType"/></em></p>
        ///   <p>Install support for deploying ACIs of this operating system type.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetOsType(this AzureAksUpgradeConnectorSettings toolSettings, AksOsType osType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = osType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.OsType"/></em></p>
        ///   <p>Install support for deploying ACIs of this operating system type.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetOsType(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OsType = null;
            return toolSettings;
        }
        #endregion
        #region ServicePrincipal
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetServicePrincipal(this AzureAksUpgradeConnectorSettings toolSettings, bool? servicePrincipal)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = servicePrincipal;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetServicePrincipal(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureAksUpgradeConnectorSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings EnableServicePrincipal(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureAksUpgradeConnectorSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings DisableServicePrincipal(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureAksUpgradeConnectorSettings.ServicePrincipal"/></em></p>
        ///   <p>Service principal used for authentication to Azure APIs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ToggleServicePrincipal(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ServicePrincipal = !toolSettings.ServicePrincipal;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetSubscription(this AzureAksUpgradeConnectorSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetSubscription(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetDebug(this AzureAksUpgradeConnectorSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetDebug(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetHelp(this AzureAksUpgradeConnectorSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetHelp(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetOutput(this AzureAksUpgradeConnectorSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetOutput(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetQuery(this AzureAksUpgradeConnectorSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetQuery(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUpgradeConnectorSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings SetVerbose(this AzureAksUpgradeConnectorSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUpgradeConnectorSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUpgradeConnectorSettings ResetVerbose(this AzureAksUpgradeConnectorSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksUseDevSpacesSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksUseDevSpacesSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetName(this AzureAksUseDevSpacesSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetName(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUseDevSpacesSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetResourceGroup(this AzureAksUseDevSpacesSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUseDevSpacesSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetResourceGroup(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Space
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Space"/></em></p>
        ///   <p>Name of the new or existing dev space to select. Defaults to an interactive selection experience.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetSpace(this AzureAksUseDevSpacesSettings toolSettings, string space)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Space = space;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Space"/></em></p>
        ///   <p>Name of the new or existing dev space to select. Defaults to an interactive selection experience.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetSpace(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Space = null;
            return toolSettings;
        }
        #endregion
        #region Update
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Update"/></em></p>
        ///   <p>Update to the latest Azure Dev Spaces client components.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetUpdate(this AzureAksUseDevSpacesSettings toolSettings, string update)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Update = update;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Update"/></em></p>
        ///   <p>Update to the latest Azure Dev Spaces client components.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetUpdate(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Update = null;
            return toolSettings;
        }
        #endregion
        #region Yes
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation. Requires --space.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetYes(this AzureAksUseDevSpacesSettings toolSettings, string yes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = yes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Yes"/></em></p>
        ///   <p>Do not prompt for confirmation. Requires --space.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetYes(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Yes = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetSubscription(this AzureAksUseDevSpacesSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetSubscription(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetDebug(this AzureAksUseDevSpacesSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetDebug(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetHelp(this AzureAksUseDevSpacesSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetHelp(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetOutput(this AzureAksUseDevSpacesSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetOutput(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetQuery(this AzureAksUseDevSpacesSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetQuery(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksUseDevSpacesSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings SetVerbose(this AzureAksUseDevSpacesSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksUseDevSpacesSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksUseDevSpacesSettings ResetVerbose(this AzureAksUseDevSpacesSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAksWaitSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAksWaitSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetName(this AzureAksWaitSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.Name"/></em></p>
        ///   <p>Name of the managed cluster.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetName(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetResourceGroup(this AzureAksWaitSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetResourceGroup(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Created
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetCreated(this AzureAksWaitSettings toolSettings, string created)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = created;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.Created"/></em></p>
        ///   <p>Wait until created with 'provisioningState' at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetCreated(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Created = null;
            return toolSettings;
        }
        #endregion
        #region Custom
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetCustom(this AzureAksWaitSettings toolSettings, string custom)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = custom;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.Custom"/></em></p>
        ///   <p>Wait until the condition satisfies a custom JMESPath query. E.g. provisioningState!='InProgress', instanceView.statuses[?code=='PowerState/running'].</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetCustom(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Custom = null;
            return toolSettings;
        }
        #endregion
        #region Deleted
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetDeleted(this AzureAksWaitSettings toolSettings, string deleted)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = deleted;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.Deleted"/></em></p>
        ///   <p>Wait until deleted.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetDeleted(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Deleted = null;
            return toolSettings;
        }
        #endregion
        #region Exists
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetExists(this AzureAksWaitSettings toolSettings, string exists)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = exists;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.Exists"/></em></p>
        ///   <p>Wait until the resource exists.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetExists(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Exists = null;
            return toolSettings;
        }
        #endregion
        #region Interval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetInterval(this AzureAksWaitSettings toolSettings, string interval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = interval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.Interval"/></em></p>
        ///   <p>Polling interval in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetInterval(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Interval = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetTimeout(this AzureAksWaitSettings toolSettings, string timeout)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.Timeout"/></em></p>
        ///   <p>Maximum wait in seconds.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetTimeout(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Updated
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetUpdated(this AzureAksWaitSettings toolSettings, string updated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = updated;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.Updated"/></em></p>
        ///   <p>Wait until updated with provisioningState at 'Succeeded'.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetUpdated(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Updated = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetSubscription(this AzureAksWaitSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetSubscription(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetDebug(this AzureAksWaitSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetDebug(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetHelp(this AzureAksWaitSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetHelp(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetOutput(this AzureAksWaitSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetOutput(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetQuery(this AzureAksWaitSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetQuery(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureAksWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings SetVerbose(this AzureAksWaitSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureAksWaitSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureAksWaitSettings ResetVerbose(this AzureAksWaitSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AksOsType
    /// <summary>
    ///   Used within <see cref="AzureAksTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AksOsType>))]
    public partial class AksOsType : Enumeration
    {
        public static AksOsType both = new AksOsType { Value = "both" };
        public static AksOsType linux = new AksOsType { Value = "linux" };
        public static AksOsType windows = new AksOsType { Value = "windows" };
    }
    #endregion
}
