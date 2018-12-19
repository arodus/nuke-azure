// Copyright 2018 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.7.0 [CommitSha: 9d3d3d7e].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureBot.json.

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
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Azure
{
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotTasks
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public static string AzureBotPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Microsoft Bot Services.</p></summary>
        public static IReadOnlyCollection<Output> AzureBot(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureBotPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotCreate(Configure<AzureBotCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotDelete(Configure<AzureBotDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotDownload(Configure<AzureBotDownloadSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotDownloadSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotPreparePublish(Configure<AzureBotPreparePublishSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotPreparePublishSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotPublish(Configure<AzureBotPublishSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotPublishSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotShow(Configure<AzureBotShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotUpdate(Configure<AzureBotUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotMsteamsCreate(Configure<AzureBotMsteamsCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotMsteamsCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotMsteamsDelete(Configure<AzureBotMsteamsDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotMsteamsDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotMsteamsShow(Configure<AzureBotMsteamsShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotMsteamsShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotSlackCreate(Configure<AzureBotSlackCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotSlackCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotSlackDelete(Configure<AzureBotSlackDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotSlackDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotSlackShow(Configure<AzureBotSlackShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotSlackShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotEmailCreate(Configure<AzureBotEmailCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotEmailCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotEmailDelete(Configure<AzureBotEmailDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotEmailDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotEmailShow(Configure<AzureBotEmailShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotEmailShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotKikCreate(Configure<AzureBotKikCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotKikCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotKikDelete(Configure<AzureBotKikDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotKikDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotKikShow(Configure<AzureBotKikShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotKikShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotAuthsettingCreate(Configure<AzureBotAuthsettingCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotAuthsettingCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotAuthsettingDelete(Configure<AzureBotAuthsettingDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotAuthsettingDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotAuthsettingList(Configure<AzureBotAuthsettingListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotAuthsettingListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotAuthsettingListProviders(Configure<AzureBotAuthsettingListProvidersSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotAuthsettingListProvidersSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotAuthsettingShow(Configure<AzureBotAuthsettingShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotAuthsettingShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotTelegramCreate(Configure<AzureBotTelegramCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotTelegramCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotTelegramDelete(Configure<AzureBotTelegramDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotTelegramDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotTelegramShow(Configure<AzureBotTelegramShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotTelegramShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotSkypeCreate(Configure<AzureBotSkypeCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotSkypeCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotSkypeDelete(Configure<AzureBotSkypeDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotSkypeDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotSkypeShow(Configure<AzureBotSkypeShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotSkypeShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotWebchatShow(Configure<AzureBotWebchatShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotWebchatShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotDirectlineCreate(Configure<AzureBotDirectlineCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotDirectlineCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotDirectlineDelete(Configure<AzureBotDirectlineDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotDirectlineDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotDirectlineShow(Configure<AzureBotDirectlineShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotDirectlineShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotSmsCreate(Configure<AzureBotSmsCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotSmsCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotSmsDelete(Configure<AzureBotSmsDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotSmsDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotSmsShow(Configure<AzureBotSmsShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotSmsShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotFacebookCreate(Configure<AzureBotFacebookCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotFacebookCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotFacebookDelete(Configure<AzureBotFacebookDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotFacebookDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Microsoft Bot Services.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/bot?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureBotFacebookShow(Configure<AzureBotFacebookShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureBotFacebookShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureBotCreateSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The kind of the bot.</p></summary>
        public virtual BotCreateKind Kind { get; internal set; }
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The Microsoft account ID (MSA ID) to be used with the bot.</p></summary>
        public virtual string Appid { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>The Microsoft account (MSA) password for the bot.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>The description of the bot.</p></summary>
        public virtual string Description { get; internal set; }
        /// <summary><p>The display name of the bot. If not specified, defaults to the name of the bot.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>The messaging endpoint of the bot.</p></summary>
        public virtual string Endpoint { get; internal set; }
        /// <summary><p>The Sku of the bot.</p></summary>
        public virtual BotCreateSku Sku { get; internal set; }
        /// <summary><p>The location for the app insights to be used with the bot.</p></summary>
        public virtual BotCreateInsightsLocation InsightsLocation { get; internal set; }
        /// <summary><p>The language to be used to create the bot.</p></summary>
        public virtual BotCreateLang Lang { get; internal set; }
        /// <summary><p>Storage account name to be used with the bot. If not provided, a new account will be created.</p></summary>
        public virtual string Storage { get; internal set; }
        /// <summary><p>The Microsoft Bot Builder SDK version to be used to create the bot.</p></summary>
        public virtual BotVersion Version { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot create")
              .Add("--kind {value}", Kind)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--appid {value}", Appid)
              .Add("--location {value}", Location)
              .Add("--password {value}", Password, secret: true)
              .Add("--tags {value}", Tags)
              .Add("--description {value}", Description)
              .Add("--display-name {value}", DisplayName)
              .Add("--endpoint {value}", Endpoint)
              .Add("--sku {value}", Sku)
              .Add("--insights-location {value}", InsightsLocation)
              .Add("--lang {value}", Lang)
              .Add("--storage {value}", Storage)
              .Add("--version {value}", Version)
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
    #region AzureBotDeleteSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot delete")
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
    #region AzureBotDownloadSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotDownloadSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The directory to download bot code to.</p></summary>
        public virtual string SavePath { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot download")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--save-path {value}", SavePath)
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
    #region AzureBotPreparePublishSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotPreparePublishSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of the start up project file name. Required only for C#.</p></summary>
        public virtual string ProjName { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the start up solution file name. Required only for C#.</p></summary>
        public virtual string SlnName { get; internal set; }
        /// <summary><p>The directory to download deployment scripts to.</p></summary>
        public virtual string CodeDir { get; internal set; }
        /// <summary><p>The Microsoft Bot Builder SDK version to be used in the bot template that will be created.</p></summary>
        public virtual BotVersion Version { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot prepare-publish")
              .Add("--name {value}", Name)
              .Add("--proj-name {value}", ProjName)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--sln-name {value}", SlnName)
              .Add("--code-dir {value}", CodeDir)
              .Add("--version {value}", Version)
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
    #region AzureBotPublishSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotPublishSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The directory to upload bot code from.</p></summary>
        public virtual string CodeDir { get; internal set; }
        /// <summary><p>Name of the start up project file name.</p></summary>
        public virtual string ProjName { get; internal set; }
        /// <summary><p>The Microsoft Bot Builder SDK version by the bot.</p></summary>
        public virtual string Version { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot publish")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--code-dir {value}", CodeDir)
              .Add("--proj-name {value}", ProjName)
              .Add("--version {value}", Version)
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
    #region AzureBotShowSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Show the output as JSON compatible with a .bot file.</p></summary>
        public virtual bool? Msbot { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--msbot", Msbot)
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
    #region AzureBotUpdateSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Entity Tag.</p></summary>
        public virtual string Etag { get; internal set; }
        /// <summary><p>Required. Gets or sets the Kind of the resource.</p></summary>
        public virtual string Kind { get; internal set; }
        /// <summary><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        public virtual string Location { get; internal set; }
        /// <summary><p>The set of properties specific to bot resource.</p></summary>
        public virtual string Properties { get; internal set; }
        /// <summary><p>Gets or sets the SKU of the resource.</p></summary>
        public virtual string Sku { get; internal set; }
        /// <summary><p>Contains resource tags defined as key/value pairs.</p></summary>
        public virtual string Tags { get; internal set; }
        /// <summary><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        public virtual string Add { get; internal set; }
        /// <summary><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        public virtual string ForceString { get; internal set; }
        /// <summary><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        public virtual string Remove { get; internal set; }
        /// <summary><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        public virtual string Set { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot update")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--etag {value}", Etag)
              .Add("--kind {value}", Kind)
              .Add("--location {value}", Location)
              .Add("--properties {value}", Properties)
              .Add("--sku {value}", Sku)
              .Add("--tags {value}", Tags)
              .Add("--add {value}", Add)
              .Add("--force-string {value}", ForceString)
              .Add("--remove {value}", Remove)
              .Add("--set {value}", Set)
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
    #region AzureBotMsteamsCreateSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotMsteamsCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Add the channel in a disabled state.</p></summary>
        public virtual bool? AddDisabled { get; internal set; }
        /// <summary><p>The calling web hook to use on Microsoft Teams.</p></summary>
        public virtual string CallingWebHook { get; internal set; }
        /// <summary><p>Enable calling on Microsoft Teams.</p></summary>
        public virtual bool? EnableCalling { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot msteams create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--add-disabled", AddDisabled)
              .Add("--calling-web-hook {value}", CallingWebHook)
              .Add("--enable-calling", EnableCalling)
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
    #region AzureBotMsteamsDeleteSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotMsteamsDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot msteams delete")
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
    #region AzureBotMsteamsShowSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotMsteamsShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Show secrets in response for the channel.</p></summary>
        public virtual bool? WithSecrets { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot msteams show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--with-secrets", WithSecrets, secret: true)
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
    #region AzureBotSlackCreateSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotSlackCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The client ID from Slack.</p></summary>
        public virtual string ClientId { get; internal set; }
        /// <summary><p>The client secret from Slack.</p></summary>
        public virtual string ClientSecret { get; internal set; }
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The verification token from Slack.</p></summary>
        public virtual string VerificationToken { get; internal set; }
        /// <summary><p>Add the channel in a disabled state.</p></summary>
        public virtual bool? AddDisabled { get; internal set; }
        /// <summary><p>The landing page url to redirect to after login.</p></summary>
        public virtual string LandingPageUrl { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot slack create")
              .Add("--client-id {value}", ClientId)
              .Add("--client-secret {value}", ClientSecret, secret: true)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--verification-token {value}", VerificationToken)
              .Add("--add-disabled", AddDisabled)
              .Add("--landing-page-url {value}", LandingPageUrl)
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
    #region AzureBotSlackDeleteSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotSlackDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot slack delete")
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
    #region AzureBotSlackShowSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotSlackShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Show secrets in response for the channel.</p></summary>
        public virtual bool? WithSecrets { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot slack show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--with-secrets", WithSecrets, secret: true)
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
    #region AzureBotEmailCreateSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotEmailCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The email address for the bot.</p></summary>
        public virtual string EmailAddress { get; internal set; }
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The email password for the bot.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Add the channel in a disabled state.</p></summary>
        public virtual bool? AddDisabled { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot email create")
              .Add("--email-address {value}", EmailAddress)
              .Add("--name {value}", Name)
              .Add("--password {value}", Password, secret: true)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--add-disabled", AddDisabled)
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
    #region AzureBotEmailDeleteSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotEmailDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot email delete")
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
    #region AzureBotEmailShowSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotEmailShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Show secrets in response for the channel.</p></summary>
        public virtual bool? WithSecrets { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot email show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--with-secrets", WithSecrets, secret: true)
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
    #region AzureBotKikCreateSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotKikCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The API key for the Kik account.</p></summary>
        public virtual string Key { get; internal set; }
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Kik user name.</p></summary>
        public virtual string UserName { get; internal set; }
        /// <summary><p>Add the channel in a disabled state.</p></summary>
        public virtual bool? AddDisabled { get; internal set; }
        /// <summary><p>Whether or not the Kik account has been validated for use with the bot.</p></summary>
        public virtual bool? IsValidated { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot kik create")
              .Add("--key {value}", Key)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--user-name {value}", UserName)
              .Add("--add-disabled", AddDisabled)
              .Add("--is-validated", IsValidated)
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
    #region AzureBotKikDeleteSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotKikDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot kik delete")
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
    #region AzureBotKikShowSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotKikShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Show secrets in response for the channel.</p></summary>
        public virtual bool? WithSecrets { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot kik show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--with-secrets", WithSecrets, secret: true)
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
    #region AzureBotAuthsettingCreateSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotAuthsettingCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>Client ID associated with the service provider setting.</p></summary>
        public virtual string ClientId { get; internal set; }
        /// <summary><p>Client secret associated with the service provider setting.</p></summary>
        public virtual string ClientSecret { get; internal set; }
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The scope string associated with the service provider setting.The string should be delimited as needed for the service provider.</p></summary>
        public virtual string ProviderScopeString { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the service provider. For a list of all service providers, use `az bot connection listserviceproviders`.</p></summary>
        public virtual string Service { get; internal set; }
        /// <summary><p>Name of the oauth connection setting.</p></summary>
        public virtual string SettingName { get; internal set; }
        /// <summary><p>Parameter values for service provider parameters. Usage: --parameters key=value key1=value1.</p></summary>
        public virtual string Parameters { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot authsetting create")
              .Add("--client-id {value}", ClientId)
              .Add("--client-secret {value}", ClientSecret, secret: true)
              .Add("--name {value}", Name)
              .Add("--provider-scope-string {value}", ProviderScopeString)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--service {value}", Service)
              .Add("--setting-name {value}", SettingName)
              .Add("--parameters {value}", Parameters)
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
    #region AzureBotAuthsettingDeleteSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotAuthsettingDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the oauth connection setting.</p></summary>
        public virtual string SettingName { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot authsetting delete")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--setting-name {value}", SettingName)
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
    #region AzureBotAuthsettingListSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotAuthsettingListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot authsetting list")
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
    #region AzureBotAuthsettingListProvidersSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotAuthsettingListProvidersSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>Service provider name for which to fetch details.</p></summary>
        public virtual string ProviderName { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot authsetting list-providers")
              .Add("--provider-name {value}", ProviderName)
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
    #region AzureBotAuthsettingShowSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotAuthsettingShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name of the oauth connection setting.</p></summary>
        public virtual string SettingName { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot authsetting show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--setting-name {value}", SettingName)
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
    #region AzureBotTelegramCreateSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotTelegramCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The access token for the Telegram account.</p></summary>
        public virtual string AccessToken { get; internal set; }
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Add the channel in a disabled state.</p></summary>
        public virtual bool? AddDisabled { get; internal set; }
        /// <summary><p>Whether or not the Telegram account has been validated for use with the bot.</p></summary>
        public virtual bool? IsValidated { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot telegram create")
              .Add("--access-token {value}", AccessToken)
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--add-disabled", AddDisabled)
              .Add("--is-validated", IsValidated)
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
    #region AzureBotTelegramDeleteSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotTelegramDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot telegram delete")
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
    #region AzureBotTelegramShowSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotTelegramShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Show secrets in response for the channel.</p></summary>
        public virtual bool? WithSecrets { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot telegram show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--with-secrets", WithSecrets, secret: true)
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
    #region AzureBotSkypeCreateSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotSkypeCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Add the channel in a disabled state.</p></summary>
        public virtual bool? AddDisabled { get; internal set; }
        /// <summary><p>The calling web hook to use on Skype.</p></summary>
        public virtual string CallingWebHook { get; internal set; }
        /// <summary><p>Enable calling on Skype.</p></summary>
        public virtual bool? EnableCalling { get; internal set; }
        /// <summary><p>Enable groups on Skype.</p></summary>
        public virtual bool? EnableGroups { get; internal set; }
        /// <summary><p>Enable media cards on Skype.</p></summary>
        public virtual bool? EnableMediaCards { get; internal set; }
        /// <summary><p>Enable messaging on Skype.</p></summary>
        public virtual bool? EnableMessaging { get; internal set; }
        /// <summary><p>Enable screen sharing on Skype.</p></summary>
        public virtual bool? EnableScreenSharing { get; internal set; }
        /// <summary><p>Enable video on Skype.</p></summary>
        public virtual bool? EnableVideo { get; internal set; }
        /// <summary><p>Select groups mode on Skype.</p></summary>
        public virtual string GroupsMode { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot skype create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--add-disabled", AddDisabled)
              .Add("--calling-web-hook {value}", CallingWebHook)
              .Add("--enable-calling", EnableCalling)
              .Add("--enable-groups", EnableGroups)
              .Add("--enable-media-cards", EnableMediaCards)
              .Add("--enable-messaging", EnableMessaging)
              .Add("--enable-screen-sharing", EnableScreenSharing)
              .Add("--enable-video", EnableVideo)
              .Add("--groups-mode {value}", GroupsMode)
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
    #region AzureBotSkypeDeleteSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotSkypeDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot skype delete")
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
    #region AzureBotSkypeShowSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotSkypeShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Show secrets in response for the channel.</p></summary>
        public virtual bool? WithSecrets { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot skype show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--with-secrets", WithSecrets, secret: true)
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
    #region AzureBotWebchatShowSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotWebchatShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Show secrets in response for the channel.</p></summary>
        public virtual bool? WithSecrets { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot webchat show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--with-secrets", WithSecrets, secret: true)
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
    #region AzureBotDirectlineCreateSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotDirectlineCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Add the channel in a disabled state.</p></summary>
        public virtual bool? AddDisabled { get; internal set; }
        /// <summary><p>If true, v1 protocol will be disabled on the channel.</p></summary>
        public virtual bool? Disablev1 { get; internal set; }
        /// <summary><p>If true, v3 protocol will be disabled on the channel.</p></summary>
        public virtual bool? Disablev3 { get; internal set; }
        /// <summary><p>Name of the Directline channel site.</p></summary>
        public virtual string SiteName { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot directline create")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--add-disabled", AddDisabled)
              .Add("--disablev1", Disablev1)
              .Add("--disablev3", Disablev3)
              .Add("--site-name {value}", SiteName)
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
    #region AzureBotDirectlineDeleteSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotDirectlineDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot directline delete")
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
    #region AzureBotDirectlineShowSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotDirectlineShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Show secrets in response for the channel.</p></summary>
        public virtual bool? WithSecrets { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot directline show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--with-secrets", WithSecrets, secret: true)
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
    #region AzureBotSmsCreateSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotSmsCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The account SID for the Twilio account.</p></summary>
        public virtual string AccountSid { get; internal set; }
        /// <summary><p>The token token for the Twilio account.</p></summary>
        public virtual string AuthToken { get; internal set; }
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>The phone number for the Twilio account.</p></summary>
        public virtual string Phone { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Add the channel in a disabled state.</p></summary>
        public virtual bool? AddDisabled { get; internal set; }
        /// <summary><p>Whether or not the Twilio account has been validated for use with the bot.</p></summary>
        public virtual bool? IsValidated { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot sms create")
              .Add("--account-sid {value}", AccountSid)
              .Add("--auth-token {value}", AuthToken)
              .Add("--name {value}", Name)
              .Add("--phone {value}", Phone)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--add-disabled", AddDisabled)
              .Add("--is-validated", IsValidated)
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
    #region AzureBotSmsDeleteSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotSmsDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot sms delete")
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
    #region AzureBotSmsShowSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotSmsShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Show secrets in response for the channel.</p></summary>
        public virtual bool? WithSecrets { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot sms show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--with-secrets", WithSecrets, secret: true)
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
    #region AzureBotFacebookCreateSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotFacebookCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The Facebook application id.</p></summary>
        public virtual string Appid { get; internal set; }
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Page ID of the Facebook page to be used for the bot.</p></summary>
        public virtual string PageId { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>The Facebook application secret.</p></summary>
        public virtual string Secret { get; internal set; }
        /// <summary><p>The Facebook application access token.</p></summary>
        public virtual string Token { get; internal set; }
        /// <summary><p>Add the channel in a disabled state.</p></summary>
        public virtual bool? AddDisabled { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot facebook create")
              .Add("--appid {value}", Appid)
              .Add("--name {value}", Name)
              .Add("--page-id {value}", PageId)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--secret {value}", Secret, secret: true)
              .Add("--token {value}", Token)
              .Add("--add-disabled", AddDisabled)
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
    #region AzureBotFacebookDeleteSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotFacebookDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot facebook delete")
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
    #region AzureBotFacebookShowSettings
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureBotFacebookShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureBot executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureBotTasks.AzureBotPath;
        /// <summary><p>The resource name of the bot.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        public virtual string ResourceGroup { get; internal set; }
        /// <summary><p>Show secrets in response for the channel.</p></summary>
        public virtual bool? WithSecrets { get; internal set; }
        /// <summary><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        public virtual string Subscription { get; internal set; }
        /// <summary><p>Increase logging verbosity to show all debug logs.</p></summary>
        public virtual string Debug { get; internal set; }
        /// <summary><p>Show this help message and exit.</p></summary>
        public virtual string Help { get; internal set; }
        /// <summary><p>Output format.</p></summary>
        public virtual AzureOutput Output { get; internal set; }
        /// <summary><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        public virtual string Query { get; internal set; }
        /// <summary><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        public virtual string Verbose { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("bot facebook show")
              .Add("--name {value}", Name)
              .Add("--resource-group {value}", ResourceGroup)
              .Add("--with-secrets", WithSecrets, secret: true)
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
    #region AzureBotCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotCreateSettingsExtensions
    {
        #region Kind
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Kind"/>.</em></p><p>The kind of the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetKind(this AzureBotCreateSettings toolSettings, BotCreateKind kind)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = kind;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Kind"/>.</em></p><p>The kind of the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetKind(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetName(this AzureBotCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetName(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetResourceGroup(this AzureBotCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetResourceGroup(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Appid
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Appid"/>.</em></p><p>The Microsoft account ID (MSA ID) to be used with the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetAppid(this AzureBotCreateSettings toolSettings, string appid)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Appid = appid;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Appid"/>.</em></p><p>The Microsoft account ID (MSA ID) to be used with the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetAppid(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Appid = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetLocation(this AzureBotCreateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetLocation(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Password"/>.</em></p><p>The Microsoft account (MSA) password for the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetPassword(this AzureBotCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Password"/>.</em></p><p>The Microsoft account (MSA) password for the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetPassword(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetTags(this AzureBotCreateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Tags"/>.</em></p><p>Space-separated tags in 'key[=value]' format. Use "" to clear existing tags.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetTags(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Description"/>.</em></p><p>The description of the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetDescription(this AzureBotCreateSettings toolSettings, string description)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Description"/>.</em></p><p>The description of the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetDescription(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.DisplayName"/>.</em></p><p>The display name of the bot. If not specified, defaults to the name of the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetDisplayName(this AzureBotCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.DisplayName"/>.</em></p><p>The display name of the bot. If not specified, defaults to the name of the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetDisplayName(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Endpoint
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Endpoint"/>.</em></p><p>The messaging endpoint of the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetEndpoint(this AzureBotCreateSettings toolSettings, string endpoint)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Endpoint = endpoint;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Endpoint"/>.</em></p><p>The messaging endpoint of the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetEndpoint(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Endpoint = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Sku"/>.</em></p><p>The Sku of the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetSku(this AzureBotCreateSettings toolSettings, BotCreateSku sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Sku"/>.</em></p><p>The Sku of the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetSku(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region InsightsLocation
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.InsightsLocation"/>.</em></p><p>The location for the app insights to be used with the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetInsightsLocation(this AzureBotCreateSettings toolSettings, BotCreateInsightsLocation insightsLocation)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InsightsLocation = insightsLocation;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.InsightsLocation"/>.</em></p><p>The location for the app insights to be used with the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetInsightsLocation(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.InsightsLocation = null;
            return toolSettings;
        }
        #endregion
        #region Lang
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Lang"/>.</em></p><p>The language to be used to create the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetLang(this AzureBotCreateSettings toolSettings, BotCreateLang lang)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Lang = lang;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Lang"/>.</em></p><p>The language to be used to create the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetLang(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Lang = null;
            return toolSettings;
        }
        #endregion
        #region Storage
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Storage"/>.</em></p><p>Storage account name to be used with the bot. If not provided, a new account will be created.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetStorage(this AzureBotCreateSettings toolSettings, string storage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Storage = storage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Storage"/>.</em></p><p>Storage account name to be used with the bot. If not provided, a new account will be created.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetStorage(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Storage = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Version"/>.</em></p><p>The Microsoft Bot Builder SDK version to be used to create the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetVersion(this AzureBotCreateSettings toolSettings, BotVersion version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Version"/>.</em></p><p>The Microsoft Bot Builder SDK version to be used to create the bot.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetVersion(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetSubscription(this AzureBotCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetSubscription(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetDebug(this AzureBotCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetDebug(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetHelp(this AzureBotCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetHelp(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetOutput(this AzureBotCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetOutput(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetQuery(this AzureBotCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetQuery(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotCreateSettings SetVerbose(this AzureBotCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotCreateSettings ResetVerbose(this AzureBotCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings SetName(this AzureBotDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings ResetName(this AzureBotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings SetResourceGroup(this AzureBotDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings ResetResourceGroup(this AzureBotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings SetSubscription(this AzureBotDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings ResetSubscription(this AzureBotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings SetDebug(this AzureBotDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings ResetDebug(this AzureBotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings SetHelp(this AzureBotDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings ResetHelp(this AzureBotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings SetOutput(this AzureBotDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings ResetOutput(this AzureBotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings SetQuery(this AzureBotDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings ResetQuery(this AzureBotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings SetVerbose(this AzureBotDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotDeleteSettings ResetVerbose(this AzureBotDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotDownloadSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotDownloadSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotDownloadSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings SetName(this AzureBotDownloadSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDownloadSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings ResetName(this AzureBotDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotDownloadSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings SetResourceGroup(this AzureBotDownloadSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDownloadSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings ResetResourceGroup(this AzureBotDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SavePath
        /// <summary><p><em>Sets <see cref="AzureBotDownloadSettings.SavePath"/>.</em></p><p>The directory to download bot code to.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings SetSavePath(this AzureBotDownloadSettings toolSettings, string savePath)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SavePath = savePath;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDownloadSettings.SavePath"/>.</em></p><p>The directory to download bot code to.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings ResetSavePath(this AzureBotDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SavePath = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotDownloadSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings SetSubscription(this AzureBotDownloadSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDownloadSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings ResetSubscription(this AzureBotDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotDownloadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings SetDebug(this AzureBotDownloadSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDownloadSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings ResetDebug(this AzureBotDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotDownloadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings SetHelp(this AzureBotDownloadSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDownloadSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings ResetHelp(this AzureBotDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotDownloadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings SetOutput(this AzureBotDownloadSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDownloadSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings ResetOutput(this AzureBotDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotDownloadSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings SetQuery(this AzureBotDownloadSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDownloadSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings ResetQuery(this AzureBotDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotDownloadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings SetVerbose(this AzureBotDownloadSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDownloadSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotDownloadSettings ResetVerbose(this AzureBotDownloadSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotPreparePublishSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotPreparePublishSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotPreparePublishSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings SetName(this AzureBotPreparePublishSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPreparePublishSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings ResetName(this AzureBotPreparePublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProjName
        /// <summary><p><em>Sets <see cref="AzureBotPreparePublishSettings.ProjName"/>.</em></p><p>Name of the start up project file name. Required only for C#.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings SetProjName(this AzureBotPreparePublishSettings toolSettings, string projName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjName = projName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPreparePublishSettings.ProjName"/>.</em></p><p>Name of the start up project file name. Required only for C#.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings ResetProjName(this AzureBotPreparePublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjName = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotPreparePublishSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings SetResourceGroup(this AzureBotPreparePublishSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPreparePublishSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings ResetResourceGroup(this AzureBotPreparePublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SlnName
        /// <summary><p><em>Sets <see cref="AzureBotPreparePublishSettings.SlnName"/>.</em></p><p>Name of the start up solution file name. Required only for C#.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings SetSlnName(this AzureBotPreparePublishSettings toolSettings, string slnName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlnName = slnName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPreparePublishSettings.SlnName"/>.</em></p><p>Name of the start up solution file name. Required only for C#.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings ResetSlnName(this AzureBotPreparePublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SlnName = null;
            return toolSettings;
        }
        #endregion
        #region CodeDir
        /// <summary><p><em>Sets <see cref="AzureBotPreparePublishSettings.CodeDir"/>.</em></p><p>The directory to download deployment scripts to.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings SetCodeDir(this AzureBotPreparePublishSettings toolSettings, string codeDir)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CodeDir = codeDir;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPreparePublishSettings.CodeDir"/>.</em></p><p>The directory to download deployment scripts to.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings ResetCodeDir(this AzureBotPreparePublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CodeDir = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureBotPreparePublishSettings.Version"/>.</em></p><p>The Microsoft Bot Builder SDK version to be used in the bot template that will be created.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings SetVersion(this AzureBotPreparePublishSettings toolSettings, BotVersion version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPreparePublishSettings.Version"/>.</em></p><p>The Microsoft Bot Builder SDK version to be used in the bot template that will be created.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings ResetVersion(this AzureBotPreparePublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotPreparePublishSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings SetSubscription(this AzureBotPreparePublishSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPreparePublishSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings ResetSubscription(this AzureBotPreparePublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotPreparePublishSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings SetDebug(this AzureBotPreparePublishSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPreparePublishSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings ResetDebug(this AzureBotPreparePublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotPreparePublishSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings SetHelp(this AzureBotPreparePublishSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPreparePublishSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings ResetHelp(this AzureBotPreparePublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotPreparePublishSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings SetOutput(this AzureBotPreparePublishSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPreparePublishSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings ResetOutput(this AzureBotPreparePublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotPreparePublishSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings SetQuery(this AzureBotPreparePublishSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPreparePublishSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings ResetQuery(this AzureBotPreparePublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotPreparePublishSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings SetVerbose(this AzureBotPreparePublishSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPreparePublishSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotPreparePublishSettings ResetVerbose(this AzureBotPreparePublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotPublishSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotPublishSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotPublishSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotPublishSettings SetName(this AzureBotPublishSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPublishSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotPublishSettings ResetName(this AzureBotPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotPublishSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotPublishSettings SetResourceGroup(this AzureBotPublishSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPublishSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotPublishSettings ResetResourceGroup(this AzureBotPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region CodeDir
        /// <summary><p><em>Sets <see cref="AzureBotPublishSettings.CodeDir"/>.</em></p><p>The directory to upload bot code from.</p></summary>
        [Pure]
        public static AzureBotPublishSettings SetCodeDir(this AzureBotPublishSettings toolSettings, string codeDir)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CodeDir = codeDir;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPublishSettings.CodeDir"/>.</em></p><p>The directory to upload bot code from.</p></summary>
        [Pure]
        public static AzureBotPublishSettings ResetCodeDir(this AzureBotPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CodeDir = null;
            return toolSettings;
        }
        #endregion
        #region ProjName
        /// <summary><p><em>Sets <see cref="AzureBotPublishSettings.ProjName"/>.</em></p><p>Name of the start up project file name.</p></summary>
        [Pure]
        public static AzureBotPublishSettings SetProjName(this AzureBotPublishSettings toolSettings, string projName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjName = projName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPublishSettings.ProjName"/>.</em></p><p>Name of the start up project file name.</p></summary>
        [Pure]
        public static AzureBotPublishSettings ResetProjName(this AzureBotPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProjName = null;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary><p><em>Sets <see cref="AzureBotPublishSettings.Version"/>.</em></p><p>The Microsoft Bot Builder SDK version by the bot.</p></summary>
        [Pure]
        public static AzureBotPublishSettings SetVersion(this AzureBotPublishSettings toolSettings, string version)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPublishSettings.Version"/>.</em></p><p>The Microsoft Bot Builder SDK version by the bot.</p></summary>
        [Pure]
        public static AzureBotPublishSettings ResetVersion(this AzureBotPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotPublishSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotPublishSettings SetSubscription(this AzureBotPublishSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPublishSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotPublishSettings ResetSubscription(this AzureBotPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotPublishSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotPublishSettings SetDebug(this AzureBotPublishSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPublishSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotPublishSettings ResetDebug(this AzureBotPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotPublishSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotPublishSettings SetHelp(this AzureBotPublishSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPublishSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotPublishSettings ResetHelp(this AzureBotPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotPublishSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotPublishSettings SetOutput(this AzureBotPublishSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPublishSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotPublishSettings ResetOutput(this AzureBotPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotPublishSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotPublishSettings SetQuery(this AzureBotPublishSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPublishSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotPublishSettings ResetQuery(this AzureBotPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotPublishSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotPublishSettings SetVerbose(this AzureBotPublishSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotPublishSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotPublishSettings ResetVerbose(this AzureBotPublishSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotShowSettings SetName(this AzureBotShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotShowSettings ResetName(this AzureBotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotShowSettings SetResourceGroup(this AzureBotShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotShowSettings ResetResourceGroup(this AzureBotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Msbot
        /// <summary><p><em>Sets <see cref="AzureBotShowSettings.Msbot"/>.</em></p><p>Show the output as JSON compatible with a .bot file.</p></summary>
        [Pure]
        public static AzureBotShowSettings SetMsbot(this AzureBotShowSettings toolSettings, bool? msbot)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Msbot = msbot;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotShowSettings.Msbot"/>.</em></p><p>Show the output as JSON compatible with a .bot file.</p></summary>
        [Pure]
        public static AzureBotShowSettings ResetMsbot(this AzureBotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Msbot = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotShowSettings.Msbot"/>.</em></p><p>Show the output as JSON compatible with a .bot file.</p></summary>
        [Pure]
        public static AzureBotShowSettings EnableMsbot(this AzureBotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Msbot = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotShowSettings.Msbot"/>.</em></p><p>Show the output as JSON compatible with a .bot file.</p></summary>
        [Pure]
        public static AzureBotShowSettings DisableMsbot(this AzureBotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Msbot = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotShowSettings.Msbot"/>.</em></p><p>Show the output as JSON compatible with a .bot file.</p></summary>
        [Pure]
        public static AzureBotShowSettings ToggleMsbot(this AzureBotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Msbot = !toolSettings.Msbot;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotShowSettings SetSubscription(this AzureBotShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotShowSettings ResetSubscription(this AzureBotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotShowSettings SetDebug(this AzureBotShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotShowSettings ResetDebug(this AzureBotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotShowSettings SetHelp(this AzureBotShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotShowSettings ResetHelp(this AzureBotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotShowSettings SetOutput(this AzureBotShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotShowSettings ResetOutput(this AzureBotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotShowSettings SetQuery(this AzureBotShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotShowSettings ResetQuery(this AzureBotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotShowSettings SetVerbose(this AzureBotShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotShowSettings ResetVerbose(this AzureBotShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotUpdateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetName(this AzureBotUpdateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetName(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetResourceGroup(this AzureBotUpdateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetResourceGroup(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Etag
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Etag"/>.</em></p><p>Entity Tag.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetEtag(this AzureBotUpdateSettings toolSettings, string etag)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = etag;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Etag"/>.</em></p><p>Entity Tag.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetEtag(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Etag = null;
            return toolSettings;
        }
        #endregion
        #region Kind
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Kind"/>.</em></p><p>Required. Gets or sets the Kind of the resource.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetKind(this AzureBotUpdateSettings toolSettings, string kind)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = kind;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Kind"/>.</em></p><p>Required. Gets or sets the Kind of the resource.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetKind(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Kind = null;
            return toolSettings;
        }
        #endregion
        #region Location
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetLocation(this AzureBotUpdateSettings toolSettings, string location)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = location;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Location"/>.</em></p><p>Location. You can configure the default location using `az configure --defaults location=&amp;lt;location&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetLocation(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Location = null;
            return toolSettings;
        }
        #endregion
        #region Properties
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Properties"/>.</em></p><p>The set of properties specific to bot resource.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetProperties(this AzureBotUpdateSettings toolSettings, string properties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Properties = properties;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Properties"/>.</em></p><p>The set of properties specific to bot resource.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetProperties(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Properties = null;
            return toolSettings;
        }
        #endregion
        #region Sku
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Sku"/>.</em></p><p>Gets or sets the SKU of the resource.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetSku(this AzureBotUpdateSettings toolSettings, string sku)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = sku;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Sku"/>.</em></p><p>Gets or sets the SKU of the resource.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetSku(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Sku = null;
            return toolSettings;
        }
        #endregion
        #region Tags
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Tags"/>.</em></p><p>Contains resource tags defined as key/value pairs.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetTags(this AzureBotUpdateSettings toolSettings, string tags)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = tags;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Tags"/>.</em></p><p>Contains resource tags defined as key/value pairs.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetTags(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Tags = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetAdd(this AzureBotUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetAdd(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetForceString(this AzureBotUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetForceString(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetRemove(this AzureBotUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetRemove(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetSet(this AzureBotUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetSet(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetSubscription(this AzureBotUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetSubscription(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetDebug(this AzureBotUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetDebug(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetHelp(this AzureBotUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetHelp(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetOutput(this AzureBotUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetOutput(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetQuery(this AzureBotUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetQuery(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings SetVerbose(this AzureBotUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotUpdateSettings ResetVerbose(this AzureBotUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotMsteamsCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotMsteamsCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings SetName(this AzureBotMsteamsCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings ResetName(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings SetResourceGroup(this AzureBotMsteamsCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings ResetResourceGroup(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AddDisabled
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings SetAddDisabled(this AzureBotMsteamsCreateSettings toolSettings, bool? addDisabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = addDisabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings ResetAddDisabled(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotMsteamsCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings EnableAddDisabled(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotMsteamsCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings DisableAddDisabled(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotMsteamsCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings ToggleAddDisabled(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = !toolSettings.AddDisabled;
            return toolSettings;
        }
        #endregion
        #region CallingWebHook
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsCreateSettings.CallingWebHook"/>.</em></p><p>The calling web hook to use on Microsoft Teams.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings SetCallingWebHook(this AzureBotMsteamsCreateSettings toolSettings, string callingWebHook)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CallingWebHook = callingWebHook;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsCreateSettings.CallingWebHook"/>.</em></p><p>The calling web hook to use on Microsoft Teams.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings ResetCallingWebHook(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CallingWebHook = null;
            return toolSettings;
        }
        #endregion
        #region EnableCalling
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsCreateSettings.EnableCalling"/>.</em></p><p>Enable calling on Microsoft Teams.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings SetEnableCalling(this AzureBotMsteamsCreateSettings toolSettings, bool? enableCalling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCalling = enableCalling;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsCreateSettings.EnableCalling"/>.</em></p><p>Enable calling on Microsoft Teams.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings ResetEnableCalling(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCalling = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotMsteamsCreateSettings.EnableCalling"/>.</em></p><p>Enable calling on Microsoft Teams.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings EnableEnableCalling(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCalling = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotMsteamsCreateSettings.EnableCalling"/>.</em></p><p>Enable calling on Microsoft Teams.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings DisableEnableCalling(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCalling = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotMsteamsCreateSettings.EnableCalling"/>.</em></p><p>Enable calling on Microsoft Teams.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings ToggleEnableCalling(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCalling = !toolSettings.EnableCalling;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings SetSubscription(this AzureBotMsteamsCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings ResetSubscription(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings SetDebug(this AzureBotMsteamsCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings ResetDebug(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings SetHelp(this AzureBotMsteamsCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings ResetHelp(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings SetOutput(this AzureBotMsteamsCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings ResetOutput(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings SetQuery(this AzureBotMsteamsCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings ResetQuery(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings SetVerbose(this AzureBotMsteamsCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotMsteamsCreateSettings ResetVerbose(this AzureBotMsteamsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotMsteamsDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotMsteamsDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings SetName(this AzureBotMsteamsDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings ResetName(this AzureBotMsteamsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings SetResourceGroup(this AzureBotMsteamsDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings ResetResourceGroup(this AzureBotMsteamsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings SetSubscription(this AzureBotMsteamsDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings ResetSubscription(this AzureBotMsteamsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings SetDebug(this AzureBotMsteamsDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings ResetDebug(this AzureBotMsteamsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings SetHelp(this AzureBotMsteamsDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings ResetHelp(this AzureBotMsteamsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings SetOutput(this AzureBotMsteamsDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings ResetOutput(this AzureBotMsteamsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings SetQuery(this AzureBotMsteamsDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings ResetQuery(this AzureBotMsteamsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings SetVerbose(this AzureBotMsteamsDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotMsteamsDeleteSettings ResetVerbose(this AzureBotMsteamsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotMsteamsShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotMsteamsShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings SetName(this AzureBotMsteamsShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings ResetName(this AzureBotMsteamsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings SetResourceGroup(this AzureBotMsteamsShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings ResetResourceGroup(this AzureBotMsteamsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WithSecrets
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings SetWithSecrets(this AzureBotMsteamsShowSettings toolSettings, bool? withSecrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = withSecrets;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings ResetWithSecrets(this AzureBotMsteamsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotMsteamsShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings EnableWithSecrets(this AzureBotMsteamsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotMsteamsShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings DisableWithSecrets(this AzureBotMsteamsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotMsteamsShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings ToggleWithSecrets(this AzureBotMsteamsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = !toolSettings.WithSecrets;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings SetSubscription(this AzureBotMsteamsShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings ResetSubscription(this AzureBotMsteamsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings SetDebug(this AzureBotMsteamsShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings ResetDebug(this AzureBotMsteamsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings SetHelp(this AzureBotMsteamsShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings ResetHelp(this AzureBotMsteamsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings SetOutput(this AzureBotMsteamsShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings ResetOutput(this AzureBotMsteamsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings SetQuery(this AzureBotMsteamsShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings ResetQuery(this AzureBotMsteamsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotMsteamsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings SetVerbose(this AzureBotMsteamsShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotMsteamsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotMsteamsShowSettings ResetVerbose(this AzureBotMsteamsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotSlackCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotSlackCreateSettingsExtensions
    {
        #region ClientId
        /// <summary><p><em>Sets <see cref="AzureBotSlackCreateSettings.ClientId"/>.</em></p><p>The client ID from Slack.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings SetClientId(this AzureBotSlackCreateSettings toolSettings, string clientId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientId = clientId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackCreateSettings.ClientId"/>.</em></p><p>The client ID from Slack.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings ResetClientId(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientId = null;
            return toolSettings;
        }
        #endregion
        #region ClientSecret
        /// <summary><p><em>Sets <see cref="AzureBotSlackCreateSettings.ClientSecret"/>.</em></p><p>The client secret from Slack.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings SetClientSecret(this AzureBotSlackCreateSettings toolSettings, string clientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = clientSecret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackCreateSettings.ClientSecret"/>.</em></p><p>The client secret from Slack.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings ResetClientSecret(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotSlackCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings SetName(this AzureBotSlackCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings ResetName(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotSlackCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings SetResourceGroup(this AzureBotSlackCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings ResetResourceGroup(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region VerificationToken
        /// <summary><p><em>Sets <see cref="AzureBotSlackCreateSettings.VerificationToken"/>.</em></p><p>The verification token from Slack.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings SetVerificationToken(this AzureBotSlackCreateSettings toolSettings, string verificationToken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VerificationToken = verificationToken;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackCreateSettings.VerificationToken"/>.</em></p><p>The verification token from Slack.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings ResetVerificationToken(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.VerificationToken = null;
            return toolSettings;
        }
        #endregion
        #region AddDisabled
        /// <summary><p><em>Sets <see cref="AzureBotSlackCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings SetAddDisabled(this AzureBotSlackCreateSettings toolSettings, bool? addDisabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = addDisabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings ResetAddDisabled(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotSlackCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings EnableAddDisabled(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotSlackCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings DisableAddDisabled(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotSlackCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings ToggleAddDisabled(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = !toolSettings.AddDisabled;
            return toolSettings;
        }
        #endregion
        #region LandingPageUrl
        /// <summary><p><em>Sets <see cref="AzureBotSlackCreateSettings.LandingPageUrl"/>.</em></p><p>The landing page url to redirect to after login.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings SetLandingPageUrl(this AzureBotSlackCreateSettings toolSettings, string landingPageUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LandingPageUrl = landingPageUrl;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackCreateSettings.LandingPageUrl"/>.</em></p><p>The landing page url to redirect to after login.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings ResetLandingPageUrl(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.LandingPageUrl = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotSlackCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings SetSubscription(this AzureBotSlackCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings ResetSubscription(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotSlackCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings SetDebug(this AzureBotSlackCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings ResetDebug(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotSlackCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings SetHelp(this AzureBotSlackCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings ResetHelp(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotSlackCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings SetOutput(this AzureBotSlackCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings ResetOutput(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotSlackCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings SetQuery(this AzureBotSlackCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings ResetQuery(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotSlackCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings SetVerbose(this AzureBotSlackCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSlackCreateSettings ResetVerbose(this AzureBotSlackCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotSlackDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotSlackDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotSlackDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings SetName(this AzureBotSlackDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings ResetName(this AzureBotSlackDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotSlackDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings SetResourceGroup(this AzureBotSlackDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings ResetResourceGroup(this AzureBotSlackDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotSlackDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings SetSubscription(this AzureBotSlackDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings ResetSubscription(this AzureBotSlackDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotSlackDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings SetDebug(this AzureBotSlackDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings ResetDebug(this AzureBotSlackDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotSlackDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings SetHelp(this AzureBotSlackDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings ResetHelp(this AzureBotSlackDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotSlackDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings SetOutput(this AzureBotSlackDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings ResetOutput(this AzureBotSlackDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotSlackDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings SetQuery(this AzureBotSlackDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings ResetQuery(this AzureBotSlackDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotSlackDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings SetVerbose(this AzureBotSlackDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSlackDeleteSettings ResetVerbose(this AzureBotSlackDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotSlackShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotSlackShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotSlackShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings SetName(this AzureBotSlackShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings ResetName(this AzureBotSlackShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotSlackShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings SetResourceGroup(this AzureBotSlackShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings ResetResourceGroup(this AzureBotSlackShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WithSecrets
        /// <summary><p><em>Sets <see cref="AzureBotSlackShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings SetWithSecrets(this AzureBotSlackShowSettings toolSettings, bool? withSecrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = withSecrets;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings ResetWithSecrets(this AzureBotSlackShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotSlackShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings EnableWithSecrets(this AzureBotSlackShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotSlackShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings DisableWithSecrets(this AzureBotSlackShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotSlackShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings ToggleWithSecrets(this AzureBotSlackShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = !toolSettings.WithSecrets;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotSlackShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings SetSubscription(this AzureBotSlackShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings ResetSubscription(this AzureBotSlackShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotSlackShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings SetDebug(this AzureBotSlackShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings ResetDebug(this AzureBotSlackShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotSlackShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings SetHelp(this AzureBotSlackShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings ResetHelp(this AzureBotSlackShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotSlackShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings SetOutput(this AzureBotSlackShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings ResetOutput(this AzureBotSlackShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotSlackShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings SetQuery(this AzureBotSlackShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings ResetQuery(this AzureBotSlackShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotSlackShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings SetVerbose(this AzureBotSlackShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSlackShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSlackShowSettings ResetVerbose(this AzureBotSlackShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotEmailCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotEmailCreateSettingsExtensions
    {
        #region EmailAddress
        /// <summary><p><em>Sets <see cref="AzureBotEmailCreateSettings.EmailAddress"/>.</em></p><p>The email address for the bot.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings SetEmailAddress(this AzureBotEmailCreateSettings toolSettings, string emailAddress)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailAddress = emailAddress;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailCreateSettings.EmailAddress"/>.</em></p><p>The email address for the bot.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings ResetEmailAddress(this AzureBotEmailCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EmailAddress = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotEmailCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings SetName(this AzureBotEmailCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings ResetName(this AzureBotEmailCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureBotEmailCreateSettings.Password"/>.</em></p><p>The email password for the bot.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings SetPassword(this AzureBotEmailCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailCreateSettings.Password"/>.</em></p><p>The email password for the bot.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings ResetPassword(this AzureBotEmailCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotEmailCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings SetResourceGroup(this AzureBotEmailCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings ResetResourceGroup(this AzureBotEmailCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AddDisabled
        /// <summary><p><em>Sets <see cref="AzureBotEmailCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings SetAddDisabled(this AzureBotEmailCreateSettings toolSettings, bool? addDisabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = addDisabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings ResetAddDisabled(this AzureBotEmailCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotEmailCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings EnableAddDisabled(this AzureBotEmailCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotEmailCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings DisableAddDisabled(this AzureBotEmailCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotEmailCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings ToggleAddDisabled(this AzureBotEmailCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = !toolSettings.AddDisabled;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotEmailCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings SetSubscription(this AzureBotEmailCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings ResetSubscription(this AzureBotEmailCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotEmailCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings SetDebug(this AzureBotEmailCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings ResetDebug(this AzureBotEmailCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotEmailCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings SetHelp(this AzureBotEmailCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings ResetHelp(this AzureBotEmailCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotEmailCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings SetOutput(this AzureBotEmailCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings ResetOutput(this AzureBotEmailCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotEmailCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings SetQuery(this AzureBotEmailCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings ResetQuery(this AzureBotEmailCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotEmailCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings SetVerbose(this AzureBotEmailCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotEmailCreateSettings ResetVerbose(this AzureBotEmailCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotEmailDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotEmailDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotEmailDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings SetName(this AzureBotEmailDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings ResetName(this AzureBotEmailDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotEmailDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings SetResourceGroup(this AzureBotEmailDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings ResetResourceGroup(this AzureBotEmailDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotEmailDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings SetSubscription(this AzureBotEmailDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings ResetSubscription(this AzureBotEmailDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotEmailDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings SetDebug(this AzureBotEmailDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings ResetDebug(this AzureBotEmailDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotEmailDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings SetHelp(this AzureBotEmailDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings ResetHelp(this AzureBotEmailDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotEmailDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings SetOutput(this AzureBotEmailDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings ResetOutput(this AzureBotEmailDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotEmailDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings SetQuery(this AzureBotEmailDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings ResetQuery(this AzureBotEmailDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotEmailDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings SetVerbose(this AzureBotEmailDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotEmailDeleteSettings ResetVerbose(this AzureBotEmailDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotEmailShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotEmailShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotEmailShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings SetName(this AzureBotEmailShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings ResetName(this AzureBotEmailShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotEmailShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings SetResourceGroup(this AzureBotEmailShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings ResetResourceGroup(this AzureBotEmailShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WithSecrets
        /// <summary><p><em>Sets <see cref="AzureBotEmailShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings SetWithSecrets(this AzureBotEmailShowSettings toolSettings, bool? withSecrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = withSecrets;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings ResetWithSecrets(this AzureBotEmailShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotEmailShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings EnableWithSecrets(this AzureBotEmailShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotEmailShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings DisableWithSecrets(this AzureBotEmailShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotEmailShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings ToggleWithSecrets(this AzureBotEmailShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = !toolSettings.WithSecrets;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotEmailShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings SetSubscription(this AzureBotEmailShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings ResetSubscription(this AzureBotEmailShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotEmailShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings SetDebug(this AzureBotEmailShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings ResetDebug(this AzureBotEmailShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotEmailShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings SetHelp(this AzureBotEmailShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings ResetHelp(this AzureBotEmailShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotEmailShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings SetOutput(this AzureBotEmailShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings ResetOutput(this AzureBotEmailShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotEmailShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings SetQuery(this AzureBotEmailShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings ResetQuery(this AzureBotEmailShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotEmailShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings SetVerbose(this AzureBotEmailShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotEmailShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotEmailShowSettings ResetVerbose(this AzureBotEmailShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotKikCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotKikCreateSettingsExtensions
    {
        #region Key
        /// <summary><p><em>Sets <see cref="AzureBotKikCreateSettings.Key"/>.</em></p><p>The API key for the Kik account.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings SetKey(this AzureBotKikCreateSettings toolSettings, string key)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = key;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikCreateSettings.Key"/>.</em></p><p>The API key for the Kik account.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings ResetKey(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Key = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotKikCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings SetName(this AzureBotKikCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings ResetName(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotKikCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings SetResourceGroup(this AzureBotKikCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings ResetResourceGroup(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region UserName
        /// <summary><p><em>Sets <see cref="AzureBotKikCreateSettings.UserName"/>.</em></p><p>Kik user name.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings SetUserName(this AzureBotKikCreateSettings toolSettings, string userName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = userName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikCreateSettings.UserName"/>.</em></p><p>Kik user name.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings ResetUserName(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserName = null;
            return toolSettings;
        }
        #endregion
        #region AddDisabled
        /// <summary><p><em>Sets <see cref="AzureBotKikCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings SetAddDisabled(this AzureBotKikCreateSettings toolSettings, bool? addDisabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = addDisabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings ResetAddDisabled(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotKikCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings EnableAddDisabled(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotKikCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings DisableAddDisabled(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotKikCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings ToggleAddDisabled(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = !toolSettings.AddDisabled;
            return toolSettings;
        }
        #endregion
        #region IsValidated
        /// <summary><p><em>Sets <see cref="AzureBotKikCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Kik account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings SetIsValidated(this AzureBotKikCreateSettings toolSettings, bool? isValidated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = isValidated;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Kik account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings ResetIsValidated(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotKikCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Kik account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings EnableIsValidated(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotKikCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Kik account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings DisableIsValidated(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotKikCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Kik account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings ToggleIsValidated(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = !toolSettings.IsValidated;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotKikCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings SetSubscription(this AzureBotKikCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings ResetSubscription(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotKikCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings SetDebug(this AzureBotKikCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings ResetDebug(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotKikCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings SetHelp(this AzureBotKikCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings ResetHelp(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotKikCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings SetOutput(this AzureBotKikCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings ResetOutput(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotKikCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings SetQuery(this AzureBotKikCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings ResetQuery(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotKikCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings SetVerbose(this AzureBotKikCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotKikCreateSettings ResetVerbose(this AzureBotKikCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotKikDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotKikDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotKikDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings SetName(this AzureBotKikDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings ResetName(this AzureBotKikDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotKikDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings SetResourceGroup(this AzureBotKikDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings ResetResourceGroup(this AzureBotKikDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotKikDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings SetSubscription(this AzureBotKikDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings ResetSubscription(this AzureBotKikDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotKikDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings SetDebug(this AzureBotKikDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings ResetDebug(this AzureBotKikDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotKikDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings SetHelp(this AzureBotKikDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings ResetHelp(this AzureBotKikDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotKikDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings SetOutput(this AzureBotKikDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings ResetOutput(this AzureBotKikDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotKikDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings SetQuery(this AzureBotKikDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings ResetQuery(this AzureBotKikDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotKikDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings SetVerbose(this AzureBotKikDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotKikDeleteSettings ResetVerbose(this AzureBotKikDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotKikShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotKikShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotKikShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings SetName(this AzureBotKikShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings ResetName(this AzureBotKikShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotKikShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings SetResourceGroup(this AzureBotKikShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings ResetResourceGroup(this AzureBotKikShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WithSecrets
        /// <summary><p><em>Sets <see cref="AzureBotKikShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings SetWithSecrets(this AzureBotKikShowSettings toolSettings, bool? withSecrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = withSecrets;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings ResetWithSecrets(this AzureBotKikShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotKikShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings EnableWithSecrets(this AzureBotKikShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotKikShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings DisableWithSecrets(this AzureBotKikShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotKikShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings ToggleWithSecrets(this AzureBotKikShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = !toolSettings.WithSecrets;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotKikShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings SetSubscription(this AzureBotKikShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings ResetSubscription(this AzureBotKikShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotKikShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings SetDebug(this AzureBotKikShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings ResetDebug(this AzureBotKikShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotKikShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings SetHelp(this AzureBotKikShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings ResetHelp(this AzureBotKikShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotKikShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings SetOutput(this AzureBotKikShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings ResetOutput(this AzureBotKikShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotKikShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings SetQuery(this AzureBotKikShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings ResetQuery(this AzureBotKikShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotKikShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings SetVerbose(this AzureBotKikShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotKikShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotKikShowSettings ResetVerbose(this AzureBotKikShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotAuthsettingCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotAuthsettingCreateSettingsExtensions
    {
        #region ClientId
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingCreateSettings.ClientId"/>.</em></p><p>Client ID associated with the service provider setting.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings SetClientId(this AzureBotAuthsettingCreateSettings toolSettings, string clientId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientId = clientId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingCreateSettings.ClientId"/>.</em></p><p>Client ID associated with the service provider setting.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings ResetClientId(this AzureBotAuthsettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientId = null;
            return toolSettings;
        }
        #endregion
        #region ClientSecret
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingCreateSettings.ClientSecret"/>.</em></p><p>Client secret associated with the service provider setting.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings SetClientSecret(this AzureBotAuthsettingCreateSettings toolSettings, string clientSecret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = clientSecret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingCreateSettings.ClientSecret"/>.</em></p><p>Client secret associated with the service provider setting.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings ResetClientSecret(this AzureBotAuthsettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ClientSecret = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings SetName(this AzureBotAuthsettingCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings ResetName(this AzureBotAuthsettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ProviderScopeString
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingCreateSettings.ProviderScopeString"/>.</em></p><p>The scope string associated with the service provider setting.The string should be delimited as needed for the service provider.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings SetProviderScopeString(this AzureBotAuthsettingCreateSettings toolSettings, string providerScopeString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProviderScopeString = providerScopeString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingCreateSettings.ProviderScopeString"/>.</em></p><p>The scope string associated with the service provider setting.The string should be delimited as needed for the service provider.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings ResetProviderScopeString(this AzureBotAuthsettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProviderScopeString = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings SetResourceGroup(this AzureBotAuthsettingCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings ResetResourceGroup(this AzureBotAuthsettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Service
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingCreateSettings.Service"/>.</em></p><p>Name of the service provider. For a list of all service providers, use `az bot connection listserviceproviders`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings SetService(this AzureBotAuthsettingCreateSettings toolSettings, string service)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Service = service;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingCreateSettings.Service"/>.</em></p><p>Name of the service provider. For a list of all service providers, use `az bot connection listserviceproviders`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings ResetService(this AzureBotAuthsettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Service = null;
            return toolSettings;
        }
        #endregion
        #region SettingName
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingCreateSettings.SettingName"/>.</em></p><p>Name of the oauth connection setting.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings SetSettingName(this AzureBotAuthsettingCreateSettings toolSettings, string settingName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingName = settingName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingCreateSettings.SettingName"/>.</em></p><p>Name of the oauth connection setting.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings ResetSettingName(this AzureBotAuthsettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingName = null;
            return toolSettings;
        }
        #endregion
        #region Parameters
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingCreateSettings.Parameters"/>.</em></p><p>Parameter values for service provider parameters. Usage: --parameters key=value key1=value1.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings SetParameters(this AzureBotAuthsettingCreateSettings toolSettings, string parameters)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = parameters;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingCreateSettings.Parameters"/>.</em></p><p>Parameter values for service provider parameters. Usage: --parameters key=value key1=value1.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings ResetParameters(this AzureBotAuthsettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Parameters = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings SetSubscription(this AzureBotAuthsettingCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings ResetSubscription(this AzureBotAuthsettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings SetDebug(this AzureBotAuthsettingCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings ResetDebug(this AzureBotAuthsettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings SetHelp(this AzureBotAuthsettingCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings ResetHelp(this AzureBotAuthsettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings SetOutput(this AzureBotAuthsettingCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings ResetOutput(this AzureBotAuthsettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings SetQuery(this AzureBotAuthsettingCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings ResetQuery(this AzureBotAuthsettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings SetVerbose(this AzureBotAuthsettingCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingCreateSettings ResetVerbose(this AzureBotAuthsettingCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotAuthsettingDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotAuthsettingDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings SetName(this AzureBotAuthsettingDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings ResetName(this AzureBotAuthsettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings SetResourceGroup(this AzureBotAuthsettingDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings ResetResourceGroup(this AzureBotAuthsettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SettingName
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingDeleteSettings.SettingName"/>.</em></p><p>Name of the oauth connection setting.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings SetSettingName(this AzureBotAuthsettingDeleteSettings toolSettings, string settingName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingName = settingName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingDeleteSettings.SettingName"/>.</em></p><p>Name of the oauth connection setting.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings ResetSettingName(this AzureBotAuthsettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings SetSubscription(this AzureBotAuthsettingDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings ResetSubscription(this AzureBotAuthsettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings SetDebug(this AzureBotAuthsettingDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings ResetDebug(this AzureBotAuthsettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings SetHelp(this AzureBotAuthsettingDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings ResetHelp(this AzureBotAuthsettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings SetOutput(this AzureBotAuthsettingDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings ResetOutput(this AzureBotAuthsettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings SetQuery(this AzureBotAuthsettingDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings ResetQuery(this AzureBotAuthsettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings SetVerbose(this AzureBotAuthsettingDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingDeleteSettings ResetVerbose(this AzureBotAuthsettingDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotAuthsettingListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotAuthsettingListSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings SetName(this AzureBotAuthsettingListSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings ResetName(this AzureBotAuthsettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings SetResourceGroup(this AzureBotAuthsettingListSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings ResetResourceGroup(this AzureBotAuthsettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings SetSubscription(this AzureBotAuthsettingListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings ResetSubscription(this AzureBotAuthsettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings SetDebug(this AzureBotAuthsettingListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings ResetDebug(this AzureBotAuthsettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings SetHelp(this AzureBotAuthsettingListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings ResetHelp(this AzureBotAuthsettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings SetOutput(this AzureBotAuthsettingListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings ResetOutput(this AzureBotAuthsettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings SetQuery(this AzureBotAuthsettingListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings ResetQuery(this AzureBotAuthsettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings SetVerbose(this AzureBotAuthsettingListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListSettings ResetVerbose(this AzureBotAuthsettingListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotAuthsettingListProvidersSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotAuthsettingListProvidersSettingsExtensions
    {
        #region ProviderName
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListProvidersSettings.ProviderName"/>.</em></p><p>Service provider name for which to fetch details.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListProvidersSettings SetProviderName(this AzureBotAuthsettingListProvidersSettings toolSettings, string providerName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProviderName = providerName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListProvidersSettings.ProviderName"/>.</em></p><p>Service provider name for which to fetch details.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListProvidersSettings ResetProviderName(this AzureBotAuthsettingListProvidersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ProviderName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListProvidersSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListProvidersSettings SetSubscription(this AzureBotAuthsettingListProvidersSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListProvidersSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListProvidersSettings ResetSubscription(this AzureBotAuthsettingListProvidersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListProvidersSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListProvidersSettings SetDebug(this AzureBotAuthsettingListProvidersSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListProvidersSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListProvidersSettings ResetDebug(this AzureBotAuthsettingListProvidersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListProvidersSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListProvidersSettings SetHelp(this AzureBotAuthsettingListProvidersSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListProvidersSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListProvidersSettings ResetHelp(this AzureBotAuthsettingListProvidersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListProvidersSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListProvidersSettings SetOutput(this AzureBotAuthsettingListProvidersSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListProvidersSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListProvidersSettings ResetOutput(this AzureBotAuthsettingListProvidersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListProvidersSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListProvidersSettings SetQuery(this AzureBotAuthsettingListProvidersSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListProvidersSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListProvidersSettings ResetQuery(this AzureBotAuthsettingListProvidersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingListProvidersSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListProvidersSettings SetVerbose(this AzureBotAuthsettingListProvidersSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingListProvidersSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingListProvidersSettings ResetVerbose(this AzureBotAuthsettingListProvidersSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotAuthsettingShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotAuthsettingShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings SetName(this AzureBotAuthsettingShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings ResetName(this AzureBotAuthsettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings SetResourceGroup(this AzureBotAuthsettingShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings ResetResourceGroup(this AzureBotAuthsettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region SettingName
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingShowSettings.SettingName"/>.</em></p><p>Name of the oauth connection setting.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings SetSettingName(this AzureBotAuthsettingShowSettings toolSettings, string settingName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingName = settingName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingShowSettings.SettingName"/>.</em></p><p>Name of the oauth connection setting.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings ResetSettingName(this AzureBotAuthsettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SettingName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings SetSubscription(this AzureBotAuthsettingShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings ResetSubscription(this AzureBotAuthsettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings SetDebug(this AzureBotAuthsettingShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings ResetDebug(this AzureBotAuthsettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings SetHelp(this AzureBotAuthsettingShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings ResetHelp(this AzureBotAuthsettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings SetOutput(this AzureBotAuthsettingShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings ResetOutput(this AzureBotAuthsettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings SetQuery(this AzureBotAuthsettingShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings ResetQuery(this AzureBotAuthsettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotAuthsettingShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings SetVerbose(this AzureBotAuthsettingShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotAuthsettingShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotAuthsettingShowSettings ResetVerbose(this AzureBotAuthsettingShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotTelegramCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotTelegramCreateSettingsExtensions
    {
        #region AccessToken
        /// <summary><p><em>Sets <see cref="AzureBotTelegramCreateSettings.AccessToken"/>.</em></p><p>The access token for the Telegram account.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings SetAccessToken(this AzureBotTelegramCreateSettings toolSettings, string accessToken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessToken = accessToken;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramCreateSettings.AccessToken"/>.</em></p><p>The access token for the Telegram account.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings ResetAccessToken(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccessToken = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotTelegramCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings SetName(this AzureBotTelegramCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings ResetName(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotTelegramCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings SetResourceGroup(this AzureBotTelegramCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings ResetResourceGroup(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AddDisabled
        /// <summary><p><em>Sets <see cref="AzureBotTelegramCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings SetAddDisabled(this AzureBotTelegramCreateSettings toolSettings, bool? addDisabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = addDisabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings ResetAddDisabled(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotTelegramCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings EnableAddDisabled(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotTelegramCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings DisableAddDisabled(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotTelegramCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings ToggleAddDisabled(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = !toolSettings.AddDisabled;
            return toolSettings;
        }
        #endregion
        #region IsValidated
        /// <summary><p><em>Sets <see cref="AzureBotTelegramCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Telegram account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings SetIsValidated(this AzureBotTelegramCreateSettings toolSettings, bool? isValidated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = isValidated;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Telegram account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings ResetIsValidated(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotTelegramCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Telegram account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings EnableIsValidated(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotTelegramCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Telegram account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings DisableIsValidated(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotTelegramCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Telegram account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings ToggleIsValidated(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = !toolSettings.IsValidated;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotTelegramCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings SetSubscription(this AzureBotTelegramCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings ResetSubscription(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotTelegramCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings SetDebug(this AzureBotTelegramCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings ResetDebug(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotTelegramCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings SetHelp(this AzureBotTelegramCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings ResetHelp(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotTelegramCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings SetOutput(this AzureBotTelegramCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings ResetOutput(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotTelegramCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings SetQuery(this AzureBotTelegramCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings ResetQuery(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotTelegramCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings SetVerbose(this AzureBotTelegramCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotTelegramCreateSettings ResetVerbose(this AzureBotTelegramCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotTelegramDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotTelegramDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotTelegramDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings SetName(this AzureBotTelegramDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings ResetName(this AzureBotTelegramDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotTelegramDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings SetResourceGroup(this AzureBotTelegramDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings ResetResourceGroup(this AzureBotTelegramDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotTelegramDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings SetSubscription(this AzureBotTelegramDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings ResetSubscription(this AzureBotTelegramDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotTelegramDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings SetDebug(this AzureBotTelegramDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings ResetDebug(this AzureBotTelegramDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotTelegramDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings SetHelp(this AzureBotTelegramDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings ResetHelp(this AzureBotTelegramDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotTelegramDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings SetOutput(this AzureBotTelegramDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings ResetOutput(this AzureBotTelegramDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotTelegramDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings SetQuery(this AzureBotTelegramDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings ResetQuery(this AzureBotTelegramDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotTelegramDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings SetVerbose(this AzureBotTelegramDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotTelegramDeleteSettings ResetVerbose(this AzureBotTelegramDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotTelegramShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotTelegramShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotTelegramShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings SetName(this AzureBotTelegramShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings ResetName(this AzureBotTelegramShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotTelegramShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings SetResourceGroup(this AzureBotTelegramShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings ResetResourceGroup(this AzureBotTelegramShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WithSecrets
        /// <summary><p><em>Sets <see cref="AzureBotTelegramShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings SetWithSecrets(this AzureBotTelegramShowSettings toolSettings, bool? withSecrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = withSecrets;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings ResetWithSecrets(this AzureBotTelegramShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotTelegramShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings EnableWithSecrets(this AzureBotTelegramShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotTelegramShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings DisableWithSecrets(this AzureBotTelegramShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotTelegramShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings ToggleWithSecrets(this AzureBotTelegramShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = !toolSettings.WithSecrets;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotTelegramShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings SetSubscription(this AzureBotTelegramShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings ResetSubscription(this AzureBotTelegramShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotTelegramShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings SetDebug(this AzureBotTelegramShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings ResetDebug(this AzureBotTelegramShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotTelegramShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings SetHelp(this AzureBotTelegramShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings ResetHelp(this AzureBotTelegramShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotTelegramShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings SetOutput(this AzureBotTelegramShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings ResetOutput(this AzureBotTelegramShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotTelegramShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings SetQuery(this AzureBotTelegramShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings ResetQuery(this AzureBotTelegramShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotTelegramShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings SetVerbose(this AzureBotTelegramShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotTelegramShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotTelegramShowSettings ResetVerbose(this AzureBotTelegramShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotSkypeCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotSkypeCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetName(this AzureBotSkypeCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetName(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetResourceGroup(this AzureBotSkypeCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetResourceGroup(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AddDisabled
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetAddDisabled(this AzureBotSkypeCreateSettings toolSettings, bool? addDisabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = addDisabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetAddDisabled(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotSkypeCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings EnableAddDisabled(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotSkypeCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings DisableAddDisabled(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotSkypeCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ToggleAddDisabled(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = !toolSettings.AddDisabled;
            return toolSettings;
        }
        #endregion
        #region CallingWebHook
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.CallingWebHook"/>.</em></p><p>The calling web hook to use on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetCallingWebHook(this AzureBotSkypeCreateSettings toolSettings, string callingWebHook)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CallingWebHook = callingWebHook;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.CallingWebHook"/>.</em></p><p>The calling web hook to use on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetCallingWebHook(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CallingWebHook = null;
            return toolSettings;
        }
        #endregion
        #region EnableCalling
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.EnableCalling"/>.</em></p><p>Enable calling on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetEnableCalling(this AzureBotSkypeCreateSettings toolSettings, bool? enableCalling)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCalling = enableCalling;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.EnableCalling"/>.</em></p><p>Enable calling on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetEnableCalling(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCalling = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotSkypeCreateSettings.EnableCalling"/>.</em></p><p>Enable calling on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings EnableEnableCalling(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCalling = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotSkypeCreateSettings.EnableCalling"/>.</em></p><p>Enable calling on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings DisableEnableCalling(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCalling = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotSkypeCreateSettings.EnableCalling"/>.</em></p><p>Enable calling on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ToggleEnableCalling(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableCalling = !toolSettings.EnableCalling;
            return toolSettings;
        }
        #endregion
        #region EnableGroups
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.EnableGroups"/>.</em></p><p>Enable groups on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetEnableGroups(this AzureBotSkypeCreateSettings toolSettings, bool? enableGroups)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableGroups = enableGroups;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.EnableGroups"/>.</em></p><p>Enable groups on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetEnableGroups(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableGroups = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotSkypeCreateSettings.EnableGroups"/>.</em></p><p>Enable groups on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings EnableEnableGroups(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableGroups = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotSkypeCreateSettings.EnableGroups"/>.</em></p><p>Enable groups on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings DisableEnableGroups(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableGroups = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotSkypeCreateSettings.EnableGroups"/>.</em></p><p>Enable groups on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ToggleEnableGroups(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableGroups = !toolSettings.EnableGroups;
            return toolSettings;
        }
        #endregion
        #region EnableMediaCards
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.EnableMediaCards"/>.</em></p><p>Enable media cards on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetEnableMediaCards(this AzureBotSkypeCreateSettings toolSettings, bool? enableMediaCards)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMediaCards = enableMediaCards;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.EnableMediaCards"/>.</em></p><p>Enable media cards on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetEnableMediaCards(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMediaCards = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotSkypeCreateSettings.EnableMediaCards"/>.</em></p><p>Enable media cards on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings EnableEnableMediaCards(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMediaCards = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotSkypeCreateSettings.EnableMediaCards"/>.</em></p><p>Enable media cards on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings DisableEnableMediaCards(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMediaCards = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotSkypeCreateSettings.EnableMediaCards"/>.</em></p><p>Enable media cards on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ToggleEnableMediaCards(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMediaCards = !toolSettings.EnableMediaCards;
            return toolSettings;
        }
        #endregion
        #region EnableMessaging
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.EnableMessaging"/>.</em></p><p>Enable messaging on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetEnableMessaging(this AzureBotSkypeCreateSettings toolSettings, bool? enableMessaging)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMessaging = enableMessaging;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.EnableMessaging"/>.</em></p><p>Enable messaging on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetEnableMessaging(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMessaging = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotSkypeCreateSettings.EnableMessaging"/>.</em></p><p>Enable messaging on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings EnableEnableMessaging(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMessaging = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotSkypeCreateSettings.EnableMessaging"/>.</em></p><p>Enable messaging on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings DisableEnableMessaging(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMessaging = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotSkypeCreateSettings.EnableMessaging"/>.</em></p><p>Enable messaging on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ToggleEnableMessaging(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableMessaging = !toolSettings.EnableMessaging;
            return toolSettings;
        }
        #endregion
        #region EnableScreenSharing
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.EnableScreenSharing"/>.</em></p><p>Enable screen sharing on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetEnableScreenSharing(this AzureBotSkypeCreateSettings toolSettings, bool? enableScreenSharing)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableScreenSharing = enableScreenSharing;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.EnableScreenSharing"/>.</em></p><p>Enable screen sharing on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetEnableScreenSharing(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableScreenSharing = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotSkypeCreateSettings.EnableScreenSharing"/>.</em></p><p>Enable screen sharing on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings EnableEnableScreenSharing(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableScreenSharing = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotSkypeCreateSettings.EnableScreenSharing"/>.</em></p><p>Enable screen sharing on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings DisableEnableScreenSharing(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableScreenSharing = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotSkypeCreateSettings.EnableScreenSharing"/>.</em></p><p>Enable screen sharing on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ToggleEnableScreenSharing(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableScreenSharing = !toolSettings.EnableScreenSharing;
            return toolSettings;
        }
        #endregion
        #region EnableVideo
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.EnableVideo"/>.</em></p><p>Enable video on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetEnableVideo(this AzureBotSkypeCreateSettings toolSettings, bool? enableVideo)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVideo = enableVideo;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.EnableVideo"/>.</em></p><p>Enable video on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetEnableVideo(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVideo = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotSkypeCreateSettings.EnableVideo"/>.</em></p><p>Enable video on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings EnableEnableVideo(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVideo = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotSkypeCreateSettings.EnableVideo"/>.</em></p><p>Enable video on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings DisableEnableVideo(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVideo = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotSkypeCreateSettings.EnableVideo"/>.</em></p><p>Enable video on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ToggleEnableVideo(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EnableVideo = !toolSettings.EnableVideo;
            return toolSettings;
        }
        #endregion
        #region GroupsMode
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.GroupsMode"/>.</em></p><p>Select groups mode on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetGroupsMode(this AzureBotSkypeCreateSettings toolSettings, string groupsMode)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GroupsMode = groupsMode;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.GroupsMode"/>.</em></p><p>Select groups mode on Skype.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetGroupsMode(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GroupsMode = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetSubscription(this AzureBotSkypeCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetSubscription(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetDebug(this AzureBotSkypeCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetDebug(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetHelp(this AzureBotSkypeCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetHelp(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetOutput(this AzureBotSkypeCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetOutput(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetQuery(this AzureBotSkypeCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetQuery(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotSkypeCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings SetVerbose(this AzureBotSkypeCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSkypeCreateSettings ResetVerbose(this AzureBotSkypeCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotSkypeDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotSkypeDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotSkypeDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings SetName(this AzureBotSkypeDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings ResetName(this AzureBotSkypeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotSkypeDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings SetResourceGroup(this AzureBotSkypeDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings ResetResourceGroup(this AzureBotSkypeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotSkypeDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings SetSubscription(this AzureBotSkypeDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings ResetSubscription(this AzureBotSkypeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotSkypeDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings SetDebug(this AzureBotSkypeDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings ResetDebug(this AzureBotSkypeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotSkypeDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings SetHelp(this AzureBotSkypeDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings ResetHelp(this AzureBotSkypeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotSkypeDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings SetOutput(this AzureBotSkypeDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings ResetOutput(this AzureBotSkypeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotSkypeDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings SetQuery(this AzureBotSkypeDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings ResetQuery(this AzureBotSkypeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotSkypeDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings SetVerbose(this AzureBotSkypeDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSkypeDeleteSettings ResetVerbose(this AzureBotSkypeDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotSkypeShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotSkypeShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotSkypeShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings SetName(this AzureBotSkypeShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings ResetName(this AzureBotSkypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotSkypeShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings SetResourceGroup(this AzureBotSkypeShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings ResetResourceGroup(this AzureBotSkypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WithSecrets
        /// <summary><p><em>Sets <see cref="AzureBotSkypeShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings SetWithSecrets(this AzureBotSkypeShowSettings toolSettings, bool? withSecrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = withSecrets;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings ResetWithSecrets(this AzureBotSkypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotSkypeShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings EnableWithSecrets(this AzureBotSkypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotSkypeShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings DisableWithSecrets(this AzureBotSkypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotSkypeShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings ToggleWithSecrets(this AzureBotSkypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = !toolSettings.WithSecrets;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotSkypeShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings SetSubscription(this AzureBotSkypeShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings ResetSubscription(this AzureBotSkypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotSkypeShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings SetDebug(this AzureBotSkypeShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings ResetDebug(this AzureBotSkypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotSkypeShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings SetHelp(this AzureBotSkypeShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings ResetHelp(this AzureBotSkypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotSkypeShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings SetOutput(this AzureBotSkypeShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings ResetOutput(this AzureBotSkypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotSkypeShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings SetQuery(this AzureBotSkypeShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings ResetQuery(this AzureBotSkypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotSkypeShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings SetVerbose(this AzureBotSkypeShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSkypeShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSkypeShowSettings ResetVerbose(this AzureBotSkypeShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotWebchatShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotWebchatShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotWebchatShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings SetName(this AzureBotWebchatShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotWebchatShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings ResetName(this AzureBotWebchatShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotWebchatShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings SetResourceGroup(this AzureBotWebchatShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotWebchatShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings ResetResourceGroup(this AzureBotWebchatShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WithSecrets
        /// <summary><p><em>Sets <see cref="AzureBotWebchatShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings SetWithSecrets(this AzureBotWebchatShowSettings toolSettings, bool? withSecrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = withSecrets;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotWebchatShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings ResetWithSecrets(this AzureBotWebchatShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotWebchatShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings EnableWithSecrets(this AzureBotWebchatShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotWebchatShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings DisableWithSecrets(this AzureBotWebchatShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotWebchatShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings ToggleWithSecrets(this AzureBotWebchatShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = !toolSettings.WithSecrets;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotWebchatShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings SetSubscription(this AzureBotWebchatShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotWebchatShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings ResetSubscription(this AzureBotWebchatShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotWebchatShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings SetDebug(this AzureBotWebchatShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotWebchatShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings ResetDebug(this AzureBotWebchatShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotWebchatShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings SetHelp(this AzureBotWebchatShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotWebchatShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings ResetHelp(this AzureBotWebchatShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotWebchatShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings SetOutput(this AzureBotWebchatShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotWebchatShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings ResetOutput(this AzureBotWebchatShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotWebchatShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings SetQuery(this AzureBotWebchatShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotWebchatShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings ResetQuery(this AzureBotWebchatShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotWebchatShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings SetVerbose(this AzureBotWebchatShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotWebchatShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotWebchatShowSettings ResetVerbose(this AzureBotWebchatShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotDirectlineCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotDirectlineCreateSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings SetName(this AzureBotDirectlineCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ResetName(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings SetResourceGroup(this AzureBotDirectlineCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ResetResourceGroup(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AddDisabled
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings SetAddDisabled(this AzureBotDirectlineCreateSettings toolSettings, bool? addDisabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = addDisabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ResetAddDisabled(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotDirectlineCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings EnableAddDisabled(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotDirectlineCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings DisableAddDisabled(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotDirectlineCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ToggleAddDisabled(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = !toolSettings.AddDisabled;
            return toolSettings;
        }
        #endregion
        #region Disablev1
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineCreateSettings.Disablev1"/>.</em></p><p>If true, v1 protocol will be disabled on the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings SetDisablev1(this AzureBotDirectlineCreateSettings toolSettings, bool? disablev1)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disablev1 = disablev1;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineCreateSettings.Disablev1"/>.</em></p><p>If true, v1 protocol will be disabled on the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ResetDisablev1(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disablev1 = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotDirectlineCreateSettings.Disablev1"/>.</em></p><p>If true, v1 protocol will be disabled on the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings EnableDisablev1(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disablev1 = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotDirectlineCreateSettings.Disablev1"/>.</em></p><p>If true, v1 protocol will be disabled on the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings DisableDisablev1(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disablev1 = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotDirectlineCreateSettings.Disablev1"/>.</em></p><p>If true, v1 protocol will be disabled on the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ToggleDisablev1(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disablev1 = !toolSettings.Disablev1;
            return toolSettings;
        }
        #endregion
        #region Disablev3
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineCreateSettings.Disablev3"/>.</em></p><p>If true, v3 protocol will be disabled on the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings SetDisablev3(this AzureBotDirectlineCreateSettings toolSettings, bool? disablev3)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disablev3 = disablev3;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineCreateSettings.Disablev3"/>.</em></p><p>If true, v3 protocol will be disabled on the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ResetDisablev3(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disablev3 = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotDirectlineCreateSettings.Disablev3"/>.</em></p><p>If true, v3 protocol will be disabled on the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings EnableDisablev3(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disablev3 = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotDirectlineCreateSettings.Disablev3"/>.</em></p><p>If true, v3 protocol will be disabled on the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings DisableDisablev3(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disablev3 = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotDirectlineCreateSettings.Disablev3"/>.</em></p><p>If true, v3 protocol will be disabled on the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ToggleDisablev3(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Disablev3 = !toolSettings.Disablev3;
            return toolSettings;
        }
        #endregion
        #region SiteName
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineCreateSettings.SiteName"/>.</em></p><p>Name of the Directline channel site.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings SetSiteName(this AzureBotDirectlineCreateSettings toolSettings, string siteName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SiteName = siteName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineCreateSettings.SiteName"/>.</em></p><p>Name of the Directline channel site.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ResetSiteName(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SiteName = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings SetSubscription(this AzureBotDirectlineCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ResetSubscription(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings SetDebug(this AzureBotDirectlineCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ResetDebug(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings SetHelp(this AzureBotDirectlineCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ResetHelp(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings SetOutput(this AzureBotDirectlineCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ResetOutput(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings SetQuery(this AzureBotDirectlineCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ResetQuery(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings SetVerbose(this AzureBotDirectlineCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotDirectlineCreateSettings ResetVerbose(this AzureBotDirectlineCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotDirectlineDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotDirectlineDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings SetName(this AzureBotDirectlineDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings ResetName(this AzureBotDirectlineDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings SetResourceGroup(this AzureBotDirectlineDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings ResetResourceGroup(this AzureBotDirectlineDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings SetSubscription(this AzureBotDirectlineDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings ResetSubscription(this AzureBotDirectlineDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings SetDebug(this AzureBotDirectlineDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings ResetDebug(this AzureBotDirectlineDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings SetHelp(this AzureBotDirectlineDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings ResetHelp(this AzureBotDirectlineDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings SetOutput(this AzureBotDirectlineDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings ResetOutput(this AzureBotDirectlineDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings SetQuery(this AzureBotDirectlineDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings ResetQuery(this AzureBotDirectlineDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings SetVerbose(this AzureBotDirectlineDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotDirectlineDeleteSettings ResetVerbose(this AzureBotDirectlineDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotDirectlineShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotDirectlineShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings SetName(this AzureBotDirectlineShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings ResetName(this AzureBotDirectlineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings SetResourceGroup(this AzureBotDirectlineShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings ResetResourceGroup(this AzureBotDirectlineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WithSecrets
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings SetWithSecrets(this AzureBotDirectlineShowSettings toolSettings, bool? withSecrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = withSecrets;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings ResetWithSecrets(this AzureBotDirectlineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotDirectlineShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings EnableWithSecrets(this AzureBotDirectlineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotDirectlineShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings DisableWithSecrets(this AzureBotDirectlineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotDirectlineShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings ToggleWithSecrets(this AzureBotDirectlineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = !toolSettings.WithSecrets;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings SetSubscription(this AzureBotDirectlineShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings ResetSubscription(this AzureBotDirectlineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings SetDebug(this AzureBotDirectlineShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings ResetDebug(this AzureBotDirectlineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings SetHelp(this AzureBotDirectlineShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings ResetHelp(this AzureBotDirectlineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings SetOutput(this AzureBotDirectlineShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings ResetOutput(this AzureBotDirectlineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings SetQuery(this AzureBotDirectlineShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings ResetQuery(this AzureBotDirectlineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotDirectlineShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings SetVerbose(this AzureBotDirectlineShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotDirectlineShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotDirectlineShowSettings ResetVerbose(this AzureBotDirectlineShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotSmsCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotSmsCreateSettingsExtensions
    {
        #region AccountSid
        /// <summary><p><em>Sets <see cref="AzureBotSmsCreateSettings.AccountSid"/>.</em></p><p>The account SID for the Twilio account.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings SetAccountSid(this AzureBotSmsCreateSettings toolSettings, string accountSid)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountSid = accountSid;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsCreateSettings.AccountSid"/>.</em></p><p>The account SID for the Twilio account.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ResetAccountSid(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AccountSid = null;
            return toolSettings;
        }
        #endregion
        #region AuthToken
        /// <summary><p><em>Sets <see cref="AzureBotSmsCreateSettings.AuthToken"/>.</em></p><p>The token token for the Twilio account.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings SetAuthToken(this AzureBotSmsCreateSettings toolSettings, string authToken)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthToken = authToken;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsCreateSettings.AuthToken"/>.</em></p><p>The token token for the Twilio account.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ResetAuthToken(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthToken = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotSmsCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings SetName(this AzureBotSmsCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ResetName(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Phone
        /// <summary><p><em>Sets <see cref="AzureBotSmsCreateSettings.Phone"/>.</em></p><p>The phone number for the Twilio account.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings SetPhone(this AzureBotSmsCreateSettings toolSettings, string phone)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Phone = phone;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsCreateSettings.Phone"/>.</em></p><p>The phone number for the Twilio account.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ResetPhone(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Phone = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotSmsCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings SetResourceGroup(this AzureBotSmsCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ResetResourceGroup(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region AddDisabled
        /// <summary><p><em>Sets <see cref="AzureBotSmsCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings SetAddDisabled(this AzureBotSmsCreateSettings toolSettings, bool? addDisabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = addDisabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ResetAddDisabled(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotSmsCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings EnableAddDisabled(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotSmsCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings DisableAddDisabled(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotSmsCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ToggleAddDisabled(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = !toolSettings.AddDisabled;
            return toolSettings;
        }
        #endregion
        #region IsValidated
        /// <summary><p><em>Sets <see cref="AzureBotSmsCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Twilio account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings SetIsValidated(this AzureBotSmsCreateSettings toolSettings, bool? isValidated)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = isValidated;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Twilio account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ResetIsValidated(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotSmsCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Twilio account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings EnableIsValidated(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotSmsCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Twilio account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings DisableIsValidated(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotSmsCreateSettings.IsValidated"/>.</em></p><p>Whether or not the Twilio account has been validated for use with the bot.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ToggleIsValidated(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IsValidated = !toolSettings.IsValidated;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotSmsCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings SetSubscription(this AzureBotSmsCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ResetSubscription(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotSmsCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings SetDebug(this AzureBotSmsCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ResetDebug(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotSmsCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings SetHelp(this AzureBotSmsCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ResetHelp(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotSmsCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings SetOutput(this AzureBotSmsCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ResetOutput(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotSmsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings SetQuery(this AzureBotSmsCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ResetQuery(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotSmsCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings SetVerbose(this AzureBotSmsCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSmsCreateSettings ResetVerbose(this AzureBotSmsCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotSmsDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotSmsDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotSmsDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings SetName(this AzureBotSmsDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings ResetName(this AzureBotSmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotSmsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings SetResourceGroup(this AzureBotSmsDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings ResetResourceGroup(this AzureBotSmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotSmsDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings SetSubscription(this AzureBotSmsDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings ResetSubscription(this AzureBotSmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotSmsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings SetDebug(this AzureBotSmsDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings ResetDebug(this AzureBotSmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotSmsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings SetHelp(this AzureBotSmsDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings ResetHelp(this AzureBotSmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotSmsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings SetOutput(this AzureBotSmsDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings ResetOutput(this AzureBotSmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotSmsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings SetQuery(this AzureBotSmsDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings ResetQuery(this AzureBotSmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotSmsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings SetVerbose(this AzureBotSmsDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSmsDeleteSettings ResetVerbose(this AzureBotSmsDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotSmsShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotSmsShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotSmsShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings SetName(this AzureBotSmsShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings ResetName(this AzureBotSmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotSmsShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings SetResourceGroup(this AzureBotSmsShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings ResetResourceGroup(this AzureBotSmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WithSecrets
        /// <summary><p><em>Sets <see cref="AzureBotSmsShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings SetWithSecrets(this AzureBotSmsShowSettings toolSettings, bool? withSecrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = withSecrets;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings ResetWithSecrets(this AzureBotSmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotSmsShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings EnableWithSecrets(this AzureBotSmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotSmsShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings DisableWithSecrets(this AzureBotSmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotSmsShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings ToggleWithSecrets(this AzureBotSmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = !toolSettings.WithSecrets;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotSmsShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings SetSubscription(this AzureBotSmsShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings ResetSubscription(this AzureBotSmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotSmsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings SetDebug(this AzureBotSmsShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings ResetDebug(this AzureBotSmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotSmsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings SetHelp(this AzureBotSmsShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings ResetHelp(this AzureBotSmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotSmsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings SetOutput(this AzureBotSmsShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings ResetOutput(this AzureBotSmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotSmsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings SetQuery(this AzureBotSmsShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings ResetQuery(this AzureBotSmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotSmsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings SetVerbose(this AzureBotSmsShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotSmsShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotSmsShowSettings ResetVerbose(this AzureBotSmsShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotFacebookCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotFacebookCreateSettingsExtensions
    {
        #region Appid
        /// <summary><p><em>Sets <see cref="AzureBotFacebookCreateSettings.Appid"/>.</em></p><p>The Facebook application id.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings SetAppid(this AzureBotFacebookCreateSettings toolSettings, string appid)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Appid = appid;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookCreateSettings.Appid"/>.</em></p><p>The Facebook application id.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings ResetAppid(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Appid = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotFacebookCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings SetName(this AzureBotFacebookCreateSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookCreateSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings ResetName(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region PageId
        /// <summary><p><em>Sets <see cref="AzureBotFacebookCreateSettings.PageId"/>.</em></p><p>Page ID of the Facebook page to be used for the bot.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings SetPageId(this AzureBotFacebookCreateSettings toolSettings, string pageId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PageId = pageId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookCreateSettings.PageId"/>.</em></p><p>Page ID of the Facebook page to be used for the bot.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings ResetPageId(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PageId = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotFacebookCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings SetResourceGroup(this AzureBotFacebookCreateSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookCreateSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings ResetResourceGroup(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Secret
        /// <summary><p><em>Sets <see cref="AzureBotFacebookCreateSettings.Secret"/>.</em></p><p>The Facebook application secret.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings SetSecret(this AzureBotFacebookCreateSettings toolSettings, string secret)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Secret = secret;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookCreateSettings.Secret"/>.</em></p><p>The Facebook application secret.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings ResetSecret(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Secret = null;
            return toolSettings;
        }
        #endregion
        #region Token
        /// <summary><p><em>Sets <see cref="AzureBotFacebookCreateSettings.Token"/>.</em></p><p>The Facebook application access token.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings SetToken(this AzureBotFacebookCreateSettings toolSettings, string token)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Token = token;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookCreateSettings.Token"/>.</em></p><p>The Facebook application access token.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings ResetToken(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Token = null;
            return toolSettings;
        }
        #endregion
        #region AddDisabled
        /// <summary><p><em>Sets <see cref="AzureBotFacebookCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings SetAddDisabled(this AzureBotFacebookCreateSettings toolSettings, bool? addDisabled)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = addDisabled;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings ResetAddDisabled(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotFacebookCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings EnableAddDisabled(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotFacebookCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings DisableAddDisabled(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotFacebookCreateSettings.AddDisabled"/>.</em></p><p>Add the channel in a disabled state.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings ToggleAddDisabled(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AddDisabled = !toolSettings.AddDisabled;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotFacebookCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings SetSubscription(this AzureBotFacebookCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings ResetSubscription(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotFacebookCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings SetDebug(this AzureBotFacebookCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings ResetDebug(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotFacebookCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings SetHelp(this AzureBotFacebookCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings ResetHelp(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotFacebookCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings SetOutput(this AzureBotFacebookCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings ResetOutput(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotFacebookCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings SetQuery(this AzureBotFacebookCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings ResetQuery(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotFacebookCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings SetVerbose(this AzureBotFacebookCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotFacebookCreateSettings ResetVerbose(this AzureBotFacebookCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotFacebookDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotFacebookDeleteSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotFacebookDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings SetName(this AzureBotFacebookDeleteSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookDeleteSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings ResetName(this AzureBotFacebookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotFacebookDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings SetResourceGroup(this AzureBotFacebookDeleteSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookDeleteSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings ResetResourceGroup(this AzureBotFacebookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotFacebookDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings SetSubscription(this AzureBotFacebookDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings ResetSubscription(this AzureBotFacebookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotFacebookDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings SetDebug(this AzureBotFacebookDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings ResetDebug(this AzureBotFacebookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotFacebookDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings SetHelp(this AzureBotFacebookDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings ResetHelp(this AzureBotFacebookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotFacebookDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings SetOutput(this AzureBotFacebookDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings ResetOutput(this AzureBotFacebookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotFacebookDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings SetQuery(this AzureBotFacebookDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings ResetQuery(this AzureBotFacebookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotFacebookDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings SetVerbose(this AzureBotFacebookDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotFacebookDeleteSettings ResetVerbose(this AzureBotFacebookDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureBotFacebookShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureBotFacebookShowSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureBotFacebookShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings SetName(this AzureBotFacebookShowSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookShowSettings.Name"/>.</em></p><p>The resource name of the bot.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings ResetName(this AzureBotFacebookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region ResourceGroup
        /// <summary><p><em>Sets <see cref="AzureBotFacebookShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings SetResourceGroup(this AzureBotFacebookShowSettings toolSettings, string resourceGroup)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = resourceGroup;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookShowSettings.ResourceGroup"/>.</em></p><p>Name of resource group. You can configure the default group using `az configure --defaults group=&amp;lt;name&amp;gt;`.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings ResetResourceGroup(this AzureBotFacebookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ResourceGroup = null;
            return toolSettings;
        }
        #endregion
        #region WithSecrets
        /// <summary><p><em>Sets <see cref="AzureBotFacebookShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings SetWithSecrets(this AzureBotFacebookShowSettings toolSettings, bool? withSecrets)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = withSecrets;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings ResetWithSecrets(this AzureBotFacebookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureBotFacebookShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings EnableWithSecrets(this AzureBotFacebookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureBotFacebookShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings DisableWithSecrets(this AzureBotFacebookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureBotFacebookShowSettings.WithSecrets"/>.</em></p><p>Show secrets in response for the channel.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings ToggleWithSecrets(this AzureBotFacebookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.WithSecrets = !toolSettings.WithSecrets;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureBotFacebookShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings SetSubscription(this AzureBotFacebookShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings ResetSubscription(this AzureBotFacebookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureBotFacebookShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings SetDebug(this AzureBotFacebookShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings ResetDebug(this AzureBotFacebookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureBotFacebookShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings SetHelp(this AzureBotFacebookShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings ResetHelp(this AzureBotFacebookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureBotFacebookShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings SetOutput(this AzureBotFacebookShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings ResetOutput(this AzureBotFacebookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureBotFacebookShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings SetQuery(this AzureBotFacebookShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings ResetQuery(this AzureBotFacebookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureBotFacebookShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings SetVerbose(this AzureBotFacebookShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureBotFacebookShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureBotFacebookShowSettings ResetVerbose(this AzureBotFacebookShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region BotCreateKind
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class BotCreateKind : Enumeration
    {
        public static BotCreateKind function = new BotCreateKind { Value = "function" };
        public static BotCreateKind registration = new BotCreateKind { Value = "registration" };
        public static BotCreateKind webapp = new BotCreateKind { Value = "webapp" };
    }
    #endregion
    #region BotCreateSku
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class BotCreateSku : Enumeration
    {
        public static BotCreateSku f0 = new BotCreateSku { Value = "f0" };
        public static BotCreateSku s1 = new BotCreateSku { Value = "s1" };
    }
    #endregion
    #region BotCreateInsightsLocation
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class BotCreateInsightsLocation : Enumeration
    {
        public static BotCreateInsightsLocation east_us = new BotCreateInsightsLocation { Value = "east us" };
        public static BotCreateInsightsLocation north_europe = new BotCreateInsightsLocation { Value = "north europe" };
        public static BotCreateInsightsLocation south_central_us = new BotCreateInsightsLocation { Value = "south central us" };
        public static BotCreateInsightsLocation southeast_asia = new BotCreateInsightsLocation { Value = "southeast asia" };
        public static BotCreateInsightsLocation west_europe = new BotCreateInsightsLocation { Value = "west europe" };
        public static BotCreateInsightsLocation west_us_2 = new BotCreateInsightsLocation { Value = "west us 2" };
    }
    #endregion
    #region BotCreateLang
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class BotCreateLang : Enumeration
    {
        public static BotCreateLang csharp = new BotCreateLang { Value = "csharp" };
        public static BotCreateLang node = new BotCreateLang { Value = "node" };
    }
    #endregion
    #region BotVersion
    /// <summary><p>Used within <see cref="AzureBotTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class BotVersion : Enumeration
    {
        public static BotVersion v3 = new BotVersion { Value = "v3" };
        public static BotVersion v4 = new BotVersion { Value = "v4" };
    }
    #endregion
}
