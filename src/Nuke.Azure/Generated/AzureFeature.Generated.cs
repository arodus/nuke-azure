// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureFeature.json
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
    public static partial class AzureFeatureTasks
    {
        /// <summary>
        ///   Path to the AzureFeature executable.
        /// </summary>
        public static string AzureFeaturePath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZUREFEATURE_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureFeatureLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage resource provider features.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureFeature(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureFeaturePath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureFeatureLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource provider features.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/feature?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureFeatureList(AzureFeatureListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureFeatureListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource provider features.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/feature?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureFeatureListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureFeatureListSettings.Help"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureFeatureListSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureFeatureListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureFeatureListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureFeatureListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureFeatureListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureFeatureList(Configure<AzureFeatureListSettings> configurator)
        {
            return AzureFeatureList(configurator(new AzureFeatureListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource provider features.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/feature?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureFeatureListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureFeatureListSettings.Help"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureFeatureListSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureFeatureListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureFeatureListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureFeatureListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureFeatureListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureFeatureListSettings Settings, IReadOnlyCollection<Output> Output)> AzureFeatureList(CombinatorialConfigure<AzureFeatureListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureFeatureList, AzureFeatureLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource provider features.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/feature?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureFeatureRegister(AzureFeatureRegisterSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureFeatureRegisterSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource provider features.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/feature?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureFeatureRegisterSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureFeatureRegisterSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureFeatureRegisterSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureFeatureRegisterSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureFeatureRegisterSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureFeatureRegisterSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureFeatureRegisterSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureFeatureRegisterSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureFeatureRegister(Configure<AzureFeatureRegisterSettings> configurator)
        {
            return AzureFeatureRegister(configurator(new AzureFeatureRegisterSettings()));
        }
        /// <summary>
        ///   <p>Manage resource provider features.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/feature?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureFeatureRegisterSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureFeatureRegisterSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureFeatureRegisterSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureFeatureRegisterSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureFeatureRegisterSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureFeatureRegisterSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureFeatureRegisterSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureFeatureRegisterSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureFeatureRegisterSettings Settings, IReadOnlyCollection<Output> Output)> AzureFeatureRegister(CombinatorialConfigure<AzureFeatureRegisterSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureFeatureRegister, AzureFeatureLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource provider features.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/feature?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureFeatureShow(AzureFeatureShowSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureFeatureShowSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource provider features.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/feature?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureFeatureShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureFeatureShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureFeatureShowSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureFeatureShowSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureFeatureShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureFeatureShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureFeatureShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureFeatureShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureFeatureShow(Configure<AzureFeatureShowSettings> configurator)
        {
            return AzureFeatureShow(configurator(new AzureFeatureShowSettings()));
        }
        /// <summary>
        ///   <p>Manage resource provider features.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/feature?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureFeatureShowSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureFeatureShowSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureFeatureShowSettings.Name"/></li>
        ///     <li><c>--namespace</c> via <see cref="AzureFeatureShowSettings.Namespace"/></li>
        ///     <li><c>--output</c> via <see cref="AzureFeatureShowSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureFeatureShowSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureFeatureShowSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureFeatureShowSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureFeatureShowSettings Settings, IReadOnlyCollection<Output> Output)> AzureFeatureShow(CombinatorialConfigure<AzureFeatureShowSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureFeatureShow, AzureFeatureLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureFeatureListSettings
    /// <summary>
    ///   Used within <see cref="AzureFeatureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFeatureListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureFeature executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureFeatureTasks.AzureFeaturePath;
        public override Action<OutputType, string> CustomLogger => AzureFeatureTasks.AzureFeatureLogger;
        /// <summary>
        ///   The resource namespace, aka 'provider'.
        /// </summary>
        public virtual string Namespace { get; internal set; }
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
              .Add("feature list")
              .Add("--namespace {value}", Namespace)
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
    #region AzureFeatureRegisterSettings
    /// <summary>
    ///   Used within <see cref="AzureFeatureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFeatureRegisterSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureFeature executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureFeatureTasks.AzureFeaturePath;
        public override Action<OutputType, string> CustomLogger => AzureFeatureTasks.AzureFeatureLogger;
        /// <summary>
        ///   The feature name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The resource namespace, aka 'provider'.
        /// </summary>
        public virtual string Namespace { get; internal set; }
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
              .Add("feature register")
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
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
    #region AzureFeatureShowSettings
    /// <summary>
    ///   Used within <see cref="AzureFeatureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureFeatureShowSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureFeature executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureFeatureTasks.AzureFeaturePath;
        public override Action<OutputType, string> CustomLogger => AzureFeatureTasks.AzureFeatureLogger;
        /// <summary>
        ///   The feature name.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The resource namespace, aka 'provider'.
        /// </summary>
        public virtual string Namespace { get; internal set; }
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
              .Add("feature show")
              .Add("--name {value}", Name)
              .Add("--namespace {value}", Namespace)
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
    #region AzureFeatureListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureFeatureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFeatureListSettingsExtensions
    {
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureListSettings.Namespace"/></em></p>
        ///   <p>The resource namespace, aka 'provider'.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureListSettings SetNamespace(this AzureFeatureListSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureListSettings.Namespace"/></em></p>
        ///   <p>The resource namespace, aka 'provider'.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureListSettings ResetNamespace(this AzureFeatureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureListSettings SetSubscription(this AzureFeatureListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureListSettings ResetSubscription(this AzureFeatureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureListSettings SetDebug(this AzureFeatureListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureListSettings ResetDebug(this AzureFeatureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureListSettings SetHelp(this AzureFeatureListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureListSettings ResetHelp(this AzureFeatureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureListSettings SetOutput(this AzureFeatureListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureListSettings ResetOutput(this AzureFeatureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureListSettings SetQuery(this AzureFeatureListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureListSettings ResetQuery(this AzureFeatureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureListSettings SetVerbose(this AzureFeatureListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureListSettings ResetVerbose(this AzureFeatureListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFeatureRegisterSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureFeatureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFeatureRegisterSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureRegisterSettings.Name"/></em></p>
        ///   <p>The feature name.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetName(this AzureFeatureRegisterSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureRegisterSettings.Name"/></em></p>
        ///   <p>The feature name.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetName(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureRegisterSettings.Namespace"/></em></p>
        ///   <p>The resource namespace, aka 'provider'.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetNamespace(this AzureFeatureRegisterSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureRegisterSettings.Namespace"/></em></p>
        ///   <p>The resource namespace, aka 'provider'.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetNamespace(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureRegisterSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetSubscription(this AzureFeatureRegisterSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureRegisterSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetSubscription(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureRegisterSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetDebug(this AzureFeatureRegisterSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureRegisterSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetDebug(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureRegisterSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetHelp(this AzureFeatureRegisterSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureRegisterSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetHelp(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureRegisterSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetOutput(this AzureFeatureRegisterSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureRegisterSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetOutput(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureRegisterSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetQuery(this AzureFeatureRegisterSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureRegisterSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetQuery(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureRegisterSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings SetVerbose(this AzureFeatureRegisterSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureRegisterSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureRegisterSettings ResetVerbose(this AzureFeatureRegisterSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureFeatureShowSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureFeatureTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureFeatureShowSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureShowSettings.Name"/></em></p>
        ///   <p>The feature name.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings SetName(this AzureFeatureShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureShowSettings.Name"/></em></p>
        ///   <p>The feature name.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings ResetName(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Namespace
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureShowSettings.Namespace"/></em></p>
        ///   <p>The resource namespace, aka 'provider'.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings SetNamespace(this AzureFeatureShowSettings toolSettings, string @namespace)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = @namespace;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureShowSettings.Namespace"/></em></p>
        ///   <p>The resource namespace, aka 'provider'.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings ResetNamespace(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Namespace = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings SetSubscription(this AzureFeatureShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureShowSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings ResetSubscription(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings SetDebug(this AzureFeatureShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureShowSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings ResetDebug(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings SetHelp(this AzureFeatureShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureShowSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings ResetHelp(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings SetOutput(this AzureFeatureShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureShowSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings ResetOutput(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings SetQuery(this AzureFeatureShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureShowSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings ResetQuery(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureFeatureShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings SetVerbose(this AzureFeatureShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureFeatureShowSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureFeatureShowSettings ResetVerbose(this AzureFeatureShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
