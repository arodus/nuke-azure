// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureIdentity.json
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
    public static partial class AzureIdentityTasks
    {
        /// <summary>
        ///   Path to the AzureIdentity executable.
        /// </summary>
        public static string AzureIdentityPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREIDENTITY_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureIdentityLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Managed Service Identities.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureIdentity(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureIdentityPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureIdentityLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureIdentityCreate(AzureIdentityCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureIdentityCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIdentityCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIdentityCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureIdentityCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureIdentityCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIdentityCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIdentityCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIdentityCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIdentityCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureIdentityCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIdentityCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureIdentityCreate(Configure<AzureIdentityCreateSettings> configurator)
        {
            return AzureIdentityCreate(configurator(new AzureIdentityCreateSettings()));
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIdentityCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIdentityCreateSettings.Help"/></li>
        ///     <li><c>--location</c> via <see cref="AzureIdentityCreateSettings.Location"/></li>
        ///     <li><c>--name</c> via <see cref="AzureIdentityCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIdentityCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIdentityCreateSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIdentityCreateSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIdentityCreateSettings.Subscription"/></li>
        ///     <li><c>--tags</c> via <see cref="AzureIdentityCreateSettings.Tags"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIdentityCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureIdentityCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureIdentityCreate(CombinatorialConfigure<AzureIdentityCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureIdentityCreate, AzureIdentityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureIdentityDelete(AzureIdentityDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureIdentityDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIdentityDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIdentityDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureIdentityDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureIdentityDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIdentityDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIdentityDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIdentityDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIdentityDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIdentityDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureIdentityDelete(Configure<AzureIdentityDeleteSettings> configurator)
        {
            return AzureIdentityDelete(configurator(new AzureIdentityDeleteSettings()));
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIdentityDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIdentityDeleteSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureIdentityDeleteSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureIdentityDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIdentityDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIdentityDeleteSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIdentityDeleteSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIdentityDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIdentityDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureIdentityDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureIdentityDelete(CombinatorialConfigure<AzureIdentityDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureIdentityDelete, AzureIdentityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureIdentityList(AzureIdentityListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureIdentityListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIdentityListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIdentityListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIdentityListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIdentityListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIdentityListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIdentityListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIdentityListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureIdentityList(Configure<AzureIdentityListSettings> configurator)
        {
            return AzureIdentityList(configurator(new AzureIdentityListSettings()));
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIdentityListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIdentityListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIdentityListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIdentityListSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIdentityListSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIdentityListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIdentityListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureIdentityListSettings Settings, IReadOnlyCollection<Output> Output)> AzureIdentityList(CombinatorialConfigure<AzureIdentityListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureIdentityList, AzureIdentityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureIdentityListOperations(AzureIdentityListOperationsSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureIdentityListOperationsSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIdentityListOperationsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIdentityListOperationsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIdentityListOperationsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIdentityListOperationsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIdentityListOperationsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIdentityListOperationsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureIdentityListOperations(Configure<AzureIdentityListOperationsSettings> configurator)
        {
            return AzureIdentityListOperations(configurator(new AzureIdentityListOperationsSettings()));
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIdentityListOperationsSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIdentityListOperationsSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIdentityListOperationsSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIdentityListOperationsSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIdentityListOperationsSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIdentityListOperationsSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureIdentityListOperationsSettings Settings, IReadOnlyCollection<Output> Output)> AzureIdentityListOperations(CombinatorialConfigure<AzureIdentityListOperationsSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureIdentityListOperations, AzureIdentityLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureIdentityShow(AzureIdentityShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureIdentityShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIdentityShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIdentityShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureIdentityShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureIdentityShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIdentityShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIdentityShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIdentityShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIdentityShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIdentityShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureIdentityShow(Configure<AzureIdentityShowSettings> configurator)
        {
            return AzureIdentityShow(configurator(new AzureIdentityShowSettings()));
        }
        /// <summary>
        ///   <p>Managed Service Identities.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/identity?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureIdentityShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureIdentityShowSettings.Help"/></li>
        ///     <li><c>--ids</c> via <see cref="AzureIdentityShowSettings.Ids"/></li>
        ///     <li><c>--name</c> via <see cref="AzureIdentityShowSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureIdentityShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureIdentityShowSettings.Query"/></li>
        ///     <li><c>--resource-group</c> via <see cref="AzureIdentityShowSettings.ResourceGroup"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureIdentityShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureIdentityShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureIdentityShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureIdentityShow(CombinatorialConfigure<AzureIdentityShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureIdentityShow, AzureIdentityLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureIdentityCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureIdentityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIdentityCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureIdentity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureIdentityTasks.AzureIdentityPath;
        public override Action<OutputType, string> CustomLogger => AzureIdentityTasks.AzureIdentityLogger;
        /// <summary>
        ///   The name of the identity resource.
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
              .Add("identity create")
              .Add("--name {value}", Name)
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
    #region AzureIdentityDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureIdentityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIdentityDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureIdentity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureIdentityTasks.AzureIdentityPath;
        public override Action<OutputType, string> CustomLogger => AzureIdentityTasks.AzureIdentityLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the identity resource.
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
              .Add("identity delete")
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
    #region AzureIdentityListSettings
    /// <summary>
    ///   Used within <see cref="AzureIdentityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIdentityListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureIdentity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureIdentityTasks.AzureIdentityPath;
        public override Action<OutputType, string> CustomLogger => AzureIdentityTasks.AzureIdentityLogger;
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
              .Add("identity list")
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
    #region AzureIdentityListOperationsSettings
    /// <summary>
    ///   Used within <see cref="AzureIdentityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIdentityListOperationsSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureIdentity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureIdentityTasks.AzureIdentityPath;
        public override Action<OutputType, string> CustomLogger => AzureIdentityTasks.AzureIdentityLogger;
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
              .Add("identity list-operations")
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
    #region AzureIdentityShowSettings
    /// <summary>
    ///   Used within <see cref="AzureIdentityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureIdentityShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureIdentity executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureIdentityTasks.AzureIdentityPath;
        public override Action<OutputType, string> CustomLogger => AzureIdentityTasks.AzureIdentityLogger;
        /// <summary>
        ///   One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.
        /// </summary>
        public virtual IReadOnlyList<string> Ids => IdsInternal.AsReadOnly();
        internal List<string> IdsInternal { get; set; } = new List<string>();
        /// <summary>
        ///   The name of the identity resource.
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
              .Add("identity show")
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
    #region AzureIdentityCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureIdentityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIdentityCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityCreateSettings.Name"/></em></p>
        ///   <p>The name of the identity resource.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings SetName(this AzureIdentityCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityCreateSettings.Name"/></em></p>
        ///   <p>The name of the identity resource.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings ResetName(this AzureIdentityCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings SetResourceGroup(this AzureIdentityCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityCreateSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings ResetResourceGroup(this AzureIdentityCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings SetLocation(this AzureIdentityCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityCreateSettings.Location"/></em></p>
        ///   <p>Location. Values from: `az account list-locations`. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings ResetLocation(this AzureIdentityCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings SetTags(this AzureIdentityCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityCreateSettings.Tags"/></em></p>
        ///   <p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings ResetTags(this AzureIdentityCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings SetSubscription(this AzureIdentityCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings ResetSubscription(this AzureIdentityCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings SetDebug(this AzureIdentityCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings ResetDebug(this AzureIdentityCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings SetHelp(this AzureIdentityCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings ResetHelp(this AzureIdentityCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings SetOutput(this AzureIdentityCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings ResetOutput(this AzureIdentityCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings SetQuery(this AzureIdentityCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings ResetQuery(this AzureIdentityCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings SetVerbose(this AzureIdentityCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityCreateSettings ResetVerbose(this AzureIdentityCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIdentityDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureIdentityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIdentityDeleteSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings SetIds(this AzureIdentityDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityDeleteSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings SetIds(this AzureIdentityDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureIdentityDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings AddIds(this AzureIdentityDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureIdentityDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings AddIds(this AzureIdentityDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureIdentityDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings ClearIds(this AzureIdentityDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureIdentityDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings RemoveIds(this AzureIdentityDeleteSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureIdentityDeleteSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings RemoveIds(this AzureIdentityDeleteSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityDeleteSettings.Name"/></em></p>
        ///   <p>The name of the identity resource.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings SetName(this AzureIdentityDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityDeleteSettings.Name"/></em></p>
        ///   <p>The name of the identity resource.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings ResetName(this AzureIdentityDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings SetResourceGroup(this AzureIdentityDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityDeleteSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings ResetResourceGroup(this AzureIdentityDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings SetSubscription(this AzureIdentityDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings ResetSubscription(this AzureIdentityDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings SetDebug(this AzureIdentityDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings ResetDebug(this AzureIdentityDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings SetHelp(this AzureIdentityDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings ResetHelp(this AzureIdentityDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings SetOutput(this AzureIdentityDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings ResetOutput(this AzureIdentityDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings SetQuery(this AzureIdentityDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings ResetQuery(this AzureIdentityDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings SetVerbose(this AzureIdentityDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityDeleteSettings ResetVerbose(this AzureIdentityDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIdentityListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureIdentityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIdentityListSettingsExtensions
    {
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListSettings SetResourceGroup(this AzureIdentityListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityListSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListSettings ResetResourceGroup(this AzureIdentityListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListSettings SetSubscription(this AzureIdentityListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListSettings ResetSubscription(this AzureIdentityListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListSettings SetDebug(this AzureIdentityListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListSettings ResetDebug(this AzureIdentityListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListSettings SetHelp(this AzureIdentityListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListSettings ResetHelp(this AzureIdentityListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListSettings SetOutput(this AzureIdentityListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListSettings ResetOutput(this AzureIdentityListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListSettings SetQuery(this AzureIdentityListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListSettings ResetQuery(this AzureIdentityListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListSettings SetVerbose(this AzureIdentityListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListSettings ResetVerbose(this AzureIdentityListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIdentityListOperationsSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureIdentityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIdentityListOperationsSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityListOperationsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListOperationsSettings SetSubscription(this AzureIdentityListOperationsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityListOperationsSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListOperationsSettings ResetSubscription(this AzureIdentityListOperationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityListOperationsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListOperationsSettings SetDebug(this AzureIdentityListOperationsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityListOperationsSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListOperationsSettings ResetDebug(this AzureIdentityListOperationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityListOperationsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListOperationsSettings SetHelp(this AzureIdentityListOperationsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityListOperationsSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListOperationsSettings ResetHelp(this AzureIdentityListOperationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityListOperationsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListOperationsSettings SetOutput(this AzureIdentityListOperationsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityListOperationsSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListOperationsSettings ResetOutput(this AzureIdentityListOperationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityListOperationsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListOperationsSettings SetQuery(this AzureIdentityListOperationsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityListOperationsSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListOperationsSettings ResetQuery(this AzureIdentityListOperationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityListOperationsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListOperationsSettings SetVerbose(this AzureIdentityListOperationsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityListOperationsSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityListOperationsSettings ResetVerbose(this AzureIdentityListOperationsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureIdentityShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureIdentityTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureIdentityShowSettingsExtensions
    {
        #region Ids
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings SetIds(this AzureIdentityShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityShowSettings.Ids"/> to a new list</em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings SetIds(this AzureIdentityShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal = ids.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureIdentityShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings AddIds(this AzureIdentityShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AzureIdentityShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings AddIds(this AzureIdentityShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.AddRange(ids);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AzureIdentityShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings ClearIds(this AzureIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureIdentityShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings RemoveIds(this AzureIdentityShowSettings toolSettings, params string[] ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AzureIdentityShowSettings.Ids"/></em></p>
        ///   <p>One or more resource IDs (space-delimited). If provided, no other 'Resource Id' arguments should be specified.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings RemoveIds(this AzureIdentityShowSettings toolSettings, IEnumerable<string> ids)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(ids);
            toolSettings.IdsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityShowSettings.Name"/></em></p>
        ///   <p>The name of the identity resource.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings SetName(this AzureIdentityShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityShowSettings.Name"/></em></p>
        ///   <p>The name of the identity resource.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings ResetName(this AzureIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings SetResourceGroup(this AzureIdentityShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityShowSettings.ResourceGroup"/></em></p>
        ///   <p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings ResetResourceGroup(this AzureIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings SetSubscription(this AzureIdentityShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings ResetSubscription(this AzureIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings SetDebug(this AzureIdentityShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings ResetDebug(this AzureIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings SetHelp(this AzureIdentityShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings ResetHelp(this AzureIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings SetOutput(this AzureIdentityShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings ResetOutput(this AzureIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings SetQuery(this AzureIdentityShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings ResetQuery(this AzureIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureIdentityShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings SetVerbose(this AzureIdentityShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureIdentityShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureIdentityShowSettings ResetVerbose(this AzureIdentityShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
