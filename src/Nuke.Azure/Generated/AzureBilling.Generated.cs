// Generated from https://github.com/totollygeek/azure/blob/master/src/Nuke.Azure/specifications/AzureBilling.json
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
    public static partial class AzureBillingTasks
    {
        /// <summary>
        ///   Path to the AzureBilling executable.
        /// </summary>
        public static string AzureBillingPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREBILLING_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureBillingLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Billing.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBilling(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureBillingPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureBillingLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBilling(AzureBillingSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBillingSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBillingSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBillingSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBillingSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBillingSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBillingSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBilling(Configure<AzureBillingSettings> configurator)
        {
            return AzureBilling(configurator(new AzureBillingSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBillingSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBillingSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBillingSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBillingSettings.Query"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBillingSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBillingSettings Settings, IReadOnlyCollection<Output> Output)> AzureBilling(CombinatorialConfigure<AzureBillingSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBilling, AzureBillingLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBillingEnrollmentAccountList(AzureBillingEnrollmentAccountListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBillingEnrollmentAccountListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBillingEnrollmentAccountListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBillingEnrollmentAccountListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBillingEnrollmentAccountListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBillingEnrollmentAccountListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBillingEnrollmentAccountListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBillingEnrollmentAccountListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBillingEnrollmentAccountList(Configure<AzureBillingEnrollmentAccountListSettings> configurator)
        {
            return AzureBillingEnrollmentAccountList(configurator(new AzureBillingEnrollmentAccountListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBillingEnrollmentAccountListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBillingEnrollmentAccountListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBillingEnrollmentAccountListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBillingEnrollmentAccountListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBillingEnrollmentAccountListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBillingEnrollmentAccountListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBillingEnrollmentAccountListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBillingEnrollmentAccountList(CombinatorialConfigure<AzureBillingEnrollmentAccountListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBillingEnrollmentAccountList, AzureBillingLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBillingEnrollmentAccountShow(AzureBillingEnrollmentAccountShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBillingEnrollmentAccountShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBillingEnrollmentAccountShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBillingEnrollmentAccountShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBillingEnrollmentAccountShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBillingEnrollmentAccountShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBillingEnrollmentAccountShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBillingEnrollmentAccountShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBillingEnrollmentAccountShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBillingEnrollmentAccountShow(Configure<AzureBillingEnrollmentAccountShowSettings> configurator)
        {
            return AzureBillingEnrollmentAccountShow(configurator(new AzureBillingEnrollmentAccountShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBillingEnrollmentAccountShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBillingEnrollmentAccountShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBillingEnrollmentAccountShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBillingEnrollmentAccountShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBillingEnrollmentAccountShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBillingEnrollmentAccountShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBillingEnrollmentAccountShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBillingEnrollmentAccountShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBillingEnrollmentAccountShow(CombinatorialConfigure<AzureBillingEnrollmentAccountShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBillingEnrollmentAccountShow, AzureBillingLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBillingInvoiceList(AzureBillingInvoiceListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBillingInvoiceListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBillingInvoiceListSettings.Debug"/></li>
        ///     <li><c>--generate-download-url</c> via <see cref="AzureBillingInvoiceListSettings.GenerateDownloadUrl"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBillingInvoiceListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBillingInvoiceListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBillingInvoiceListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBillingInvoiceListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBillingInvoiceListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBillingInvoiceList(Configure<AzureBillingInvoiceListSettings> configurator)
        {
            return AzureBillingInvoiceList(configurator(new AzureBillingInvoiceListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBillingInvoiceListSettings.Debug"/></li>
        ///     <li><c>--generate-download-url</c> via <see cref="AzureBillingInvoiceListSettings.GenerateDownloadUrl"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBillingInvoiceListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBillingInvoiceListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBillingInvoiceListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBillingInvoiceListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBillingInvoiceListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBillingInvoiceListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBillingInvoiceList(CombinatorialConfigure<AzureBillingInvoiceListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBillingInvoiceList, AzureBillingLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBillingInvoiceShow(AzureBillingInvoiceShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBillingInvoiceShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBillingInvoiceShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBillingInvoiceShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBillingInvoiceShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBillingInvoiceShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBillingInvoiceShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBillingInvoiceShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBillingInvoiceShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBillingInvoiceShow(Configure<AzureBillingInvoiceShowSettings> configurator)
        {
            return AzureBillingInvoiceShow(configurator(new AzureBillingInvoiceShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBillingInvoiceShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBillingInvoiceShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBillingInvoiceShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBillingInvoiceShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBillingInvoiceShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBillingInvoiceShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBillingInvoiceShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBillingInvoiceShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBillingInvoiceShow(CombinatorialConfigure<AzureBillingInvoiceShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBillingInvoiceShow, AzureBillingLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBillingPeriodList(AzureBillingPeriodListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBillingPeriodListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBillingPeriodListSettings.Debug"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureBillingPeriodListSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBillingPeriodListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBillingPeriodListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBillingPeriodListSettings.Query"/></li>
        ///     <li><c>--skiptoken</c> via <see cref="AzureBillingPeriodListSettings.Skiptoken"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBillingPeriodListSettings.Subscription"/></li>
        ///     <li><c>--top</c> via <see cref="AzureBillingPeriodListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBillingPeriodListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBillingPeriodList(Configure<AzureBillingPeriodListSettings> configurator)
        {
            return AzureBillingPeriodList(configurator(new AzureBillingPeriodListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBillingPeriodListSettings.Debug"/></li>
        ///     <li><c>--filter</c> via <see cref="AzureBillingPeriodListSettings.Filter"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBillingPeriodListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBillingPeriodListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBillingPeriodListSettings.Query"/></li>
        ///     <li><c>--skiptoken</c> via <see cref="AzureBillingPeriodListSettings.Skiptoken"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBillingPeriodListSettings.Subscription"/></li>
        ///     <li><c>--top</c> via <see cref="AzureBillingPeriodListSettings.Top"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBillingPeriodListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBillingPeriodListSettings Settings, IReadOnlyCollection<Output> Output)> AzureBillingPeriodList(CombinatorialConfigure<AzureBillingPeriodListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBillingPeriodList, AzureBillingLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureBillingPeriodShow(AzureBillingPeriodShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureBillingPeriodShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBillingPeriodShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBillingPeriodShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBillingPeriodShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBillingPeriodShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBillingPeriodShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBillingPeriodShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBillingPeriodShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureBillingPeriodShow(Configure<AzureBillingPeriodShowSettings> configurator)
        {
            return AzureBillingPeriodShow(configurator(new AzureBillingPeriodShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Billing.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/billing?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureBillingPeriodShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureBillingPeriodShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureBillingPeriodShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureBillingPeriodShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureBillingPeriodShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureBillingPeriodShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureBillingPeriodShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureBillingPeriodShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureBillingPeriodShow(CombinatorialConfigure<AzureBillingPeriodShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureBillingPeriodShow, AzureBillingLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureBillingSettings
    /// <summary>
    ///   Used within <see cref="AzureBillingTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBillingSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBilling executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBillingTasks.AzureBillingPath;
        public override Action<OutputType, string> CustomLogger => AzureBillingTasks.AzureBillingLogger;
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
              .Add("billing")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureBillingEnrollmentAccountListSettings
    /// <summary>
    ///   Used within <see cref="AzureBillingTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBillingEnrollmentAccountListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBilling executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBillingTasks.AzureBillingPath;
        public override Action<OutputType, string> CustomLogger => AzureBillingTasks.AzureBillingLogger;
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
              .Add("billing enrollment-account list")
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
    #region AzureBillingEnrollmentAccountShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBillingTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBillingEnrollmentAccountShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBilling executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBillingTasks.AzureBillingPath;
        public override Action<OutputType, string> CustomLogger => AzureBillingTasks.AzureBillingLogger;
        /// <summary>
        ///   Name of the enrollment account.
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
              .Add("billing enrollment-account show")
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
    #region AzureBillingInvoiceListSettings
    /// <summary>
    ///   Used within <see cref="AzureBillingTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBillingInvoiceListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBilling executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBillingTasks.AzureBillingPath;
        public override Action<OutputType, string> CustomLogger => AzureBillingTasks.AzureBillingLogger;
        /// <summary>
        ///   Generate download url of the invoice.
        /// </summary>
        public virtual string GenerateDownloadUrl { get; internal set; }
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
              .Add("billing invoice list")
              .Add("--generate-download-url {value}", GenerateDownloadUrl)
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
    #region AzureBillingInvoiceShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBillingTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBillingInvoiceShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBilling executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBillingTasks.AzureBillingPath;
        public override Action<OutputType, string> CustomLogger => AzureBillingTasks.AzureBillingLogger;
        /// <summary>
        ///   Name of the invoice.
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
              .Add("billing invoice show")
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
    #region AzureBillingPeriodListSettings
    /// <summary>
    ///   Used within <see cref="AzureBillingTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBillingPeriodListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBilling executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBillingTasks.AzureBillingPath;
        public override Action<OutputType, string> CustomLogger => AzureBillingTasks.AzureBillingLogger;
        /// <summary>
        ///   May be used to filter billing periods by billingPeriodEndDate. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'.
        /// </summary>
        public virtual string Filter { get; internal set; }
        /// <summary>
        ///   Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls.
        /// </summary>
        public virtual string Skiptoken { get; internal set; }
        /// <summary>
        ///   May be used to limit the number of results to the most recent N billing periods.
        /// </summary>
        public virtual string Top { get; internal set; }
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
              .Add("billing period list")
              .Add("--filter {value}", Filter)
              .Add("--skiptoken {value}", Skiptoken)
              .Add("--top {value}", Top)
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
    #region AzureBillingPeriodShowSettings
    /// <summary>
    ///   Used within <see cref="AzureBillingTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBillingPeriodShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureBilling executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureBillingTasks.AzureBillingPath;
        public override Action<OutputType, string> CustomLogger => AzureBillingTasks.AzureBillingLogger;
        /// <summary>
        ///   Name of the billing period.
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
              .Add("billing period show")
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
    #region AzureBillingSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBillingTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBillingSettingsExtensions
    {
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingSettings SetDebug(this AzureBillingSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingSettings ResetDebug(this AzureBillingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBillingSettings SetHelp(this AzureBillingSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBillingSettings ResetHelp(this AzureBillingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBillingSettings SetOutput(this AzureBillingSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBillingSettings ResetOutput(this AzureBillingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBillingSettings SetQuery(this AzureBillingSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBillingSettings ResetQuery(this AzureBillingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingSettings SetVerbose(this AzureBillingSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingSettings ResetVerbose(this AzureBillingSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBillingEnrollmentAccountListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBillingTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBillingEnrollmentAccountListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingEnrollmentAccountListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountListSettings SetSubscription(this AzureBillingEnrollmentAccountListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingEnrollmentAccountListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountListSettings ResetSubscription(this AzureBillingEnrollmentAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingEnrollmentAccountListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountListSettings SetDebug(this AzureBillingEnrollmentAccountListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingEnrollmentAccountListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountListSettings ResetDebug(this AzureBillingEnrollmentAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingEnrollmentAccountListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountListSettings SetHelp(this AzureBillingEnrollmentAccountListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingEnrollmentAccountListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountListSettings ResetHelp(this AzureBillingEnrollmentAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingEnrollmentAccountListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountListSettings SetOutput(this AzureBillingEnrollmentAccountListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingEnrollmentAccountListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountListSettings ResetOutput(this AzureBillingEnrollmentAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingEnrollmentAccountListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountListSettings SetQuery(this AzureBillingEnrollmentAccountListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingEnrollmentAccountListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountListSettings ResetQuery(this AzureBillingEnrollmentAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingEnrollmentAccountListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountListSettings SetVerbose(this AzureBillingEnrollmentAccountListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingEnrollmentAccountListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountListSettings ResetVerbose(this AzureBillingEnrollmentAccountListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBillingEnrollmentAccountShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBillingTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBillingEnrollmentAccountShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingEnrollmentAccountShowSettings.Name"/></em></p>
        ///   <p>Name of the enrollment account.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountShowSettings SetName(this AzureBillingEnrollmentAccountShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingEnrollmentAccountShowSettings.Name"/></em></p>
        ///   <p>Name of the enrollment account.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountShowSettings ResetName(this AzureBillingEnrollmentAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingEnrollmentAccountShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountShowSettings SetSubscription(this AzureBillingEnrollmentAccountShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingEnrollmentAccountShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountShowSettings ResetSubscription(this AzureBillingEnrollmentAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingEnrollmentAccountShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountShowSettings SetDebug(this AzureBillingEnrollmentAccountShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingEnrollmentAccountShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountShowSettings ResetDebug(this AzureBillingEnrollmentAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingEnrollmentAccountShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountShowSettings SetHelp(this AzureBillingEnrollmentAccountShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingEnrollmentAccountShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountShowSettings ResetHelp(this AzureBillingEnrollmentAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingEnrollmentAccountShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountShowSettings SetOutput(this AzureBillingEnrollmentAccountShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingEnrollmentAccountShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountShowSettings ResetOutput(this AzureBillingEnrollmentAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingEnrollmentAccountShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountShowSettings SetQuery(this AzureBillingEnrollmentAccountShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingEnrollmentAccountShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountShowSettings ResetQuery(this AzureBillingEnrollmentAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingEnrollmentAccountShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountShowSettings SetVerbose(this AzureBillingEnrollmentAccountShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingEnrollmentAccountShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingEnrollmentAccountShowSettings ResetVerbose(this AzureBillingEnrollmentAccountShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBillingInvoiceListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBillingTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBillingInvoiceListSettingsExtensions
    {
        #region GenerateDownloadUrl
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingInvoiceListSettings.GenerateDownloadUrl"/></em></p>
        ///   <p>Generate download url of the invoice.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceListSettings SetGenerateDownloadUrl(this AzureBillingInvoiceListSettings toolSettings, string generateDownloadUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateDownloadUrl = generateDownloadUrl;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingInvoiceListSettings.GenerateDownloadUrl"/></em></p>
        ///   <p>Generate download url of the invoice.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceListSettings ResetGenerateDownloadUrl(this AzureBillingInvoiceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GenerateDownloadUrl = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingInvoiceListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceListSettings SetSubscription(this AzureBillingInvoiceListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingInvoiceListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceListSettings ResetSubscription(this AzureBillingInvoiceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingInvoiceListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceListSettings SetDebug(this AzureBillingInvoiceListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingInvoiceListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceListSettings ResetDebug(this AzureBillingInvoiceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingInvoiceListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceListSettings SetHelp(this AzureBillingInvoiceListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingInvoiceListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceListSettings ResetHelp(this AzureBillingInvoiceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingInvoiceListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceListSettings SetOutput(this AzureBillingInvoiceListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingInvoiceListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceListSettings ResetOutput(this AzureBillingInvoiceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingInvoiceListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceListSettings SetQuery(this AzureBillingInvoiceListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingInvoiceListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceListSettings ResetQuery(this AzureBillingInvoiceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingInvoiceListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceListSettings SetVerbose(this AzureBillingInvoiceListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingInvoiceListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceListSettings ResetVerbose(this AzureBillingInvoiceListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBillingInvoiceShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBillingTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBillingInvoiceShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingInvoiceShowSettings.Name"/></em></p>
        ///   <p>Name of the invoice.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceShowSettings SetName(this AzureBillingInvoiceShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingInvoiceShowSettings.Name"/></em></p>
        ///   <p>Name of the invoice.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceShowSettings ResetName(this AzureBillingInvoiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingInvoiceShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceShowSettings SetSubscription(this AzureBillingInvoiceShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingInvoiceShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceShowSettings ResetSubscription(this AzureBillingInvoiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingInvoiceShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceShowSettings SetDebug(this AzureBillingInvoiceShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingInvoiceShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceShowSettings ResetDebug(this AzureBillingInvoiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingInvoiceShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceShowSettings SetHelp(this AzureBillingInvoiceShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingInvoiceShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceShowSettings ResetHelp(this AzureBillingInvoiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingInvoiceShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceShowSettings SetOutput(this AzureBillingInvoiceShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingInvoiceShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceShowSettings ResetOutput(this AzureBillingInvoiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingInvoiceShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceShowSettings SetQuery(this AzureBillingInvoiceShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingInvoiceShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceShowSettings ResetQuery(this AzureBillingInvoiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingInvoiceShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceShowSettings SetVerbose(this AzureBillingInvoiceShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingInvoiceShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingInvoiceShowSettings ResetVerbose(this AzureBillingInvoiceShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBillingPeriodListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBillingTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBillingPeriodListSettingsExtensions
    {
        #region Filter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodListSettings.Filter"/></em></p>
        ///   <p>May be used to filter billing periods by billingPeriodEndDate. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings SetFilter(this AzureBillingPeriodListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodListSettings.Filter"/></em></p>
        ///   <p>May be used to filter billing periods by billingPeriodEndDate. The filter supports 'eq', 'lt', 'gt', 'le', 'ge', and 'and'. It does not currently support 'ne', 'or', or 'not'.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings ResetFilter(this AzureBillingPeriodListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Skiptoken
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodListSettings.Skiptoken"/></em></p>
        ///   <p>Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings SetSkiptoken(this AzureBillingPeriodListSettings toolSettings, string skiptoken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skiptoken = skiptoken;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodListSettings.Skiptoken"/></em></p>
        ///   <p>Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings ResetSkiptoken(this AzureBillingPeriodListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Skiptoken = null;
            return toolSettings;
        }
        #endregion
        #region Top
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodListSettings.Top"/></em></p>
        ///   <p>May be used to limit the number of results to the most recent N billing periods.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings SetTop(this AzureBillingPeriodListSettings toolSettings, string top)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = top;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodListSettings.Top"/></em></p>
        ///   <p>May be used to limit the number of results to the most recent N billing periods.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings ResetTop(this AzureBillingPeriodListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Top = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings SetSubscription(this AzureBillingPeriodListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings ResetSubscription(this AzureBillingPeriodListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings SetDebug(this AzureBillingPeriodListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings ResetDebug(this AzureBillingPeriodListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings SetHelp(this AzureBillingPeriodListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings ResetHelp(this AzureBillingPeriodListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings SetOutput(this AzureBillingPeriodListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings ResetOutput(this AzureBillingPeriodListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings SetQuery(this AzureBillingPeriodListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings ResetQuery(this AzureBillingPeriodListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings SetVerbose(this AzureBillingPeriodListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodListSettings ResetVerbose(this AzureBillingPeriodListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBillingPeriodShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureBillingTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBillingPeriodShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodShowSettings.Name"/></em></p>
        ///   <p>Name of the billing period.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodShowSettings SetName(this AzureBillingPeriodShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodShowSettings.Name"/></em></p>
        ///   <p>Name of the billing period.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodShowSettings ResetName(this AzureBillingPeriodShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodShowSettings SetSubscription(this AzureBillingPeriodShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodShowSettings ResetSubscription(this AzureBillingPeriodShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodShowSettings SetDebug(this AzureBillingPeriodShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodShowSettings ResetDebug(this AzureBillingPeriodShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodShowSettings SetHelp(this AzureBillingPeriodShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodShowSettings ResetHelp(this AzureBillingPeriodShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodShowSettings SetOutput(this AzureBillingPeriodShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodShowSettings ResetOutput(this AzureBillingPeriodShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodShowSettings SetQuery(this AzureBillingPeriodShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodShowSettings ResetQuery(this AzureBillingPeriodShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureBillingPeriodShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodShowSettings SetVerbose(this AzureBillingPeriodShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureBillingPeriodShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureBillingPeriodShowSettings ResetVerbose(this AzureBillingPeriodShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
