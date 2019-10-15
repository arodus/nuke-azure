// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureCdn.json
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
    public static partial class AzureCdnTasks
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public static string AzureCdnPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURECDN_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureCdnLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Content Delivery Networks (CDNs).
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdn(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureCdnPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureCdnLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnNameExists(AzureCdnNameExistsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnNameExistsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnNameExistsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnNameExistsSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnNameExistsSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnNameExistsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnNameExistsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnNameExistsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnNameExistsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnNameExistsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnNameExists(Configure<AzureCdnNameExistsSettings> configurator)
        {
            return AzureCdnNameExists(configurator(new AzureCdnNameExistsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnNameExistsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnNameExistsSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnNameExistsSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnNameExistsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnNameExistsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnNameExistsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnNameExistsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnNameExistsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnNameExistsSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnNameExists(CombinatorialConfigure<AzureCdnNameExistsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnNameExists, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnUsage(AzureCdnUsageSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnUsageSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnUsageSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnUsageSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnUsageSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnUsageSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnUsageSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnUsageSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnUsage(Configure<AzureCdnUsageSettings> configurator)
        {
            return AzureCdnUsage(configurator(new AzureCdnUsageSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnUsageSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnUsageSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnUsageSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnUsageSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnUsageSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnUsageSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnUsageSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnUsage(CombinatorialConfigure<AzureCdnUsageSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnUsage, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnCustomDomainCreate(AzureCdnCustomDomainCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnCustomDomainCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnCustomDomainCreateSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnCustomDomainCreateSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnCustomDomainCreateSettings.Help"/></li>
        ///     <li><c>--hostname</c> via <see cref="AzureCdnCustomDomainCreateSettings.Hostname"/></li>
        ///     <li><c>--location</c> via <see cref="AzureCdnCustomDomainCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnCustomDomainCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnCustomDomainCreateSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnCustomDomainCreateSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnCustomDomainCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnCustomDomainCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnCustomDomainCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCdnCustomDomainCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnCustomDomainCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnCustomDomainCreate(Configure<AzureCdnCustomDomainCreateSettings> configurator)
        {
            return AzureCdnCustomDomainCreate(configurator(new AzureCdnCustomDomainCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnCustomDomainCreateSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnCustomDomainCreateSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnCustomDomainCreateSettings.Help"/></li>
        ///     <li><c>--hostname</c> via <see cref="AzureCdnCustomDomainCreateSettings.Hostname"/></li>
        ///     <li><c>--location</c> via <see cref="AzureCdnCustomDomainCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnCustomDomainCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnCustomDomainCreateSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnCustomDomainCreateSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnCustomDomainCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnCustomDomainCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnCustomDomainCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCdnCustomDomainCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnCustomDomainCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnCustomDomainCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnCustomDomainCreate(CombinatorialConfigure<AzureCdnCustomDomainCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnCustomDomainCreate, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnCustomDomainDelete(AzureCdnCustomDomainDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnCustomDomainDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnCustomDomainDeleteSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnCustomDomainDeleteSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnCustomDomainDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnCustomDomainDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnCustomDomainDeleteSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnCustomDomainDeleteSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnCustomDomainDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnCustomDomainDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnCustomDomainDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnCustomDomainDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnCustomDomainDelete(Configure<AzureCdnCustomDomainDeleteSettings> configurator)
        {
            return AzureCdnCustomDomainDelete(configurator(new AzureCdnCustomDomainDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnCustomDomainDeleteSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnCustomDomainDeleteSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnCustomDomainDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnCustomDomainDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnCustomDomainDeleteSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnCustomDomainDeleteSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnCustomDomainDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnCustomDomainDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnCustomDomainDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnCustomDomainDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnCustomDomainDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnCustomDomainDelete(CombinatorialConfigure<AzureCdnCustomDomainDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnCustomDomainDelete, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnCustomDomainDisableHttps(AzureCdnCustomDomainDisableHttpsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnCustomDomainDisableHttpsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnCustomDomainDisableHttps(Configure<AzureCdnCustomDomainDisableHttpsSettings> configurator)
        {
            return AzureCdnCustomDomainDisableHttps(configurator(new AzureCdnCustomDomainDisableHttpsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnCustomDomainDisableHttpsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnCustomDomainDisableHttpsSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnCustomDomainDisableHttps(CombinatorialConfigure<AzureCdnCustomDomainDisableHttpsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnCustomDomainDisableHttps, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnCustomDomainEnableHttps(AzureCdnCustomDomainEnableHttpsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnCustomDomainEnableHttpsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--custom-domain-https-parameters</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.CustomDomainHttpsParameters"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnCustomDomainEnableHttps(Configure<AzureCdnCustomDomainEnableHttpsSettings> configurator)
        {
            return AzureCdnCustomDomainEnableHttps(configurator(new AzureCdnCustomDomainEnableHttpsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--custom-domain-https-parameters</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.CustomDomainHttpsParameters"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnCustomDomainEnableHttpsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnCustomDomainEnableHttpsSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnCustomDomainEnableHttps(CombinatorialConfigure<AzureCdnCustomDomainEnableHttpsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnCustomDomainEnableHttps, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnCustomDomainList(AzureCdnCustomDomainListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnCustomDomainListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnCustomDomainListSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnCustomDomainListSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnCustomDomainListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnCustomDomainListSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnCustomDomainListSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnCustomDomainListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnCustomDomainListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnCustomDomainListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnCustomDomainListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnCustomDomainList(Configure<AzureCdnCustomDomainListSettings> configurator)
        {
            return AzureCdnCustomDomainList(configurator(new AzureCdnCustomDomainListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnCustomDomainListSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnCustomDomainListSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnCustomDomainListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnCustomDomainListSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnCustomDomainListSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnCustomDomainListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnCustomDomainListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnCustomDomainListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnCustomDomainListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnCustomDomainListSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnCustomDomainList(CombinatorialConfigure<AzureCdnCustomDomainListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnCustomDomainList, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnCustomDomainShow(AzureCdnCustomDomainShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnCustomDomainShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnCustomDomainShowSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnCustomDomainShowSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnCustomDomainShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnCustomDomainShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnCustomDomainShowSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnCustomDomainShowSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnCustomDomainShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnCustomDomainShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnCustomDomainShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnCustomDomainShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnCustomDomainShow(Configure<AzureCdnCustomDomainShowSettings> configurator)
        {
            return AzureCdnCustomDomainShow(configurator(new AzureCdnCustomDomainShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnCustomDomainShowSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnCustomDomainShowSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnCustomDomainShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnCustomDomainShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnCustomDomainShowSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnCustomDomainShowSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnCustomDomainShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnCustomDomainShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnCustomDomainShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnCustomDomainShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnCustomDomainShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnCustomDomainShow(CombinatorialConfigure<AzureCdnCustomDomainShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnCustomDomainShow, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnProfileCreate(AzureCdnProfileCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnProfileCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnProfileCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnProfileCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureCdnProfileCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnProfileCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnProfileCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnProfileCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnProfileCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureCdnProfileCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnProfileCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCdnProfileCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnProfileCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnProfileCreate(Configure<AzureCdnProfileCreateSettings> configurator)
        {
            return AzureCdnProfileCreate(configurator(new AzureCdnProfileCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnProfileCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnProfileCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureCdnProfileCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnProfileCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnProfileCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnProfileCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnProfileCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--sku</c> via <see cref="AzureCdnProfileCreateSettings.Sku"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnProfileCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCdnProfileCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnProfileCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnProfileCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnProfileCreate(CombinatorialConfigure<AzureCdnProfileCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnProfileCreate, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnProfileDelete(AzureCdnProfileDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnProfileDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnProfileDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnProfileDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnProfileDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnProfileDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnProfileDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnProfileDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnProfileDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnProfileDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnProfileDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnProfileDelete(Configure<AzureCdnProfileDeleteSettings> configurator)
        {
            return AzureCdnProfileDelete(configurator(new AzureCdnProfileDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnProfileDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnProfileDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnProfileDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnProfileDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnProfileDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnProfileDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnProfileDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnProfileDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnProfileDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnProfileDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnProfileDelete(CombinatorialConfigure<AzureCdnProfileDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnProfileDelete, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnProfileList(AzureCdnProfileListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnProfileListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnProfileListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnProfileListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnProfileListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnProfileListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnProfileListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnProfileListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnProfileListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnProfileList(Configure<AzureCdnProfileListSettings> configurator)
        {
            return AzureCdnProfileList(configurator(new AzureCdnProfileListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnProfileListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnProfileListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnProfileListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnProfileListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnProfileListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnProfileListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnProfileListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnProfileListSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnProfileList(CombinatorialConfigure<AzureCdnProfileListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnProfileList, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnProfileShow(AzureCdnProfileShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnProfileShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnProfileShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnProfileShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnProfileShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnProfileShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnProfileShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnProfileShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnProfileShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnProfileShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnProfileShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnProfileShow(Configure<AzureCdnProfileShowSettings> configurator)
        {
            return AzureCdnProfileShow(configurator(new AzureCdnProfileShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnProfileShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnProfileShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnProfileShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnProfileShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnProfileShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnProfileShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnProfileShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnProfileShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnProfileShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnProfileShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnProfileShow(CombinatorialConfigure<AzureCdnProfileShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnProfileShow, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnProfileUpdate(AzureCdnProfileUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnProfileUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureCdnProfileUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCdnProfileUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureCdnProfileUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnProfileUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnProfileUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnProfileUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnProfileUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnProfileUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureCdnProfileUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnProfileUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureCdnProfileUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnProfileUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCdnProfileUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnProfileUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnProfileUpdate(Configure<AzureCdnProfileUpdateSettings> configurator)
        {
            return AzureCdnProfileUpdate(configurator(new AzureCdnProfileUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureCdnProfileUpdateSettings.Add"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCdnProfileUpdateSettings.Debug"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureCdnProfileUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnProfileUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnProfileUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnProfileUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnProfileUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnProfileUpdateSettings.Query"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureCdnProfileUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnProfileUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureCdnProfileUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnProfileUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCdnProfileUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnProfileUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnProfileUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnProfileUpdate(CombinatorialConfigure<AzureCdnProfileUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnProfileUpdate, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnProfileUsage(AzureCdnProfileUsageSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnProfileUsageSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnProfileUsageSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnProfileUsageSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnProfileUsageSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnProfileUsageSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnProfileUsageSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnProfileUsageSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnProfileUsageSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnProfileUsageSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnProfileUsageSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnProfileUsage(Configure<AzureCdnProfileUsageSettings> configurator)
        {
            return AzureCdnProfileUsage(configurator(new AzureCdnProfileUsageSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnProfileUsageSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnProfileUsageSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnProfileUsageSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnProfileUsageSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnProfileUsageSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnProfileUsageSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnProfileUsageSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnProfileUsageSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnProfileUsageSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnProfileUsageSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnProfileUsage(CombinatorialConfigure<AzureCdnProfileUsageSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnProfileUsage, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnEndpointCreate(AzureCdnEndpointCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnEndpointCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--content-types-to-compress</c> via <see cref="AzureCdnEndpointCreateSettings.ContentTypesToCompress"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointCreateSettings.Debug"/></li>
        ///     <li><c>--enable-compression</c> via <see cref="AzureCdnEndpointCreateSettings.EnableCompression"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureCdnEndpointCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointCreateSettings.Name"/></li>
        ///     <li><c>--no-http</c> via <see cref="AzureCdnEndpointCreateSettings.NoHttp"/></li>
        ///     <li><c>--no-https</c> via <see cref="AzureCdnEndpointCreateSettings.NoHttps"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureCdnEndpointCreateSettings.NoWait"/></li>
        ///     <li><c>--origin</c> via <see cref="AzureCdnEndpointCreateSettings.Origin"/></li>
        ///     <li><c>--origin-host-header</c> via <see cref="AzureCdnEndpointCreateSettings.OriginHostHeader"/></li>
        ///     <li><c>--origin-path</c> via <see cref="AzureCdnEndpointCreateSettings.OriginPath"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointCreateSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointCreateSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointCreateSettings.Query"/></li>
        ///     <li><c>--query-string-caching</c> via <see cref="AzureCdnEndpointCreateSettings.QueryStringCaching"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCdnEndpointCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnEndpointCreate(Configure<AzureCdnEndpointCreateSettings> configurator)
        {
            return AzureCdnEndpointCreate(configurator(new AzureCdnEndpointCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--content-types-to-compress</c> via <see cref="AzureCdnEndpointCreateSettings.ContentTypesToCompress"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointCreateSettings.Debug"/></li>
        ///     <li><c>--enable-compression</c> via <see cref="AzureCdnEndpointCreateSettings.EnableCompression"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureCdnEndpointCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointCreateSettings.Name"/></li>
        ///     <li><c>--no-http</c> via <see cref="AzureCdnEndpointCreateSettings.NoHttp"/></li>
        ///     <li><c>--no-https</c> via <see cref="AzureCdnEndpointCreateSettings.NoHttps"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureCdnEndpointCreateSettings.NoWait"/></li>
        ///     <li><c>--origin</c> via <see cref="AzureCdnEndpointCreateSettings.Origin"/></li>
        ///     <li><c>--origin-host-header</c> via <see cref="AzureCdnEndpointCreateSettings.OriginHostHeader"/></li>
        ///     <li><c>--origin-path</c> via <see cref="AzureCdnEndpointCreateSettings.OriginPath"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointCreateSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointCreateSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointCreateSettings.Query"/></li>
        ///     <li><c>--query-string-caching</c> via <see cref="AzureCdnEndpointCreateSettings.QueryStringCaching"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCdnEndpointCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnEndpointCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnEndpointCreate(CombinatorialConfigure<AzureCdnEndpointCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnEndpointCreate, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnEndpointDelete(AzureCdnEndpointDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnEndpointDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureCdnEndpointDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointDeleteSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointDeleteSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnEndpointDelete(Configure<AzureCdnEndpointDeleteSettings> configurator)
        {
            return AzureCdnEndpointDelete(configurator(new AzureCdnEndpointDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointDeleteSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureCdnEndpointDeleteSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointDeleteSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointDeleteSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnEndpointDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnEndpointDelete(CombinatorialConfigure<AzureCdnEndpointDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnEndpointDelete, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnEndpointList(AzureCdnEndpointListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnEndpointListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointListSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointListSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnEndpointList(Configure<AzureCdnEndpointListSettings> configurator)
        {
            return AzureCdnEndpointList(configurator(new AzureCdnEndpointListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointListSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointListSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnEndpointListSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnEndpointList(CombinatorialConfigure<AzureCdnEndpointListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnEndpointList, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnEndpointLoad(AzureCdnEndpointLoadSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnEndpointLoadSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--content-paths</c> via <see cref="AzureCdnEndpointLoadSettings.ContentPaths"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointLoadSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointLoadSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointLoadSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointLoadSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureCdnEndpointLoadSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointLoadSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointLoadSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointLoadSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointLoadSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointLoadSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointLoadSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnEndpointLoad(Configure<AzureCdnEndpointLoadSettings> configurator)
        {
            return AzureCdnEndpointLoad(configurator(new AzureCdnEndpointLoadSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--content-paths</c> via <see cref="AzureCdnEndpointLoadSettings.ContentPaths"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointLoadSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointLoadSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointLoadSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointLoadSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureCdnEndpointLoadSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointLoadSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointLoadSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointLoadSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointLoadSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointLoadSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointLoadSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnEndpointLoadSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnEndpointLoad(CombinatorialConfigure<AzureCdnEndpointLoadSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnEndpointLoad, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnEndpointPurge(AzureCdnEndpointPurgeSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnEndpointPurgeSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--content-paths</c> via <see cref="AzureCdnEndpointPurgeSettings.ContentPaths"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointPurgeSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointPurgeSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointPurgeSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointPurgeSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureCdnEndpointPurgeSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointPurgeSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointPurgeSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointPurgeSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointPurgeSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointPurgeSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointPurgeSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnEndpointPurge(Configure<AzureCdnEndpointPurgeSettings> configurator)
        {
            return AzureCdnEndpointPurge(configurator(new AzureCdnEndpointPurgeSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--content-paths</c> via <see cref="AzureCdnEndpointPurgeSettings.ContentPaths"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointPurgeSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointPurgeSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointPurgeSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointPurgeSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureCdnEndpointPurgeSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointPurgeSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointPurgeSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointPurgeSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointPurgeSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointPurgeSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointPurgeSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnEndpointPurgeSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnEndpointPurge(CombinatorialConfigure<AzureCdnEndpointPurgeSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnEndpointPurge, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnEndpointShow(AzureCdnEndpointShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnEndpointShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointShowSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointShowSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnEndpointShow(Configure<AzureCdnEndpointShowSettings> configurator)
        {
            return AzureCdnEndpointShow(configurator(new AzureCdnEndpointShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointShowSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointShowSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnEndpointShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnEndpointShow(CombinatorialConfigure<AzureCdnEndpointShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnEndpointShow, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnEndpointStart(AzureCdnEndpointStartSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnEndpointStartSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointStartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointStartSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointStartSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointStartSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureCdnEndpointStartSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointStartSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointStartSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointStartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointStartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointStartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointStartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnEndpointStart(Configure<AzureCdnEndpointStartSettings> configurator)
        {
            return AzureCdnEndpointStart(configurator(new AzureCdnEndpointStartSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointStartSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointStartSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointStartSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointStartSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureCdnEndpointStartSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointStartSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointStartSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointStartSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointStartSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointStartSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointStartSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnEndpointStartSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnEndpointStart(CombinatorialConfigure<AzureCdnEndpointStartSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnEndpointStart, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnEndpointStop(AzureCdnEndpointStopSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnEndpointStopSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointStopSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointStopSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointStopSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureCdnEndpointStopSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointStopSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointStopSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointStopSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointStopSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnEndpointStop(Configure<AzureCdnEndpointStopSettings> configurator)
        {
            return AzureCdnEndpointStop(configurator(new AzureCdnEndpointStopSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointStopSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointStopSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointStopSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointStopSettings.Name"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureCdnEndpointStopSettings.NoWait"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointStopSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointStopSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointStopSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointStopSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointStopSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointStopSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnEndpointStopSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnEndpointStop(CombinatorialConfigure<AzureCdnEndpointStopSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnEndpointStop, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnEndpointUpdate(AzureCdnEndpointUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnEndpointUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureCdnEndpointUpdateSettings.Add"/></li>
        ///     <li><c>--content-types-to-compress</c> via <see cref="AzureCdnEndpointUpdateSettings.ContentTypesToCompress"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointUpdateSettings.Debug"/></li>
        ///     <li><c>--enable-compression</c> via <see cref="AzureCdnEndpointUpdateSettings.EnableCompression"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureCdnEndpointUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointUpdateSettings.Name"/></li>
        ///     <li><c>--no-http</c> via <see cref="AzureCdnEndpointUpdateSettings.NoHttp"/></li>
        ///     <li><c>--no-https</c> via <see cref="AzureCdnEndpointUpdateSettings.NoHttps"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureCdnEndpointUpdateSettings.NoWait"/></li>
        ///     <li><c>--origin-host-header</c> via <see cref="AzureCdnEndpointUpdateSettings.OriginHostHeader"/></li>
        ///     <li><c>--origin-path</c> via <see cref="AzureCdnEndpointUpdateSettings.OriginPath"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointUpdateSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointUpdateSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointUpdateSettings.Query"/></li>
        ///     <li><c>--query-string-caching</c> via <see cref="AzureCdnEndpointUpdateSettings.QueryStringCaching"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureCdnEndpointUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureCdnEndpointUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCdnEndpointUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnEndpointUpdate(Configure<AzureCdnEndpointUpdateSettings> configurator)
        {
            return AzureCdnEndpointUpdate(configurator(new AzureCdnEndpointUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--add</c> via <see cref="AzureCdnEndpointUpdateSettings.Add"/></li>
        ///     <li><c>--content-types-to-compress</c> via <see cref="AzureCdnEndpointUpdateSettings.ContentTypesToCompress"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointUpdateSettings.Debug"/></li>
        ///     <li><c>--enable-compression</c> via <see cref="AzureCdnEndpointUpdateSettings.EnableCompression"/></li>
        ///     <li><c>--force-string</c> via <see cref="AzureCdnEndpointUpdateSettings.ForceString"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointUpdateSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointUpdateSettings.Name"/></li>
        ///     <li><c>--no-http</c> via <see cref="AzureCdnEndpointUpdateSettings.NoHttp"/></li>
        ///     <li><c>--no-https</c> via <see cref="AzureCdnEndpointUpdateSettings.NoHttps"/></li>
        ///     <li><c>--no-wait</c> via <see cref="AzureCdnEndpointUpdateSettings.NoWait"/></li>
        ///     <li><c>--origin-host-header</c> via <see cref="AzureCdnEndpointUpdateSettings.OriginHostHeader"/></li>
        ///     <li><c>--origin-path</c> via <see cref="AzureCdnEndpointUpdateSettings.OriginPath"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointUpdateSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointUpdateSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointUpdateSettings.Query"/></li>
        ///     <li><c>--query-string-caching</c> via <see cref="AzureCdnEndpointUpdateSettings.QueryStringCaching"/></li>
        ///     <li><c>--remove</c> via <see cref="AzureCdnEndpointUpdateSettings.Remove"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--set</c> via <see cref="AzureCdnEndpointUpdateSettings.Set"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCdnEndpointUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnEndpointUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnEndpointUpdate(CombinatorialConfigure<AzureCdnEndpointUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnEndpointUpdate, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnEndpointValidateCustomDomain(AzureCdnEndpointValidateCustomDomainSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnEndpointValidateCustomDomainSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Help"/></li>
        ///     <li><c>--host-name</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.HostName"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnEndpointValidateCustomDomain(Configure<AzureCdnEndpointValidateCustomDomainSettings> configurator)
        {
            return AzureCdnEndpointValidateCustomDomain(configurator(new AzureCdnEndpointValidateCustomDomainSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Help"/></li>
        ///     <li><c>--host-name</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.HostName"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEndpointValidateCustomDomainSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnEndpointValidateCustomDomainSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnEndpointValidateCustomDomain(CombinatorialConfigure<AzureCdnEndpointValidateCustomDomainSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnEndpointValidateCustomDomain, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnEdgeNodeList(AzureCdnEdgeNodeListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnEdgeNodeListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEdgeNodeListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEdgeNodeListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEdgeNodeListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEdgeNodeListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEdgeNodeListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEdgeNodeListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnEdgeNodeList(Configure<AzureCdnEdgeNodeListSettings> configurator)
        {
            return AzureCdnEdgeNodeList(configurator(new AzureCdnEdgeNodeListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnEdgeNodeListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnEdgeNodeListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnEdgeNodeListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnEdgeNodeListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnEdgeNodeListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnEdgeNodeListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnEdgeNodeListSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnEdgeNodeList(CombinatorialConfigure<AzureCdnEdgeNodeListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnEdgeNodeList, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnOriginList(AzureCdnOriginListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnOriginListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnOriginListSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnOriginListSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnOriginListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnOriginListSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnOriginListSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnOriginListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnOriginListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnOriginListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnOriginListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnOriginList(Configure<AzureCdnOriginListSettings> configurator)
        {
            return AzureCdnOriginList(configurator(new AzureCdnOriginListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnOriginListSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnOriginListSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnOriginListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnOriginListSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnOriginListSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnOriginListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnOriginListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnOriginListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnOriginListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnOriginListSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnOriginList(CombinatorialConfigure<AzureCdnOriginListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnOriginList, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCdnOriginShow(AzureCdnOriginShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCdnOriginShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnOriginShowSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnOriginShowSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnOriginShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnOriginShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnOriginShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnOriginShowSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnOriginShowSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnOriginShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnOriginShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnOriginShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnOriginShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCdnOriginShow(Configure<AzureCdnOriginShowSettings> configurator)
        {
            return AzureCdnOriginShow(configurator(new AzureCdnOriginShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Content Delivery Networks (CDNs).</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cdn?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCdnOriginShowSettings.Debug"/></li>
        ///     <li><c>--endpoint-name</c> via <see cref="AzureCdnOriginShowSettings.EndpointName"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCdnOriginShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCdnOriginShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCdnOriginShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCdnOriginShowSettings.Output"/></li>
        ///     <li><c>--profile-name</c> via <see cref="AzureCdnOriginShowSettings.ProfileName"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCdnOriginShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCdnOriginShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCdnOriginShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCdnOriginShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCdnOriginShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureCdnOriginShow(CombinatorialConfigure<AzureCdnOriginShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCdnOriginShow, AzureCdnLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureCdnNameExistsSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnNameExistsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The resource name to validate.
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
              .Add("cdn name-exists")
              .Add("--ids {value}", Ids, separator: ' ')
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
    #region AzureCdnUsageSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnUsageSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
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
              .Add("cdn usage")
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
    #region AzureCdnCustomDomainCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnCustomDomainCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   Name of the endpoint under the profile which is unique globally.
        /// </summary>
        public virtual string EndpointName { get; internal set; }
        /// <summary>
        ///   The host name of the custom domain. Must be a domain name.
        /// </summary>
        public virtual string Hostname { get; internal set; }
        /// <summary>
        ///   Name of the custom domain.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
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
              .Add("cdn custom-domain create")
              .Add("--endpoint-name {value}", EndpointName)
              .Add("--hostname {value}", Hostname)
              .Add("--name {value}", Name)
              .Add("--profile-name {value}", ProfileName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--location {value}", Location)
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
    #region AzureCdnCustomDomainDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnCustomDomainDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   Name of the endpoint under the profile which is unique globally.
        /// </summary>
        public virtual string EndpointName { get; internal set; }
        /// <summary>
        ///   Name of the custom domain.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
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
              .Add("cdn custom-domain delete")
              .Add("--endpoint-name {value}", EndpointName)
              .Add("--name {value}", Name)
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnCustomDomainDisableHttpsSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnCustomDomainDisableHttpsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   Name of the endpoint under the profile which is unique globally.
        /// </summary>
        public virtual string EndpointName { get; internal set; }
        /// <summary>
        ///   Name of the custom domain.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
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
              .Add("cdn custom-domain disable-https")
              .Add("--endpoint-name {value}", EndpointName)
              .Add("--name {value}", Name)
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnCustomDomainEnableHttpsSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnCustomDomainEnableHttpsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   Name of the endpoint under the profile which is unique globally.
        /// </summary>
        public virtual string EndpointName { get; internal set; }
        /// <summary>
        ///   Name of the custom domain.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   The configuration specifying how to enable HTTPS for the custom domain - using CDN managed certificate or user's own certificate. If not specified, enabling ssl uses CDN managed certificate by default.
        /// </summary>
        public virtual string CustomDomainHttpsParameters { get; internal set; }
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
              .Add("cdn custom-domain enable-https")
              .Add("--endpoint-name {value}", EndpointName)
              .Add("--name {value}", Name)
              .Add("--profile-name {value}", ProfileName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--custom-domain-https-parameters {value}", CustomDomainHttpsParameters)
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
    #region AzureCdnCustomDomainListSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnCustomDomainListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   Name of the endpoint under the profile which is unique globally.
        /// </summary>
        public virtual string EndpointName { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
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
              .Add("cdn custom-domain list")
              .Add("--endpoint-name {value}", EndpointName)
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnCustomDomainShowSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnCustomDomainShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   Name of the endpoint under the profile which is unique globally.
        /// </summary>
        public virtual string EndpointName { get; internal set; }
        /// <summary>
        ///   Name of the custom domain.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
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
              .Add("cdn custom-domain show")
              .Add("--endpoint-name {value}", EndpointName)
              .Add("--name {value}", Name)
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnProfileCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnProfileCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
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
        ///   The pricing tier (defines a CDN provider, feature list and rate) of the CDN profile. Defaults to Standard_Akamai.
        /// </summary>
        public virtual CdnProfileCreateSku Sku { get; internal set; }
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
              .Add("cdn profile create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--location {value}", Location)
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
    #region AzureCdnProfileDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnProfileDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
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
              .Add("cdn profile delete")
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
    #region AzureCdnProfileListSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnProfileListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
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
              .Add("cdn profile list")
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
    #region AzureCdnProfileShowSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnProfileShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
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
              .Add("cdn profile show")
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
    #region AzureCdnProfileUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnProfileUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
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
        ///   Name of the CDN profile which is unique within the resource group.
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
              .Add("cdn profile update")
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
    #region AzureCdnProfileUsageSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnProfileUsageSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
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
              .Add("cdn profile usage")
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
    #region AzureCdnEndpointCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnEndpointCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   Name of the CDN endpoint.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Endpoint origin specified by the following space-delimited 3 tuple: `www.example.com http_port https_port`. The HTTP and HTTPsports are optional and will default to 80 and 443 respectively.
        /// </summary>
        public virtual string Origin { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   List of content types on which compression applies. The value should be a valid MIME type.
        /// </summary>
        public virtual string ContentTypesToCompress { get; internal set; }
        /// <summary>
        ///   If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.
        /// </summary>
        public virtual bool? EnableCompression { get; internal set; }
        /// <summary>
        ///   Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.
        /// </summary>
        public virtual string Location { get; internal set; }
        /// <summary>
        ///   Indicates whether HTTP traffic is not allowed on the endpoint. Default is to allow HTTP traffic.
        /// </summary>
        public virtual bool? NoHttp { get; internal set; }
        /// <summary>
        ///   Indicates whether HTTPS traffic is not allowed on the endpoint. Default is to allow HTTPS traffic.
        /// </summary>
        public virtual bool? NoHttps { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default.
        /// </summary>
        public virtual string OriginHostHeader { get; internal set; }
        /// <summary>
        ///   A directory path on the origin that CDN can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
        /// </summary>
        public virtual string OriginPath { get; internal set; }
        /// <summary>
        ///   Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL.
        /// </summary>
        public virtual CdnEndpointQueryStringCaching QueryStringCaching { get; internal set; }
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
              .Add("cdn endpoint create")
              .Add("--name {value}", Name)
              .Add("--origin {value}", Origin)
              .Add("--profile-name {value}", ProfileName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--content-types-to-compress {value}", ContentTypesToCompress)
              .Add("--enable-compression", EnableCompression)
              .Add("--location {value}", Location)
              .Add("--no-http", NoHttp)
              .Add("--no-https", NoHttps)
              .Add("--no-wait", NoWait)
              .Add("--origin-host-header {value}", OriginHostHeader)
              .Add("--origin-path {value}", OriginPath)
              .Add("--query-string-caching {value}", QueryStringCaching)
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
    #region AzureCdnEndpointDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnEndpointDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
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
        ///   Name of the CDN endpoint.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
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
              .Add("cdn endpoint delete")
              .Add("--no-wait", NoWait)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnEndpointListSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnEndpointListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
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
              .Add("cdn endpoint list")
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnEndpointLoadSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnEndpointLoadSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   The path to the content to be loaded. Path should be a relative file URL of the origin.
        /// </summary>
        public virtual string ContentPaths { get; internal set; }
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
        ///   Name of the CDN endpoint.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
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
              .Add("cdn endpoint load")
              .Add("--content-paths {value}", ContentPaths)
              .Add("--no-wait", NoWait)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnEndpointPurgeSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnEndpointPurgeSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   The path to the content to be purged. Can describe a file path or a wild card directory.
        /// </summary>
        public virtual string ContentPaths { get; internal set; }
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
        ///   Name of the CDN endpoint.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
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
              .Add("cdn endpoint purge")
              .Add("--content-paths {value}", ContentPaths)
              .Add("--no-wait", NoWait)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnEndpointShowSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnEndpointShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the CDN endpoint.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
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
              .Add("cdn endpoint show")
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnEndpointStartSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnEndpointStartSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
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
        ///   Name of the CDN endpoint.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
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
              .Add("cdn endpoint start")
              .Add("--no-wait", NoWait)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnEndpointStopSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnEndpointStopSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
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
        ///   Name of the CDN endpoint.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
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
              .Add("cdn endpoint stop")
              .Add("--no-wait", NoWait)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnEndpointUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnEndpointUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   List of content types on which compression applies. The value should be a valid MIME type.
        /// </summary>
        public virtual string ContentTypesToCompress { get; internal set; }
        /// <summary>
        ///   If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.
        /// </summary>
        public virtual bool? EnableCompression { get; internal set; }
        /// <summary>
        ///   Indicates whether HTTP traffic is not allowed on the endpoint. Default is to allow HTTP traffic.
        /// </summary>
        public virtual bool? NoHttp { get; internal set; }
        /// <summary>
        ///   Indicates whether HTTPS traffic is not allowed on the endpoint. Default is to allow HTTPS traffic.
        /// </summary>
        public virtual bool? NoHttps { get; internal set; }
        /// <summary>
        ///   Do not wait for the long-running operation to finish.
        /// </summary>
        public virtual bool? NoWait { get; internal set; }
        /// <summary>
        ///   The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default.
        /// </summary>
        public virtual string OriginHostHeader { get; internal set; }
        /// <summary>
        ///   A directory path on the origin that CDN can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
        /// </summary>
        public virtual string OriginPath { get; internal set; }
        /// <summary>
        ///   Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL.
        /// </summary>
        public virtual CdnEndpointQueryStringCaching QueryStringCaching { get; internal set; }
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
        ///   Name of the CDN endpoint.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
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
              .Add("cdn endpoint update")
              .Add("--content-types-to-compress {value}", ContentTypesToCompress)
              .Add("--enable-compression", EnableCompression)
              .Add("--no-http", NoHttp)
              .Add("--no-https", NoHttps)
              .Add("--no-wait", NoWait)
              .Add("--origin-host-header {value}", OriginHostHeader)
              .Add("--origin-path {value}", OriginPath)
              .Add("--query-string-caching {value}", QueryStringCaching)
              .Add("--tags {value}", Tags)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnEndpointValidateCustomDomainSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnEndpointValidateCustomDomainSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   The host name of the custom domain. Must be a domain name.
        /// </summary>
        public virtual string HostName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the CDN endpoint.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
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
              .Add("cdn endpoint validate-custom-domain")
              .Add("--host-name {value}", HostName)
              .Add("--ids {value}", Ids, separator: ' ')
              .Add("--name {value}", Name)
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnEdgeNodeListSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnEdgeNodeListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
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
              .Add("cdn edge-node list")
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
    #region AzureCdnOriginListSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnOriginListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   Name of the endpoint under the profile which is unique globally.
        /// </summary>
        public virtual string EndpointName { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
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
              .Add("cdn origin list")
              .Add("--endpoint-name {value}", EndpointName)
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnOriginShowSettings
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCdnOriginShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCdn executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCdnTasks.AzureCdnPath;
        public override Action<OutputType, string> CustomLogger => AzureCdnTasks.AzureCdnLogger;
        /// <summary>
        ///   Name of the endpoint under the profile which is unique globally.
        /// </summary>
        public virtual string EndpointName { get; internal set; }
        /// <summary>
        ///   Name of the CDN profile which is unique within the resource group.
        /// </summary>
        public virtual string ProfileName { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the origin which is unique within the endpoint.
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
              .Add("cdn origin show")
              .Add("--endpoint-name {value}", EndpointName)
              .Add("--profile-name {value}", ProfileName)
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
    #region AzureCdnNameExistsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnNameExistsSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnNameExistsSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings SetIds(this AzureCdnNameExistsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnNameExistsSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings SetIds(this AzureCdnNameExistsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnNameExistsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings AddIds(this AzureCdnNameExistsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnNameExistsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings AddIds(this AzureCdnNameExistsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCdnNameExistsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings ClearIds(this AzureCdnNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnNameExistsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings RemoveIds(this AzureCdnNameExistsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnNameExistsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings RemoveIds(this AzureCdnNameExistsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnNameExistsSettings.Name"/></em></p>
        ///   <p>The resource name to validate.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings SetName(this AzureCdnNameExistsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnNameExistsSettings.Name"/></em></p>
        ///   <p>The resource name to validate.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings ResetName(this AzureCdnNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnNameExistsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings SetSubscription(this AzureCdnNameExistsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnNameExistsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings ResetSubscription(this AzureCdnNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnNameExistsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings SetDebug(this AzureCdnNameExistsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnNameExistsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings ResetDebug(this AzureCdnNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnNameExistsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings SetHelp(this AzureCdnNameExistsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnNameExistsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings ResetHelp(this AzureCdnNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnNameExistsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings SetOutput(this AzureCdnNameExistsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnNameExistsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings ResetOutput(this AzureCdnNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnNameExistsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings SetQuery(this AzureCdnNameExistsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnNameExistsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings ResetQuery(this AzureCdnNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnNameExistsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings SetVerbose(this AzureCdnNameExistsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnNameExistsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnNameExistsSettings ResetVerbose(this AzureCdnNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnUsageSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnUsageSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnUsageSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnUsageSettings SetSubscription(this AzureCdnUsageSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnUsageSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnUsageSettings ResetSubscription(this AzureCdnUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnUsageSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnUsageSettings SetDebug(this AzureCdnUsageSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnUsageSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnUsageSettings ResetDebug(this AzureCdnUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnUsageSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnUsageSettings SetHelp(this AzureCdnUsageSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnUsageSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnUsageSettings ResetHelp(this AzureCdnUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnUsageSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnUsageSettings SetOutput(this AzureCdnUsageSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnUsageSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnUsageSettings ResetOutput(this AzureCdnUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnUsageSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnUsageSettings SetQuery(this AzureCdnUsageSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnUsageSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnUsageSettings ResetQuery(this AzureCdnUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnUsageSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnUsageSettings SetVerbose(this AzureCdnUsageSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnUsageSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnUsageSettings ResetVerbose(this AzureCdnUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnCustomDomainCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnCustomDomainCreateSettingsExtensions
    {
        #region EndpointName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainCreateSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings SetEndpointName(this AzureCdnCustomDomainCreateSettings toolSettings, string endpointName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = endpointName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainCreateSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings ResetEndpointName(this AzureCdnCustomDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = null;
            return toolSettings;
        }
        #endregion
        #region Hostname
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainCreateSettings.Hostname"/></em></p>
        ///   <p>The host name of the custom domain. Must be a domain name.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings SetHostname(this AzureCdnCustomDomainCreateSettings toolSettings, string hostname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hostname = hostname;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainCreateSettings.Hostname"/></em></p>
        ///   <p>The host name of the custom domain. Must be a domain name.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings ResetHostname(this AzureCdnCustomDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Hostname = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainCreateSettings.Name"/></em></p>
        ///   <p>Name of the custom domain.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings SetName(this AzureCdnCustomDomainCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainCreateSettings.Name"/></em></p>
        ///   <p>Name of the custom domain.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings ResetName(this AzureCdnCustomDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainCreateSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings SetProfileName(this AzureCdnCustomDomainCreateSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainCreateSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings ResetProfileName(this AzureCdnCustomDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings SetResourceGroup(this AzureCdnCustomDomainCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings ResetResourceGroup(this AzureCdnCustomDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings SetLocation(this AzureCdnCustomDomainCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings ResetLocation(this AzureCdnCustomDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings SetTags(this AzureCdnCustomDomainCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings ResetTags(this AzureCdnCustomDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings SetSubscription(this AzureCdnCustomDomainCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings ResetSubscription(this AzureCdnCustomDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings SetDebug(this AzureCdnCustomDomainCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings ResetDebug(this AzureCdnCustomDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings SetHelp(this AzureCdnCustomDomainCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings ResetHelp(this AzureCdnCustomDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings SetOutput(this AzureCdnCustomDomainCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings ResetOutput(this AzureCdnCustomDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings SetQuery(this AzureCdnCustomDomainCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings ResetQuery(this AzureCdnCustomDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings SetVerbose(this AzureCdnCustomDomainCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainCreateSettings ResetVerbose(this AzureCdnCustomDomainCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnCustomDomainDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnCustomDomainDeleteSettingsExtensions
    {
        #region EndpointName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDeleteSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings SetEndpointName(this AzureCdnCustomDomainDeleteSettings toolSettings, string endpointName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = endpointName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDeleteSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings ResetEndpointName(this AzureCdnCustomDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDeleteSettings.Name"/></em></p>
        ///   <p>Name of the custom domain.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings SetName(this AzureCdnCustomDomainDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDeleteSettings.Name"/></em></p>
        ///   <p>Name of the custom domain.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings ResetName(this AzureCdnCustomDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDeleteSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings SetProfileName(this AzureCdnCustomDomainDeleteSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDeleteSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings ResetProfileName(this AzureCdnCustomDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings SetResourceGroup(this AzureCdnCustomDomainDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings ResetResourceGroup(this AzureCdnCustomDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings SetSubscription(this AzureCdnCustomDomainDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings ResetSubscription(this AzureCdnCustomDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings SetDebug(this AzureCdnCustomDomainDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings ResetDebug(this AzureCdnCustomDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings SetHelp(this AzureCdnCustomDomainDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings ResetHelp(this AzureCdnCustomDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings SetOutput(this AzureCdnCustomDomainDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings ResetOutput(this AzureCdnCustomDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings SetQuery(this AzureCdnCustomDomainDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings ResetQuery(this AzureCdnCustomDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings SetVerbose(this AzureCdnCustomDomainDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDeleteSettings ResetVerbose(this AzureCdnCustomDomainDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnCustomDomainDisableHttpsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnCustomDomainDisableHttpsSettingsExtensions
    {
        #region EndpointName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDisableHttpsSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings SetEndpointName(this AzureCdnCustomDomainDisableHttpsSettings toolSettings, string endpointName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = endpointName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDisableHttpsSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings ResetEndpointName(this AzureCdnCustomDomainDisableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDisableHttpsSettings.Name"/></em></p>
        ///   <p>Name of the custom domain.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings SetName(this AzureCdnCustomDomainDisableHttpsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDisableHttpsSettings.Name"/></em></p>
        ///   <p>Name of the custom domain.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings ResetName(this AzureCdnCustomDomainDisableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDisableHttpsSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings SetProfileName(this AzureCdnCustomDomainDisableHttpsSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDisableHttpsSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings ResetProfileName(this AzureCdnCustomDomainDisableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDisableHttpsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings SetResourceGroup(this AzureCdnCustomDomainDisableHttpsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDisableHttpsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings ResetResourceGroup(this AzureCdnCustomDomainDisableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDisableHttpsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings SetSubscription(this AzureCdnCustomDomainDisableHttpsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDisableHttpsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings ResetSubscription(this AzureCdnCustomDomainDisableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDisableHttpsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings SetDebug(this AzureCdnCustomDomainDisableHttpsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDisableHttpsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings ResetDebug(this AzureCdnCustomDomainDisableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDisableHttpsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings SetHelp(this AzureCdnCustomDomainDisableHttpsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDisableHttpsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings ResetHelp(this AzureCdnCustomDomainDisableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDisableHttpsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings SetOutput(this AzureCdnCustomDomainDisableHttpsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDisableHttpsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings ResetOutput(this AzureCdnCustomDomainDisableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDisableHttpsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings SetQuery(this AzureCdnCustomDomainDisableHttpsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDisableHttpsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings ResetQuery(this AzureCdnCustomDomainDisableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainDisableHttpsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings SetVerbose(this AzureCdnCustomDomainDisableHttpsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainDisableHttpsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainDisableHttpsSettings ResetVerbose(this AzureCdnCustomDomainDisableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnCustomDomainEnableHttpsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnCustomDomainEnableHttpsSettingsExtensions
    {
        #region EndpointName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainEnableHttpsSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings SetEndpointName(this AzureCdnCustomDomainEnableHttpsSettings toolSettings, string endpointName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = endpointName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainEnableHttpsSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings ResetEndpointName(this AzureCdnCustomDomainEnableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainEnableHttpsSettings.Name"/></em></p>
        ///   <p>Name of the custom domain.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings SetName(this AzureCdnCustomDomainEnableHttpsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainEnableHttpsSettings.Name"/></em></p>
        ///   <p>Name of the custom domain.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings ResetName(this AzureCdnCustomDomainEnableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainEnableHttpsSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings SetProfileName(this AzureCdnCustomDomainEnableHttpsSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainEnableHttpsSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings ResetProfileName(this AzureCdnCustomDomainEnableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainEnableHttpsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings SetResourceGroup(this AzureCdnCustomDomainEnableHttpsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainEnableHttpsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings ResetResourceGroup(this AzureCdnCustomDomainEnableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region CustomDomainHttpsParameters
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainEnableHttpsSettings.CustomDomainHttpsParameters"/></em></p>
        ///   <p>The configuration specifying how to enable HTTPS for the custom domain - using CDN managed certificate or user's own certificate. If not specified, enabling ssl uses CDN managed certificate by default.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings SetCustomDomainHttpsParameters(this AzureCdnCustomDomainEnableHttpsSettings toolSettings, string customDomainHttpsParameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomDomainHttpsParameters = customDomainHttpsParameters;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainEnableHttpsSettings.CustomDomainHttpsParameters"/></em></p>
        ///   <p>The configuration specifying how to enable HTTPS for the custom domain - using CDN managed certificate or user's own certificate. If not specified, enabling ssl uses CDN managed certificate by default.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings ResetCustomDomainHttpsParameters(this AzureCdnCustomDomainEnableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CustomDomainHttpsParameters = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainEnableHttpsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings SetSubscription(this AzureCdnCustomDomainEnableHttpsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainEnableHttpsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings ResetSubscription(this AzureCdnCustomDomainEnableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainEnableHttpsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings SetDebug(this AzureCdnCustomDomainEnableHttpsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainEnableHttpsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings ResetDebug(this AzureCdnCustomDomainEnableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainEnableHttpsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings SetHelp(this AzureCdnCustomDomainEnableHttpsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainEnableHttpsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings ResetHelp(this AzureCdnCustomDomainEnableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainEnableHttpsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings SetOutput(this AzureCdnCustomDomainEnableHttpsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainEnableHttpsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings ResetOutput(this AzureCdnCustomDomainEnableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainEnableHttpsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings SetQuery(this AzureCdnCustomDomainEnableHttpsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainEnableHttpsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings ResetQuery(this AzureCdnCustomDomainEnableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainEnableHttpsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings SetVerbose(this AzureCdnCustomDomainEnableHttpsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainEnableHttpsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainEnableHttpsSettings ResetVerbose(this AzureCdnCustomDomainEnableHttpsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnCustomDomainListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnCustomDomainListSettingsExtensions
    {
        #region EndpointName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainListSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings SetEndpointName(this AzureCdnCustomDomainListSettings toolSettings, string endpointName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = endpointName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainListSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings ResetEndpointName(this AzureCdnCustomDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainListSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings SetProfileName(this AzureCdnCustomDomainListSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainListSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings ResetProfileName(this AzureCdnCustomDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings SetResourceGroup(this AzureCdnCustomDomainListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings ResetResourceGroup(this AzureCdnCustomDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings SetSubscription(this AzureCdnCustomDomainListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings ResetSubscription(this AzureCdnCustomDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings SetDebug(this AzureCdnCustomDomainListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings ResetDebug(this AzureCdnCustomDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings SetHelp(this AzureCdnCustomDomainListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings ResetHelp(this AzureCdnCustomDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings SetOutput(this AzureCdnCustomDomainListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings ResetOutput(this AzureCdnCustomDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings SetQuery(this AzureCdnCustomDomainListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings ResetQuery(this AzureCdnCustomDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings SetVerbose(this AzureCdnCustomDomainListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainListSettings ResetVerbose(this AzureCdnCustomDomainListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnCustomDomainShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnCustomDomainShowSettingsExtensions
    {
        #region EndpointName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainShowSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings SetEndpointName(this AzureCdnCustomDomainShowSettings toolSettings, string endpointName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = endpointName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainShowSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings ResetEndpointName(this AzureCdnCustomDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainShowSettings.Name"/></em></p>
        ///   <p>Name of the custom domain.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings SetName(this AzureCdnCustomDomainShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainShowSettings.Name"/></em></p>
        ///   <p>Name of the custom domain.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings ResetName(this AzureCdnCustomDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainShowSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings SetProfileName(this AzureCdnCustomDomainShowSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainShowSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings ResetProfileName(this AzureCdnCustomDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings SetResourceGroup(this AzureCdnCustomDomainShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings ResetResourceGroup(this AzureCdnCustomDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings SetSubscription(this AzureCdnCustomDomainShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings ResetSubscription(this AzureCdnCustomDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings SetDebug(this AzureCdnCustomDomainShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings ResetDebug(this AzureCdnCustomDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings SetHelp(this AzureCdnCustomDomainShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings ResetHelp(this AzureCdnCustomDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings SetOutput(this AzureCdnCustomDomainShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings ResetOutput(this AzureCdnCustomDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings SetQuery(this AzureCdnCustomDomainShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings ResetQuery(this AzureCdnCustomDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnCustomDomainShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings SetVerbose(this AzureCdnCustomDomainShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnCustomDomainShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnCustomDomainShowSettings ResetVerbose(this AzureCdnCustomDomainShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnProfileCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnProfileCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileCreateSettings.Name"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings SetName(this AzureCdnProfileCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileCreateSettings.Name"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings ResetName(this AzureCdnProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings SetResourceGroup(this AzureCdnProfileCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings ResetResourceGroup(this AzureCdnProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings SetLocation(this AzureCdnProfileCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings ResetLocation(this AzureCdnProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileCreateSettings.Sku"/></em></p>
        ///   <p>The pricing tier (defines a CDN provider, feature list and rate) of the CDN profile. Defaults to Standard_Akamai.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings SetSku(this AzureCdnProfileCreateSettings toolSettings, CdnProfileCreateSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileCreateSettings.Sku"/></em></p>
        ///   <p>The pricing tier (defines a CDN provider, feature list and rate) of the CDN profile. Defaults to Standard_Akamai.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings ResetSku(this AzureCdnProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings SetTags(this AzureCdnProfileCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings ResetTags(this AzureCdnProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings SetSubscription(this AzureCdnProfileCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings ResetSubscription(this AzureCdnProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings SetDebug(this AzureCdnProfileCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings ResetDebug(this AzureCdnProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings SetHelp(this AzureCdnProfileCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings ResetHelp(this AzureCdnProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings SetOutput(this AzureCdnProfileCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings ResetOutput(this AzureCdnProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings SetQuery(this AzureCdnProfileCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings ResetQuery(this AzureCdnProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings SetVerbose(this AzureCdnProfileCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileCreateSettings ResetVerbose(this AzureCdnProfileCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnProfileDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnProfileDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings SetIds(this AzureCdnProfileDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings SetIds(this AzureCdnProfileDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnProfileDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings AddIds(this AzureCdnProfileDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnProfileDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings AddIds(this AzureCdnProfileDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCdnProfileDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings ClearIds(this AzureCdnProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnProfileDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings RemoveIds(this AzureCdnProfileDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnProfileDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings RemoveIds(this AzureCdnProfileDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileDeleteSettings.Name"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings SetName(this AzureCdnProfileDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileDeleteSettings.Name"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings ResetName(this AzureCdnProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings SetResourceGroup(this AzureCdnProfileDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings ResetResourceGroup(this AzureCdnProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings SetSubscription(this AzureCdnProfileDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings ResetSubscription(this AzureCdnProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings SetDebug(this AzureCdnProfileDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings ResetDebug(this AzureCdnProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings SetHelp(this AzureCdnProfileDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings ResetHelp(this AzureCdnProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings SetOutput(this AzureCdnProfileDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings ResetOutput(this AzureCdnProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings SetQuery(this AzureCdnProfileDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings ResetQuery(this AzureCdnProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings SetVerbose(this AzureCdnProfileDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileDeleteSettings ResetVerbose(this AzureCdnProfileDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnProfileListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnProfileListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileListSettings SetResourceGroup(this AzureCdnProfileListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileListSettings ResetResourceGroup(this AzureCdnProfileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileListSettings SetSubscription(this AzureCdnProfileListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileListSettings ResetSubscription(this AzureCdnProfileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileListSettings SetDebug(this AzureCdnProfileListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileListSettings ResetDebug(this AzureCdnProfileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileListSettings SetHelp(this AzureCdnProfileListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileListSettings ResetHelp(this AzureCdnProfileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileListSettings SetOutput(this AzureCdnProfileListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileListSettings ResetOutput(this AzureCdnProfileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileListSettings SetQuery(this AzureCdnProfileListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileListSettings ResetQuery(this AzureCdnProfileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileListSettings SetVerbose(this AzureCdnProfileListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileListSettings ResetVerbose(this AzureCdnProfileListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnProfileShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnProfileShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings SetIds(this AzureCdnProfileShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings SetIds(this AzureCdnProfileShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnProfileShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings AddIds(this AzureCdnProfileShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnProfileShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings AddIds(this AzureCdnProfileShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCdnProfileShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings ClearIds(this AzureCdnProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnProfileShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings RemoveIds(this AzureCdnProfileShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnProfileShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings RemoveIds(this AzureCdnProfileShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileShowSettings.Name"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings SetName(this AzureCdnProfileShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileShowSettings.Name"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings ResetName(this AzureCdnProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings SetResourceGroup(this AzureCdnProfileShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings ResetResourceGroup(this AzureCdnProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings SetSubscription(this AzureCdnProfileShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings ResetSubscription(this AzureCdnProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings SetDebug(this AzureCdnProfileShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings ResetDebug(this AzureCdnProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings SetHelp(this AzureCdnProfileShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings ResetHelp(this AzureCdnProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings SetOutput(this AzureCdnProfileShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings ResetOutput(this AzureCdnProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings SetQuery(this AzureCdnProfileShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings ResetQuery(this AzureCdnProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings SetVerbose(this AzureCdnProfileShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileShowSettings ResetVerbose(this AzureCdnProfileShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnProfileUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnProfileUpdateSettingsExtensions
    {
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetTags(this AzureCdnProfileUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings ResetTags(this AzureCdnProfileUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetIds(this AzureCdnProfileUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetIds(this AzureCdnProfileUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnProfileUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings AddIds(this AzureCdnProfileUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnProfileUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings AddIds(this AzureCdnProfileUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCdnProfileUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings ClearIds(this AzureCdnProfileUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnProfileUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings RemoveIds(this AzureCdnProfileUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnProfileUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings RemoveIds(this AzureCdnProfileUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.Name"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetName(this AzureCdnProfileUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUpdateSettings.Name"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings ResetName(this AzureCdnProfileUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetResourceGroup(this AzureCdnProfileUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings ResetResourceGroup(this AzureCdnProfileUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetSubscription(this AzureCdnProfileUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings ResetSubscription(this AzureCdnProfileUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetAdd(this AzureCdnProfileUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings ResetAdd(this AzureCdnProfileUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetForceString(this AzureCdnProfileUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings ResetForceString(this AzureCdnProfileUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetRemove(this AzureCdnProfileUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings ResetRemove(this AzureCdnProfileUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetSet(this AzureCdnProfileUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings ResetSet(this AzureCdnProfileUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetDebug(this AzureCdnProfileUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings ResetDebug(this AzureCdnProfileUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetHelp(this AzureCdnProfileUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings ResetHelp(this AzureCdnProfileUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetOutput(this AzureCdnProfileUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings ResetOutput(this AzureCdnProfileUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetQuery(this AzureCdnProfileUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings ResetQuery(this AzureCdnProfileUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings SetVerbose(this AzureCdnProfileUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUpdateSettings ResetVerbose(this AzureCdnProfileUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnProfileUsageSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnProfileUsageSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUsageSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings SetIds(this AzureCdnProfileUsageSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUsageSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings SetIds(this AzureCdnProfileUsageSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnProfileUsageSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings AddIds(this AzureCdnProfileUsageSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnProfileUsageSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings AddIds(this AzureCdnProfileUsageSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCdnProfileUsageSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings ClearIds(this AzureCdnProfileUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnProfileUsageSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings RemoveIds(this AzureCdnProfileUsageSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnProfileUsageSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings RemoveIds(this AzureCdnProfileUsageSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUsageSettings.Name"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings SetName(this AzureCdnProfileUsageSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUsageSettings.Name"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings ResetName(this AzureCdnProfileUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUsageSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings SetResourceGroup(this AzureCdnProfileUsageSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUsageSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings ResetResourceGroup(this AzureCdnProfileUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUsageSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings SetSubscription(this AzureCdnProfileUsageSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUsageSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings ResetSubscription(this AzureCdnProfileUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUsageSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings SetDebug(this AzureCdnProfileUsageSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUsageSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings ResetDebug(this AzureCdnProfileUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUsageSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings SetHelp(this AzureCdnProfileUsageSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUsageSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings ResetHelp(this AzureCdnProfileUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUsageSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings SetOutput(this AzureCdnProfileUsageSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUsageSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings ResetOutput(this AzureCdnProfileUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUsageSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings SetQuery(this AzureCdnProfileUsageSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUsageSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings ResetQuery(this AzureCdnProfileUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnProfileUsageSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings SetVerbose(this AzureCdnProfileUsageSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnProfileUsageSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnProfileUsageSettings ResetVerbose(this AzureCdnProfileUsageSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnEndpointCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnEndpointCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetName(this AzureCdnEndpointCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetName(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Origin
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.Origin"/></em></p>
        ///   <p>Endpoint origin specified by the following space-delimited 3 tuple: `www.example.com http_port https_port`. The HTTP and HTTPsports are optional and will default to 80 and 443 respectively.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetOrigin(this AzureCdnEndpointCreateSettings toolSettings, string origin)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Origin = origin;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.Origin"/></em></p>
        ///   <p>Endpoint origin specified by the following space-delimited 3 tuple: `www.example.com http_port https_port`. The HTTP and HTTPsports are optional and will default to 80 and 443 respectively.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetOrigin(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Origin = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetProfileName(this AzureCdnEndpointCreateSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetProfileName(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetResourceGroup(this AzureCdnEndpointCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetResourceGroup(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region ContentTypesToCompress
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.ContentTypesToCompress"/></em></p>
        ///   <p>List of content types on which compression applies. The value should be a valid MIME type.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetContentTypesToCompress(this AzureCdnEndpointCreateSettings toolSettings, string contentTypesToCompress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentTypesToCompress = contentTypesToCompress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.ContentTypesToCompress"/></em></p>
        ///   <p>List of content types on which compression applies. The value should be a valid MIME type.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetContentTypesToCompress(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentTypesToCompress = null;
            return toolSettings;
        }
        #endregion
        #region EnableCompression
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.EnableCompression"/></em></p>
        ///   <p>If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetEnableCompression(this AzureCdnEndpointCreateSettings toolSettings, bool? enableCompression)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCompression = enableCompression;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.EnableCompression"/></em></p>
        ///   <p>If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetEnableCompression(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCompression = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCdnEndpointCreateSettings.EnableCompression"/></em></p>
        ///   <p>If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings EnableEnableCompression(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCompression = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCdnEndpointCreateSettings.EnableCompression"/></em></p>
        ///   <p>If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings DisableEnableCompression(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCompression = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCdnEndpointCreateSettings.EnableCompression"/></em></p>
        ///   <p>If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ToggleEnableCompression(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCompression = !toolSettings.EnableCompression;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetLocation(this AzureCdnEndpointCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetLocation(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region NoHttp
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.NoHttp"/></em></p>
        ///   <p>Indicates whether HTTP traffic is not allowed on the endpoint. Default is to allow HTTP traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetNoHttp(this AzureCdnEndpointCreateSettings toolSettings, bool? noHttp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttp = noHttp;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.NoHttp"/></em></p>
        ///   <p>Indicates whether HTTP traffic is not allowed on the endpoint. Default is to allow HTTP traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetNoHttp(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttp = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCdnEndpointCreateSettings.NoHttp"/></em></p>
        ///   <p>Indicates whether HTTP traffic is not allowed on the endpoint. Default is to allow HTTP traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings EnableNoHttp(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttp = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCdnEndpointCreateSettings.NoHttp"/></em></p>
        ///   <p>Indicates whether HTTP traffic is not allowed on the endpoint. Default is to allow HTTP traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings DisableNoHttp(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttp = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCdnEndpointCreateSettings.NoHttp"/></em></p>
        ///   <p>Indicates whether HTTP traffic is not allowed on the endpoint. Default is to allow HTTP traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ToggleNoHttp(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttp = !toolSettings.NoHttp;
            return toolSettings;
        }
        #endregion
        #region NoHttps
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.NoHttps"/></em></p>
        ///   <p>Indicates whether HTTPS traffic is not allowed on the endpoint. Default is to allow HTTPS traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetNoHttps(this AzureCdnEndpointCreateSettings toolSettings, bool? noHttps)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttps = noHttps;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.NoHttps"/></em></p>
        ///   <p>Indicates whether HTTPS traffic is not allowed on the endpoint. Default is to allow HTTPS traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetNoHttps(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttps = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCdnEndpointCreateSettings.NoHttps"/></em></p>
        ///   <p>Indicates whether HTTPS traffic is not allowed on the endpoint. Default is to allow HTTPS traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings EnableNoHttps(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttps = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCdnEndpointCreateSettings.NoHttps"/></em></p>
        ///   <p>Indicates whether HTTPS traffic is not allowed on the endpoint. Default is to allow HTTPS traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings DisableNoHttps(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttps = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCdnEndpointCreateSettings.NoHttps"/></em></p>
        ///   <p>Indicates whether HTTPS traffic is not allowed on the endpoint. Default is to allow HTTPS traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ToggleNoHttps(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttps = !toolSettings.NoHttps;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetNoWait(this AzureCdnEndpointCreateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetNoWait(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCdnEndpointCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings EnableNoWait(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCdnEndpointCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings DisableNoWait(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCdnEndpointCreateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ToggleNoWait(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region OriginHostHeader
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.OriginHostHeader"/></em></p>
        ///   <p>The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetOriginHostHeader(this AzureCdnEndpointCreateSettings toolSettings, string originHostHeader)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OriginHostHeader = originHostHeader;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.OriginHostHeader"/></em></p>
        ///   <p>The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetOriginHostHeader(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OriginHostHeader = null;
            return toolSettings;
        }
        #endregion
        #region OriginPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.OriginPath"/></em></p>
        ///   <p>A directory path on the origin that CDN can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetOriginPath(this AzureCdnEndpointCreateSettings toolSettings, string originPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OriginPath = originPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.OriginPath"/></em></p>
        ///   <p>A directory path on the origin that CDN can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetOriginPath(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OriginPath = null;
            return toolSettings;
        }
        #endregion
        #region QueryStringCaching
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.QueryStringCaching"/></em></p>
        ///   <p>Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetQueryStringCaching(this AzureCdnEndpointCreateSettings toolSettings, CdnEndpointQueryStringCaching queryStringCaching)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.QueryStringCaching = queryStringCaching;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.QueryStringCaching"/></em></p>
        ///   <p>Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetQueryStringCaching(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.QueryStringCaching = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetTags(this AzureCdnEndpointCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetTags(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetSubscription(this AzureCdnEndpointCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetSubscription(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetDebug(this AzureCdnEndpointCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetDebug(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetHelp(this AzureCdnEndpointCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetHelp(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetOutput(this AzureCdnEndpointCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetOutput(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetQuery(this AzureCdnEndpointCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetQuery(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings SetVerbose(this AzureCdnEndpointCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointCreateSettings ResetVerbose(this AzureCdnEndpointCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnEndpointDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnEndpointDeleteSettingsExtensions
    {
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings SetNoWait(this AzureCdnEndpointDeleteSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings ResetNoWait(this AzureCdnEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCdnEndpointDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings EnableNoWait(this AzureCdnEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCdnEndpointDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings DisableNoWait(this AzureCdnEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCdnEndpointDeleteSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings ToggleNoWait(this AzureCdnEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings SetIds(this AzureCdnEndpointDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings SetIds(this AzureCdnEndpointDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings AddIds(this AzureCdnEndpointDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings AddIds(this AzureCdnEndpointDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCdnEndpointDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings ClearIds(this AzureCdnEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings RemoveIds(this AzureCdnEndpointDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings RemoveIds(this AzureCdnEndpointDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointDeleteSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings SetName(this AzureCdnEndpointDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointDeleteSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings ResetName(this AzureCdnEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointDeleteSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings SetProfileName(this AzureCdnEndpointDeleteSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointDeleteSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings ResetProfileName(this AzureCdnEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings SetResourceGroup(this AzureCdnEndpointDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings ResetResourceGroup(this AzureCdnEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings SetSubscription(this AzureCdnEndpointDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings ResetSubscription(this AzureCdnEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings SetDebug(this AzureCdnEndpointDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings ResetDebug(this AzureCdnEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings SetHelp(this AzureCdnEndpointDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings ResetHelp(this AzureCdnEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings SetOutput(this AzureCdnEndpointDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings ResetOutput(this AzureCdnEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings SetQuery(this AzureCdnEndpointDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings ResetQuery(this AzureCdnEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings SetVerbose(this AzureCdnEndpointDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointDeleteSettings ResetVerbose(this AzureCdnEndpointDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnEndpointListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnEndpointListSettingsExtensions
    {
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointListSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings SetProfileName(this AzureCdnEndpointListSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointListSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings ResetProfileName(this AzureCdnEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings SetResourceGroup(this AzureCdnEndpointListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings ResetResourceGroup(this AzureCdnEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings SetSubscription(this AzureCdnEndpointListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings ResetSubscription(this AzureCdnEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings SetDebug(this AzureCdnEndpointListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings ResetDebug(this AzureCdnEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings SetHelp(this AzureCdnEndpointListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings ResetHelp(this AzureCdnEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings SetOutput(this AzureCdnEndpointListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings ResetOutput(this AzureCdnEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings SetQuery(this AzureCdnEndpointListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings ResetQuery(this AzureCdnEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings SetVerbose(this AzureCdnEndpointListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointListSettings ResetVerbose(this AzureCdnEndpointListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnEndpointLoadSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnEndpointLoadSettingsExtensions
    {
        #region ContentPaths
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointLoadSettings.ContentPaths"/></em></p>
        ///   <p>The path to the content to be loaded. Path should be a relative file URL of the origin.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings SetContentPaths(this AzureCdnEndpointLoadSettings toolSettings, string contentPaths)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentPaths = contentPaths;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointLoadSettings.ContentPaths"/></em></p>
        ///   <p>The path to the content to be loaded. Path should be a relative file URL of the origin.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings ResetContentPaths(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentPaths = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointLoadSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings SetNoWait(this AzureCdnEndpointLoadSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointLoadSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings ResetNoWait(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCdnEndpointLoadSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings EnableNoWait(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCdnEndpointLoadSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings DisableNoWait(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCdnEndpointLoadSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings ToggleNoWait(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointLoadSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings SetIds(this AzureCdnEndpointLoadSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointLoadSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings SetIds(this AzureCdnEndpointLoadSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointLoadSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings AddIds(this AzureCdnEndpointLoadSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointLoadSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings AddIds(this AzureCdnEndpointLoadSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCdnEndpointLoadSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings ClearIds(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointLoadSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings RemoveIds(this AzureCdnEndpointLoadSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointLoadSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings RemoveIds(this AzureCdnEndpointLoadSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointLoadSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings SetName(this AzureCdnEndpointLoadSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointLoadSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings ResetName(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointLoadSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings SetProfileName(this AzureCdnEndpointLoadSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointLoadSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings ResetProfileName(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointLoadSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings SetResourceGroup(this AzureCdnEndpointLoadSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointLoadSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings ResetResourceGroup(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointLoadSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings SetSubscription(this AzureCdnEndpointLoadSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointLoadSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings ResetSubscription(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointLoadSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings SetDebug(this AzureCdnEndpointLoadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointLoadSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings ResetDebug(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointLoadSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings SetHelp(this AzureCdnEndpointLoadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointLoadSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings ResetHelp(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointLoadSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings SetOutput(this AzureCdnEndpointLoadSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointLoadSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings ResetOutput(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointLoadSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings SetQuery(this AzureCdnEndpointLoadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointLoadSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings ResetQuery(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointLoadSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings SetVerbose(this AzureCdnEndpointLoadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointLoadSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointLoadSettings ResetVerbose(this AzureCdnEndpointLoadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnEndpointPurgeSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnEndpointPurgeSettingsExtensions
    {
        #region ContentPaths
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointPurgeSettings.ContentPaths"/></em></p>
        ///   <p>The path to the content to be purged. Can describe a file path or a wild card directory.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings SetContentPaths(this AzureCdnEndpointPurgeSettings toolSettings, string contentPaths)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentPaths = contentPaths;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointPurgeSettings.ContentPaths"/></em></p>
        ///   <p>The path to the content to be purged. Can describe a file path or a wild card directory.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings ResetContentPaths(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentPaths = null;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointPurgeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings SetNoWait(this AzureCdnEndpointPurgeSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointPurgeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings ResetNoWait(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCdnEndpointPurgeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings EnableNoWait(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCdnEndpointPurgeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings DisableNoWait(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCdnEndpointPurgeSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings ToggleNoWait(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointPurgeSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings SetIds(this AzureCdnEndpointPurgeSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointPurgeSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings SetIds(this AzureCdnEndpointPurgeSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointPurgeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings AddIds(this AzureCdnEndpointPurgeSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointPurgeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings AddIds(this AzureCdnEndpointPurgeSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCdnEndpointPurgeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings ClearIds(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointPurgeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings RemoveIds(this AzureCdnEndpointPurgeSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointPurgeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings RemoveIds(this AzureCdnEndpointPurgeSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointPurgeSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings SetName(this AzureCdnEndpointPurgeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointPurgeSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings ResetName(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointPurgeSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings SetProfileName(this AzureCdnEndpointPurgeSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointPurgeSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings ResetProfileName(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointPurgeSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings SetResourceGroup(this AzureCdnEndpointPurgeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointPurgeSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings ResetResourceGroup(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointPurgeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings SetSubscription(this AzureCdnEndpointPurgeSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointPurgeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings ResetSubscription(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointPurgeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings SetDebug(this AzureCdnEndpointPurgeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointPurgeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings ResetDebug(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointPurgeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings SetHelp(this AzureCdnEndpointPurgeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointPurgeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings ResetHelp(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointPurgeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings SetOutput(this AzureCdnEndpointPurgeSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointPurgeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings ResetOutput(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointPurgeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings SetQuery(this AzureCdnEndpointPurgeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointPurgeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings ResetQuery(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointPurgeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings SetVerbose(this AzureCdnEndpointPurgeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointPurgeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointPurgeSettings ResetVerbose(this AzureCdnEndpointPurgeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnEndpointShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnEndpointShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings SetIds(this AzureCdnEndpointShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings SetIds(this AzureCdnEndpointShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings AddIds(this AzureCdnEndpointShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings AddIds(this AzureCdnEndpointShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCdnEndpointShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings ClearIds(this AzureCdnEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings RemoveIds(this AzureCdnEndpointShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings RemoveIds(this AzureCdnEndpointShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointShowSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings SetName(this AzureCdnEndpointShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointShowSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings ResetName(this AzureCdnEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointShowSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings SetProfileName(this AzureCdnEndpointShowSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointShowSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings ResetProfileName(this AzureCdnEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings SetResourceGroup(this AzureCdnEndpointShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings ResetResourceGroup(this AzureCdnEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings SetSubscription(this AzureCdnEndpointShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings ResetSubscription(this AzureCdnEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings SetDebug(this AzureCdnEndpointShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings ResetDebug(this AzureCdnEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings SetHelp(this AzureCdnEndpointShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings ResetHelp(this AzureCdnEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings SetOutput(this AzureCdnEndpointShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings ResetOutput(this AzureCdnEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings SetQuery(this AzureCdnEndpointShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings ResetQuery(this AzureCdnEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings SetVerbose(this AzureCdnEndpointShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointShowSettings ResetVerbose(this AzureCdnEndpointShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnEndpointStartSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnEndpointStartSettingsExtensions
    {
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings SetNoWait(this AzureCdnEndpointStartSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings ResetNoWait(this AzureCdnEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCdnEndpointStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings EnableNoWait(this AzureCdnEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCdnEndpointStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings DisableNoWait(this AzureCdnEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCdnEndpointStartSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings ToggleNoWait(this AzureCdnEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStartSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings SetIds(this AzureCdnEndpointStartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStartSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings SetIds(this AzureCdnEndpointStartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointStartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings AddIds(this AzureCdnEndpointStartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointStartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings AddIds(this AzureCdnEndpointStartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCdnEndpointStartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings ClearIds(this AzureCdnEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointStartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings RemoveIds(this AzureCdnEndpointStartSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointStartSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings RemoveIds(this AzureCdnEndpointStartSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStartSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings SetName(this AzureCdnEndpointStartSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStartSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings ResetName(this AzureCdnEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStartSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings SetProfileName(this AzureCdnEndpointStartSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStartSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings ResetProfileName(this AzureCdnEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings SetResourceGroup(this AzureCdnEndpointStartSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStartSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings ResetResourceGroup(this AzureCdnEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings SetSubscription(this AzureCdnEndpointStartSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStartSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings ResetSubscription(this AzureCdnEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings SetDebug(this AzureCdnEndpointStartSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStartSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings ResetDebug(this AzureCdnEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings SetHelp(this AzureCdnEndpointStartSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStartSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings ResetHelp(this AzureCdnEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings SetOutput(this AzureCdnEndpointStartSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStartSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings ResetOutput(this AzureCdnEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings SetQuery(this AzureCdnEndpointStartSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStartSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings ResetQuery(this AzureCdnEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings SetVerbose(this AzureCdnEndpointStartSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStartSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStartSettings ResetVerbose(this AzureCdnEndpointStartSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnEndpointStopSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnEndpointStopSettingsExtensions
    {
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings SetNoWait(this AzureCdnEndpointStopSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings ResetNoWait(this AzureCdnEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCdnEndpointStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings EnableNoWait(this AzureCdnEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCdnEndpointStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings DisableNoWait(this AzureCdnEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCdnEndpointStopSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings ToggleNoWait(this AzureCdnEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStopSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings SetIds(this AzureCdnEndpointStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStopSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings SetIds(this AzureCdnEndpointStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings AddIds(this AzureCdnEndpointStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings AddIds(this AzureCdnEndpointStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCdnEndpointStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings ClearIds(this AzureCdnEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings RemoveIds(this AzureCdnEndpointStopSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointStopSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings RemoveIds(this AzureCdnEndpointStopSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStopSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings SetName(this AzureCdnEndpointStopSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStopSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings ResetName(this AzureCdnEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStopSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings SetProfileName(this AzureCdnEndpointStopSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStopSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings ResetProfileName(this AzureCdnEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings SetResourceGroup(this AzureCdnEndpointStopSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStopSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings ResetResourceGroup(this AzureCdnEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings SetSubscription(this AzureCdnEndpointStopSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStopSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings ResetSubscription(this AzureCdnEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings SetDebug(this AzureCdnEndpointStopSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStopSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings ResetDebug(this AzureCdnEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings SetHelp(this AzureCdnEndpointStopSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStopSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings ResetHelp(this AzureCdnEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings SetOutput(this AzureCdnEndpointStopSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStopSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings ResetOutput(this AzureCdnEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings SetQuery(this AzureCdnEndpointStopSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStopSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings ResetQuery(this AzureCdnEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings SetVerbose(this AzureCdnEndpointStopSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointStopSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointStopSettings ResetVerbose(this AzureCdnEndpointStopSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnEndpointUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnEndpointUpdateSettingsExtensions
    {
        #region ContentTypesToCompress
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.ContentTypesToCompress"/></em></p>
        ///   <p>List of content types on which compression applies. The value should be a valid MIME type.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetContentTypesToCompress(this AzureCdnEndpointUpdateSettings toolSettings, string contentTypesToCompress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentTypesToCompress = contentTypesToCompress;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.ContentTypesToCompress"/></em></p>
        ///   <p>List of content types on which compression applies. The value should be a valid MIME type.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetContentTypesToCompress(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ContentTypesToCompress = null;
            return toolSettings;
        }
        #endregion
        #region EnableCompression
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.EnableCompression"/></em></p>
        ///   <p>If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetEnableCompression(this AzureCdnEndpointUpdateSettings toolSettings, bool? enableCompression)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCompression = enableCompression;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.EnableCompression"/></em></p>
        ///   <p>If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetEnableCompression(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCompression = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCdnEndpointUpdateSettings.EnableCompression"/></em></p>
        ///   <p>If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings EnableEnableCompression(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCompression = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCdnEndpointUpdateSettings.EnableCompression"/></em></p>
        ///   <p>If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings DisableEnableCompression(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCompression = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCdnEndpointUpdateSettings.EnableCompression"/></em></p>
        ///   <p>If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ToggleEnableCompression(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCompression = !toolSettings.EnableCompression;
            return toolSettings;
        }
        #endregion
        #region NoHttp
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.NoHttp"/></em></p>
        ///   <p>Indicates whether HTTP traffic is not allowed on the endpoint. Default is to allow HTTP traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetNoHttp(this AzureCdnEndpointUpdateSettings toolSettings, bool? noHttp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttp = noHttp;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.NoHttp"/></em></p>
        ///   <p>Indicates whether HTTP traffic is not allowed on the endpoint. Default is to allow HTTP traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetNoHttp(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttp = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCdnEndpointUpdateSettings.NoHttp"/></em></p>
        ///   <p>Indicates whether HTTP traffic is not allowed on the endpoint. Default is to allow HTTP traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings EnableNoHttp(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttp = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCdnEndpointUpdateSettings.NoHttp"/></em></p>
        ///   <p>Indicates whether HTTP traffic is not allowed on the endpoint. Default is to allow HTTP traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings DisableNoHttp(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttp = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCdnEndpointUpdateSettings.NoHttp"/></em></p>
        ///   <p>Indicates whether HTTP traffic is not allowed on the endpoint. Default is to allow HTTP traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ToggleNoHttp(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttp = !toolSettings.NoHttp;
            return toolSettings;
        }
        #endregion
        #region NoHttps
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.NoHttps"/></em></p>
        ///   <p>Indicates whether HTTPS traffic is not allowed on the endpoint. Default is to allow HTTPS traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetNoHttps(this AzureCdnEndpointUpdateSettings toolSettings, bool? noHttps)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttps = noHttps;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.NoHttps"/></em></p>
        ///   <p>Indicates whether HTTPS traffic is not allowed on the endpoint. Default is to allow HTTPS traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetNoHttps(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttps = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCdnEndpointUpdateSettings.NoHttps"/></em></p>
        ///   <p>Indicates whether HTTPS traffic is not allowed on the endpoint. Default is to allow HTTPS traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings EnableNoHttps(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttps = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCdnEndpointUpdateSettings.NoHttps"/></em></p>
        ///   <p>Indicates whether HTTPS traffic is not allowed on the endpoint. Default is to allow HTTPS traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings DisableNoHttps(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttps = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCdnEndpointUpdateSettings.NoHttps"/></em></p>
        ///   <p>Indicates whether HTTPS traffic is not allowed on the endpoint. Default is to allow HTTPS traffic.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ToggleNoHttps(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoHttps = !toolSettings.NoHttps;
            return toolSettings;
        }
        #endregion
        #region NoWait
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetNoWait(this AzureCdnEndpointUpdateSettings toolSettings, bool? noWait)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = noWait;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetNoWait(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCdnEndpointUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings EnableNoWait(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCdnEndpointUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings DisableNoWait(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCdnEndpointUpdateSettings.NoWait"/></em></p>
        ///   <p>Do not wait for the long-running operation to finish.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ToggleNoWait(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoWait = !toolSettings.NoWait;
            return toolSettings;
        }
        #endregion
        #region OriginHostHeader
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.OriginHostHeader"/></em></p>
        ///   <p>The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetOriginHostHeader(this AzureCdnEndpointUpdateSettings toolSettings, string originHostHeader)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OriginHostHeader = originHostHeader;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.OriginHostHeader"/></em></p>
        ///   <p>The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetOriginHostHeader(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OriginHostHeader = null;
            return toolSettings;
        }
        #endregion
        #region OriginPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.OriginPath"/></em></p>
        ///   <p>A directory path on the origin that CDN can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetOriginPath(this AzureCdnEndpointUpdateSettings toolSettings, string originPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OriginPath = originPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.OriginPath"/></em></p>
        ///   <p>A directory path on the origin that CDN can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetOriginPath(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OriginPath = null;
            return toolSettings;
        }
        #endregion
        #region QueryStringCaching
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.QueryStringCaching"/></em></p>
        ///   <p>Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetQueryStringCaching(this AzureCdnEndpointUpdateSettings toolSettings, CdnEndpointQueryStringCaching queryStringCaching)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.QueryStringCaching = queryStringCaching;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.QueryStringCaching"/></em></p>
        ///   <p>Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetQueryStringCaching(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.QueryStringCaching = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetTags(this AzureCdnEndpointUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetTags(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetIds(this AzureCdnEndpointUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetIds(this AzureCdnEndpointUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings AddIds(this AzureCdnEndpointUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings AddIds(this AzureCdnEndpointUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCdnEndpointUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ClearIds(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings RemoveIds(this AzureCdnEndpointUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings RemoveIds(this AzureCdnEndpointUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetName(this AzureCdnEndpointUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetName(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetProfileName(this AzureCdnEndpointUpdateSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetProfileName(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetResourceGroup(this AzureCdnEndpointUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetResourceGroup(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetSubscription(this AzureCdnEndpointUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetSubscription(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetAdd(this AzureCdnEndpointUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.Add"/></em></p>
        ///   <p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetAdd(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetForceString(this AzureCdnEndpointUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.ForceString"/></em></p>
        ///   <p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetForceString(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetRemove(this AzureCdnEndpointUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.Remove"/></em></p>
        ///   <p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetRemove(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetSet(this AzureCdnEndpointUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.Set"/></em></p>
        ///   <p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetSet(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetDebug(this AzureCdnEndpointUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetDebug(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetHelp(this AzureCdnEndpointUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetHelp(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetOutput(this AzureCdnEndpointUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetOutput(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetQuery(this AzureCdnEndpointUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetQuery(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings SetVerbose(this AzureCdnEndpointUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointUpdateSettings ResetVerbose(this AzureCdnEndpointUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnEndpointValidateCustomDomainSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnEndpointValidateCustomDomainSettingsExtensions
    {
        #region HostName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointValidateCustomDomainSettings.HostName"/></em></p>
        ///   <p>The host name of the custom domain. Must be a domain name.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings SetHostName(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, string hostName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HostName = hostName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointValidateCustomDomainSettings.HostName"/></em></p>
        ///   <p>The host name of the custom domain. Must be a domain name.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings ResetHostName(this AzureCdnEndpointValidateCustomDomainSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.HostName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings SetIds(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings SetIds(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointValidateCustomDomainSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings AddIds(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnEndpointValidateCustomDomainSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings AddIds(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCdnEndpointValidateCustomDomainSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings ClearIds(this AzureCdnEndpointValidateCustomDomainSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointValidateCustomDomainSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings RemoveIds(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnEndpointValidateCustomDomainSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings RemoveIds(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings SetName(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Name"/></em></p>
        ///   <p>Name of the CDN endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings ResetName(this AzureCdnEndpointValidateCustomDomainSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointValidateCustomDomainSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings SetProfileName(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointValidateCustomDomainSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings ResetProfileName(this AzureCdnEndpointValidateCustomDomainSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointValidateCustomDomainSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings SetResourceGroup(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointValidateCustomDomainSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings ResetResourceGroup(this AzureCdnEndpointValidateCustomDomainSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings SetSubscription(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings ResetSubscription(this AzureCdnEndpointValidateCustomDomainSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings SetDebug(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings ResetDebug(this AzureCdnEndpointValidateCustomDomainSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings SetHelp(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings ResetHelp(this AzureCdnEndpointValidateCustomDomainSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings SetOutput(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings ResetOutput(this AzureCdnEndpointValidateCustomDomainSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings SetQuery(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings ResetQuery(this AzureCdnEndpointValidateCustomDomainSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings SetVerbose(this AzureCdnEndpointValidateCustomDomainSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEndpointValidateCustomDomainSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEndpointValidateCustomDomainSettings ResetVerbose(this AzureCdnEndpointValidateCustomDomainSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnEdgeNodeListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnEdgeNodeListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEdgeNodeListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEdgeNodeListSettings SetSubscription(this AzureCdnEdgeNodeListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEdgeNodeListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEdgeNodeListSettings ResetSubscription(this AzureCdnEdgeNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEdgeNodeListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEdgeNodeListSettings SetDebug(this AzureCdnEdgeNodeListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEdgeNodeListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEdgeNodeListSettings ResetDebug(this AzureCdnEdgeNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEdgeNodeListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEdgeNodeListSettings SetHelp(this AzureCdnEdgeNodeListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEdgeNodeListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEdgeNodeListSettings ResetHelp(this AzureCdnEdgeNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEdgeNodeListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEdgeNodeListSettings SetOutput(this AzureCdnEdgeNodeListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEdgeNodeListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEdgeNodeListSettings ResetOutput(this AzureCdnEdgeNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEdgeNodeListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEdgeNodeListSettings SetQuery(this AzureCdnEdgeNodeListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEdgeNodeListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEdgeNodeListSettings ResetQuery(this AzureCdnEdgeNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnEdgeNodeListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEdgeNodeListSettings SetVerbose(this AzureCdnEdgeNodeListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnEdgeNodeListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnEdgeNodeListSettings ResetVerbose(this AzureCdnEdgeNodeListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnOriginListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnOriginListSettingsExtensions
    {
        #region EndpointName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginListSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings SetEndpointName(this AzureCdnOriginListSettings toolSettings, string endpointName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = endpointName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginListSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings ResetEndpointName(this AzureCdnOriginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginListSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings SetProfileName(this AzureCdnOriginListSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginListSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings ResetProfileName(this AzureCdnOriginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings SetResourceGroup(this AzureCdnOriginListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings ResetResourceGroup(this AzureCdnOriginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings SetSubscription(this AzureCdnOriginListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings ResetSubscription(this AzureCdnOriginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings SetDebug(this AzureCdnOriginListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings ResetDebug(this AzureCdnOriginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings SetHelp(this AzureCdnOriginListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings ResetHelp(this AzureCdnOriginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings SetOutput(this AzureCdnOriginListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings ResetOutput(this AzureCdnOriginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings SetQuery(this AzureCdnOriginListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings ResetQuery(this AzureCdnOriginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings SetVerbose(this AzureCdnOriginListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginListSettings ResetVerbose(this AzureCdnOriginListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCdnOriginShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCdnOriginShowSettingsExtensions
    {
        #region EndpointName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginShowSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings SetEndpointName(this AzureCdnOriginShowSettings toolSettings, string endpointName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = endpointName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginShowSettings.EndpointName"/></em></p>
        ///   <p>Name of the endpoint under the profile which is unique globally.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings ResetEndpointName(this AzureCdnOriginShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndpointName = null;
            return toolSettings;
        }
        #endregion
        #region ProfileName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginShowSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings SetProfileName(this AzureCdnOriginShowSettings toolSettings, string profileName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = profileName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginShowSettings.ProfileName"/></em></p>
        ///   <p>Name of the CDN profile which is unique within the resource group.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings ResetProfileName(this AzureCdnOriginShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProfileName = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings SetIds(this AzureCdnOriginShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings SetIds(this AzureCdnOriginShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnOriginShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings AddIds(this AzureCdnOriginShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCdnOriginShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings AddIds(this AzureCdnOriginShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCdnOriginShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings ClearIds(this AzureCdnOriginShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnOriginShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings RemoveIds(this AzureCdnOriginShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCdnOriginShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings RemoveIds(this AzureCdnOriginShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginShowSettings.Name"/></em></p>
        ///   <p>Name of the origin which is unique within the endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings SetName(this AzureCdnOriginShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginShowSettings.Name"/></em></p>
        ///   <p>Name of the origin which is unique within the endpoint.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings ResetName(this AzureCdnOriginShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings SetResourceGroup(this AzureCdnOriginShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings ResetResourceGroup(this AzureCdnOriginShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings SetSubscription(this AzureCdnOriginShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings ResetSubscription(this AzureCdnOriginShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings SetDebug(this AzureCdnOriginShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings ResetDebug(this AzureCdnOriginShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings SetHelp(this AzureCdnOriginShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings ResetHelp(this AzureCdnOriginShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings SetOutput(this AzureCdnOriginShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings ResetOutput(this AzureCdnOriginShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings SetQuery(this AzureCdnOriginShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings ResetQuery(this AzureCdnOriginShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCdnOriginShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings SetVerbose(this AzureCdnOriginShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCdnOriginShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCdnOriginShowSettings ResetVerbose(this AzureCdnOriginShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region CdnProfileCreateSku
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<CdnProfileCreateSku>))]
    public partial class CdnProfileCreateSku : Enumeration
    {
        public static CdnProfileCreateSku custom_verizon = new CdnProfileCreateSku { Value = "custom_verizon" };
        public static CdnProfileCreateSku premium_verizon = new CdnProfileCreateSku { Value = "premium_verizon" };
        public static CdnProfileCreateSku standard_akamai = new CdnProfileCreateSku { Value = "standard_akamai" };
        public static CdnProfileCreateSku standard_chinacdn = new CdnProfileCreateSku { Value = "standard_chinacdn" };
        public static CdnProfileCreateSku standard_microsoft = new CdnProfileCreateSku { Value = "standard_microsoft" };
        public static CdnProfileCreateSku standard_verizon = new CdnProfileCreateSku { Value = "standard_verizon" };
    }
    #endregion
    #region CdnEndpointQueryStringCaching
    /// <summary>
    ///   Used within <see cref="AzureCdnTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<CdnEndpointQueryStringCaching>))]
    public partial class CdnEndpointQueryStringCaching : Enumeration
    {
        public static CdnEndpointQueryStringCaching bypasscaching = new CdnEndpointQueryStringCaching { Value = "bypasscaching" };
        public static CdnEndpointQueryStringCaching ignorequerystring = new CdnEndpointQueryStringCaching { Value = "ignorequerystring" };
        public static CdnEndpointQueryStringCaching notset = new CdnEndpointQueryStringCaching { Value = "notset" };
        public static CdnEndpointQueryStringCaching usequerystring = new CdnEndpointQueryStringCaching { Value = "usequerystring" };
    }
    #endregion
}
