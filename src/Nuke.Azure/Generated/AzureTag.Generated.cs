// Generated from https://github.com/totollygeek/azure/blob/master/src/Nuke.Azure/specifications/AzureTag.json
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
    public static partial class AzureTagTasks
    {
        /// <summary>
        ///   Path to the AzureTag executable.
        /// </summary>
        public static string AzureTagPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("AZURETAG_EXE") ??
            ToolPathResolver.GetPathExecutable("az");
        public static Action<OutputType, string> AzureTagLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   Manage resource tags.
        /// </summary>
        public static IReadOnlyCollection<Output> AzureTag(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureTagPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AzureTagLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureTagAddValue(AzureTagAddValueSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureTagAddValueSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureTagAddValueSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureTagAddValueSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureTagAddValueSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureTagAddValueSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureTagAddValueSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureTagAddValueSettings.Subscription"/></li>
        ///     <li><c>--value</c> via <see cref="AzureTagAddValueSettings.Value"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureTagAddValueSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureTagAddValue(Configure<AzureTagAddValueSettings> configurator)
        {
            return AzureTagAddValue(configurator(new AzureTagAddValueSettings()));
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureTagAddValueSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureTagAddValueSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureTagAddValueSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureTagAddValueSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureTagAddValueSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureTagAddValueSettings.Subscription"/></li>
        ///     <li><c>--value</c> via <see cref="AzureTagAddValueSettings.Value"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureTagAddValueSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureTagAddValueSettings Settings, IReadOnlyCollection<Output> Output)> AzureTagAddValue(CombinatorialConfigure<AzureTagAddValueSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureTagAddValue, AzureTagLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureTagCreate(AzureTagCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureTagCreateSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureTagCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureTagCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureTagCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureTagCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureTagCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureTagCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureTagCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureTagCreate(Configure<AzureTagCreateSettings> configurator)
        {
            return AzureTagCreate(configurator(new AzureTagCreateSettings()));
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureTagCreateSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureTagCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureTagCreateSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureTagCreateSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureTagCreateSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureTagCreateSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureTagCreateSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureTagCreateSettings Settings, IReadOnlyCollection<Output> Output)> AzureTagCreate(CombinatorialConfigure<AzureTagCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureTagCreate, AzureTagLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureTagDelete(AzureTagDeleteSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureTagDeleteSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureTagDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureTagDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureTagDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureTagDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureTagDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureTagDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureTagDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureTagDelete(Configure<AzureTagDeleteSettings> configurator)
        {
            return AzureTagDelete(configurator(new AzureTagDeleteSettings()));
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureTagDeleteSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureTagDeleteSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureTagDeleteSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureTagDeleteSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureTagDeleteSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureTagDeleteSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureTagDeleteSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureTagDeleteSettings Settings, IReadOnlyCollection<Output> Output)> AzureTagDelete(CombinatorialConfigure<AzureTagDeleteSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureTagDelete, AzureTagLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureTagList(AzureTagListSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureTagListSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureTagListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureTagListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureTagListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureTagListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureTagListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureTagListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureTagList(Configure<AzureTagListSettings> configurator)
        {
            return AzureTagList(configurator(new AzureTagListSettings()));
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureTagListSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureTagListSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AzureTagListSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureTagListSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureTagListSettings.Subscription"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureTagListSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureTagListSettings Settings, IReadOnlyCollection<Output> Output)> AzureTagList(CombinatorialConfigure<AzureTagListSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureTagList, AzureTagLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AzureTagRemoveValue(AzureTagRemoveValueSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AzureTagRemoveValueSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureTagRemoveValueSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureTagRemoveValueSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureTagRemoveValueSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureTagRemoveValueSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureTagRemoveValueSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureTagRemoveValueSettings.Subscription"/></li>
        ///     <li><c>--value</c> via <see cref="AzureTagRemoveValueSettings.Value"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureTagRemoveValueSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AzureTagRemoveValue(Configure<AzureTagRemoveValueSettings> configurator)
        {
            return AzureTagRemoveValue(configurator(new AzureTagRemoveValueSettings()));
        }
        /// <summary>
        ///   <p>Manage resource tags.</p>
        ///   <p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/tag?view=azure-cli-latest">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AzureTagRemoveValueSettings.Debug"/></li>
        ///     <li><c>--help</c> via <see cref="AzureTagRemoveValueSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AzureTagRemoveValueSettings.Name"/></li>
        ///     <li><c>--output</c> via <see cref="AzureTagRemoveValueSettings.Output"/></li>
        ///     <li><c>--query</c> via <see cref="AzureTagRemoveValueSettings.Query"/></li>
        ///     <li><c>--subscription</c> via <see cref="AzureTagRemoveValueSettings.Subscription"/></li>
        ///     <li><c>--value</c> via <see cref="AzureTagRemoveValueSettings.Value"/></li>
        ///     <li><c>--verbose</c> via <see cref="AzureTagRemoveValueSettings.Verbose"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AzureTagRemoveValueSettings Settings, IReadOnlyCollection<Output> Output)> AzureTagRemoveValue(CombinatorialConfigure<AzureTagRemoveValueSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AzureTagRemoveValue, AzureTagLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AzureTagAddValueSettings
    /// <summary>
    ///   Used within <see cref="AzureTagTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureTagAddValueSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureTag executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureTagTasks.AzureTagPath;
        public override Action<OutputType, string> CustomLogger => AzureTagTasks.AzureTagLogger;
        /// <summary>
        ///   The name of the tag.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The value of the tag to create.
        /// </summary>
        public virtual string Value { get; internal set; }
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
              .Add("tag add-value")
              .Add("--name {value}", Name)
              .Add("--value {value}", Value)
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
    #region AzureTagCreateSettings
    /// <summary>
    ///   Used within <see cref="AzureTagTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureTagCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureTag executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureTagTasks.AzureTagPath;
        public override Action<OutputType, string> CustomLogger => AzureTagTasks.AzureTagLogger;
        /// <summary>
        ///   The name of the tag to create.
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
              .Add("tag create")
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
    #region AzureTagDeleteSettings
    /// <summary>
    ///   Used within <see cref="AzureTagTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureTagDeleteSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureTag executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureTagTasks.AzureTagPath;
        public override Action<OutputType, string> CustomLogger => AzureTagTasks.AzureTagLogger;
        /// <summary>
        ///   The name of the tag.
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
              .Add("tag delete")
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
    #region AzureTagListSettings
    /// <summary>
    ///   Used within <see cref="AzureTagTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureTagListSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureTag executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureTagTasks.AzureTagPath;
        public override Action<OutputType, string> CustomLogger => AzureTagTasks.AzureTagLogger;
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
              .Add("tag list")
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
    #region AzureTagRemoveValueSettings
    /// <summary>
    ///   Used within <see cref="AzureTagTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureTagRemoveValueSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AzureTag executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? AzureTagTasks.AzureTagPath;
        public override Action<OutputType, string> CustomLogger => AzureTagTasks.AzureTagLogger;
        /// <summary>
        ///   The name of the tag.
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The value of the tag to delete.
        /// </summary>
        public virtual string Value { get; internal set; }
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
              .Add("tag remove-value")
              .Add("--name {value}", Name)
              .Add("--value {value}", Value)
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
    #region AzureTagAddValueSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureTagTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureTagAddValueSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagAddValueSettings.Name"/></em></p>
        ///   <p>The name of the tag.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings SetName(this AzureTagAddValueSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagAddValueSettings.Name"/></em></p>
        ///   <p>The name of the tag.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings ResetName(this AzureTagAddValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Value
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagAddValueSettings.Value"/></em></p>
        ///   <p>The value of the tag to create.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings SetValue(this AzureTagAddValueSettings toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagAddValueSettings.Value"/></em></p>
        ///   <p>The value of the tag to create.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings ResetValue(this AzureTagAddValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagAddValueSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings SetSubscription(this AzureTagAddValueSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagAddValueSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings ResetSubscription(this AzureTagAddValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagAddValueSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings SetDebug(this AzureTagAddValueSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagAddValueSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings ResetDebug(this AzureTagAddValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagAddValueSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings SetHelp(this AzureTagAddValueSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagAddValueSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings ResetHelp(this AzureTagAddValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagAddValueSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings SetOutput(this AzureTagAddValueSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagAddValueSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings ResetOutput(this AzureTagAddValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagAddValueSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings SetQuery(this AzureTagAddValueSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagAddValueSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings ResetQuery(this AzureTagAddValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagAddValueSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings SetVerbose(this AzureTagAddValueSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagAddValueSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagAddValueSettings ResetVerbose(this AzureTagAddValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureTagCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureTagTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureTagCreateSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagCreateSettings.Name"/></em></p>
        ///   <p>The name of the tag to create.</p>
        /// </summary>
        [Pure]
        public static AzureTagCreateSettings SetName(this AzureTagCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagCreateSettings.Name"/></em></p>
        ///   <p>The name of the tag to create.</p>
        /// </summary>
        [Pure]
        public static AzureTagCreateSettings ResetName(this AzureTagCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureTagCreateSettings SetSubscription(this AzureTagCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagCreateSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureTagCreateSettings ResetSubscription(this AzureTagCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagCreateSettings SetDebug(this AzureTagCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagCreateSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagCreateSettings ResetDebug(this AzureTagCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureTagCreateSettings SetHelp(this AzureTagCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagCreateSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureTagCreateSettings ResetHelp(this AzureTagCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureTagCreateSettings SetOutput(this AzureTagCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagCreateSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureTagCreateSettings ResetOutput(this AzureTagCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureTagCreateSettings SetQuery(this AzureTagCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagCreateSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureTagCreateSettings ResetQuery(this AzureTagCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagCreateSettings SetVerbose(this AzureTagCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagCreateSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagCreateSettings ResetVerbose(this AzureTagCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureTagDeleteSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureTagTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureTagDeleteSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagDeleteSettings.Name"/></em></p>
        ///   <p>The name of the tag.</p>
        /// </summary>
        [Pure]
        public static AzureTagDeleteSettings SetName(this AzureTagDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagDeleteSettings.Name"/></em></p>
        ///   <p>The name of the tag.</p>
        /// </summary>
        [Pure]
        public static AzureTagDeleteSettings ResetName(this AzureTagDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureTagDeleteSettings SetSubscription(this AzureTagDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagDeleteSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureTagDeleteSettings ResetSubscription(this AzureTagDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagDeleteSettings SetDebug(this AzureTagDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagDeleteSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagDeleteSettings ResetDebug(this AzureTagDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureTagDeleteSettings SetHelp(this AzureTagDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagDeleteSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureTagDeleteSettings ResetHelp(this AzureTagDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureTagDeleteSettings SetOutput(this AzureTagDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagDeleteSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureTagDeleteSettings ResetOutput(this AzureTagDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureTagDeleteSettings SetQuery(this AzureTagDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagDeleteSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureTagDeleteSettings ResetQuery(this AzureTagDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagDeleteSettings SetVerbose(this AzureTagDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagDeleteSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagDeleteSettings ResetVerbose(this AzureTagDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureTagListSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureTagTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureTagListSettingsExtensions
    {
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureTagListSettings SetSubscription(this AzureTagListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagListSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureTagListSettings ResetSubscription(this AzureTagListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagListSettings SetDebug(this AzureTagListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagListSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagListSettings ResetDebug(this AzureTagListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureTagListSettings SetHelp(this AzureTagListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagListSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureTagListSettings ResetHelp(this AzureTagListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureTagListSettings SetOutput(this AzureTagListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagListSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureTagListSettings ResetOutput(this AzureTagListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureTagListSettings SetQuery(this AzureTagListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagListSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureTagListSettings ResetQuery(this AzureTagListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagListSettings SetVerbose(this AzureTagListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagListSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagListSettings ResetVerbose(this AzureTagListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureTagRemoveValueSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AzureTagTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureTagRemoveValueSettingsExtensions
    {
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagRemoveValueSettings.Name"/></em></p>
        ///   <p>The name of the tag.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings SetName(this AzureTagRemoveValueSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagRemoveValueSettings.Name"/></em></p>
        ///   <p>The name of the tag.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings ResetName(this AzureTagRemoveValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Value
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagRemoveValueSettings.Value"/></em></p>
        ///   <p>The value of the tag to delete.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings SetValue(this AzureTagRemoveValueSettings toolSettings, string value)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagRemoveValueSettings.Value"/></em></p>
        ///   <p>The value of the tag to delete.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings ResetValue(this AzureTagRemoveValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagRemoveValueSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings SetSubscription(this AzureTagRemoveValueSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagRemoveValueSettings.Subscription"/></em></p>
        ///   <p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings ResetSubscription(this AzureTagRemoveValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagRemoveValueSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings SetDebug(this AzureTagRemoveValueSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagRemoveValueSettings.Debug"/></em></p>
        ///   <p>Increase logging verbosity to show all debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings ResetDebug(this AzureTagRemoveValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagRemoveValueSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings SetHelp(this AzureTagRemoveValueSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagRemoveValueSettings.Help"/></em></p>
        ///   <p>Show this help message and exit.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings ResetHelp(this AzureTagRemoveValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagRemoveValueSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings SetOutput(this AzureTagRemoveValueSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagRemoveValueSettings.Output"/></em></p>
        ///   <p>Output format.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings ResetOutput(this AzureTagRemoveValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagRemoveValueSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings SetQuery(this AzureTagRemoveValueSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagRemoveValueSettings.Query"/></em></p>
        ///   <p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings ResetQuery(this AzureTagRemoveValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary>
        ///   <p><em>Sets <see cref="AzureTagRemoveValueSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings SetVerbose(this AzureTagRemoveValueSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AzureTagRemoveValueSettings.Verbose"/></em></p>
        ///   <p>Increase logging verbosity. Use --debug for full debug logs.</p>
        /// </summary>
        [Pure]
        public static AzureTagRemoveValueSettings ResetVerbose(this AzureTagRemoveValueSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
