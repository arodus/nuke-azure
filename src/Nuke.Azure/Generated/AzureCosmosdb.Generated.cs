// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureCosmosdb.json
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
    public static partial class AzureCosmosdbTasks
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public static string AzureCosmosdbPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURECOSMOSDB_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureCosmosdbLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage Azure Cosmos DB database accounts.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdb(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureCosmosdbPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureCosmosdbLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbCheckNameExists(AzureCosmosdbCheckNameExistsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbCheckNameExistsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbCheckNameExists(Configure<AzureCosmosdbCheckNameExistsSettings> configurator)
        {
            return AzureCosmosdbCheckNameExists(configurator(new AzureCosmosdbCheckNameExistsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCheckNameExistsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbCheckNameExistsSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbCheckNameExists(CombinatorialConfigure<AzureCosmosdbCheckNameExistsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbCheckNameExists, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbCreate(AzureCosmosdbCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--capabilities</c> via <see cref="AzureCosmosdbCreateSettings.Capabilities"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCreateSettings.Debug"/></li>
        ///     <li><c>--default-consistency-level</c> via <see cref="AzureCosmosdbCreateSettings.DefaultConsistencyLevel"/></li>
        ///     <li><c>--enable-automatic-failover</c> via <see cref="AzureCosmosdbCreateSettings.EnableAutomaticFailover"/></li>
        ///     <li><c>--enable-multiple-write-locations</c> via <see cref="AzureCosmosdbCreateSettings.EnableMultipleWriteLocations"/></li>
        ///     <li><c>--enable-virtual-network</c> via <see cref="AzureCosmosdbCreateSettings.EnableVirtualNetwork"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCreateSettings.Help"/></li>
        ///     <li><c>--ip-range-filter</c> via <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/></li>
        ///     <li><c>--kind</c> via <see cref="AzureCosmosdbCreateSettings.Kind"/></li>
        ///     <li><c>--locations</c> via <see cref="AzureCosmosdbCreateSettings.Locations"/></li>
        ///     <li><c>--max-interval</c> via <see cref="AzureCosmosdbCreateSettings.MaxInterval"/></li>
        ///     <li><c>--max-staleness-prefix</c> via <see cref="AzureCosmosdbCreateSettings.MaxStalenessPrefix"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCosmosdbCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCreateSettings.Verbose"/></li>
        ///     <li><c>--virtual-network-rules</c> via <see cref="AzureCosmosdbCreateSettings.VirtualNetworkRules"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbCreate(Configure<AzureCosmosdbCreateSettings> configurator)
        {
            return AzureCosmosdbCreate(configurator(new AzureCosmosdbCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--capabilities</c> via <see cref="AzureCosmosdbCreateSettings.Capabilities"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCreateSettings.Debug"/></li>
        ///     <li><c>--default-consistency-level</c> via <see cref="AzureCosmosdbCreateSettings.DefaultConsistencyLevel"/></li>
        ///     <li><c>--enable-automatic-failover</c> via <see cref="AzureCosmosdbCreateSettings.EnableAutomaticFailover"/></li>
        ///     <li><c>--enable-multiple-write-locations</c> via <see cref="AzureCosmosdbCreateSettings.EnableMultipleWriteLocations"/></li>
        ///     <li><c>--enable-virtual-network</c> via <see cref="AzureCosmosdbCreateSettings.EnableVirtualNetwork"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCreateSettings.Help"/></li>
        ///     <li><c>--ip-range-filter</c> via <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/></li>
        ///     <li><c>--kind</c> via <see cref="AzureCosmosdbCreateSettings.Kind"/></li>
        ///     <li><c>--locations</c> via <see cref="AzureCosmosdbCreateSettings.Locations"/></li>
        ///     <li><c>--max-interval</c> via <see cref="AzureCosmosdbCreateSettings.MaxInterval"/></li>
        ///     <li><c>--max-staleness-prefix</c> via <see cref="AzureCosmosdbCreateSettings.MaxStalenessPrefix"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCosmosdbCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCreateSettings.Verbose"/></li>
        ///     <li><c>--virtual-network-rules</c> via <see cref="AzureCosmosdbCreateSettings.VirtualNetworkRules"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbCreate(CombinatorialConfigure<AzureCosmosdbCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbCreate, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbDelete(AzureCosmosdbDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbDelete(Configure<AzureCosmosdbDeleteSettings> configurator)
        {
            return AzureCosmosdbDelete(configurator(new AzureCosmosdbDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbDelete(CombinatorialConfigure<AzureCosmosdbDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbDelete, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbFailoverPriorityChange(AzureCosmosdbFailoverPriorityChangeSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbFailoverPriorityChangeSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Debug"/></li>
        ///     <li><c>--failover-policies</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.FailoverPolicies"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbFailoverPriorityChange(Configure<AzureCosmosdbFailoverPriorityChangeSettings> configurator)
        {
            return AzureCosmosdbFailoverPriorityChange(configurator(new AzureCosmosdbFailoverPriorityChangeSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Debug"/></li>
        ///     <li><c>--failover-policies</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.FailoverPolicies"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbFailoverPriorityChangeSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbFailoverPriorityChange(CombinatorialConfigure<AzureCosmosdbFailoverPriorityChangeSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbFailoverPriorityChange, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbList(AzureCosmosdbListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbList(Configure<AzureCosmosdbListSettings> configurator)
        {
            return AzureCosmosdbList(configurator(new AzureCosmosdbListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbListSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbList(CombinatorialConfigure<AzureCosmosdbListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbList, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbListConnectionStrings(AzureCosmosdbListConnectionStringsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbListConnectionStringsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbListConnectionStrings(Configure<AzureCosmosdbListConnectionStringsSettings> configurator)
        {
            return AzureCosmosdbListConnectionStrings(configurator(new AzureCosmosdbListConnectionStringsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbListConnectionStringsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbListConnectionStringsSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbListConnectionStrings(CombinatorialConfigure<AzureCosmosdbListConnectionStringsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbListConnectionStrings, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbListKeys(AzureCosmosdbListKeysSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbListKeysSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbListKeysSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbListKeysSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbListKeysSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbListKeysSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbListKeysSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbListKeysSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbListKeysSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbListKeysSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbListKeysSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbListKeys(Configure<AzureCosmosdbListKeysSettings> configurator)
        {
            return AzureCosmosdbListKeys(configurator(new AzureCosmosdbListKeysSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbListKeysSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbListKeysSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbListKeysSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbListKeysSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbListKeysSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbListKeysSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbListKeysSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbListKeysSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbListKeysSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbListKeysSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbListKeys(CombinatorialConfigure<AzureCosmosdbListKeysSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbListKeys, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbListReadOnlyKeys(AzureCosmosdbListReadOnlyKeysSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbListReadOnlyKeysSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbListReadOnlyKeys(Configure<AzureCosmosdbListReadOnlyKeysSettings> configurator)
        {
            return AzureCosmosdbListReadOnlyKeys(configurator(new AzureCosmosdbListReadOnlyKeysSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbListReadOnlyKeysSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbListReadOnlyKeysSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbListReadOnlyKeys(CombinatorialConfigure<AzureCosmosdbListReadOnlyKeysSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbListReadOnlyKeys, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbRegenerateKey(AzureCosmosdbRegenerateKeySettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbRegenerateKeySettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Ids"/></li>
        ///     <li><c>--key-kind</c> via <see cref="AzureCosmosdbRegenerateKeySettings.KeyKind"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbRegenerateKeySettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbRegenerateKey(Configure<AzureCosmosdbRegenerateKeySettings> configurator)
        {
            return AzureCosmosdbRegenerateKey(configurator(new AzureCosmosdbRegenerateKeySettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Ids"/></li>
        ///     <li><c>--key-kind</c> via <see cref="AzureCosmosdbRegenerateKeySettings.KeyKind"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbRegenerateKeySettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbRegenerateKeySettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbRegenerateKeySettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbRegenerateKey(CombinatorialConfigure<AzureCosmosdbRegenerateKeySettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbRegenerateKey, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbShow(AzureCosmosdbShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbShow(Configure<AzureCosmosdbShowSettings> configurator)
        {
            return AzureCosmosdbShow(configurator(new AzureCosmosdbShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbShow(CombinatorialConfigure<AzureCosmosdbShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbShow, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbUpdate(AzureCosmosdbUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--capabilities</c> via <see cref="AzureCosmosdbUpdateSettings.Capabilities"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbUpdateSettings.Debug"/></li>
        ///     <li><c>--default-consistency-level</c> via <see cref="AzureCosmosdbUpdateSettings.DefaultConsistencyLevel"/></li>
        ///     <li><c>--enable-automatic-failover</c> via <see cref="AzureCosmosdbUpdateSettings.EnableAutomaticFailover"/></li>
        ///     <li><c>--enable-multiple-write-locations</c> via <see cref="AzureCosmosdbUpdateSettings.EnableMultipleWriteLocations"/></li>
        ///     <li><c>--enable-virtual-network</c> via <see cref="AzureCosmosdbUpdateSettings.EnableVirtualNetwork"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbUpdateSettings.Ids"/></li>
        ///     <li><c>--ip-range-filter</c> via <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/></li>
        ///     <li><c>--locations</c> via <see cref="AzureCosmosdbUpdateSettings.Locations"/></li>
        ///     <li><c>--max-interval</c> via <see cref="AzureCosmosdbUpdateSettings.MaxInterval"/></li>
        ///     <li><c>--max-staleness-prefix</c> via <see cref="AzureCosmosdbUpdateSettings.MaxStalenessPrefix"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCosmosdbUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbUpdateSettings.Verbose"/></li>
        ///     <li><c>--virtual-network-rules</c> via <see cref="AzureCosmosdbUpdateSettings.VirtualNetworkRules"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbUpdate(Configure<AzureCosmosdbUpdateSettings> configurator)
        {
            return AzureCosmosdbUpdate(configurator(new AzureCosmosdbUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--capabilities</c> via <see cref="AzureCosmosdbUpdateSettings.Capabilities"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbUpdateSettings.Debug"/></li>
        ///     <li><c>--default-consistency-level</c> via <see cref="AzureCosmosdbUpdateSettings.DefaultConsistencyLevel"/></li>
        ///     <li><c>--enable-automatic-failover</c> via <see cref="AzureCosmosdbUpdateSettings.EnableAutomaticFailover"/></li>
        ///     <li><c>--enable-multiple-write-locations</c> via <see cref="AzureCosmosdbUpdateSettings.EnableMultipleWriteLocations"/></li>
        ///     <li><c>--enable-virtual-network</c> via <see cref="AzureCosmosdbUpdateSettings.EnableVirtualNetwork"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbUpdateSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbUpdateSettings.Ids"/></li>
        ///     <li><c>--ip-range-filter</c> via <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/></li>
        ///     <li><c>--locations</c> via <see cref="AzureCosmosdbUpdateSettings.Locations"/></li>
        ///     <li><c>--max-interval</c> via <see cref="AzureCosmosdbUpdateSettings.MaxInterval"/></li>
        ///     <li><c>--max-staleness-prefix</c> via <see cref="AzureCosmosdbUpdateSettings.MaxStalenessPrefix"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbUpdateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbUpdateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureCosmosdbUpdateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbUpdateSettings.Verbose"/></li>
        ///     <li><c>--virtual-network-rules</c> via <see cref="AzureCosmosdbUpdateSettings.VirtualNetworkRules"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbUpdate(CombinatorialConfigure<AzureCosmosdbUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbUpdate, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbCollectionCreate(AzureCosmosdbCollectionCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbCollectionCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--collection-name</c> via <see cref="AzureCosmosdbCollectionCreateSettings.CollectionName"/></li>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbCollectionCreateSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Debug"/></li>
        ///     <li><c>--default-ttl</c> via <see cref="AzureCosmosdbCollectionCreateSettings.DefaultTtl"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Help"/></li>
        ///     <li><c>--indexing-policy</c> via <see cref="AzureCosmosdbCollectionCreateSettings.IndexingPolicy"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Output"/></li>
        ///     <li><c>--partition-key-path</c> via <see cref="AzureCosmosdbCollectionCreateSettings.PartitionKeyPath"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbCollectionCreateSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Subscription"/></li>
        ///     <li><c>--throughput</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Throughput"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbCollectionCreateSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbCollectionCreate(Configure<AzureCosmosdbCollectionCreateSettings> configurator)
        {
            return AzureCosmosdbCollectionCreate(configurator(new AzureCosmosdbCollectionCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--collection-name</c> via <see cref="AzureCosmosdbCollectionCreateSettings.CollectionName"/></li>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbCollectionCreateSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Debug"/></li>
        ///     <li><c>--default-ttl</c> via <see cref="AzureCosmosdbCollectionCreateSettings.DefaultTtl"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Help"/></li>
        ///     <li><c>--indexing-policy</c> via <see cref="AzureCosmosdbCollectionCreateSettings.IndexingPolicy"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Output"/></li>
        ///     <li><c>--partition-key-path</c> via <see cref="AzureCosmosdbCollectionCreateSettings.PartitionKeyPath"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbCollectionCreateSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Subscription"/></li>
        ///     <li><c>--throughput</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Throughput"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbCollectionCreateSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCollectionCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbCollectionCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbCollectionCreate(CombinatorialConfigure<AzureCosmosdbCollectionCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbCollectionCreate, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbCollectionDelete(AzureCosmosdbCollectionDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbCollectionDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--collection-name</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.CollectionName"/></li>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbCollectionDelete(Configure<AzureCosmosdbCollectionDeleteSettings> configurator)
        {
            return AzureCosmosdbCollectionDelete(configurator(new AzureCosmosdbCollectionDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--collection-name</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.CollectionName"/></li>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCollectionDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbCollectionDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbCollectionDelete(CombinatorialConfigure<AzureCosmosdbCollectionDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbCollectionDelete, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbCollectionExists(AzureCosmosdbCollectionExistsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbCollectionExistsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--collection-name</c> via <see cref="AzureCosmosdbCollectionExistsSettings.CollectionName"/></li>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbCollectionExistsSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbCollectionExistsSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbCollectionExistsSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbCollectionExists(Configure<AzureCosmosdbCollectionExistsSettings> configurator)
        {
            return AzureCosmosdbCollectionExists(configurator(new AzureCosmosdbCollectionExistsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--collection-name</c> via <see cref="AzureCosmosdbCollectionExistsSettings.CollectionName"/></li>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbCollectionExistsSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbCollectionExistsSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbCollectionExistsSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCollectionExistsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbCollectionExistsSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbCollectionExists(CombinatorialConfigure<AzureCosmosdbCollectionExistsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbCollectionExists, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbCollectionList(AzureCosmosdbCollectionListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbCollectionListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbCollectionListSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCollectionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCollectionListSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbCollectionListSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCollectionListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCollectionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCollectionListSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbCollectionListSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCollectionListSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbCollectionListSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCollectionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbCollectionList(Configure<AzureCosmosdbCollectionListSettings> configurator)
        {
            return AzureCosmosdbCollectionList(configurator(new AzureCosmosdbCollectionListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbCollectionListSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCollectionListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCollectionListSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbCollectionListSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCollectionListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCollectionListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCollectionListSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbCollectionListSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCollectionListSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbCollectionListSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCollectionListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbCollectionListSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbCollectionList(CombinatorialConfigure<AzureCosmosdbCollectionListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbCollectionList, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbCollectionShow(AzureCosmosdbCollectionShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbCollectionShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--collection-name</c> via <see cref="AzureCosmosdbCollectionShowSettings.CollectionName"/></li>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbCollectionShowSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCollectionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCollectionShowSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbCollectionShowSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCollectionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCollectionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCollectionShowSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbCollectionShowSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCollectionShowSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbCollectionShowSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCollectionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbCollectionShow(Configure<AzureCosmosdbCollectionShowSettings> configurator)
        {
            return AzureCosmosdbCollectionShow(configurator(new AzureCosmosdbCollectionShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--collection-name</c> via <see cref="AzureCosmosdbCollectionShowSettings.CollectionName"/></li>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbCollectionShowSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCollectionShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCollectionShowSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbCollectionShowSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCollectionShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCollectionShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCollectionShowSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbCollectionShowSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCollectionShowSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbCollectionShowSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCollectionShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbCollectionShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbCollectionShow(CombinatorialConfigure<AzureCosmosdbCollectionShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbCollectionShow, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbCollectionUpdate(AzureCosmosdbCollectionUpdateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbCollectionUpdateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--collection-name</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.CollectionName"/></li>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Debug"/></li>
        ///     <li><c>--default-ttl</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.DefaultTtl"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Help"/></li>
        ///     <li><c>--indexing-policy</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.IndexingPolicy"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Subscription"/></li>
        ///     <li><c>--throughput</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Throughput"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbCollectionUpdate(Configure<AzureCosmosdbCollectionUpdateSettings> configurator)
        {
            return AzureCosmosdbCollectionUpdate(configurator(new AzureCosmosdbCollectionUpdateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--collection-name</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.CollectionName"/></li>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Debug"/></li>
        ///     <li><c>--default-ttl</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.DefaultTtl"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Help"/></li>
        ///     <li><c>--indexing-policy</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.IndexingPolicy"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Subscription"/></li>
        ///     <li><c>--throughput</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Throughput"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbCollectionUpdateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbCollectionUpdateSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbCollectionUpdate(CombinatorialConfigure<AzureCosmosdbCollectionUpdateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbCollectionUpdate, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbDatabaseCreate(AzureCosmosdbDatabaseCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbDatabaseCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Subscription"/></li>
        ///     <li><c>--throughput</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Throughput"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbDatabaseCreate(Configure<AzureCosmosdbDatabaseCreateSettings> configurator)
        {
            return AzureCosmosdbDatabaseCreate(configurator(new AzureCosmosdbDatabaseCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Subscription"/></li>
        ///     <li><c>--throughput</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Throughput"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbDatabaseCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbDatabaseCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbDatabaseCreate(CombinatorialConfigure<AzureCosmosdbDatabaseCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbDatabaseCreate, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbDatabaseDelete(AzureCosmosdbDatabaseDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbDatabaseDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbDatabaseDelete(Configure<AzureCosmosdbDatabaseDeleteSettings> configurator)
        {
            return AzureCosmosdbDatabaseDelete(configurator(new AzureCosmosdbDatabaseDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbDatabaseDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbDatabaseDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbDatabaseDelete(CombinatorialConfigure<AzureCosmosdbDatabaseDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbDatabaseDelete, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbDatabaseExists(AzureCosmosdbDatabaseExistsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbDatabaseExistsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbDatabaseExists(Configure<AzureCosmosdbDatabaseExistsSettings> configurator)
        {
            return AzureCosmosdbDatabaseExists(configurator(new AzureCosmosdbDatabaseExistsSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbDatabaseExistsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbDatabaseExistsSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbDatabaseExists(CombinatorialConfigure<AzureCosmosdbDatabaseExistsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbDatabaseExists, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbDatabaseList(AzureCosmosdbDatabaseListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbDatabaseListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbDatabaseListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbDatabaseListSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbDatabaseListSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbDatabaseListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbDatabaseListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbDatabaseListSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbDatabaseListSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbDatabaseListSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbDatabaseListSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbDatabaseListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbDatabaseList(Configure<AzureCosmosdbDatabaseListSettings> configurator)
        {
            return AzureCosmosdbDatabaseList(configurator(new AzureCosmosdbDatabaseListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbDatabaseListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbDatabaseListSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbDatabaseListSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbDatabaseListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbDatabaseListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbDatabaseListSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbDatabaseListSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbDatabaseListSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbDatabaseListSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbDatabaseListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbDatabaseListSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbDatabaseList(CombinatorialConfigure<AzureCosmosdbDatabaseListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbDatabaseList, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbDatabaseShow(AzureCosmosdbDatabaseShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbDatabaseShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbDatabaseShowSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbDatabaseShowSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbDatabaseShowSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbDatabaseShow(Configure<AzureCosmosdbDatabaseShowSettings> configurator)
        {
            return AzureCosmosdbDatabaseShow(configurator(new AzureCosmosdbDatabaseShowSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--db-name</c> via <see cref="AzureCosmosdbDatabaseShowSettings.DbName"/></li>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Help"/></li>
        ///     <li><c>--key</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Key"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Query"/></li>
        ///     <li><c>--resource-group-name</c> via <see cref="AzureCosmosdbDatabaseShowSettings.ResourceGroupName"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Subscription"/></li>
        ///     <li><c>--url-connection</c> via <see cref="AzureCosmosdbDatabaseShowSettings.UrlConnection"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbDatabaseShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbDatabaseShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbDatabaseShow(CombinatorialConfigure<AzureCosmosdbDatabaseShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbDatabaseShow, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbKeysList(AzureCosmosdbKeysListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbKeysListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbKeysListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbKeysListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbKeysListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbKeysListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbKeysListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbKeysListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbKeysListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbKeysListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbKeysList(Configure<AzureCosmosdbKeysListSettings> configurator)
        {
            return AzureCosmosdbKeysList(configurator(new AzureCosmosdbKeysListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbKeysListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbKeysListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbKeysListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbKeysListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbKeysListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbKeysListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbKeysListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbKeysListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbKeysListSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbKeysList(CombinatorialConfigure<AzureCosmosdbKeysListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbKeysList, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbNetworkRuleAdd(AzureCosmosdbNetworkRuleAddSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbNetworkRuleAddSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Ids"/></li>
        ///     <li><c>--ignore-missing-vnet-service-endpoint</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.IgnoreMissingVnetServiceEndpoint"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.ResourceGroup"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Verbose"/></li>
        ///     <li><c>--virtual-network</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.VirtualNetwork"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbNetworkRuleAdd(Configure<AzureCosmosdbNetworkRuleAddSettings> configurator)
        {
            return AzureCosmosdbNetworkRuleAdd(configurator(new AzureCosmosdbNetworkRuleAddSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Ids"/></li>
        ///     <li><c>--ignore-missing-vnet-service-endpoint</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.IgnoreMissingVnetServiceEndpoint"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.ResourceGroup"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.Verbose"/></li>
        ///     <li><c>--virtual-network</c> via <see cref="AzureCosmosdbNetworkRuleAddSettings.VirtualNetwork"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbNetworkRuleAddSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbNetworkRuleAdd(CombinatorialConfigure<AzureCosmosdbNetworkRuleAddSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbNetworkRuleAdd, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbNetworkRuleList(AzureCosmosdbNetworkRuleListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbNetworkRuleListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbNetworkRuleList(Configure<AzureCosmosdbNetworkRuleListSettings> configurator)
        {
            return AzureCosmosdbNetworkRuleList(configurator(new AzureCosmosdbNetworkRuleListSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbNetworkRuleListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbNetworkRuleListSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbNetworkRuleList(CombinatorialConfigure<AzureCosmosdbNetworkRuleListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbNetworkRuleList, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureCosmosdbNetworkRuleRemove(AzureCosmosdbNetworkRuleRemoveSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureCosmosdbNetworkRuleRemoveSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.ResourceGroup"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Verbose"/></li>
        ///     <li><c>--virtual-network</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.VirtualNetwork"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureCosmosdbNetworkRuleRemove(Configure<AzureCosmosdbNetworkRuleRemoveSettings> configurator)
        {
            return AzureCosmosdbNetworkRuleRemove(configurator(new AzureCosmosdbNetworkRuleRemoveSettings()));
        }
        /// <summary>
        ///   <p>Manage Azure Cosmos DB database accounts.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/cosmosdb?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.ResourceGroup"/></li>
        ///     <li><c>--subnet</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Subnet"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Verbose"/></li>
        ///     <li><c>--virtual-network</c> via <see cref="AzureCosmosdbNetworkRuleRemoveSettings.VirtualNetwork"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureCosmosdbNetworkRuleRemoveSettings Settings, IReadOnlyCollection<Output> Output)> AzureCosmosdbNetworkRuleRemove(CombinatorialConfigure<AzureCosmosdbNetworkRuleRemoveSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureCosmosdbNetworkRuleRemove, AzureCosmosdbLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureCosmosdbCheckNameExistsSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCheckNameExistsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Cosmos DB database account.
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
              .Add("cosmosdb check-name-exists")
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
    #region AzureCosmosdbCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Name of the Cosmos DB database account.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.
        /// </summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary>
        ///   Set custom capabilities on the Cosmos DB database account.
        /// </summary>
        public virtual string Capabilities { get; internal set; }
        /// <summary>
        ///   Default consistency level of the Cosmos DB database account.
        /// </summary>
        public virtual CosmosdbDefaultConsistencyLevel DefaultConsistencyLevel { get; internal set; }
        /// <summary>
        ///   Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.
        /// </summary>
        public virtual bool? EnableAutomaticFailover { get; internal set; }
        /// <summary>
        ///   Enable Multiple Write Locations.
        /// </summary>
        public virtual bool? EnableMultipleWriteLocations { get; internal set; }
        /// <summary>
        ///   Enables virtual network on the Cosmos DB database account.
        /// </summary>
        public virtual bool? EnableVirtualNetwork { get; internal set; }
        /// <summary>
        ///   Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.
        /// </summary>
        public virtual IReadOnlyList<string> IpRangeFilter => IpRangeFilterInternal.AsReadOnly();
        internal List<string> IpRangeFilterInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The type of Cosmos DB database account to create.
        /// </summary>
        public virtual CosmosdbCreateKind Kind { get; internal set; }
        /// <summary>
        ///   Add a location to the Cosmos DB database account.
        /// </summary>
        public virtual string Locations { get; internal set; }
        /// <summary>
        ///   When used with Bounded Staleness consistency, this value represents the time amount of staleness (in seconds) tolerated. Accepted range for this value is 1 - 100.
        /// </summary>
        public virtual string MaxInterval { get; internal set; }
        /// <summary>
        ///   When used with Bounded Staleness consistency, this value represents the number of stale requests tolerated. Accepted range for this value is 1 - 2,147,483,647.
        /// </summary>
        public virtual string MaxStalenessPrefix { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   ACL's for virtual network.
        /// </summary>
        public virtual string VirtualNetworkRules { get; internal set; }
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
              .Add("cosmosdb create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--capabilities {value}", Capabilities)
              .Add("--default-consistency-level {value}", DefaultConsistencyLevel)
              .Add("--enable-automatic-failover", EnableAutomaticFailover)
              .Add("--enable-multiple-write-locations", EnableMultipleWriteLocations)
              .Add("--enable-virtual-network", EnableVirtualNetwork)
              .Add("--ip-range-filter {value}", IpRangeFilter, separator: ',')
              .Add("--kind {value}", Kind)
              .Add("--locations {value}", Locations)
              .Add("--max-interval {value}", MaxInterval)
              .Add("--max-staleness-prefix {value}", MaxStalenessPrefix)
              .Add("--tags {value}", Tags)
              .Add("--virtual-network-rules {value}", VirtualNetworkRules)
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
    #region AzureCosmosdbDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Cosmos DB database account.
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
              .Add("cosmosdb delete")
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
    #region AzureCosmosdbFailoverPriorityChangeSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbFailoverPriorityChangeSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Space-separated failover policies in 'regionName=failoverPriority' format. E.g eastus=0 westus=1.
        /// </summary>
        public virtual IReadOnlyList<string> FailoverPolicies => FailoverPoliciesInternal.AsReadOnly();
        internal List<string> FailoverPoliciesInternal { get; set; } = new List<string>();
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Cosmos DB database account.
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
              .Add("cosmosdb failover-priority-change")
              .Add("--failover-policies {value}", FailoverPolicies, separator: ' ')
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
    #region AzureCosmosdbListSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
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
              .Add("cosmosdb list")
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
    #region AzureCosmosdbListConnectionStringsSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbListConnectionStringsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Cosmos DB database account.
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
              .Add("cosmosdb list-connection-strings")
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
    #region AzureCosmosdbListKeysSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbListKeysSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Cosmos DB database account.
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
              .Add("cosmosdb list-keys")
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
    #region AzureCosmosdbListReadOnlyKeysSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbListReadOnlyKeysSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Cosmos DB database account.
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
              .Add("cosmosdb list-read-only-keys")
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
    #region AzureCosmosdbRegenerateKeySettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbRegenerateKeySettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   The access key to regenerate.
        /// </summary>
        public virtual CosmosdbRegenerateKeyKeyKind KeyKind { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Cosmos DB database account.
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
              .Add("cosmosdb regenerate-key")
              .Add("--key-kind {value}", KeyKind)
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
    #region AzureCosmosdbShowSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Cosmos DB database account.
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
              .Add("cosmosdb show")
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
    #region AzureCosmosdbUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Set custom capabilities on the Cosmos DB database account.
        /// </summary>
        public virtual string Capabilities { get; internal set; }
        /// <summary>
        ///   Default consistency level of the Cosmos DB database account.
        /// </summary>
        public virtual CosmosdbDefaultConsistencyLevel DefaultConsistencyLevel { get; internal set; }
        /// <summary>
        ///   Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.
        /// </summary>
        public virtual bool? EnableAutomaticFailover { get; internal set; }
        /// <summary>
        ///   Enable Multiple Write Locations.
        /// </summary>
        public virtual bool? EnableMultipleWriteLocations { get; internal set; }
        /// <summary>
        ///   Enables virtual network on the Cosmos DB database account.
        /// </summary>
        public virtual bool? EnableVirtualNetwork { get; internal set; }
        /// <summary>
        ///   Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.
        /// </summary>
        public virtual IReadOnlyList<string> IpRangeFilter => IpRangeFilterInternal.AsReadOnly();
        internal List<string> IpRangeFilterInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Add a location to the Cosmos DB database account.
        /// </summary>
        public virtual string Locations { get; internal set; }
        /// <summary>
        ///   When used with Bounded Staleness consistency, this value represents the time amount of staleness (in seconds) tolerated. Accepted range for this value is 1 - 100.
        /// </summary>
        public virtual string MaxInterval { get; internal set; }
        /// <summary>
        ///   When used with Bounded Staleness consistency, this value represents the number of stale requests tolerated. Accepted range for this value is 1 - 2,147,483,647.
        /// </summary>
        public virtual string MaxStalenessPrefix { get; internal set; }
        /// <summary>
        ///   Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.
        /// </summary>
        public virtual string Tags { get; internal set; }
        /// <summary>
        ///   ACL's for virtual network.
        /// </summary>
        public virtual string VirtualNetworkRules { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Cosmos DB database account.
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
              .Add("cosmosdb update")
              .Add("--capabilities {value}", Capabilities)
              .Add("--default-consistency-level {value}", DefaultConsistencyLevel)
              .Add("--enable-automatic-failover", EnableAutomaticFailover)
              .Add("--enable-multiple-write-locations", EnableMultipleWriteLocations)
              .Add("--enable-virtual-network", EnableVirtualNetwork)
              .Add("--ip-range-filter {value}", IpRangeFilter, separator: ',')
              .Add("--locations {value}", Locations)
              .Add("--max-interval {value}", MaxInterval)
              .Add("--max-staleness-prefix {value}", MaxStalenessPrefix)
              .Add("--tags {value}", Tags)
              .Add("--virtual-network-rules {value}", VirtualNetworkRules)
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
    #region AzureCosmosdbCollectionCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCollectionCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Collection Name.
        /// </summary>
        public virtual string CollectionName { get; internal set; }
        /// <summary>
        ///   Database Name.
        /// </summary>
        public virtual string DbName { get; internal set; }
        /// <summary>
        ///   Default TTL.
        /// </summary>
        public virtual string DefaultTtl { get; internal set; }
        /// <summary>
        ///   Indexing Policy, you can enter it as a string or as a file, e.g., --indexing-policy @policy-file.json).
        /// </summary>
        public virtual string IndexingPolicy { get; internal set; }
        /// <summary>
        ///   Partition Key Path, e.g., '/properties/name'.
        /// </summary>
        public virtual string PartitionKeyPath { get; internal set; }
        /// <summary>
        ///   Offer Throughput (RU/s).
        /// </summary>
        public virtual string Throughput { get; internal set; }
        /// <summary>
        ///   Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the resource group. Must be used in conjunction with cosmosdb account name.
        /// </summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.
        /// </summary>
        public virtual string UrlConnection { get; internal set; }
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
              .Add("cosmosdb collection create")
              .Add("--collection-name {value}", CollectionName)
              .Add("--db-name {value}", DbName)
              .Add("--default-ttl {value}", DefaultTtl)
              .Add("--indexing-policy {value}", IndexingPolicy)
              .Add("--partition-key-path {value}", PartitionKeyPath)
              .Add("--throughput {value}", Throughput)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
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
    #region AzureCosmosdbCollectionDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCollectionDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Collection Name.
        /// </summary>
        public virtual string CollectionName { get; internal set; }
        /// <summary>
        ///   Database Name.
        /// </summary>
        public virtual string DbName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the resource group. Must be used in conjunction with cosmosdb account name.
        /// </summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.
        /// </summary>
        public virtual string UrlConnection { get; internal set; }
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
              .Add("cosmosdb collection delete")
              .Add("--collection-name {value}", CollectionName)
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
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
    #region AzureCosmosdbCollectionExistsSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCollectionExistsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Collection Name.
        /// </summary>
        public virtual string CollectionName { get; internal set; }
        /// <summary>
        ///   Database Name.
        /// </summary>
        public virtual string DbName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the resource group. Must be used in conjunction with cosmosdb account name.
        /// </summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.
        /// </summary>
        public virtual string UrlConnection { get; internal set; }
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
              .Add("cosmosdb collection exists")
              .Add("--collection-name {value}", CollectionName)
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
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
    #region AzureCosmosdbCollectionListSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCollectionListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Database Name.
        /// </summary>
        public virtual string DbName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the resource group. Must be used in conjunction with cosmosdb account name.
        /// </summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.
        /// </summary>
        public virtual string UrlConnection { get; internal set; }
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
              .Add("cosmosdb collection list")
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
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
    #region AzureCosmosdbCollectionShowSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCollectionShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Collection Name.
        /// </summary>
        public virtual string CollectionName { get; internal set; }
        /// <summary>
        ///   Database Name.
        /// </summary>
        public virtual string DbName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the resource group. Must be used in conjunction with cosmosdb account name.
        /// </summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.
        /// </summary>
        public virtual string UrlConnection { get; internal set; }
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
              .Add("cosmosdb collection show")
              .Add("--collection-name {value}", CollectionName)
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
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
    #region AzureCosmosdbCollectionUpdateSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbCollectionUpdateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Collection Name.
        /// </summary>
        public virtual string CollectionName { get; internal set; }
        /// <summary>
        ///   Database Name.
        /// </summary>
        public virtual string DbName { get; internal set; }
        /// <summary>
        ///   Default TTL.
        /// </summary>
        public virtual string DefaultTtl { get; internal set; }
        /// <summary>
        ///   Indexing Policy, you can enter it as a string or as a file, e.g., --indexing-policy @policy-file.json).
        /// </summary>
        public virtual string IndexingPolicy { get; internal set; }
        /// <summary>
        ///   Offer Throughput (RU/s).
        /// </summary>
        public virtual string Throughput { get; internal set; }
        /// <summary>
        ///   Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the resource group. Must be used in conjunction with cosmosdb account name.
        /// </summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.
        /// </summary>
        public virtual string UrlConnection { get; internal set; }
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
              .Add("cosmosdb collection update")
              .Add("--collection-name {value}", CollectionName)
              .Add("--db-name {value}", DbName)
              .Add("--default-ttl {value}", DefaultTtl)
              .Add("--indexing-policy {value}", IndexingPolicy)
              .Add("--throughput {value}", Throughput)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
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
    #region AzureCosmosdbDatabaseCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbDatabaseCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Database Name.
        /// </summary>
        public virtual string DbName { get; internal set; }
        /// <summary>
        ///   Offer Throughput (RU/s).
        /// </summary>
        public virtual string Throughput { get; internal set; }
        /// <summary>
        ///   Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the resource group. Must be used in conjunction with cosmosdb account name.
        /// </summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.
        /// </summary>
        public virtual string UrlConnection { get; internal set; }
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
              .Add("cosmosdb database create")
              .Add("--db-name {value}", DbName)
              .Add("--throughput {value}", Throughput)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
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
    #region AzureCosmosdbDatabaseDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbDatabaseDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Database Name.
        /// </summary>
        public virtual string DbName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the resource group. Must be used in conjunction with cosmosdb account name.
        /// </summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.
        /// </summary>
        public virtual string UrlConnection { get; internal set; }
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
              .Add("cosmosdb database delete")
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
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
    #region AzureCosmosdbDatabaseExistsSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbDatabaseExistsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Database Name.
        /// </summary>
        public virtual string DbName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the resource group. Must be used in conjunction with cosmosdb account name.
        /// </summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.
        /// </summary>
        public virtual string UrlConnection { get; internal set; }
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
              .Add("cosmosdb database exists")
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
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
    #region AzureCosmosdbDatabaseListSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbDatabaseListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the resource group. Must be used in conjunction with cosmosdb account name.
        /// </summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.
        /// </summary>
        public virtual string UrlConnection { get; internal set; }
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
              .Add("cosmosdb database list")
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
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
    #region AzureCosmosdbDatabaseShowSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbDatabaseShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Database Name.
        /// </summary>
        public virtual string DbName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.
        /// </summary>
        public virtual string Key { get; internal set; }
        /// <summary>
        ///   Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   Name of the resource group. Must be used in conjunction with cosmosdb account name.
        /// </summary>
        public virtual string ResourceGroupName { get; internal set; }
        /// <summary>
        ///   Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.
        /// </summary>
        public virtual string UrlConnection { get; internal set; }
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
              .Add("cosmosdb database show")
              .Add("--db-name {value}", DbName)
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group-name {value}", ResourceGroupName)
              .Add("--url-connection {value}", UrlConnection)
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
    #region AzureCosmosdbKeysListSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbKeysListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Name of the Cosmos DB database account.
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
              .Add("cosmosdb keys list")
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
    #region AzureCosmosdbNetworkRuleAddSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbNetworkRuleAddSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Name or ID of the subnet.
        /// </summary>
        public virtual string Subnet { get; internal set; }
        /// <summary>
        ///   Create firewall rule before the virtual network has vnet service endpoint enabled.
        /// </summary>
        public virtual bool? IgnoreMissingVnetServiceEndpoint { get; internal set; }
        /// <summary>
        ///   The name of the VNET, which must be provided in conjunction with the name of the subnet.
        /// </summary>
        public virtual string VirtualNetwork { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Cosmos DB database account.
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
              .Add("cosmosdb network-rule add")
              .Add("--subnet {value}", Subnet)
              .Add("--ignore-missing-vnet-service-endpoint", IgnoreMissingVnetServiceEndpoint)
              .Add("--virtual-network {value}", VirtualNetwork)
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
    #region AzureCosmosdbNetworkRuleListSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbNetworkRuleListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Name of the Cosmos DB database account.
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
              .Add("cosmosdb network-rule list")
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
    #region AzureCosmosdbNetworkRuleRemoveSettings
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureCosmosdbNetworkRuleRemoveSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureCosmosdb executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureCosmosdbTasks.AzureCosmosdbPath;
        public override Action<OutputType, string> CustomLogger => AzureCosmosdbTasks.AzureCosmosdbLogger;
        /// <summary>
        ///   Name or ID of the subnet.
        /// </summary>
        public virtual string Subnet { get; internal set; }
        /// <summary>
        ///   The name of the VNET, which must be provided in conjunction with the name of the subnet.
        /// </summary>
        public virtual string VirtualNetwork { get; internal set; }
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Name of the Cosmos DB database account.
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
              .Add("cosmosdb network-rule remove")
              .Add("--subnet {value}", Subnet)
              .Add("--virtual-network {value}", VirtualNetwork)
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
    #region AzureCosmosdbCheckNameExistsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCheckNameExistsSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetIds(this AzureCosmosdbCheckNameExistsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetIds(this AzureCosmosdbCheckNameExistsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbCheckNameExistsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings AddIds(this AzureCosmosdbCheckNameExistsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbCheckNameExistsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings AddIds(this AzureCosmosdbCheckNameExistsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCosmosdbCheckNameExistsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings ClearIds(this AzureCosmosdbCheckNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbCheckNameExistsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings RemoveIds(this AzureCosmosdbCheckNameExistsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbCheckNameExistsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings RemoveIds(this AzureCosmosdbCheckNameExistsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetName(this AzureCosmosdbCheckNameExistsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCheckNameExistsSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings ResetName(this AzureCosmosdbCheckNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetSubscription(this AzureCosmosdbCheckNameExistsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCheckNameExistsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings ResetSubscription(this AzureCosmosdbCheckNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetDebug(this AzureCosmosdbCheckNameExistsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCheckNameExistsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings ResetDebug(this AzureCosmosdbCheckNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetHelp(this AzureCosmosdbCheckNameExistsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCheckNameExistsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings ResetHelp(this AzureCosmosdbCheckNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetOutput(this AzureCosmosdbCheckNameExistsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCheckNameExistsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings ResetOutput(this AzureCosmosdbCheckNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetQuery(this AzureCosmosdbCheckNameExistsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCheckNameExistsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings ResetQuery(this AzureCosmosdbCheckNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCheckNameExistsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings SetVerbose(this AzureCosmosdbCheckNameExistsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCheckNameExistsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCheckNameExistsSettings ResetVerbose(this AzureCosmosdbCheckNameExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetName(this AzureCosmosdbCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetName(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetResourceGroup(this AzureCosmosdbCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetResourceGroup(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Capabilities
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.Capabilities"/></em></p>
        ///   <p>Set custom capabilities on the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetCapabilities(this AzureCosmosdbCreateSettings toolSettings, string capabilities)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capabilities = capabilities;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.Capabilities"/></em></p>
        ///   <p>Set custom capabilities on the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetCapabilities(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capabilities = null;
            return toolSettings;
        }
        #endregion
        #region DefaultConsistencyLevel
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.DefaultConsistencyLevel"/></em></p>
        ///   <p>Default consistency level of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetDefaultConsistencyLevel(this AzureCosmosdbCreateSettings toolSettings, CosmosdbDefaultConsistencyLevel defaultConsistencyLevel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultConsistencyLevel = defaultConsistencyLevel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.DefaultConsistencyLevel"/></em></p>
        ///   <p>Default consistency level of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetDefaultConsistencyLevel(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultConsistencyLevel = null;
            return toolSettings;
        }
        #endregion
        #region EnableAutomaticFailover
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.EnableAutomaticFailover"/></em></p>
        ///   <p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetEnableAutomaticFailover(this AzureCosmosdbCreateSettings toolSettings, bool? enableAutomaticFailover)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = enableAutomaticFailover;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.EnableAutomaticFailover"/></em></p>
        ///   <p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetEnableAutomaticFailover(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCosmosdbCreateSettings.EnableAutomaticFailover"/></em></p>
        ///   <p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings EnableEnableAutomaticFailover(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCosmosdbCreateSettings.EnableAutomaticFailover"/></em></p>
        ///   <p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings DisableEnableAutomaticFailover(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCosmosdbCreateSettings.EnableAutomaticFailover"/></em></p>
        ///   <p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ToggleEnableAutomaticFailover(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = !toolSettings.EnableAutomaticFailover;
            return toolSettings;
        }
        #endregion
        #region EnableMultipleWriteLocations
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.EnableMultipleWriteLocations"/></em></p>
        ///   <p>Enable Multiple Write Locations.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetEnableMultipleWriteLocations(this AzureCosmosdbCreateSettings toolSettings, bool? enableMultipleWriteLocations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMultipleWriteLocations = enableMultipleWriteLocations;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.EnableMultipleWriteLocations"/></em></p>
        ///   <p>Enable Multiple Write Locations.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetEnableMultipleWriteLocations(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMultipleWriteLocations = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCosmosdbCreateSettings.EnableMultipleWriteLocations"/></em></p>
        ///   <p>Enable Multiple Write Locations.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings EnableEnableMultipleWriteLocations(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMultipleWriteLocations = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCosmosdbCreateSettings.EnableMultipleWriteLocations"/></em></p>
        ///   <p>Enable Multiple Write Locations.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings DisableEnableMultipleWriteLocations(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMultipleWriteLocations = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCosmosdbCreateSettings.EnableMultipleWriteLocations"/></em></p>
        ///   <p>Enable Multiple Write Locations.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ToggleEnableMultipleWriteLocations(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMultipleWriteLocations = !toolSettings.EnableMultipleWriteLocations;
            return toolSettings;
        }
        #endregion
        #region EnableVirtualNetwork
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.EnableVirtualNetwork"/></em></p>
        ///   <p>Enables virtual network on the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetEnableVirtualNetwork(this AzureCosmosdbCreateSettings toolSettings, bool? enableVirtualNetwork)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = enableVirtualNetwork;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.EnableVirtualNetwork"/></em></p>
        ///   <p>Enables virtual network on the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetEnableVirtualNetwork(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCosmosdbCreateSettings.EnableVirtualNetwork"/></em></p>
        ///   <p>Enables virtual network on the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings EnableEnableVirtualNetwork(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCosmosdbCreateSettings.EnableVirtualNetwork"/></em></p>
        ///   <p>Enables virtual network on the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings DisableEnableVirtualNetwork(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCosmosdbCreateSettings.EnableVirtualNetwork"/></em></p>
        ///   <p>Enables virtual network on the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ToggleEnableVirtualNetwork(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = !toolSettings.EnableVirtualNetwork;
            return toolSettings;
        }
        #endregion
        #region IpRangeFilter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/> to a new list</em></p>
        ///   <p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetIpRangeFilter(this AzureCosmosdbCreateSettings toolSettings, params string[] ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal = ipRangeFilter.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/> to a new list</em></p>
        ///   <p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetIpRangeFilter(this AzureCosmosdbCreateSettings toolSettings, IEnumerable<string> ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal = ipRangeFilter.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/></em></p>
        ///   <p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings AddIpRangeFilter(this AzureCosmosdbCreateSettings toolSettings, params string[] ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal.AddRange(ipRangeFilter);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/></em></p>
        ///   <p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings AddIpRangeFilter(this AzureCosmosdbCreateSettings toolSettings, IEnumerable<string> ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal.AddRange(ipRangeFilter);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/></em></p>
        ///   <p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ClearIpRangeFilter(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/></em></p>
        ///   <p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings RemoveIpRangeFilter(this AzureCosmosdbCreateSettings toolSettings, params string[] ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ipRangeFilter);
            toolSettings.IpRangeFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbCreateSettings.IpRangeFilter"/></em></p>
        ///   <p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings RemoveIpRangeFilter(this AzureCosmosdbCreateSettings toolSettings, IEnumerable<string> ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ipRangeFilter);
            toolSettings.IpRangeFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Kind
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.Kind"/></em></p>
        ///   <p>The type of Cosmos DB database account to create.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetKind(this AzureCosmosdbCreateSettings toolSettings, CosmosdbCreateKind kind)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = kind;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.Kind"/></em></p>
        ///   <p>The type of Cosmos DB database account to create.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetKind(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = null;
            return toolSettings;
        }
        #endregion
        #region Locations
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.Locations"/></em></p>
        ///   <p>Add a location to the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetLocations(this AzureCosmosdbCreateSettings toolSettings, string locations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Locations = locations;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.Locations"/></em></p>
        ///   <p>Add a location to the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetLocations(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Locations = null;
            return toolSettings;
        }
        #endregion
        #region MaxInterval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.MaxInterval"/></em></p>
        ///   <p>When used with Bounded Staleness consistency, this value represents the time amount of staleness (in seconds) tolerated. Accepted range for this value is 1 - 100.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetMaxInterval(this AzureCosmosdbCreateSettings toolSettings, string maxInterval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxInterval = maxInterval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.MaxInterval"/></em></p>
        ///   <p>When used with Bounded Staleness consistency, this value represents the time amount of staleness (in seconds) tolerated. Accepted range for this value is 1 - 100.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetMaxInterval(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxInterval = null;
            return toolSettings;
        }
        #endregion
        #region MaxStalenessPrefix
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.MaxStalenessPrefix"/></em></p>
        ///   <p>When used with Bounded Staleness consistency, this value represents the number of stale requests tolerated. Accepted range for this value is 1 - 2,147,483,647.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetMaxStalenessPrefix(this AzureCosmosdbCreateSettings toolSettings, string maxStalenessPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxStalenessPrefix = maxStalenessPrefix;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.MaxStalenessPrefix"/></em></p>
        ///   <p>When used with Bounded Staleness consistency, this value represents the number of stale requests tolerated. Accepted range for this value is 1 - 2,147,483,647.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetMaxStalenessPrefix(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxStalenessPrefix = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetTags(this AzureCosmosdbCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetTags(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region VirtualNetworkRules
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.VirtualNetworkRules"/></em></p>
        ///   <p>ACL's for virtual network.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetVirtualNetworkRules(this AzureCosmosdbCreateSettings toolSettings, string virtualNetworkRules)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetworkRules = virtualNetworkRules;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.VirtualNetworkRules"/></em></p>
        ///   <p>ACL's for virtual network.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetVirtualNetworkRules(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetworkRules = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetSubscription(this AzureCosmosdbCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetSubscription(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetDebug(this AzureCosmosdbCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetDebug(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetHelp(this AzureCosmosdbCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetHelp(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetOutput(this AzureCosmosdbCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetOutput(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetQuery(this AzureCosmosdbCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetQuery(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings SetVerbose(this AzureCosmosdbCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCreateSettings ResetVerbose(this AzureCosmosdbCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetIds(this AzureCosmosdbDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetIds(this AzureCosmosdbDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings AddIds(this AzureCosmosdbDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings AddIds(this AzureCosmosdbDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCosmosdbDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ClearIds(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings RemoveIds(this AzureCosmosdbDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings RemoveIds(this AzureCosmosdbDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetName(this AzureCosmosdbDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDeleteSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetName(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetResourceGroup(this AzureCosmosdbDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetResourceGroup(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetSubscription(this AzureCosmosdbDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetSubscription(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetDebug(this AzureCosmosdbDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetDebug(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetHelp(this AzureCosmosdbDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetHelp(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetOutput(this AzureCosmosdbDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetOutput(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetQuery(this AzureCosmosdbDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetQuery(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings SetVerbose(this AzureCosmosdbDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDeleteSettings ResetVerbose(this AzureCosmosdbDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbFailoverPriorityChangeSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbFailoverPriorityChangeSettingsExtensions
    {
        #region FailoverPolicies
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.FailoverPolicies"/> to a new list</em></p>
        ///   <p>Space-separated failover policies in 'regionName=failoverPriority' format. E.g eastus=0 westus=1.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetFailoverPolicies(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, params string[] failoverPolicies)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FailoverPoliciesInternal = failoverPolicies.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.FailoverPolicies"/> to a new list</em></p>
        ///   <p>Space-separated failover policies in 'regionName=failoverPriority' format. E.g eastus=0 westus=1.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetFailoverPolicies(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, IEnumerable<string> failoverPolicies)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FailoverPoliciesInternal = failoverPolicies.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbFailoverPriorityChangeSettings.FailoverPolicies"/></em></p>
        ///   <p>Space-separated failover policies in 'regionName=failoverPriority' format. E.g eastus=0 westus=1.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings AddFailoverPolicies(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, params string[] failoverPolicies)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FailoverPoliciesInternal.AddRange(failoverPolicies);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbFailoverPriorityChangeSettings.FailoverPolicies"/></em></p>
        ///   <p>Space-separated failover policies in 'regionName=failoverPriority' format. E.g eastus=0 westus=1.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings AddFailoverPolicies(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, IEnumerable<string> failoverPolicies)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FailoverPoliciesInternal.AddRange(failoverPolicies);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCosmosdbFailoverPriorityChangeSettings.FailoverPolicies"/></em></p>
        ///   <p>Space-separated failover policies in 'regionName=failoverPriority' format. E.g eastus=0 westus=1.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ClearFailoverPolicies(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FailoverPoliciesInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbFailoverPriorityChangeSettings.FailoverPolicies"/></em></p>
        ///   <p>Space-separated failover policies in 'regionName=failoverPriority' format. E.g eastus=0 westus=1.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings RemoveFailoverPolicies(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, params string[] failoverPolicies)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(failoverPolicies);
            toolSettings.FailoverPoliciesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbFailoverPriorityChangeSettings.FailoverPolicies"/></em></p>
        ///   <p>Space-separated failover policies in 'regionName=failoverPriority' format. E.g eastus=0 westus=1.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings RemoveFailoverPolicies(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, IEnumerable<string> failoverPolicies)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(failoverPolicies);
            toolSettings.FailoverPoliciesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetIds(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetIds(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings AddIds(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings AddIds(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ClearIds(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings RemoveIds(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings RemoveIds(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetName(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetName(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetResourceGroup(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetResourceGroup(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetSubscription(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetSubscription(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetDebug(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetDebug(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetHelp(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetHelp(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetOutput(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetOutput(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetQuery(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetQuery(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings SetVerbose(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbFailoverPriorityChangeSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbFailoverPriorityChangeSettings ResetVerbose(this AzureCosmosdbFailoverPriorityChangeSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListSettings SetResourceGroup(this AzureCosmosdbListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListSettings ResetResourceGroup(this AzureCosmosdbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListSettings SetSubscription(this AzureCosmosdbListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListSettings ResetSubscription(this AzureCosmosdbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListSettings SetDebug(this AzureCosmosdbListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListSettings ResetDebug(this AzureCosmosdbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListSettings SetHelp(this AzureCosmosdbListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListSettings ResetHelp(this AzureCosmosdbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListSettings SetOutput(this AzureCosmosdbListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListSettings ResetOutput(this AzureCosmosdbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListSettings SetQuery(this AzureCosmosdbListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListSettings ResetQuery(this AzureCosmosdbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListSettings SetVerbose(this AzureCosmosdbListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListSettings ResetVerbose(this AzureCosmosdbListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbListConnectionStringsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbListConnectionStringsSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetIds(this AzureCosmosdbListConnectionStringsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetIds(this AzureCosmosdbListConnectionStringsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbListConnectionStringsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings AddIds(this AzureCosmosdbListConnectionStringsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbListConnectionStringsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings AddIds(this AzureCosmosdbListConnectionStringsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCosmosdbListConnectionStringsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ClearIds(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbListConnectionStringsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings RemoveIds(this AzureCosmosdbListConnectionStringsSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbListConnectionStringsSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings RemoveIds(this AzureCosmosdbListConnectionStringsSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetName(this AzureCosmosdbListConnectionStringsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetName(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetResourceGroup(this AzureCosmosdbListConnectionStringsSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetResourceGroup(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetSubscription(this AzureCosmosdbListConnectionStringsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetSubscription(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetDebug(this AzureCosmosdbListConnectionStringsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetDebug(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetHelp(this AzureCosmosdbListConnectionStringsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetHelp(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetOutput(this AzureCosmosdbListConnectionStringsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetOutput(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetQuery(this AzureCosmosdbListConnectionStringsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetQuery(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListConnectionStringsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings SetVerbose(this AzureCosmosdbListConnectionStringsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListConnectionStringsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListConnectionStringsSettings ResetVerbose(this AzureCosmosdbListConnectionStringsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbListKeysSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbListKeysSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetIds(this AzureCosmosdbListKeysSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetIds(this AzureCosmosdbListKeysSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbListKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings AddIds(this AzureCosmosdbListKeysSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbListKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings AddIds(this AzureCosmosdbListKeysSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCosmosdbListKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ClearIds(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbListKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings RemoveIds(this AzureCosmosdbListKeysSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbListKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings RemoveIds(this AzureCosmosdbListKeysSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetName(this AzureCosmosdbListKeysSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListKeysSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetName(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListKeysSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetResourceGroup(this AzureCosmosdbListKeysSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListKeysSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetResourceGroup(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetSubscription(this AzureCosmosdbListKeysSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListKeysSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetSubscription(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetDebug(this AzureCosmosdbListKeysSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListKeysSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetDebug(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetHelp(this AzureCosmosdbListKeysSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListKeysSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetHelp(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetOutput(this AzureCosmosdbListKeysSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListKeysSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetOutput(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetQuery(this AzureCosmosdbListKeysSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListKeysSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetQuery(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListKeysSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings SetVerbose(this AzureCosmosdbListKeysSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListKeysSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListKeysSettings ResetVerbose(this AzureCosmosdbListKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbListReadOnlyKeysSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbListReadOnlyKeysSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetIds(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetIds(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbListReadOnlyKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings AddIds(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbListReadOnlyKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings AddIds(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCosmosdbListReadOnlyKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ClearIds(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbListReadOnlyKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings RemoveIds(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbListReadOnlyKeysSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings RemoveIds(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetName(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetName(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetResourceGroup(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetResourceGroup(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetSubscription(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetSubscription(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetDebug(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetDebug(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetHelp(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetHelp(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetOutput(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetOutput(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetQuery(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetQuery(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings SetVerbose(this AzureCosmosdbListReadOnlyKeysSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbListReadOnlyKeysSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbListReadOnlyKeysSettings ResetVerbose(this AzureCosmosdbListReadOnlyKeysSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbRegenerateKeySettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbRegenerateKeySettingsExtensions
    {
        #region KeyKind
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.KeyKind"/></em></p>
        ///   <p>The access key to regenerate.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetKeyKind(this AzureCosmosdbRegenerateKeySettings toolSettings, CosmosdbRegenerateKeyKeyKind keyKind)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyKind = keyKind;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.KeyKind"/></em></p>
        ///   <p>The access key to regenerate.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetKeyKind(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyKind = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetIds(this AzureCosmosdbRegenerateKeySettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetIds(this AzureCosmosdbRegenerateKeySettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbRegenerateKeySettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings AddIds(this AzureCosmosdbRegenerateKeySettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbRegenerateKeySettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings AddIds(this AzureCosmosdbRegenerateKeySettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCosmosdbRegenerateKeySettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ClearIds(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbRegenerateKeySettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings RemoveIds(this AzureCosmosdbRegenerateKeySettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbRegenerateKeySettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings RemoveIds(this AzureCosmosdbRegenerateKeySettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetName(this AzureCosmosdbRegenerateKeySettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetName(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetResourceGroup(this AzureCosmosdbRegenerateKeySettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetResourceGroup(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetSubscription(this AzureCosmosdbRegenerateKeySettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetSubscription(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetDebug(this AzureCosmosdbRegenerateKeySettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetDebug(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetHelp(this AzureCosmosdbRegenerateKeySettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetHelp(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetOutput(this AzureCosmosdbRegenerateKeySettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetOutput(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetQuery(this AzureCosmosdbRegenerateKeySettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetQuery(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbRegenerateKeySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings SetVerbose(this AzureCosmosdbRegenerateKeySettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbRegenerateKeySettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbRegenerateKeySettings ResetVerbose(this AzureCosmosdbRegenerateKeySettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetIds(this AzureCosmosdbShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetIds(this AzureCosmosdbShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings AddIds(this AzureCosmosdbShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings AddIds(this AzureCosmosdbShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCosmosdbShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings ClearIds(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings RemoveIds(this AzureCosmosdbShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings RemoveIds(this AzureCosmosdbShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbShowSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetName(this AzureCosmosdbShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbShowSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetName(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetResourceGroup(this AzureCosmosdbShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetResourceGroup(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetSubscription(this AzureCosmosdbShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetSubscription(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetDebug(this AzureCosmosdbShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetDebug(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetHelp(this AzureCosmosdbShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetHelp(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetOutput(this AzureCosmosdbShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetOutput(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetQuery(this AzureCosmosdbShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetQuery(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings SetVerbose(this AzureCosmosdbShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbShowSettings ResetVerbose(this AzureCosmosdbShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbUpdateSettingsExtensions
    {
        #region Capabilities
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Capabilities"/></em></p>
        ///   <p>Set custom capabilities on the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetCapabilities(this AzureCosmosdbUpdateSettings toolSettings, string capabilities)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capabilities = capabilities;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Capabilities"/></em></p>
        ///   <p>Set custom capabilities on the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetCapabilities(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Capabilities = null;
            return toolSettings;
        }
        #endregion
        #region DefaultConsistencyLevel
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.DefaultConsistencyLevel"/></em></p>
        ///   <p>Default consistency level of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetDefaultConsistencyLevel(this AzureCosmosdbUpdateSettings toolSettings, CosmosdbDefaultConsistencyLevel defaultConsistencyLevel)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultConsistencyLevel = defaultConsistencyLevel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.DefaultConsistencyLevel"/></em></p>
        ///   <p>Default consistency level of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetDefaultConsistencyLevel(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultConsistencyLevel = null;
            return toolSettings;
        }
        #endregion
        #region EnableAutomaticFailover
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.EnableAutomaticFailover"/></em></p>
        ///   <p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetEnableAutomaticFailover(this AzureCosmosdbUpdateSettings toolSettings, bool? enableAutomaticFailover)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = enableAutomaticFailover;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.EnableAutomaticFailover"/></em></p>
        ///   <p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetEnableAutomaticFailover(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCosmosdbUpdateSettings.EnableAutomaticFailover"/></em></p>
        ///   <p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings EnableEnableAutomaticFailover(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCosmosdbUpdateSettings.EnableAutomaticFailover"/></em></p>
        ///   <p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings DisableEnableAutomaticFailover(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCosmosdbUpdateSettings.EnableAutomaticFailover"/></em></p>
        ///   <p>Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ToggleEnableAutomaticFailover(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableAutomaticFailover = !toolSettings.EnableAutomaticFailover;
            return toolSettings;
        }
        #endregion
        #region EnableMultipleWriteLocations
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.EnableMultipleWriteLocations"/></em></p>
        ///   <p>Enable Multiple Write Locations.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetEnableMultipleWriteLocations(this AzureCosmosdbUpdateSettings toolSettings, bool? enableMultipleWriteLocations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMultipleWriteLocations = enableMultipleWriteLocations;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.EnableMultipleWriteLocations"/></em></p>
        ///   <p>Enable Multiple Write Locations.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetEnableMultipleWriteLocations(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMultipleWriteLocations = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCosmosdbUpdateSettings.EnableMultipleWriteLocations"/></em></p>
        ///   <p>Enable Multiple Write Locations.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings EnableEnableMultipleWriteLocations(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMultipleWriteLocations = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCosmosdbUpdateSettings.EnableMultipleWriteLocations"/></em></p>
        ///   <p>Enable Multiple Write Locations.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings DisableEnableMultipleWriteLocations(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMultipleWriteLocations = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCosmosdbUpdateSettings.EnableMultipleWriteLocations"/></em></p>
        ///   <p>Enable Multiple Write Locations.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ToggleEnableMultipleWriteLocations(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMultipleWriteLocations = !toolSettings.EnableMultipleWriteLocations;
            return toolSettings;
        }
        #endregion
        #region EnableVirtualNetwork
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.EnableVirtualNetwork"/></em></p>
        ///   <p>Enables virtual network on the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetEnableVirtualNetwork(this AzureCosmosdbUpdateSettings toolSettings, bool? enableVirtualNetwork)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = enableVirtualNetwork;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.EnableVirtualNetwork"/></em></p>
        ///   <p>Enables virtual network on the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetEnableVirtualNetwork(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCosmosdbUpdateSettings.EnableVirtualNetwork"/></em></p>
        ///   <p>Enables virtual network on the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings EnableEnableVirtualNetwork(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCosmosdbUpdateSettings.EnableVirtualNetwork"/></em></p>
        ///   <p>Enables virtual network on the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings DisableEnableVirtualNetwork(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCosmosdbUpdateSettings.EnableVirtualNetwork"/></em></p>
        ///   <p>Enables virtual network on the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ToggleEnableVirtualNetwork(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVirtualNetwork = !toolSettings.EnableVirtualNetwork;
            return toolSettings;
        }
        #endregion
        #region IpRangeFilter
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/> to a new list</em></p>
        ///   <p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetIpRangeFilter(this AzureCosmosdbUpdateSettings toolSettings, params string[] ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal = ipRangeFilter.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/> to a new list</em></p>
        ///   <p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetIpRangeFilter(this AzureCosmosdbUpdateSettings toolSettings, IEnumerable<string> ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal = ipRangeFilter.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/></em></p>
        ///   <p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings AddIpRangeFilter(this AzureCosmosdbUpdateSettings toolSettings, params string[] ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal.AddRange(ipRangeFilter);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/></em></p>
        ///   <p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings AddIpRangeFilter(this AzureCosmosdbUpdateSettings toolSettings, IEnumerable<string> ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal.AddRange(ipRangeFilter);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/></em></p>
        ///   <p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ClearIpRangeFilter(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IpRangeFilterInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/></em></p>
        ///   <p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings RemoveIpRangeFilter(this AzureCosmosdbUpdateSettings toolSettings, params string[] ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ipRangeFilter);
            toolSettings.IpRangeFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbUpdateSettings.IpRangeFilter"/></em></p>
        ///   <p>Firewall support. Specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma-separated and must not contain any spaces.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings RemoveIpRangeFilter(this AzureCosmosdbUpdateSettings toolSettings, IEnumerable<string> ipRangeFilter)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ipRangeFilter);
            toolSettings.IpRangeFilterInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Locations
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Locations"/></em></p>
        ///   <p>Add a location to the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetLocations(this AzureCosmosdbUpdateSettings toolSettings, string locations)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Locations = locations;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Locations"/></em></p>
        ///   <p>Add a location to the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetLocations(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Locations = null;
            return toolSettings;
        }
        #endregion
        #region MaxInterval
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.MaxInterval"/></em></p>
        ///   <p>When used with Bounded Staleness consistency, this value represents the time amount of staleness (in seconds) tolerated. Accepted range for this value is 1 - 100.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetMaxInterval(this AzureCosmosdbUpdateSettings toolSettings, string maxInterval)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxInterval = maxInterval;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.MaxInterval"/></em></p>
        ///   <p>When used with Bounded Staleness consistency, this value represents the time amount of staleness (in seconds) tolerated. Accepted range for this value is 1 - 100.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetMaxInterval(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxInterval = null;
            return toolSettings;
        }
        #endregion
        #region MaxStalenessPrefix
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.MaxStalenessPrefix"/></em></p>
        ///   <p>When used with Bounded Staleness consistency, this value represents the number of stale requests tolerated. Accepted range for this value is 1 - 2,147,483,647.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetMaxStalenessPrefix(this AzureCosmosdbUpdateSettings toolSettings, string maxStalenessPrefix)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxStalenessPrefix = maxStalenessPrefix;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.MaxStalenessPrefix"/></em></p>
        ///   <p>When used with Bounded Staleness consistency, this value represents the number of stale requests tolerated. Accepted range for this value is 1 - 2,147,483,647.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetMaxStalenessPrefix(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MaxStalenessPrefix = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetTags(this AzureCosmosdbUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetTags(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region VirtualNetworkRules
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.VirtualNetworkRules"/></em></p>
        ///   <p>ACL's for virtual network.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetVirtualNetworkRules(this AzureCosmosdbUpdateSettings toolSettings, string virtualNetworkRules)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetworkRules = virtualNetworkRules;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.VirtualNetworkRules"/></em></p>
        ///   <p>ACL's for virtual network.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetVirtualNetworkRules(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetworkRules = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetIds(this AzureCosmosdbUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetIds(this AzureCosmosdbUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings AddIds(this AzureCosmosdbUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings AddIds(this AzureCosmosdbUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCosmosdbUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ClearIds(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings RemoveIds(this AzureCosmosdbUpdateSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbUpdateSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings RemoveIds(this AzureCosmosdbUpdateSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetName(this AzureCosmosdbUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetName(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetResourceGroup(this AzureCosmosdbUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetResourceGroup(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetSubscription(this AzureCosmosdbUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetSubscription(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetDebug(this AzureCosmosdbUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetDebug(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetHelp(this AzureCosmosdbUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetHelp(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetOutput(this AzureCosmosdbUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetOutput(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetQuery(this AzureCosmosdbUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetQuery(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings SetVerbose(this AzureCosmosdbUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbUpdateSettings ResetVerbose(this AzureCosmosdbUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbCollectionCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCollectionCreateSettingsExtensions
    {
        #region CollectionName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.CollectionName"/></em></p>
        ///   <p>Collection Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetCollectionName(this AzureCosmosdbCollectionCreateSettings toolSettings, string collectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = collectionName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.CollectionName"/></em></p>
        ///   <p>Collection Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetCollectionName(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = null;
            return toolSettings;
        }
        #endregion
        #region DbName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetDbName(this AzureCosmosdbCollectionCreateSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetDbName(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region DefaultTtl
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.DefaultTtl"/></em></p>
        ///   <p>Default TTL.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetDefaultTtl(this AzureCosmosdbCollectionCreateSettings toolSettings, string defaultTtl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultTtl = defaultTtl;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.DefaultTtl"/></em></p>
        ///   <p>Default TTL.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetDefaultTtl(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultTtl = null;
            return toolSettings;
        }
        #endregion
        #region IndexingPolicy
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.IndexingPolicy"/></em></p>
        ///   <p>Indexing Policy, you can enter it as a string or as a file, e.g., --indexing-policy @policy-file.json).</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetIndexingPolicy(this AzureCosmosdbCollectionCreateSettings toolSettings, string indexingPolicy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexingPolicy = indexingPolicy;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.IndexingPolicy"/></em></p>
        ///   <p>Indexing Policy, you can enter it as a string or as a file, e.g., --indexing-policy @policy-file.json).</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetIndexingPolicy(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexingPolicy = null;
            return toolSettings;
        }
        #endregion
        #region PartitionKeyPath
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.PartitionKeyPath"/></em></p>
        ///   <p>Partition Key Path, e.g., '/properties/name'.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetPartitionKeyPath(this AzureCosmosdbCollectionCreateSettings toolSettings, string partitionKeyPath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionKeyPath = partitionKeyPath;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.PartitionKeyPath"/></em></p>
        ///   <p>Partition Key Path, e.g., '/properties/name'.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetPartitionKeyPath(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PartitionKeyPath = null;
            return toolSettings;
        }
        #endregion
        #region Throughput
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Throughput"/></em></p>
        ///   <p>Offer Throughput (RU/s).</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetThroughput(this AzureCosmosdbCollectionCreateSettings toolSettings, string throughput)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Throughput = throughput;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Throughput"/></em></p>
        ///   <p>Offer Throughput (RU/s).</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetThroughput(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Throughput = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetKey(this AzureCosmosdbCollectionCreateSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetKey(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetName(this AzureCosmosdbCollectionCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetName(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetResourceGroupName(this AzureCosmosdbCollectionCreateSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetResourceGroupName(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetUrlConnection(this AzureCosmosdbCollectionCreateSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetUrlConnection(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetSubscription(this AzureCosmosdbCollectionCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetSubscription(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetDebug(this AzureCosmosdbCollectionCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetDebug(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetHelp(this AzureCosmosdbCollectionCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetHelp(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetOutput(this AzureCosmosdbCollectionCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetOutput(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetQuery(this AzureCosmosdbCollectionCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetQuery(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings SetVerbose(this AzureCosmosdbCollectionCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionCreateSettings ResetVerbose(this AzureCosmosdbCollectionCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbCollectionDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCollectionDeleteSettingsExtensions
    {
        #region CollectionName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.CollectionName"/></em></p>
        ///   <p>Collection Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetCollectionName(this AzureCosmosdbCollectionDeleteSettings toolSettings, string collectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = collectionName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.CollectionName"/></em></p>
        ///   <p>Collection Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetCollectionName(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = null;
            return toolSettings;
        }
        #endregion
        #region DbName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetDbName(this AzureCosmosdbCollectionDeleteSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetDbName(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetKey(this AzureCosmosdbCollectionDeleteSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetKey(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetName(this AzureCosmosdbCollectionDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetName(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetResourceGroupName(this AzureCosmosdbCollectionDeleteSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetResourceGroupName(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetUrlConnection(this AzureCosmosdbCollectionDeleteSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetUrlConnection(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetSubscription(this AzureCosmosdbCollectionDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetSubscription(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetDebug(this AzureCosmosdbCollectionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetDebug(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetHelp(this AzureCosmosdbCollectionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetHelp(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetOutput(this AzureCosmosdbCollectionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetOutput(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetQuery(this AzureCosmosdbCollectionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetQuery(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings SetVerbose(this AzureCosmosdbCollectionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionDeleteSettings ResetVerbose(this AzureCosmosdbCollectionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbCollectionExistsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCollectionExistsSettingsExtensions
    {
        #region CollectionName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.CollectionName"/></em></p>
        ///   <p>Collection Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetCollectionName(this AzureCosmosdbCollectionExistsSettings toolSettings, string collectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = collectionName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.CollectionName"/></em></p>
        ///   <p>Collection Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetCollectionName(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = null;
            return toolSettings;
        }
        #endregion
        #region DbName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetDbName(this AzureCosmosdbCollectionExistsSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetDbName(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetKey(this AzureCosmosdbCollectionExistsSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetKey(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetName(this AzureCosmosdbCollectionExistsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetName(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetResourceGroupName(this AzureCosmosdbCollectionExistsSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetResourceGroupName(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetUrlConnection(this AzureCosmosdbCollectionExistsSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetUrlConnection(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetSubscription(this AzureCosmosdbCollectionExistsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetSubscription(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetDebug(this AzureCosmosdbCollectionExistsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetDebug(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetHelp(this AzureCosmosdbCollectionExistsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetHelp(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetOutput(this AzureCosmosdbCollectionExistsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetOutput(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetQuery(this AzureCosmosdbCollectionExistsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetQuery(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionExistsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings SetVerbose(this AzureCosmosdbCollectionExistsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionExistsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionExistsSettings ResetVerbose(this AzureCosmosdbCollectionExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbCollectionListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCollectionListSettingsExtensions
    {
        #region DbName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetDbName(this AzureCosmosdbCollectionListSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetDbName(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetKey(this AzureCosmosdbCollectionListSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetKey(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetName(this AzureCosmosdbCollectionListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetName(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetResourceGroupName(this AzureCosmosdbCollectionListSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetResourceGroupName(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetUrlConnection(this AzureCosmosdbCollectionListSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetUrlConnection(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetSubscription(this AzureCosmosdbCollectionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetSubscription(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetDebug(this AzureCosmosdbCollectionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetDebug(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetHelp(this AzureCosmosdbCollectionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetHelp(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetOutput(this AzureCosmosdbCollectionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetOutput(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetQuery(this AzureCosmosdbCollectionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetQuery(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings SetVerbose(this AzureCosmosdbCollectionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionListSettings ResetVerbose(this AzureCosmosdbCollectionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbCollectionShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCollectionShowSettingsExtensions
    {
        #region CollectionName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.CollectionName"/></em></p>
        ///   <p>Collection Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetCollectionName(this AzureCosmosdbCollectionShowSettings toolSettings, string collectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = collectionName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.CollectionName"/></em></p>
        ///   <p>Collection Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetCollectionName(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = null;
            return toolSettings;
        }
        #endregion
        #region DbName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetDbName(this AzureCosmosdbCollectionShowSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetDbName(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetKey(this AzureCosmosdbCollectionShowSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetKey(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetName(this AzureCosmosdbCollectionShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetName(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetResourceGroupName(this AzureCosmosdbCollectionShowSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetResourceGroupName(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetUrlConnection(this AzureCosmosdbCollectionShowSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetUrlConnection(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetSubscription(this AzureCosmosdbCollectionShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetSubscription(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetDebug(this AzureCosmosdbCollectionShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetDebug(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetHelp(this AzureCosmosdbCollectionShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetHelp(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetOutput(this AzureCosmosdbCollectionShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetOutput(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetQuery(this AzureCosmosdbCollectionShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetQuery(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings SetVerbose(this AzureCosmosdbCollectionShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionShowSettings ResetVerbose(this AzureCosmosdbCollectionShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbCollectionUpdateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbCollectionUpdateSettingsExtensions
    {
        #region CollectionName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.CollectionName"/></em></p>
        ///   <p>Collection Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetCollectionName(this AzureCosmosdbCollectionUpdateSettings toolSettings, string collectionName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = collectionName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.CollectionName"/></em></p>
        ///   <p>Collection Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetCollectionName(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CollectionName = null;
            return toolSettings;
        }
        #endregion
        #region DbName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetDbName(this AzureCosmosdbCollectionUpdateSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetDbName(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region DefaultTtl
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.DefaultTtl"/></em></p>
        ///   <p>Default TTL.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetDefaultTtl(this AzureCosmosdbCollectionUpdateSettings toolSettings, string defaultTtl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultTtl = defaultTtl;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.DefaultTtl"/></em></p>
        ///   <p>Default TTL.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetDefaultTtl(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DefaultTtl = null;
            return toolSettings;
        }
        #endregion
        #region IndexingPolicy
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.IndexingPolicy"/></em></p>
        ///   <p>Indexing Policy, you can enter it as a string or as a file, e.g., --indexing-policy @policy-file.json).</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetIndexingPolicy(this AzureCosmosdbCollectionUpdateSettings toolSettings, string indexingPolicy)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexingPolicy = indexingPolicy;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.IndexingPolicy"/></em></p>
        ///   <p>Indexing Policy, you can enter it as a string or as a file, e.g., --indexing-policy @policy-file.json).</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetIndexingPolicy(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IndexingPolicy = null;
            return toolSettings;
        }
        #endregion
        #region Throughput
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Throughput"/></em></p>
        ///   <p>Offer Throughput (RU/s).</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetThroughput(this AzureCosmosdbCollectionUpdateSettings toolSettings, string throughput)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Throughput = throughput;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Throughput"/></em></p>
        ///   <p>Offer Throughput (RU/s).</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetThroughput(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Throughput = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetKey(this AzureCosmosdbCollectionUpdateSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetKey(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetName(this AzureCosmosdbCollectionUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetName(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetResourceGroupName(this AzureCosmosdbCollectionUpdateSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetResourceGroupName(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetUrlConnection(this AzureCosmosdbCollectionUpdateSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetUrlConnection(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetSubscription(this AzureCosmosdbCollectionUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetSubscription(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetDebug(this AzureCosmosdbCollectionUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetDebug(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetHelp(this AzureCosmosdbCollectionUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetHelp(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetOutput(this AzureCosmosdbCollectionUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetOutput(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetQuery(this AzureCosmosdbCollectionUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetQuery(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbCollectionUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings SetVerbose(this AzureCosmosdbCollectionUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbCollectionUpdateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbCollectionUpdateSettings ResetVerbose(this AzureCosmosdbCollectionUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbDatabaseCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbDatabaseCreateSettingsExtensions
    {
        #region DbName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetDbName(this AzureCosmosdbDatabaseCreateSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetDbName(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Throughput
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Throughput"/></em></p>
        ///   <p>Offer Throughput (RU/s).</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetThroughput(this AzureCosmosdbDatabaseCreateSettings toolSettings, string throughput)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Throughput = throughput;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Throughput"/></em></p>
        ///   <p>Offer Throughput (RU/s).</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetThroughput(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Throughput = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetKey(this AzureCosmosdbDatabaseCreateSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetKey(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetName(this AzureCosmosdbDatabaseCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetName(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetResourceGroupName(this AzureCosmosdbDatabaseCreateSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetResourceGroupName(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetUrlConnection(this AzureCosmosdbDatabaseCreateSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetUrlConnection(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetSubscription(this AzureCosmosdbDatabaseCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetSubscription(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetDebug(this AzureCosmosdbDatabaseCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetDebug(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetHelp(this AzureCosmosdbDatabaseCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetHelp(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetOutput(this AzureCosmosdbDatabaseCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetOutput(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetQuery(this AzureCosmosdbDatabaseCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetQuery(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings SetVerbose(this AzureCosmosdbDatabaseCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseCreateSettings ResetVerbose(this AzureCosmosdbDatabaseCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbDatabaseDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbDatabaseDeleteSettingsExtensions
    {
        #region DbName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetDbName(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetDbName(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetKey(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetKey(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetName(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetName(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetResourceGroupName(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetResourceGroupName(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetUrlConnection(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetUrlConnection(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetSubscription(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetSubscription(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetDebug(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetDebug(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetHelp(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetHelp(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetOutput(this AzureCosmosdbDatabaseDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetOutput(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetQuery(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetQuery(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings SetVerbose(this AzureCosmosdbDatabaseDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseDeleteSettings ResetVerbose(this AzureCosmosdbDatabaseDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbDatabaseExistsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbDatabaseExistsSettingsExtensions
    {
        #region DbName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetDbName(this AzureCosmosdbDatabaseExistsSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetDbName(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetKey(this AzureCosmosdbDatabaseExistsSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetKey(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetName(this AzureCosmosdbDatabaseExistsSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetName(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetResourceGroupName(this AzureCosmosdbDatabaseExistsSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetResourceGroupName(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetUrlConnection(this AzureCosmosdbDatabaseExistsSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetUrlConnection(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetSubscription(this AzureCosmosdbDatabaseExistsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetSubscription(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetDebug(this AzureCosmosdbDatabaseExistsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetDebug(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetHelp(this AzureCosmosdbDatabaseExistsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetHelp(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetOutput(this AzureCosmosdbDatabaseExistsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetOutput(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetQuery(this AzureCosmosdbDatabaseExistsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetQuery(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseExistsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings SetVerbose(this AzureCosmosdbDatabaseExistsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseExistsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseExistsSettings ResetVerbose(this AzureCosmosdbDatabaseExistsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbDatabaseListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbDatabaseListSettingsExtensions
    {
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetKey(this AzureCosmosdbDatabaseListSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetKey(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetName(this AzureCosmosdbDatabaseListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetName(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetResourceGroupName(this AzureCosmosdbDatabaseListSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetResourceGroupName(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetUrlConnection(this AzureCosmosdbDatabaseListSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetUrlConnection(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetSubscription(this AzureCosmosdbDatabaseListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetSubscription(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetDebug(this AzureCosmosdbDatabaseListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetDebug(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetHelp(this AzureCosmosdbDatabaseListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetHelp(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetOutput(this AzureCosmosdbDatabaseListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetOutput(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetQuery(this AzureCosmosdbDatabaseListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetQuery(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings SetVerbose(this AzureCosmosdbDatabaseListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseListSettings ResetVerbose(this AzureCosmosdbDatabaseListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbDatabaseShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbDatabaseShowSettingsExtensions
    {
        #region DbName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetDbName(this AzureCosmosdbDatabaseShowSettings toolSettings, string dbName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = dbName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.DbName"/></em></p>
        ///   <p>Database Name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetDbName(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DbName = null;
            return toolSettings;
        }
        #endregion
        #region Key
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetKey(this AzureCosmosdbDatabaseShowSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Key"/></em></p>
        ///   <p>Cosmos DB account key. Must be used in conjunction with cosmosdb account name or url-connection.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetKey(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetName(this AzureCosmosdbDatabaseShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Name"/></em></p>
        ///   <p>Cosmos DB account name. Must be used in conjunction with either name of the resource group or cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetName(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroupName
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetResourceGroupName(this AzureCosmosdbDatabaseShowSettings toolSettings, string resourceGroupName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = resourceGroupName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.ResourceGroupName"/></em></p>
        ///   <p>Name of the resource group. Must be used in conjunction with cosmosdb account name.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetResourceGroupName(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroupName = null;
            return toolSettings;
        }
        #endregion
        #region UrlConnection
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetUrlConnection(this AzureCosmosdbDatabaseShowSettings toolSettings, string urlConnection)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = urlConnection;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.UrlConnection"/></em></p>
        ///   <p>Cosmos DB account url connection. Must be used in conjunction with cosmosdb account key.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetUrlConnection(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UrlConnection = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetSubscription(this AzureCosmosdbDatabaseShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetSubscription(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetDebug(this AzureCosmosdbDatabaseShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetDebug(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetHelp(this AzureCosmosdbDatabaseShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetHelp(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetOutput(this AzureCosmosdbDatabaseShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetOutput(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetQuery(this AzureCosmosdbDatabaseShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetQuery(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbDatabaseShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings SetVerbose(this AzureCosmosdbDatabaseShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbDatabaseShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbDatabaseShowSettings ResetVerbose(this AzureCosmosdbDatabaseShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbKeysListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbKeysListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbKeysListSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings SetName(this AzureCosmosdbKeysListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbKeysListSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings ResetName(this AzureCosmosdbKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbKeysListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings SetResourceGroup(this AzureCosmosdbKeysListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbKeysListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings ResetResourceGroup(this AzureCosmosdbKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbKeysListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings SetSubscription(this AzureCosmosdbKeysListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbKeysListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings ResetSubscription(this AzureCosmosdbKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbKeysListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings SetDebug(this AzureCosmosdbKeysListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbKeysListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings ResetDebug(this AzureCosmosdbKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbKeysListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings SetHelp(this AzureCosmosdbKeysListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbKeysListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings ResetHelp(this AzureCosmosdbKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbKeysListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings SetOutput(this AzureCosmosdbKeysListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbKeysListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings ResetOutput(this AzureCosmosdbKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbKeysListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings SetQuery(this AzureCosmosdbKeysListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbKeysListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings ResetQuery(this AzureCosmosdbKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbKeysListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings SetVerbose(this AzureCosmosdbKeysListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbKeysListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbKeysListSettings ResetVerbose(this AzureCosmosdbKeysListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbNetworkRuleAddSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbNetworkRuleAddSettingsExtensions
    {
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleAddSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings SetSubnet(this AzureCosmosdbNetworkRuleAddSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleAddSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings ResetSubnet(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region IgnoreMissingVnetServiceEndpoint
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleAddSettings.IgnoreMissingVnetServiceEndpoint"/></em></p>
        ///   <p>Create firewall rule before the virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings SetIgnoreMissingVnetServiceEndpoint(this AzureCosmosdbNetworkRuleAddSettings toolSettings, bool? ignoreMissingVnetServiceEndpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingVnetServiceEndpoint = ignoreMissingVnetServiceEndpoint;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleAddSettings.IgnoreMissingVnetServiceEndpoint"/></em></p>
        ///   <p>Create firewall rule before the virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings ResetIgnoreMissingVnetServiceEndpoint(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingVnetServiceEndpoint = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AzureCosmosdbNetworkRuleAddSettings.IgnoreMissingVnetServiceEndpoint"/></em></p>
        ///   <p>Create firewall rule before the virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings EnableIgnoreMissingVnetServiceEndpoint(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingVnetServiceEndpoint = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AzureCosmosdbNetworkRuleAddSettings.IgnoreMissingVnetServiceEndpoint"/></em></p>
        ///   <p>Create firewall rule before the virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings DisableIgnoreMissingVnetServiceEndpoint(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingVnetServiceEndpoint = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AzureCosmosdbNetworkRuleAddSettings.IgnoreMissingVnetServiceEndpoint"/></em></p>
        ///   <p>Create firewall rule before the virtual network has vnet service endpoint enabled.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings ToggleIgnoreMissingVnetServiceEndpoint(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IgnoreMissingVnetServiceEndpoint = !toolSettings.IgnoreMissingVnetServiceEndpoint;
            return toolSettings;
        }
        #endregion
        #region VirtualNetwork
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleAddSettings.VirtualNetwork"/></em></p>
        ///   <p>The name of the VNET, which must be provided in conjunction with the name of the subnet.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings SetVirtualNetwork(this AzureCosmosdbNetworkRuleAddSettings toolSettings, string virtualNetwork)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetwork = virtualNetwork;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleAddSettings.VirtualNetwork"/></em></p>
        ///   <p>The name of the VNET, which must be provided in conjunction with the name of the subnet.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings ResetVirtualNetwork(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetwork = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleAddSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings SetIds(this AzureCosmosdbNetworkRuleAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleAddSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings SetIds(this AzureCosmosdbNetworkRuleAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbNetworkRuleAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings AddIds(this AzureCosmosdbNetworkRuleAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbNetworkRuleAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings AddIds(this AzureCosmosdbNetworkRuleAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCosmosdbNetworkRuleAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings ClearIds(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbNetworkRuleAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings RemoveIds(this AzureCosmosdbNetworkRuleAddSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbNetworkRuleAddSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings RemoveIds(this AzureCosmosdbNetworkRuleAddSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleAddSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings SetName(this AzureCosmosdbNetworkRuleAddSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleAddSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings ResetName(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleAddSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings SetResourceGroup(this AzureCosmosdbNetworkRuleAddSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleAddSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings ResetResourceGroup(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings SetSubscription(this AzureCosmosdbNetworkRuleAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleAddSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings ResetSubscription(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings SetDebug(this AzureCosmosdbNetworkRuleAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleAddSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings ResetDebug(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings SetHelp(this AzureCosmosdbNetworkRuleAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleAddSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings ResetHelp(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings SetOutput(this AzureCosmosdbNetworkRuleAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleAddSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings ResetOutput(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings SetQuery(this AzureCosmosdbNetworkRuleAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleAddSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings ResetQuery(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings SetVerbose(this AzureCosmosdbNetworkRuleAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleAddSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleAddSettings ResetVerbose(this AzureCosmosdbNetworkRuleAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbNetworkRuleListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbNetworkRuleListSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleListSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings SetName(this AzureCosmosdbNetworkRuleListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleListSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings ResetName(this AzureCosmosdbNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings SetResourceGroup(this AzureCosmosdbNetworkRuleListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings ResetResourceGroup(this AzureCosmosdbNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings SetSubscription(this AzureCosmosdbNetworkRuleListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings ResetSubscription(this AzureCosmosdbNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings SetDebug(this AzureCosmosdbNetworkRuleListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings ResetDebug(this AzureCosmosdbNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings SetHelp(this AzureCosmosdbNetworkRuleListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings ResetHelp(this AzureCosmosdbNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings SetOutput(this AzureCosmosdbNetworkRuleListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings ResetOutput(this AzureCosmosdbNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings SetQuery(this AzureCosmosdbNetworkRuleListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings ResetQuery(this AzureCosmosdbNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings SetVerbose(this AzureCosmosdbNetworkRuleListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleListSettings ResetVerbose(this AzureCosmosdbNetworkRuleListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureCosmosdbNetworkRuleRemoveSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureCosmosdbNetworkRuleRemoveSettingsExtensions
    {
        #region Subnet
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings SetSubnet(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, string subnet)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = subnet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Subnet"/></em></p>
        ///   <p>Name or ID of the subnet.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings ResetSubnet(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subnet = null;
            return toolSettings;
        }
        #endregion
        #region VirtualNetwork
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.VirtualNetwork"/></em></p>
        ///   <p>The name of the VNET, which must be provided in conjunction with the name of the subnet.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings SetVirtualNetwork(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, string virtualNetwork)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetwork = virtualNetwork;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.VirtualNetwork"/></em></p>
        ///   <p>The name of the VNET, which must be provided in conjunction with the name of the subnet.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings ResetVirtualNetwork(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VirtualNetwork = null;
            return toolSettings;
        }
        #endregion
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings SetIds(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings SetIds(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings AddIds(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings AddIds(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings ClearIds(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings RemoveIds(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings RemoveIds(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings SetName(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Name"/></em></p>
        ///   <p>Name of the Cosmos DB database account.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings ResetName(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings SetResourceGroup(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings ResetResourceGroup(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings SetSubscription(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings ResetSubscription(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings SetDebug(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings ResetDebug(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings SetHelp(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings ResetHelp(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings SetOutput(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings ResetOutput(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings SetQuery(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings ResetQuery(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings SetVerbose(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureCosmosdbNetworkRuleRemoveSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureCosmosdbNetworkRuleRemoveSettings ResetVerbose(this AzureCosmosdbNetworkRuleRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region CosmosdbDefaultConsistencyLevel
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<CosmosdbDefaultConsistencyLevel>))]
    public partial class CosmosdbDefaultConsistencyLevel : Enumeration
    {
        public static CosmosdbDefaultConsistencyLevel boundedstaleness = new CosmosdbDefaultConsistencyLevel { Value = "boundedstaleness" };
        public static CosmosdbDefaultConsistencyLevel consistentprefix = new CosmosdbDefaultConsistencyLevel { Value = "consistentprefix" };
        public static CosmosdbDefaultConsistencyLevel eventual = new CosmosdbDefaultConsistencyLevel { Value = "eventual" };
        public static CosmosdbDefaultConsistencyLevel session = new CosmosdbDefaultConsistencyLevel { Value = "session" };
        public static CosmosdbDefaultConsistencyLevel strong = new CosmosdbDefaultConsistencyLevel { Value = "strong" };
    }
    #endregion
    #region CosmosdbCreateKind
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<CosmosdbCreateKind>))]
    public partial class CosmosdbCreateKind : Enumeration
    {
        public static CosmosdbCreateKind globaldocumentdb = new CosmosdbCreateKind { Value = "globaldocumentdb" };
        public static CosmosdbCreateKind mongodb = new CosmosdbCreateKind { Value = "mongodb" };
        public static CosmosdbCreateKind parse = new CosmosdbCreateKind { Value = "parse" };
    }
    #endregion
    #region CosmosdbRegenerateKeyKeyKind
    /// <summary>
    ///   Used within <see cref="AzureCosmosdbTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<CosmosdbRegenerateKeyKeyKind>))]
    public partial class CosmosdbRegenerateKeyKeyKind : Enumeration
    {
        public static CosmosdbRegenerateKeyKeyKind primary = new CosmosdbRegenerateKeyKeyKind { Value = "primary" };
        public static CosmosdbRegenerateKeyKeyKind primaryreadonly = new CosmosdbRegenerateKeyKeyKind { Value = "primaryreadonly" };
        public static CosmosdbRegenerateKeyKeyKind secondary = new CosmosdbRegenerateKeyKeyKind { Value = "secondary" };
        public static CosmosdbRegenerateKeyKeyKind secondaryreadonly = new CosmosdbRegenerateKeyKeyKind { Value = "secondaryreadonly" };
    }
    #endregion
}
