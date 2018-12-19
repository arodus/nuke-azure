// Copyright 2018 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

// Generated with Nuke.CodeGeneration, Version: 0.7.0 [CommitSha: 9d3d3d7e].
// Generated from https://github.com/nuke-build/azure/blob/master/src/Nuke.Azure/specifications/AzureAd.json.

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
    public static partial class AzureAdTasks
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public static string AzureAdPath => ToolPathResolver.GetPathExecutable("az");
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p></summary>
        public static IReadOnlyCollection<Output> AzureAd(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool logOutput = true, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(AzureAdPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, null, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAd(Configure<AzureAdSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSignedInUserListOwnedObjects(Configure<AzureAdSignedInUserListOwnedObjectsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSignedInUserListOwnedObjectsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSignedInUserShow(Configure<AzureAdSignedInUserShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSignedInUserShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdUserCreate(Configure<AzureAdUserCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdUserCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdUserDelete(Configure<AzureAdUserDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdUserDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdUserGetMemberGroups(Configure<AzureAdUserGetMemberGroupsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdUserGetMemberGroupsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdUserList(Configure<AzureAdUserListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdUserListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdUserShow(Configure<AzureAdUserShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdUserShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppCreate(Configure<AzureAdAppCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppDelete(Configure<AzureAdAppDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppList(Configure<AzureAdAppListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppShow(Configure<AzureAdAppShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppUpdate(Configure<AzureAdAppUpdateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppUpdateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupCreate(Configure<AzureAdGroupCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupDelete(Configure<AzureAdGroupDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupGetMemberGroups(Configure<AzureAdGroupGetMemberGroupsSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupGetMemberGroupsSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupList(Configure<AzureAdGroupListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupShow(Configure<AzureAdGroupShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpCreate(Configure<AzureAdSpCreateSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpCreateSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpCreateForRbac(Configure<AzureAdSpCreateForRbacSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpCreateForRbacSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpDelete(Configure<AzureAdSpDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpList(Configure<AzureAdSpListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpShow(Configure<AzureAdSpShowSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpShowSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionAdd(Configure<AzureAdAppPermissionAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppPermissionAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionDelete(Configure<AzureAdAppPermissionDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppPermissionDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionGrant(Configure<AzureAdAppPermissionGrantSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppPermissionGrantSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppPermissionList(Configure<AzureAdAppPermissionListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppPermissionListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppCredentialDelete(Configure<AzureAdAppCredentialDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppCredentialDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppCredentialList(Configure<AzureAdAppCredentialListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppCredentialListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppCredentialReset(Configure<AzureAdAppCredentialResetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppCredentialResetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppOwnerAdd(Configure<AzureAdAppOwnerAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppOwnerAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppOwnerList(Configure<AzureAdAppOwnerListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppOwnerListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdAppOwnerRemove(Configure<AzureAdAppOwnerRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdAppOwnerRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpCredentialDelete(Configure<AzureAdSpCredentialDeleteSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpCredentialDeleteSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpCredentialList(Configure<AzureAdSpCredentialListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpCredentialListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpCredentialReset(Configure<AzureAdSpCredentialResetSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpCredentialResetSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdSpOwnerList(Configure<AzureAdSpOwnerListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdSpOwnerListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberAdd(Configure<AzureAdGroupMemberAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupMemberAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberCheck(Configure<AzureAdGroupMemberCheckSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupMemberCheckSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberList(Configure<AzureAdGroupMemberListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupMemberListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupMemberRemove(Configure<AzureAdGroupMemberRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupMemberRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupOwnerAdd(Configure<AzureAdGroupOwnerAddSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupOwnerAddSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupOwnerList(Configure<AzureAdGroupOwnerListSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupOwnerListSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary><p>Manage Azure Active Directory Graph entities needed for Role Based Access Control.</p><p>For more details, visit the <a href="https://docs.microsoft.com/en-us/cli/azure/ad?view=azure-cli-latest">official website</a>.</p></summary>
        public static IReadOnlyCollection<Output> AzureAdGroupOwnerRemove(Configure<AzureAdGroupOwnerRemoveSettings> configurator = null)
        {
            var toolSettings = configurator.InvokeSafe(new AzureAdGroupOwnerRemoveSettings());
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
    }
    #region AzureAdSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
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
              .Add("ad")
              .Add("--debug {value}", Debug)
              .Add("--help {value}", Help)
              .Add("--output {value}", Output)
              .Add("--query {value}", Query)
              .Add("--verbose {value}", Verbose);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region AzureAdSignedInUserListOwnedObjectsSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSignedInUserListOwnedObjectsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Object type filter, e.g. "application", "servicePrincipal"  "group", etc.</p></summary>
        public virtual string Type { get; internal set; }
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
              .Add("ad signed-in-user list-owned-objects")
              .Add("--type {value}", Type)
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
    #region AzureAdSignedInUserShowSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSignedInUserShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
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
              .Add("ad signed-in-user show")
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
    #region AzureAdUserCreateSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdUserCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Object's display name or its prefix.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p></p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Required. The user principal name (someuser@contoso.com). It must contain one of the verified domains for the tenant.</p></summary>
        public virtual string UserPrincipalName { get; internal set; }
        /// <summary><p></p></summary>
        public virtual bool? ForceChangePasswordNextLogin { get; internal set; }
        /// <summary><p>This must be specified if you are using a federated domain for the user's userPrincipalName (UPN) property when creating a new user account. It is used to associate an on-premises Active Directory user account with their Azure AD user object.</p></summary>
        public virtual string ImmutableId { get; internal set; }
        /// <summary><p>Mail alias. Defaults to user principal name.</p></summary>
        public virtual string MailNickname { get; internal set; }
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
              .Add("ad user create")
              .Add("--display-name {value}", DisplayName)
              .Add("--password {value}", Password, secret: true)
              .Add("--user-principal-name {value}", UserPrincipalName)
              .Add("--force-change-password-next-login", ForceChangePasswordNextLogin, secret: true)
              .Add("--immutable-id {value}", ImmutableId)
              .Add("--mail-nickname {value}", MailNickname)
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
    #region AzureAdUserDeleteSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdUserDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>The object ID or principal name of the user to delete.</p></summary>
        public virtual string UpnOrObjectId { get; internal set; }
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
              .Add("ad user delete")
              .Add("--upn-or-object-id {value}", UpnOrObjectId)
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
    #region AzureAdUserGetMemberGroupsSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdUserGetMemberGroupsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>The object ID or principal name of the user for which to get information.</p></summary>
        public virtual string UpnOrObjectId { get; internal set; }
        /// <summary><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        public virtual bool? SecurityEnabledOnly { get; internal set; }
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
              .Add("ad user get-member-groups")
              .Add("--upn-or-object-id {value}", UpnOrObjectId)
              .Add("--security-enabled-only", SecurityEnabledOnly)
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
    #region AzureAdUserListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdUserListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Object's display name or its prefix.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>OData filter.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>User principal name, e.g. john.doe@contoso.com.</p></summary>
        public virtual string Upn { get; internal set; }
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
              .Add("ad user list")
              .Add("--display-name {value}", DisplayName)
              .Add("--filter {value}", Filter)
              .Add("--upn {value}", Upn)
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
    #region AzureAdUserShowSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdUserShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>The object ID or principal name of the user for which to get information.</p></summary>
        public virtual string UpnOrObjectId { get; internal set; }
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
              .Add("ad user show")
              .Add("--upn-or-object-id {value}", UpnOrObjectId)
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
    #region AzureAdAppCreateSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>The display name of the application.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>The application can be used from any Azure AD tenants.</p></summary>
        public virtual bool? AvailableToOtherTenants { get; internal set; }
        /// <summary><p>The description of the password.</p></summary>
        public virtual string CredentialDescription { get; internal set; }
        /// <summary><p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p></summary>
        public virtual string EndDate { get; internal set; }
        /// <summary><p>The url where users can sign in and use your app.</p></summary>
        public virtual string Homepage { get; internal set; }
        /// <summary><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        public virtual IReadOnlyList<string> IdentifierUris => IdentifierUrisInternal.AsReadOnly();
        internal List<string> IdentifierUrisInternal { get; set; } = new List<string>();
        /// <summary><p>The type of the key credentials associated with the application.</p></summary>
        public virtual AdAppKeyType KeyType { get; internal set; }
        /// <summary><p>The usage of the key credentials associated with the application.</p></summary>
        public virtual AdAppKeyUsage KeyUsage { get; internal set; }
        /// <summary><p>The value for the key credentials associated with the application.</p></summary>
        public virtual string KeyValue { get; internal set; }
        /// <summary><p>An application which can be installed on a user's device or computer.</p></summary>
        public virtual bool? NativeApp { get; internal set; }
        /// <summary><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        public virtual bool? Oauth2AllowImplicitFlow { get; internal set; }
        /// <summary><p>App password, aka 'client secret'.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        public virtual IReadOnlyList<string> ReplyUrls => ReplyUrlsInternal.AsReadOnly();
        internal List<string> ReplyUrlsInternal { get; set; } = new List<string>();
        /// <summary><p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p></summary>
        public virtual string RequiredResourceAccesses { get; internal set; }
        /// <summary><p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p></summary>
        public virtual string StartDate { get; internal set; }
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
              .Add("ad app create")
              .Add("--display-name {value}", DisplayName)
              .Add("--available-to-other-tenants", AvailableToOtherTenants)
              .Add("--credential-description {value}", CredentialDescription)
              .Add("--end-date {value}", EndDate)
              .Add("--homepage {value}", Homepage)
              .Add("--identifier-uris {value}", IdentifierUris, separator: ' ')
              .Add("--key-type {value}", KeyType)
              .Add("--key-usage {value}", KeyUsage)
              .Add("--key-value {value}", KeyValue)
              .Add("--native-app", NativeApp)
              .Add("--oauth2-allow-implicit-flow", Oauth2AllowImplicitFlow)
              .Add("--password {value}", Password, secret: true)
              .Add("--reply-urls {value}", ReplyUrls, separator: ' ')
              .Add("--required-resource-accesses {value}", RequiredResourceAccesses)
              .Add("--start-date {value}", StartDate)
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
    #region AzureAdAppDeleteSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app delete")
              .Add("--id {value}", Id)
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
    #region AzureAdAppListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Application id.</p></summary>
        public virtual string AppId { get; internal set; }
        /// <summary><p>The display name of the application.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>OData filter.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>Graph application identifier, must be in uri format.</p></summary>
        public virtual string IdentifierUri { get; internal set; }
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
              .Add("ad app list")
              .Add("--app-id {value}", AppId)
              .Add("--display-name {value}", DisplayName)
              .Add("--filter {value}", Filter)
              .Add("--identifier-uri {value}", IdentifierUri)
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
    #region AzureAdAppShowSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app show")
              .Add("--id {value}", Id)
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
    #region AzureAdAppUpdateSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppUpdateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id.</p></summary>
        public virtual string Id { get; internal set; }
        /// <summary><p>The application can be used from any Azure AD tenants.</p></summary>
        public virtual bool? AvailableToOtherTenants { get; internal set; }
        /// <summary><p>The display name of the application.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p></summary>
        public virtual string EndDate { get; internal set; }
        /// <summary><p>The url where users can sign in and use your app.</p></summary>
        public virtual string Homepage { get; internal set; }
        /// <summary><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        public virtual IReadOnlyList<string> IdentifierUris => IdentifierUrisInternal.AsReadOnly();
        internal List<string> IdentifierUrisInternal { get; set; } = new List<string>();
        /// <summary><p>The type of the key credentials associated with the application.</p></summary>
        public virtual AdAppKeyType KeyType { get; internal set; }
        /// <summary><p>The usage of the key credentials associated with the application.</p></summary>
        public virtual AdAppKeyUsage KeyUsage { get; internal set; }
        /// <summary><p>The value for the key credentials associated with the application.</p></summary>
        public virtual string KeyValue { get; internal set; }
        /// <summary><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        public virtual bool? Oauth2AllowImplicitFlow { get; internal set; }
        /// <summary><p>App password, aka 'client secret'.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        public virtual IReadOnlyList<string> ReplyUrls => ReplyUrlsInternal.AsReadOnly();
        internal List<string> ReplyUrlsInternal { get; set; } = new List<string>();
        /// <summary><p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p></summary>
        public virtual string RequiredResourceAccesses { get; internal set; }
        /// <summary><p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p></summary>
        public virtual string StartDate { get; internal set; }
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
              .Add("ad app update")
              .Add("--id {value}", Id)
              .Add("--available-to-other-tenants", AvailableToOtherTenants)
              .Add("--display-name {value}", DisplayName)
              .Add("--end-date {value}", EndDate)
              .Add("--homepage {value}", Homepage)
              .Add("--identifier-uris {value}", IdentifierUris, separator: ' ')
              .Add("--key-type {value}", KeyType)
              .Add("--key-usage {value}", KeyUsage)
              .Add("--key-value {value}", KeyValue)
              .Add("--oauth2-allow-implicit-flow", Oauth2AllowImplicitFlow)
              .Add("--password {value}", Password, secret: true)
              .Add("--reply-urls {value}", ReplyUrls, separator: ' ')
              .Add("--required-resource-accesses {value}", RequiredResourceAccesses)
              .Add("--start-date {value}", StartDate)
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
    #region AzureAdGroupCreateSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Object's display name or its prefix.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>Mail nickname.</p></summary>
        public virtual string MailNickname { get; internal set; }
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
              .Add("ad group create")
              .Add("--display-name {value}", DisplayName)
              .Add("--mail-nickname {value}", MailNickname)
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
    #region AzureAdGroupDeleteSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
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
              .Add("ad group delete")
              .Add("--group {value}", Group)
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
    #region AzureAdGroupGetMemberGroupsSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupGetMemberGroupsSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
        /// <summary><p>Unmatched properties from the message are deserialized this collection.</p></summary>
        public virtual string AdditionalProperties { get; internal set; }
        /// <summary><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        public virtual bool? SecurityEnabledOnly { get; internal set; }
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
              .Add("ad group get-member-groups")
              .Add("--group {value}", Group)
              .Add("--additional-properties {value}", AdditionalProperties)
              .Add("--security-enabled-only", SecurityEnabledOnly)
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
    #region AzureAdGroupListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Object's display name or its prefix.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>OData filter.</p></summary>
        public virtual string Filter { get; internal set; }
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
              .Add("ad group list")
              .Add("--display-name {value}", DisplayName)
              .Add("--filter {value}", Filter)
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
    #region AzureAdGroupShowSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
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
              .Add("ad group show")
              .Add("--group {value}", Group)
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
    #region AzureAdSpCreateSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCreateSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id of the associated application.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad sp create")
              .Add("--id {value}", Id)
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
    #region AzureAdSpCreateForRbacSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCreateForRbacSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>A URI to use as the logic name. It doesn't need to exist. If not present, CLI will generate one.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Role of the service principal.</p></summary>
        public virtual string Role { get; internal set; }
        /// <summary><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        public virtual IReadOnlyList<string> Scopes => ScopesInternal.AsReadOnly();
        internal List<string> ScopesInternal { get; set; } = new List<string>();
        /// <summary><p>Output result in compatible with Azure SDK auth file.</p></summary>
        public virtual bool? SdkAuth { get; internal set; }
        /// <summary><p>Do not create default assignment.</p></summary>
        public virtual bool? SkipAssignment { get; internal set; }
        /// <summary><p>Certificate to use for credentials.</p></summary>
        public virtual string Cert { get; internal set; }
        /// <summary><p>Create a self-signed certificate to use for the credential.</p></summary>
        public virtual string CreateCert { get; internal set; }
        /// <summary><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        public virtual string Keyvault { get; internal set; }
        /// <summary><p>The password used to log in.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Number of years for which the credentials will be valid. Default: 1 year.</p></summary>
        public virtual int? Years { get; internal set; }
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
              .Add("ad sp create-for-rbac")
              .Add("--name {value}", Name)
              .Add("--role {value}", Role)
              .Add("--scopes {value}", Scopes, separator: ' ')
              .Add("--sdk-auth", SdkAuth)
              .Add("--skip-assignment", SkipAssignment)
              .Add("--cert {value}", Cert)
              .Add("--create-cert {value}", CreateCert)
              .Add("--keyvault {value}", Keyvault)
              .Add("--password {value}", Password, secret: true)
              .Add("--years {value}", Years)
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
    #region AzureAdSpDeleteSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Service principal name, or object id.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad sp delete")
              .Add("--id {value}", Id)
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
    #region AzureAdSpListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Object's display name or its prefix.</p></summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary><p>OData filter.</p></summary>
        public virtual string Filter { get; internal set; }
        /// <summary><p>Service principal name.</p></summary>
        public virtual string Spn { get; internal set; }
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
              .Add("ad sp list")
              .Add("--display-name {value}", DisplayName)
              .Add("--filter {value}", Filter)
              .Add("--spn {value}", Spn)
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
    #region AzureAdSpShowSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpShowSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Service principal name, or object id.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad sp show")
              .Add("--id {value}", Id)
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
    #region AzureAdAppPermissionAddSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppPermissionAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>The target API to access.</p></summary>
        public virtual string Api { get; internal set; }
        /// <summary><p>Space seperated list of &lt;resource-access-id&gt;=&lt;type&gt;.</p></summary>
        public virtual string ApiPermissions { get; internal set; }
        /// <summary><p>Identifier uri, application id, or object id.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app permission add")
              .Add("--api {value}", Api)
              .Add("--api-permissions {value}", ApiPermissions)
              .Add("--id {value}", Id)
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
    #region AzureAdAppPermissionDeleteSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppPermissionDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>The target API to access.</p></summary>
        public virtual string Api { get; internal set; }
        /// <summary><p>Identifier uri, application id, or object id.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app permission delete")
              .Add("--api {value}", Api)
              .Add("--id {value}", Id)
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
    #region AzureAdAppPermissionGrantSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppPermissionGrantSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>The target API to access.</p></summary>
        public virtual string Api { get; internal set; }
        /// <summary><p>Identifier uri, application id, or object id.</p></summary>
        public virtual string Id { get; internal set; }
        /// <summary><p>Expiry date for the permissions in years. e.g. 1, 2 or "never".</p></summary>
        public virtual string Expires { get; internal set; }
        /// <summary><p>Oauth scope.</p></summary>
        public virtual string Scope { get; internal set; }
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
              .Add("ad app permission grant")
              .Add("--api {value}", Api)
              .Add("--id {value}", Id)
              .Add("--expires {value}", Expires)
              .Add("--scope {value}", Scope)
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
    #region AzureAdAppPermissionListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppPermissionListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id of the associated application.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app permission list")
              .Add("--id {value}", Id)
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
    #region AzureAdAppCredentialDeleteSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppCredentialDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id.</p></summary>
        public virtual string Id { get; internal set; }
        /// <summary><p>Credential key id.</p></summary>
        public virtual string KeyId { get; internal set; }
        /// <summary><p>A certificate based credential.</p></summary>
        public virtual string Cert { get; internal set; }
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
              .Add("ad app credential delete")
              .Add("--id {value}", Id)
              .Add("--key-id {value}", KeyId)
              .Add("--cert {value}", Cert)
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
    #region AzureAdAppCredentialListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppCredentialListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id.</p></summary>
        public virtual string Id { get; internal set; }
        /// <summary><p>A certificate based credential.</p></summary>
        public virtual string Cert { get; internal set; }
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
              .Add("ad app credential list")
              .Add("--id {value}", Id)
              .Add("--cert {value}", Cert)
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
    #region AzureAdAppCredentialResetSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppCredentialResetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id.</p></summary>
        public virtual string Id { get; internal set; }
        /// <summary><p>Append the new credential instead of overwriting.</p></summary>
        public virtual string Append { get; internal set; }
        /// <summary><p>The description of the password.</p></summary>
        public virtual string CredentialDescription { get; internal set; }
        /// <summary><p>Certificate to use for credentials.</p></summary>
        public virtual string Cert { get; internal set; }
        /// <summary><p>Create a self-signed certificate to use for the credential.</p></summary>
        public virtual string CreateCert { get; internal set; }
        /// <summary><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        public virtual string Keyvault { get; internal set; }
        /// <summary><p>App password, aka 'client secret'.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Number of years for which the credentials will be valid.</p></summary>
        public virtual int? Years { get; internal set; }
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
              .Add("ad app credential reset")
              .Add("--id {value}", Id)
              .Add("--append {value}", Append)
              .Add("--credential-description {value}", CredentialDescription)
              .Add("--cert {value}", Cert)
              .Add("--create-cert {value}", CreateCert)
              .Add("--keyvault {value}", Keyvault)
              .Add("--password {value}", Password, secret: true)
              .Add("--years {value}", Years)
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
    #region AzureAdAppOwnerAddSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppOwnerAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id.</p></summary>
        public virtual string Id { get; internal set; }
        /// <summary><p>Owner's object id.</p></summary>
        public virtual string OwnerObjectId { get; internal set; }
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
              .Add("ad app owner add")
              .Add("--id {value}", Id)
              .Add("--owner-object-id {value}", OwnerObjectId)
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
    #region AzureAdAppOwnerListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppOwnerListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id of the application.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad app owner list")
              .Add("--id {value}", Id)
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
    #region AzureAdAppOwnerRemoveSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdAppOwnerRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Identifier uri, application id, or object id.</p></summary>
        public virtual string Id { get; internal set; }
        /// <summary><p>Owner's object id.</p></summary>
        public virtual string OwnerObjectId { get; internal set; }
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
              .Add("ad app owner remove")
              .Add("--id {value}", Id)
              .Add("--owner-object-id {value}", OwnerObjectId)
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
    #region AzureAdSpCredentialDeleteSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCredentialDeleteSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Service principal name, or object id.</p></summary>
        public virtual string Id { get; internal set; }
        /// <summary><p>Credential key id.</p></summary>
        public virtual string KeyId { get; internal set; }
        /// <summary><p>A certificate based credential.</p></summary>
        public virtual string Cert { get; internal set; }
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
              .Add("ad sp credential delete")
              .Add("--id {value}", Id)
              .Add("--key-id {value}", KeyId)
              .Add("--cert {value}", Cert)
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
    #region AzureAdSpCredentialListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCredentialListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Service principal name, or object id.</p></summary>
        public virtual string Id { get; internal set; }
        /// <summary><p>A certificate based credential.</p></summary>
        public virtual string Cert { get; internal set; }
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
              .Add("ad sp credential list")
              .Add("--id {value}", Id)
              .Add("--cert {value}", Cert)
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
    #region AzureAdSpCredentialResetSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpCredentialResetSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Name or app URI for the credential.</p></summary>
        public virtual string Name { get; internal set; }
        /// <summary><p>Append the new credential instead of overwriting.</p></summary>
        public virtual string Append { get; internal set; }
        /// <summary><p>Certificate to use for credentials.</p></summary>
        public virtual string Cert { get; internal set; }
        /// <summary><p>Create a self-signed certificate to use for the credential.</p></summary>
        public virtual string CreateCert { get; internal set; }
        /// <summary><p>The description of the password.</p></summary>
        public virtual string CredentialDescription { get; internal set; }
        /// <summary><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        public virtual string Keyvault { get; internal set; }
        /// <summary><p>The password used to log in.</p></summary>
        public virtual string Password { get; internal set; }
        /// <summary><p>Number of years for which the credentials will be valid. Default: 1 year.</p></summary>
        public virtual int? Years { get; internal set; }
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
              .Add("ad sp credential reset")
              .Add("--name {value}", Name)
              .Add("--append {value}", Append)
              .Add("--cert {value}", Cert)
              .Add("--create-cert {value}", CreateCert)
              .Add("--credential-description {value}", CredentialDescription)
              .Add("--keyvault {value}", Keyvault)
              .Add("--password {value}", Password, secret: true)
              .Add("--years {value}", Years)
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
    #region AzureAdSpOwnerListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdSpOwnerListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Service principal name, or object id or the service principal.</p></summary>
        public virtual string Id { get; internal set; }
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
              .Add("ad sp owner list")
              .Add("--id {value}", Id)
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
    #region AzureAdGroupMemberAddSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupMemberAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
        /// <summary><p>The object ID of the contact, group, user, or service principal.</p></summary>
        public virtual string MemberId { get; internal set; }
        /// <summary><p>Unmatched properties from the message are deserialized this collection.</p></summary>
        public virtual string AdditionalProperties { get; internal set; }
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
              .Add("ad group member add")
              .Add("--group {value}", Group)
              .Add("--member-id {value}", MemberId)
              .Add("--additional-properties {value}", AdditionalProperties)
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
    #region AzureAdGroupMemberCheckSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupMemberCheckSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
        /// <summary><p>The object ID of the contact, group, user, or service principal.</p></summary>
        public virtual string MemberId { get; internal set; }
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
              .Add("ad group member check")
              .Add("--group {value}", Group)
              .Add("--member-id {value}", MemberId)
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
    #region AzureAdGroupMemberListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupMemberListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
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
              .Add("ad group member list")
              .Add("--group {value}", Group)
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
    #region AzureAdGroupMemberRemoveSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupMemberRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
        /// <summary><p>The object ID of the contact, group, user, or service principal.</p></summary>
        public virtual string MemberId { get; internal set; }
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
              .Add("ad group member remove")
              .Add("--group {value}", Group)
              .Add("--member-id {value}", MemberId)
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
    #region AzureAdGroupOwnerAddSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupOwnerAddSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
        /// <summary><p>Owner's object id.</p></summary>
        public virtual string OwnerObjectId { get; internal set; }
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
              .Add("ad group owner add")
              .Add("--group {value}", Group)
              .Add("--owner-object-id {value}", OwnerObjectId)
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
    #region AzureAdGroupOwnerListSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupOwnerListSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
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
              .Add("ad group owner list")
              .Add("--group {value}", Group)
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
    #region AzureAdGroupOwnerRemoveSettings
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AzureAdGroupOwnerRemoveSettings : ToolSettings
    {
        /// <summary><p>Path to the AzureAd executable.</p></summary>
        public override string ToolPath => base.ToolPath ?? AzureAdTasks.AzureAdPath;
        /// <summary><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        public virtual string Group { get; internal set; }
        /// <summary><p>Owner's object id.</p></summary>
        public virtual string OwnerObjectId { get; internal set; }
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
              .Add("ad group owner remove")
              .Add("--group {value}", Group)
              .Add("--owner-object-id {value}", OwnerObjectId)
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
    #region AzureAdSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSettingsExtensions
    {
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSettings SetDebug(this AzureAdSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSettings ResetDebug(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSettings SetHelp(this AzureAdSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSettings ResetHelp(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSettings SetOutput(this AzureAdSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSettings ResetOutput(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSettings SetQuery(this AzureAdSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSettings ResetQuery(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSettings SetVerbose(this AzureAdSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSettings ResetVerbose(this AzureAdSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSignedInUserListOwnedObjectsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSignedInUserListOwnedObjectsSettingsExtensions
    {
        #region Type
        /// <summary><p><em>Sets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Type"/>.</em></p><p>Object type filter, e.g. "application", "servicePrincipal"  "group", etc.</p></summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings SetType(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings, string type)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = type;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Type"/>.</em></p><p>Object type filter, e.g. "application", "servicePrincipal"  "group", etc.</p></summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings ResetType(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Type = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings SetSubscription(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings ResetSubscription(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings SetDebug(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings ResetDebug(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings SetHelp(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings ResetHelp(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings SetOutput(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings ResetOutput(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings SetQuery(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings ResetQuery(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings SetVerbose(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSignedInUserListOwnedObjectsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSignedInUserListOwnedObjectsSettings ResetVerbose(this AzureAdSignedInUserListOwnedObjectsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSignedInUserShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSignedInUserShowSettingsExtensions
    {
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdSignedInUserShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings SetSubscription(this AzureAdSignedInUserShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSignedInUserShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings ResetSubscription(this AzureAdSignedInUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSignedInUserShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings SetDebug(this AzureAdSignedInUserShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSignedInUserShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings ResetDebug(this AzureAdSignedInUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSignedInUserShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings SetHelp(this AzureAdSignedInUserShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSignedInUserShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings ResetHelp(this AzureAdSignedInUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSignedInUserShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings SetOutput(this AzureAdSignedInUserShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSignedInUserShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings ResetOutput(this AzureAdSignedInUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSignedInUserShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings SetQuery(this AzureAdSignedInUserShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSignedInUserShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings ResetQuery(this AzureAdSignedInUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSignedInUserShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings SetVerbose(this AzureAdSignedInUserShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSignedInUserShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSignedInUserShowSettings ResetVerbose(this AzureAdSignedInUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdUserCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdUserCreateSettingsExtensions
    {
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetDisplayName(this AzureAdUserCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetDisplayName(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.Password"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetPassword(this AzureAdUserCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.Password"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetPassword(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region UserPrincipalName
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.UserPrincipalName"/>.</em></p><p>Required. The user principal name (someuser@contoso.com). It must contain one of the verified domains for the tenant.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetUserPrincipalName(this AzureAdUserCreateSettings toolSettings, string userPrincipalName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserPrincipalName = userPrincipalName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.UserPrincipalName"/>.</em></p><p>Required. The user principal name (someuser@contoso.com). It must contain one of the verified domains for the tenant.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetUserPrincipalName(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UserPrincipalName = null;
            return toolSettings;
        }
        #endregion
        #region ForceChangePasswordNextLogin
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings, bool? forceChangePasswordNextLogin)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = forceChangePasswordNextLogin;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdUserCreateSettings EnableForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdUserCreateSettings DisableForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdUserCreateSettings.ForceChangePasswordNextLogin"/>.</em></p><p></p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ToggleForceChangePasswordNextLogin(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceChangePasswordNextLogin = !toolSettings.ForceChangePasswordNextLogin;
            return toolSettings;
        }
        #endregion
        #region ImmutableId
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.ImmutableId"/>.</em></p><p>This must be specified if you are using a federated domain for the user's userPrincipalName (UPN) property when creating a new user account. It is used to associate an on-premises Active Directory user account with their Azure AD user object.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetImmutableId(this AzureAdUserCreateSettings toolSettings, string immutableId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImmutableId = immutableId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.ImmutableId"/>.</em></p><p>This must be specified if you are using a federated domain for the user's userPrincipalName (UPN) property when creating a new user account. It is used to associate an on-premises Active Directory user account with their Azure AD user object.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetImmutableId(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImmutableId = null;
            return toolSettings;
        }
        #endregion
        #region MailNickname
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.MailNickname"/>.</em></p><p>Mail alias. Defaults to user principal name.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetMailNickname(this AzureAdUserCreateSettings toolSettings, string mailNickname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MailNickname = mailNickname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.MailNickname"/>.</em></p><p>Mail alias. Defaults to user principal name.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetMailNickname(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MailNickname = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetSubscription(this AzureAdUserCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetSubscription(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetDebug(this AzureAdUserCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetDebug(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetHelp(this AzureAdUserCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetHelp(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetOutput(this AzureAdUserCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetOutput(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetQuery(this AzureAdUserCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetQuery(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdUserCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings SetVerbose(this AzureAdUserCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserCreateSettings ResetVerbose(this AzureAdUserCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdUserDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdUserDeleteSettingsExtensions
    {
        #region UpnOrObjectId
        /// <summary><p><em>Sets <see cref="AzureAdUserDeleteSettings.UpnOrObjectId"/>.</em></p><p>The object ID or principal name of the user to delete.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetUpnOrObjectId(this AzureAdUserDeleteSettings toolSettings, string upnOrObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = upnOrObjectId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserDeleteSettings.UpnOrObjectId"/>.</em></p><p>The object ID or principal name of the user to delete.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetUpnOrObjectId(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdUserDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetSubscription(this AzureAdUserDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetSubscription(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdUserDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetDebug(this AzureAdUserDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetDebug(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdUserDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetHelp(this AzureAdUserDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetHelp(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdUserDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetOutput(this AzureAdUserDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetOutput(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdUserDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetQuery(this AzureAdUserDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetQuery(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdUserDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings SetVerbose(this AzureAdUserDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserDeleteSettings ResetVerbose(this AzureAdUserDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdUserGetMemberGroupsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdUserGetMemberGroupsSettingsExtensions
    {
        #region UpnOrObjectId
        /// <summary><p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.UpnOrObjectId"/>.</em></p><p>The object ID or principal name of the user for which to get information.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetUpnOrObjectId(this AzureAdUserGetMemberGroupsSettings toolSettings, string upnOrObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = upnOrObjectId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.UpnOrObjectId"/>.</em></p><p>The object ID or principal name of the user for which to get information.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetUpnOrObjectId(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = null;
            return toolSettings;
        }
        #endregion
        #region SecurityEnabledOnly
        /// <summary><p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetSecurityEnabledOnly(this AzureAdUserGetMemberGroupsSettings toolSettings, bool? securityEnabledOnly)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = securityEnabledOnly;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetSecurityEnabledOnly(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdUserGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings EnableSecurityEnabledOnly(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdUserGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings DisableSecurityEnabledOnly(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdUserGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ToggleSecurityEnabledOnly(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = !toolSettings.SecurityEnabledOnly;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetSubscription(this AzureAdUserGetMemberGroupsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetSubscription(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetDebug(this AzureAdUserGetMemberGroupsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetDebug(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetHelp(this AzureAdUserGetMemberGroupsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetHelp(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetOutput(this AzureAdUserGetMemberGroupsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetOutput(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetQuery(this AzureAdUserGetMemberGroupsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetQuery(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdUserGetMemberGroupsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings SetVerbose(this AzureAdUserGetMemberGroupsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserGetMemberGroupsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserGetMemberGroupsSettings ResetVerbose(this AzureAdUserGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdUserListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdUserListSettingsExtensions
    {
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetDisplayName(this AzureAdUserListSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetDisplayName(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetFilter(this AzureAdUserListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetFilter(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Upn
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Upn"/>.</em></p><p>User principal name, e.g. john.doe@contoso.com.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetUpn(this AzureAdUserListSettings toolSettings, string upn)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upn = upn;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Upn"/>.</em></p><p>User principal name, e.g. john.doe@contoso.com.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetUpn(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Upn = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetSubscription(this AzureAdUserListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetSubscription(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetDebug(this AzureAdUserListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetDebug(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetHelp(this AzureAdUserListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetHelp(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetOutput(this AzureAdUserListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetOutput(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetQuery(this AzureAdUserListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetQuery(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdUserListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserListSettings SetVerbose(this AzureAdUserListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserListSettings ResetVerbose(this AzureAdUserListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdUserShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdUserShowSettingsExtensions
    {
        #region UpnOrObjectId
        /// <summary><p><em>Sets <see cref="AzureAdUserShowSettings.UpnOrObjectId"/>.</em></p><p>The object ID or principal name of the user for which to get information.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings SetUpnOrObjectId(this AzureAdUserShowSettings toolSettings, string upnOrObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = upnOrObjectId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserShowSettings.UpnOrObjectId"/>.</em></p><p>The object ID or principal name of the user for which to get information.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings ResetUpnOrObjectId(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.UpnOrObjectId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdUserShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings SetSubscription(this AzureAdUserShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings ResetSubscription(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdUserShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings SetDebug(this AzureAdUserShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings ResetDebug(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdUserShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings SetHelp(this AzureAdUserShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings ResetHelp(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdUserShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings SetOutput(this AzureAdUserShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings ResetOutput(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdUserShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings SetQuery(this AzureAdUserShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings ResetQuery(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdUserShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings SetVerbose(this AzureAdUserShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdUserShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdUserShowSettings ResetVerbose(this AzureAdUserShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppCreateSettingsExtensions
    {
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.DisplayName"/>.</em></p><p>The display name of the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetDisplayName(this AzureAdAppCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.DisplayName"/>.</em></p><p>The display name of the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetDisplayName(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region AvailableToOtherTenants
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings, bool? availableToOtherTenants)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = availableToOtherTenants;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings EnableAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings DisableAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdAppCreateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ToggleAvailableToOtherTenants(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = !toolSettings.AvailableToOtherTenants;
            return toolSettings;
        }
        #endregion
        #region CredentialDescription
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.CredentialDescription"/>.</em></p><p>The description of the password.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetCredentialDescription(this AzureAdAppCreateSettings toolSettings, string credentialDescription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialDescription = credentialDescription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.CredentialDescription"/>.</em></p><p>The description of the password.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetCredentialDescription(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialDescription = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.EndDate"/>.</em></p><p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetEndDate(this AzureAdAppCreateSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.EndDate"/>.</em></p><p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetEndDate(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region Homepage
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Homepage"/>.</em></p><p>The url where users can sign in and use your app.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetHomepage(this AzureAdAppCreateSettings toolSettings, string homepage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Homepage = homepage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Homepage"/>.</em></p><p>The url where users can sign in and use your app.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetHomepage(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Homepage = null;
            return toolSettings;
        }
        #endregion
        #region IdentifierUris
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.IdentifierUris"/> to a new list.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetIdentifierUris(this AzureAdAppCreateSettings toolSettings, params string[] identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal = identifierUris.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.IdentifierUris"/> to a new list.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetIdentifierUris(this AzureAdAppCreateSettings toolSettings, IEnumerable<string> identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal = identifierUris.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAdAppCreateSettings.IdentifierUris"/>.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings AddIdentifierUris(this AzureAdAppCreateSettings toolSettings, params string[] identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal.AddRange(identifierUris);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAdAppCreateSettings.IdentifierUris"/>.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings AddIdentifierUris(this AzureAdAppCreateSettings toolSettings, IEnumerable<string> identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal.AddRange(identifierUris);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAdAppCreateSettings.IdentifierUris"/>.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ClearIdentifierUris(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAdAppCreateSettings.IdentifierUris"/>.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings RemoveIdentifierUris(this AzureAdAppCreateSettings toolSettings, params string[] identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(identifierUris);
            toolSettings.IdentifierUrisInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAdAppCreateSettings.IdentifierUris"/>.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings RemoveIdentifierUris(this AzureAdAppCreateSettings toolSettings, IEnumerable<string> identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(identifierUris);
            toolSettings.IdentifierUrisInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region KeyType
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.KeyType"/>.</em></p><p>The type of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetKeyType(this AzureAdAppCreateSettings toolSettings, AdAppKeyType keyType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = keyType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.KeyType"/>.</em></p><p>The type of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetKeyType(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = null;
            return toolSettings;
        }
        #endregion
        #region KeyUsage
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.KeyUsage"/>.</em></p><p>The usage of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetKeyUsage(this AzureAdAppCreateSettings toolSettings, AdAppKeyUsage keyUsage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyUsage = keyUsage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.KeyUsage"/>.</em></p><p>The usage of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetKeyUsage(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyUsage = null;
            return toolSettings;
        }
        #endregion
        #region KeyValue
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.KeyValue"/>.</em></p><p>The value for the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetKeyValue(this AzureAdAppCreateSettings toolSettings, string keyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = keyValue;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.KeyValue"/>.</em></p><p>The value for the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetKeyValue(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = null;
            return toolSettings;
        }
        #endregion
        #region NativeApp
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.NativeApp"/>.</em></p><p>An application which can be installed on a user's device or computer.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetNativeApp(this AzureAdAppCreateSettings toolSettings, bool? nativeApp)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = nativeApp;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.NativeApp"/>.</em></p><p>An application which can be installed on a user's device or computer.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetNativeApp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdAppCreateSettings.NativeApp"/>.</em></p><p>An application which can be installed on a user's device or computer.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings EnableNativeApp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdAppCreateSettings.NativeApp"/>.</em></p><p>An application which can be installed on a user's device or computer.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings DisableNativeApp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdAppCreateSettings.NativeApp"/>.</em></p><p>An application which can be installed on a user's device or computer.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ToggleNativeApp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NativeApp = !toolSettings.NativeApp;
            return toolSettings;
        }
        #endregion
        #region Oauth2AllowImplicitFlow
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings, bool? oauth2AllowImplicitFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = oauth2AllowImplicitFlow;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings EnableOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings DisableOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdAppCreateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ToggleOauth2AllowImplicitFlow(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = !toolSettings.Oauth2AllowImplicitFlow;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Password"/>.</em></p><p>App password, aka 'client secret'.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetPassword(this AzureAdAppCreateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Password"/>.</em></p><p>App password, aka 'client secret'.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetPassword(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ReplyUrls
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.ReplyUrls"/> to a new list.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetReplyUrls(this AzureAdAppCreateSettings toolSettings, params string[] replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal = replyUrls.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.ReplyUrls"/> to a new list.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetReplyUrls(this AzureAdAppCreateSettings toolSettings, IEnumerable<string> replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal = replyUrls.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAdAppCreateSettings.ReplyUrls"/>.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings AddReplyUrls(this AzureAdAppCreateSettings toolSettings, params string[] replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal.AddRange(replyUrls);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAdAppCreateSettings.ReplyUrls"/>.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings AddReplyUrls(this AzureAdAppCreateSettings toolSettings, IEnumerable<string> replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal.AddRange(replyUrls);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAdAppCreateSettings.ReplyUrls"/>.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ClearReplyUrls(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAdAppCreateSettings.ReplyUrls"/>.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings RemoveReplyUrls(this AzureAdAppCreateSettings toolSettings, params string[] replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(replyUrls);
            toolSettings.ReplyUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAdAppCreateSettings.ReplyUrls"/>.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings RemoveReplyUrls(this AzureAdAppCreateSettings toolSettings, IEnumerable<string> replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(replyUrls);
            toolSettings.ReplyUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region RequiredResourceAccesses
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.RequiredResourceAccesses"/>.</em></p><p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetRequiredResourceAccesses(this AzureAdAppCreateSettings toolSettings, string requiredResourceAccesses)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiredResourceAccesses = requiredResourceAccesses;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.RequiredResourceAccesses"/>.</em></p><p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetRequiredResourceAccesses(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiredResourceAccesses = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.StartDate"/>.</em></p><p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetStartDate(this AzureAdAppCreateSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.StartDate"/>.</em></p><p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetStartDate(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetSubscription(this AzureAdAppCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetSubscription(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetDebug(this AzureAdAppCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetDebug(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetHelp(this AzureAdAppCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetHelp(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetOutput(this AzureAdAppCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetOutput(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetQuery(this AzureAdAppCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetQuery(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings SetVerbose(this AzureAdAppCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCreateSettings ResetVerbose(this AzureAdAppCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppDeleteSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppDeleteSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetId(this AzureAdAppDeleteSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppDeleteSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetId(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetSubscription(this AzureAdAppDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetSubscription(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetDebug(this AzureAdAppDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetDebug(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetHelp(this AzureAdAppDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetHelp(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetOutput(this AzureAdAppDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetOutput(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetQuery(this AzureAdAppDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetQuery(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings SetVerbose(this AzureAdAppDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppDeleteSettings ResetVerbose(this AzureAdAppDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppListSettingsExtensions
    {
        #region AppId
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.AppId"/>.</em></p><p>Application id.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetAppId(this AzureAdAppListSettings toolSettings, string appId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppId = appId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.AppId"/>.</em></p><p>Application id.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetAppId(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AppId = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.DisplayName"/>.</em></p><p>The display name of the application.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetDisplayName(this AzureAdAppListSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.DisplayName"/>.</em></p><p>The display name of the application.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetDisplayName(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetFilter(this AzureAdAppListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetFilter(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region IdentifierUri
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.IdentifierUri"/>.</em></p><p>Graph application identifier, must be in uri format.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetIdentifierUri(this AzureAdAppListSettings toolSettings, string identifierUri)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUri = identifierUri;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.IdentifierUri"/>.</em></p><p>Graph application identifier, must be in uri format.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetIdentifierUri(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUri = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetSubscription(this AzureAdAppListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetSubscription(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetDebug(this AzureAdAppListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetDebug(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetHelp(this AzureAdAppListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetHelp(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetOutput(this AzureAdAppListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetOutput(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetQuery(this AzureAdAppListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetQuery(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppListSettings SetVerbose(this AzureAdAppListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppListSettings ResetVerbose(this AzureAdAppListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppShowSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppShowSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings SetId(this AzureAdAppShowSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppShowSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings ResetId(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings SetSubscription(this AzureAdAppShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings ResetSubscription(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings SetDebug(this AzureAdAppShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings ResetDebug(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings SetHelp(this AzureAdAppShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings ResetHelp(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings SetOutput(this AzureAdAppShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings ResetOutput(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings SetQuery(this AzureAdAppShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings ResetQuery(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings SetVerbose(this AzureAdAppShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppShowSettings ResetVerbose(this AzureAdAppShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppUpdateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppUpdateSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetId(this AzureAdAppUpdateSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetId(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region AvailableToOtherTenants
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings, bool? availableToOtherTenants)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = availableToOtherTenants;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings EnableAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings DisableAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdAppUpdateSettings.AvailableToOtherTenants"/>.</em></p><p>The application can be used from any Azure AD tenants.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ToggleAvailableToOtherTenants(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AvailableToOtherTenants = !toolSettings.AvailableToOtherTenants;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.DisplayName"/>.</em></p><p>The display name of the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetDisplayName(this AzureAdAppUpdateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.DisplayName"/>.</em></p><p>The display name of the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetDisplayName(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region EndDate
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.EndDate"/>.</em></p><p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetEndDate(this AzureAdAppUpdateSettings toolSettings, string endDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = endDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.EndDate"/>.</em></p><p>Date or datetime after which credentials expire(e.g. '2017-12-31T11:59:59+00:00' or '2017-12-31'). Default value is one year after current time.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetEndDate(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.EndDate = null;
            return toolSettings;
        }
        #endregion
        #region Homepage
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Homepage"/>.</em></p><p>The url where users can sign in and use your app.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetHomepage(this AzureAdAppUpdateSettings toolSettings, string homepage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Homepage = homepage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Homepage"/>.</em></p><p>The url where users can sign in and use your app.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetHomepage(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Homepage = null;
            return toolSettings;
        }
        #endregion
        #region IdentifierUris
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.IdentifierUris"/> to a new list.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetIdentifierUris(this AzureAdAppUpdateSettings toolSettings, params string[] identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal = identifierUris.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.IdentifierUris"/> to a new list.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetIdentifierUris(this AzureAdAppUpdateSettings toolSettings, IEnumerable<string> identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal = identifierUris.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAdAppUpdateSettings.IdentifierUris"/>.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings AddIdentifierUris(this AzureAdAppUpdateSettings toolSettings, params string[] identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal.AddRange(identifierUris);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAdAppUpdateSettings.IdentifierUris"/>.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings AddIdentifierUris(this AzureAdAppUpdateSettings toolSettings, IEnumerable<string> identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal.AddRange(identifierUris);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAdAppUpdateSettings.IdentifierUris"/>.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ClearIdentifierUris(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.IdentifierUrisInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAdAppUpdateSettings.IdentifierUris"/>.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings RemoveIdentifierUris(this AzureAdAppUpdateSettings toolSettings, params string[] identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(identifierUris);
            toolSettings.IdentifierUrisInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAdAppUpdateSettings.IdentifierUris"/>.</em></p><p>Space-separated unique URIs that Azure AD can use for this app.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings RemoveIdentifierUris(this AzureAdAppUpdateSettings toolSettings, IEnumerable<string> identifierUris)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(identifierUris);
            toolSettings.IdentifierUrisInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region KeyType
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.KeyType"/>.</em></p><p>The type of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetKeyType(this AzureAdAppUpdateSettings toolSettings, AdAppKeyType keyType)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = keyType;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.KeyType"/>.</em></p><p>The type of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetKeyType(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyType = null;
            return toolSettings;
        }
        #endregion
        #region KeyUsage
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.KeyUsage"/>.</em></p><p>The usage of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetKeyUsage(this AzureAdAppUpdateSettings toolSettings, AdAppKeyUsage keyUsage)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyUsage = keyUsage;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.KeyUsage"/>.</em></p><p>The usage of the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetKeyUsage(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyUsage = null;
            return toolSettings;
        }
        #endregion
        #region KeyValue
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.KeyValue"/>.</em></p><p>The value for the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetKeyValue(this AzureAdAppUpdateSettings toolSettings, string keyValue)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = keyValue;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.KeyValue"/>.</em></p><p>The value for the key credentials associated with the application.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetKeyValue(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyValue = null;
            return toolSettings;
        }
        #endregion
        #region Oauth2AllowImplicitFlow
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings, bool? oauth2AllowImplicitFlow)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = oauth2AllowImplicitFlow;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings EnableOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings DisableOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdAppUpdateSettings.Oauth2AllowImplicitFlow"/>.</em></p><p>Whether to allow implicit grant flow for OAuth2.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ToggleOauth2AllowImplicitFlow(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Oauth2AllowImplicitFlow = !toolSettings.Oauth2AllowImplicitFlow;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Password"/>.</em></p><p>App password, aka 'client secret'.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetPassword(this AzureAdAppUpdateSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Password"/>.</em></p><p>App password, aka 'client secret'.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetPassword(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region ReplyUrls
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.ReplyUrls"/> to a new list.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetReplyUrls(this AzureAdAppUpdateSettings toolSettings, params string[] replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal = replyUrls.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.ReplyUrls"/> to a new list.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetReplyUrls(this AzureAdAppUpdateSettings toolSettings, IEnumerable<string> replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal = replyUrls.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAdAppUpdateSettings.ReplyUrls"/>.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings AddReplyUrls(this AzureAdAppUpdateSettings toolSettings, params string[] replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal.AddRange(replyUrls);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAdAppUpdateSettings.ReplyUrls"/>.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings AddReplyUrls(this AzureAdAppUpdateSettings toolSettings, IEnumerable<string> replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal.AddRange(replyUrls);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAdAppUpdateSettings.ReplyUrls"/>.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ClearReplyUrls(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReplyUrlsInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAdAppUpdateSettings.ReplyUrls"/>.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings RemoveReplyUrls(this AzureAdAppUpdateSettings toolSettings, params string[] replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(replyUrls);
            toolSettings.ReplyUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAdAppUpdateSettings.ReplyUrls"/>.</em></p><p>Space-separated URIs to which Azure AD will redirect in response to an OAuth 2.0 request. The value does not need to be a physical endpoint, but must be a valid URI.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings RemoveReplyUrls(this AzureAdAppUpdateSettings toolSettings, IEnumerable<string> replyUrls)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(replyUrls);
            toolSettings.ReplyUrlsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region RequiredResourceAccesses
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.RequiredResourceAccesses"/>.</em></p><p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetRequiredResourceAccesses(this AzureAdAppUpdateSettings toolSettings, string requiredResourceAccesses)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiredResourceAccesses = requiredResourceAccesses;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.RequiredResourceAccesses"/>.</em></p><p>Resource scopes and roles the application requires access to. Should be in manifest json format. See examples below for details.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetRequiredResourceAccesses(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.RequiredResourceAccesses = null;
            return toolSettings;
        }
        #endregion
        #region StartDate
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.StartDate"/>.</em></p><p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetStartDate(this AzureAdAppUpdateSettings toolSettings, string startDate)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = startDate;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.StartDate"/>.</em></p><p>Date or datetime at which credentials become valid(e.g. '2017-01-01T01:00:00+00:00' or '2017-01-01'). Default value is current time.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetStartDate(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.StartDate = null;
            return toolSettings;
        }
        #endregion
        #region Add
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetAdd(this AzureAdAppUpdateSettings toolSettings, string add)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = add;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Add"/>.</em></p><p>Add an object to a list of objects by specifying a path and key value pairs.  Example: --add property.listProperty &lt;key=value, string or JSON string&gt;.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetAdd(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Add = null;
            return toolSettings;
        }
        #endregion
        #region ForceString
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetForceString(this AzureAdAppUpdateSettings toolSettings, string forceString)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = forceString;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.ForceString"/>.</em></p><p>When using 'set' or 'add', preserve string literals instead of attempting to convert to JSON.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetForceString(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ForceString = null;
            return toolSettings;
        }
        #endregion
        #region Remove
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetRemove(this AzureAdAppUpdateSettings toolSettings, string remove)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = remove;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Remove"/>.</em></p><p>Remove a property or an element from a list.  Example: --remove property.list &lt;indexToRemove&gt; OR --remove propertyToRemove.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetRemove(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Remove = null;
            return toolSettings;
        }
        #endregion
        #region Set
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetSet(this AzureAdAppUpdateSettings toolSettings, string set)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = set;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Set"/>.</em></p><p>Update an object by specifying a property path and value to set.  Example: --set property1.property2=&lt;value&gt;.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetSet(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Set = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetSubscription(this AzureAdAppUpdateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetSubscription(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetDebug(this AzureAdAppUpdateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetDebug(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetHelp(this AzureAdAppUpdateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetHelp(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetOutput(this AzureAdAppUpdateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetOutput(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetQuery(this AzureAdAppUpdateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetQuery(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings SetVerbose(this AzureAdAppUpdateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppUpdateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppUpdateSettings ResetVerbose(this AzureAdAppUpdateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupCreateSettingsExtensions
    {
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetDisplayName(this AzureAdGroupCreateSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetDisplayName(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region MailNickname
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.MailNickname"/>.</em></p><p>Mail nickname.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetMailNickname(this AzureAdGroupCreateSettings toolSettings, string mailNickname)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MailNickname = mailNickname;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.MailNickname"/>.</em></p><p>Mail nickname.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetMailNickname(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MailNickname = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetSubscription(this AzureAdGroupCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetSubscription(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetDebug(this AzureAdGroupCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetDebug(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetHelp(this AzureAdGroupCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetHelp(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetOutput(this AzureAdGroupCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetOutput(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetQuery(this AzureAdGroupCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetQuery(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings SetVerbose(this AzureAdGroupCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupCreateSettings ResetVerbose(this AzureAdGroupCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupDeleteSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupDeleteSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetGroup(this AzureAdGroupDeleteSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupDeleteSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetGroup(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdGroupDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetSubscription(this AzureAdGroupDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetSubscription(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetDebug(this AzureAdGroupDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetDebug(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetHelp(this AzureAdGroupDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetHelp(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetOutput(this AzureAdGroupDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetOutput(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetQuery(this AzureAdGroupDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetQuery(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings SetVerbose(this AzureAdGroupDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupDeleteSettings ResetVerbose(this AzureAdGroupDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupGetMemberGroupsSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupGetMemberGroupsSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetGroup(this AzureAdGroupGetMemberGroupsSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetGroup(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region AdditionalProperties
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.AdditionalProperties"/>.</em></p><p>Unmatched properties from the message are deserialized this collection.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetAdditionalProperties(this AzureAdGroupGetMemberGroupsSettings toolSettings, string additionalProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdditionalProperties = additionalProperties;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.AdditionalProperties"/>.</em></p><p>Unmatched properties from the message are deserialized this collection.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetAdditionalProperties(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdditionalProperties = null;
            return toolSettings;
        }
        #endregion
        #region SecurityEnabledOnly
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings, bool? securityEnabledOnly)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = securityEnabledOnly;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings EnableSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings DisableSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdGroupGetMemberGroupsSettings.SecurityEnabledOnly"/>.</em></p><p>If true, only membership in security-enabled groups should be checked. Otherwise, membership in all groups should be checked.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ToggleSecurityEnabledOnly(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SecurityEnabledOnly = !toolSettings.SecurityEnabledOnly;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetSubscription(this AzureAdGroupGetMemberGroupsSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetSubscription(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetDebug(this AzureAdGroupGetMemberGroupsSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetDebug(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetHelp(this AzureAdGroupGetMemberGroupsSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetHelp(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetOutput(this AzureAdGroupGetMemberGroupsSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetOutput(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetQuery(this AzureAdGroupGetMemberGroupsSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetQuery(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupGetMemberGroupsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings SetVerbose(this AzureAdGroupGetMemberGroupsSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupGetMemberGroupsSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupGetMemberGroupsSettings ResetVerbose(this AzureAdGroupGetMemberGroupsSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupListSettingsExtensions
    {
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetDisplayName(this AzureAdGroupListSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetDisplayName(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetFilter(this AzureAdGroupListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetFilter(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetSubscription(this AzureAdGroupListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetSubscription(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetDebug(this AzureAdGroupListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetDebug(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetHelp(this AzureAdGroupListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetHelp(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetOutput(this AzureAdGroupListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetOutput(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetQuery(this AzureAdGroupListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetQuery(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings SetVerbose(this AzureAdGroupListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupListSettings ResetVerbose(this AzureAdGroupListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupShowSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupShowSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings SetGroup(this AzureAdGroupShowSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupShowSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetGroup(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdGroupShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings SetSubscription(this AzureAdGroupShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetSubscription(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings SetDebug(this AzureAdGroupShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetDebug(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings SetHelp(this AzureAdGroupShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetHelp(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings SetOutput(this AzureAdGroupShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetOutput(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings SetQuery(this AzureAdGroupShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetQuery(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings SetVerbose(this AzureAdGroupShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupShowSettings ResetVerbose(this AzureAdGroupShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCreateSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCreateSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id of the associated application.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings SetId(this AzureAdSpCreateSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id of the associated application.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetId(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings SetSubscription(this AzureAdSpCreateSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetSubscription(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings SetDebug(this AzureAdSpCreateSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetDebug(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings SetHelp(this AzureAdSpCreateSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetHelp(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings SetOutput(this AzureAdSpCreateSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetOutput(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings SetQuery(this AzureAdSpCreateSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetQuery(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings SetVerbose(this AzureAdSpCreateSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateSettings ResetVerbose(this AzureAdSpCreateSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCreateForRbacSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCreateForRbacSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Name"/>.</em></p><p>A URI to use as the logic name. It doesn't need to exist. If not present, CLI will generate one.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetName(this AzureAdSpCreateForRbacSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Name"/>.</em></p><p>A URI to use as the logic name. It doesn't need to exist. If not present, CLI will generate one.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetName(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Role
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Role"/>.</em></p><p>Role of the service principal.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetRole(this AzureAdSpCreateForRbacSettings toolSettings, string role)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = role;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Role"/>.</em></p><p>Role of the service principal.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetRole(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Role = null;
            return toolSettings;
        }
        #endregion
        #region Scopes
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Scopes"/> to a new list.</em></p><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetScopes(this AzureAdSpCreateForRbacSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal = scopes.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Scopes"/> to a new list.</em></p><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetScopes(this AzureAdSpCreateForRbacSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal = scopes.ToList();
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAdSpCreateForRbacSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings AddScopes(this AzureAdSpCreateForRbacSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.AddRange(scopes);
            return toolSettings;
        }
        /// <summary><p><em>Adds values to <see cref="AzureAdSpCreateForRbacSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings AddScopes(this AzureAdSpCreateForRbacSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.AddRange(scopes);
            return toolSettings;
        }
        /// <summary><p><em>Clears <see cref="AzureAdSpCreateForRbacSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ClearScopes(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ScopesInternal.Clear();
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAdSpCreateForRbacSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings RemoveScopes(this AzureAdSpCreateForRbacSettings toolSettings, params string[] scopes)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(scopes);
            toolSettings.ScopesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary><p><em>Removes values from <see cref="AzureAdSpCreateForRbacSettings.Scopes"/>.</em></p><p>Space-separated list of scopes the service principal's role assignment applies to. Defaults to the root of the current subscription.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings RemoveScopes(this AzureAdSpCreateForRbacSettings toolSettings, IEnumerable<string> scopes)
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(scopes);
            toolSettings.ScopesInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region SdkAuth
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/>.</em></p><p>Output result in compatible with Azure SDK auth file.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings, bool? sdkAuth)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = sdkAuth;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/>.</em></p><p>Output result in compatible with Azure SDK auth file.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/>.</em></p><p>Output result in compatible with Azure SDK auth file.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings EnableSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/>.</em></p><p>Output result in compatible with Azure SDK auth file.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings DisableSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdSpCreateForRbacSettings.SdkAuth"/>.</em></p><p>Output result in compatible with Azure SDK auth file.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ToggleSdkAuth(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SdkAuth = !toolSettings.SdkAuth;
            return toolSettings;
        }
        #endregion
        #region SkipAssignment
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/>.</em></p><p>Do not create default assignment.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings, bool? skipAssignment)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = skipAssignment;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/>.</em></p><p>Do not create default assignment.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = null;
            return toolSettings;
        }
        /// <summary><p><em>Enables <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/>.</em></p><p>Do not create default assignment.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings EnableSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = true;
            return toolSettings;
        }
        /// <summary><p><em>Disables <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/>.</em></p><p>Do not create default assignment.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings DisableSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = false;
            return toolSettings;
        }
        /// <summary><p><em>Toggles <see cref="AzureAdSpCreateForRbacSettings.SkipAssignment"/>.</em></p><p>Do not create default assignment.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ToggleSkipAssignment(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.SkipAssignment = !toolSettings.SkipAssignment;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Cert"/>.</em></p><p>Certificate to use for credentials.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetCert(this AzureAdSpCreateForRbacSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Cert"/>.</em></p><p>Certificate to use for credentials.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetCert(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region CreateCert
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.CreateCert"/>.</em></p><p>Create a self-signed certificate to use for the credential.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetCreateCert(this AzureAdSpCreateForRbacSettings toolSettings, string createCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = createCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.CreateCert"/>.</em></p><p>Create a self-signed certificate to use for the credential.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetCreateCert(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = null;
            return toolSettings;
        }
        #endregion
        #region Keyvault
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Keyvault"/>.</em></p><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetKeyvault(this AzureAdSpCreateForRbacSettings toolSettings, string keyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = keyvault;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Keyvault"/>.</em></p><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetKeyvault(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Password"/>.</em></p><p>The password used to log in.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetPassword(this AzureAdSpCreateForRbacSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Password"/>.</em></p><p>The password used to log in.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetPassword(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Years
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Years"/>.</em></p><p>Number of years for which the credentials will be valid. Default: 1 year.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetYears(this AzureAdSpCreateForRbacSettings toolSettings, int? years)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = years;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Years"/>.</em></p><p>Number of years for which the credentials will be valid. Default: 1 year.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetYears(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetSubscription(this AzureAdSpCreateForRbacSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetSubscription(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetDebug(this AzureAdSpCreateForRbacSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetDebug(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetHelp(this AzureAdSpCreateForRbacSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetHelp(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetOutput(this AzureAdSpCreateForRbacSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetOutput(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetQuery(this AzureAdSpCreateForRbacSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetQuery(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpCreateForRbacSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings SetVerbose(this AzureAdSpCreateForRbacSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCreateForRbacSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCreateForRbacSettings ResetVerbose(this AzureAdSpCreateForRbacSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpDeleteSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdSpDeleteSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetId(this AzureAdSpDeleteSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpDeleteSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetId(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdSpDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetSubscription(this AzureAdSpDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetSubscription(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetDebug(this AzureAdSpDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetDebug(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetHelp(this AzureAdSpDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetHelp(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetOutput(this AzureAdSpDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetOutput(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetQuery(this AzureAdSpDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetQuery(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings SetVerbose(this AzureAdSpDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpDeleteSettings ResetVerbose(this AzureAdSpDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpListSettingsExtensions
    {
        #region DisplayName
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetDisplayName(this AzureAdSpListSettings toolSettings, string displayName)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.DisplayName"/>.</em></p><p>Object's display name or its prefix.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetDisplayName(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region Filter
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetFilter(this AzureAdSpListSettings toolSettings, string filter)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = filter;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Filter"/>.</em></p><p>OData filter.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetFilter(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Filter = null;
            return toolSettings;
        }
        #endregion
        #region Spn
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Spn"/>.</em></p><p>Service principal name.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetSpn(this AzureAdSpListSettings toolSettings, string spn)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Spn = spn;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Spn"/>.</em></p><p>Service principal name.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetSpn(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Spn = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetSubscription(this AzureAdSpListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetSubscription(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetDebug(this AzureAdSpListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetDebug(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetHelp(this AzureAdSpListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetHelp(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetOutput(this AzureAdSpListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetOutput(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetQuery(this AzureAdSpListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetQuery(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpListSettings SetVerbose(this AzureAdSpListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpListSettings ResetVerbose(this AzureAdSpListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpShowSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpShowSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdSpShowSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings SetId(this AzureAdSpShowSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpShowSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings ResetId(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdSpShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings SetSubscription(this AzureAdSpShowSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpShowSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings ResetSubscription(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings SetDebug(this AzureAdSpShowSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpShowSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings ResetDebug(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings SetHelp(this AzureAdSpShowSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpShowSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings ResetHelp(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings SetOutput(this AzureAdSpShowSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpShowSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings ResetOutput(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings SetQuery(this AzureAdSpShowSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpShowSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings ResetQuery(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings SetVerbose(this AzureAdSpShowSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpShowSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpShowSettings ResetVerbose(this AzureAdSpShowSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppPermissionAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppPermissionAddSettingsExtensions
    {
        #region Api
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Api"/>.</em></p><p>The target API to access.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetApi(this AzureAdAppPermissionAddSettings toolSettings, string api)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Api = api;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Api"/>.</em></p><p>The target API to access.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetApi(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Api = null;
            return toolSettings;
        }
        #endregion
        #region ApiPermissions
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionAddSettings.ApiPermissions"/>.</em></p><p>Space seperated list of &lt;resource-access-id&gt;=&lt;type&gt;.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetApiPermissions(this AzureAdAppPermissionAddSettings toolSettings, string apiPermissions)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiPermissions = apiPermissions;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionAddSettings.ApiPermissions"/>.</em></p><p>Space seperated list of &lt;resource-access-id&gt;=&lt;type&gt;.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetApiPermissions(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ApiPermissions = null;
            return toolSettings;
        }
        #endregion
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetId(this AzureAdAppPermissionAddSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetId(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetSubscription(this AzureAdAppPermissionAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetSubscription(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetDebug(this AzureAdAppPermissionAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetDebug(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetHelp(this AzureAdAppPermissionAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetHelp(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetOutput(this AzureAdAppPermissionAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetOutput(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetQuery(this AzureAdAppPermissionAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetQuery(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings SetVerbose(this AzureAdAppPermissionAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionAddSettings ResetVerbose(this AzureAdAppPermissionAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppPermissionDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppPermissionDeleteSettingsExtensions
    {
        #region Api
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Api"/>.</em></p><p>The target API to access.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetApi(this AzureAdAppPermissionDeleteSettings toolSettings, string api)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Api = api;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Api"/>.</em></p><p>The target API to access.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetApi(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Api = null;
            return toolSettings;
        }
        #endregion
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetId(this AzureAdAppPermissionDeleteSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetId(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetSubscription(this AzureAdAppPermissionDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetSubscription(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetDebug(this AzureAdAppPermissionDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetDebug(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetHelp(this AzureAdAppPermissionDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetHelp(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetOutput(this AzureAdAppPermissionDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetOutput(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetQuery(this AzureAdAppPermissionDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetQuery(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings SetVerbose(this AzureAdAppPermissionDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionDeleteSettings ResetVerbose(this AzureAdAppPermissionDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppPermissionGrantSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppPermissionGrantSettingsExtensions
    {
        #region Api
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Api"/>.</em></p><p>The target API to access.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetApi(this AzureAdAppPermissionGrantSettings toolSettings, string api)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Api = api;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Api"/>.</em></p><p>The target API to access.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetApi(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Api = null;
            return toolSettings;
        }
        #endregion
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetId(this AzureAdAppPermissionGrantSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetId(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Expires
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Expires"/>.</em></p><p>Expiry date for the permissions in years. e.g. 1, 2 or "never".</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetExpires(this AzureAdAppPermissionGrantSettings toolSettings, string expires)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = expires;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Expires"/>.</em></p><p>Expiry date for the permissions in years. e.g. 1, 2 or "never".</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetExpires(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Expires = null;
            return toolSettings;
        }
        #endregion
        #region Scope
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Scope"/>.</em></p><p>Oauth scope.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetScope(this AzureAdAppPermissionGrantSettings toolSettings, string scope)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = scope;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Scope"/>.</em></p><p>Oauth scope.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetScope(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Scope = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetSubscription(this AzureAdAppPermissionGrantSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetSubscription(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetDebug(this AzureAdAppPermissionGrantSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetDebug(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetHelp(this AzureAdAppPermissionGrantSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetHelp(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetOutput(this AzureAdAppPermissionGrantSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetOutput(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetQuery(this AzureAdAppPermissionGrantSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetQuery(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionGrantSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings SetVerbose(this AzureAdAppPermissionGrantSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionGrantSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionGrantSettings ResetVerbose(this AzureAdAppPermissionGrantSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppPermissionListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppPermissionListSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionListSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id of the associated application.</p></summary>
        [Pure]
        public static AzureAdAppPermissionListSettings SetId(this AzureAdAppPermissionListSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionListSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id of the associated application.</p></summary>
        [Pure]
        public static AzureAdAppPermissionListSettings ResetId(this AzureAdAppPermissionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppPermissionListSettings SetSubscription(this AzureAdAppPermissionListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppPermissionListSettings ResetSubscription(this AzureAdAppPermissionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionListSettings SetDebug(this AzureAdAppPermissionListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionListSettings ResetDebug(this AzureAdAppPermissionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppPermissionListSettings SetHelp(this AzureAdAppPermissionListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppPermissionListSettings ResetHelp(this AzureAdAppPermissionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppPermissionListSettings SetOutput(this AzureAdAppPermissionListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppPermissionListSettings ResetOutput(this AzureAdAppPermissionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppPermissionListSettings SetQuery(this AzureAdAppPermissionListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppPermissionListSettings ResetQuery(this AzureAdAppPermissionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppPermissionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionListSettings SetVerbose(this AzureAdAppPermissionListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppPermissionListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppPermissionListSettings ResetVerbose(this AzureAdAppPermissionListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppCredentialDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppCredentialDeleteSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetId(this AzureAdAppCredentialDeleteSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetId(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region KeyId
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.KeyId"/>.</em></p><p>Credential key id.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetKeyId(this AzureAdAppCredentialDeleteSettings toolSettings, string keyId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyId = keyId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.KeyId"/>.</em></p><p>Credential key id.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetKeyId(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyId = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Cert"/>.</em></p><p>A certificate based credential.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetCert(this AzureAdAppCredentialDeleteSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Cert"/>.</em></p><p>A certificate based credential.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetCert(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetSubscription(this AzureAdAppCredentialDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetSubscription(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetDebug(this AzureAdAppCredentialDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetDebug(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetHelp(this AzureAdAppCredentialDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetHelp(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetOutput(this AzureAdAppCredentialDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetOutput(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetQuery(this AzureAdAppCredentialDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetQuery(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings SetVerbose(this AzureAdAppCredentialDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCredentialDeleteSettings ResetVerbose(this AzureAdAppCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppCredentialListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppCredentialListSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialListSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetId(this AzureAdAppCredentialListSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialListSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetId(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialListSettings.Cert"/>.</em></p><p>A certificate based credential.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetCert(this AzureAdAppCredentialListSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialListSettings.Cert"/>.</em></p><p>A certificate based credential.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetCert(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetSubscription(this AzureAdAppCredentialListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetSubscription(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetDebug(this AzureAdAppCredentialListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetDebug(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetHelp(this AzureAdAppCredentialListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetHelp(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetOutput(this AzureAdAppCredentialListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetOutput(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetQuery(this AzureAdAppCredentialListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetQuery(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings SetVerbose(this AzureAdAppCredentialListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCredentialListSettings ResetVerbose(this AzureAdAppCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppCredentialResetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppCredentialResetSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetId(this AzureAdAppCredentialResetSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetId(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Append
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Append"/>.</em></p><p>Append the new credential instead of overwriting.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetAppend(this AzureAdAppCredentialResetSettings toolSettings, string append)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Append = append;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Append"/>.</em></p><p>Append the new credential instead of overwriting.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetAppend(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Append = null;
            return toolSettings;
        }
        #endregion
        #region CredentialDescription
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialResetSettings.CredentialDescription"/>.</em></p><p>The description of the password.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetCredentialDescription(this AzureAdAppCredentialResetSettings toolSettings, string credentialDescription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialDescription = credentialDescription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialResetSettings.CredentialDescription"/>.</em></p><p>The description of the password.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetCredentialDescription(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialDescription = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Cert"/>.</em></p><p>Certificate to use for credentials.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetCert(this AzureAdAppCredentialResetSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Cert"/>.</em></p><p>Certificate to use for credentials.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetCert(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region CreateCert
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialResetSettings.CreateCert"/>.</em></p><p>Create a self-signed certificate to use for the credential.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetCreateCert(this AzureAdAppCredentialResetSettings toolSettings, string createCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = createCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialResetSettings.CreateCert"/>.</em></p><p>Create a self-signed certificate to use for the credential.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetCreateCert(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = null;
            return toolSettings;
        }
        #endregion
        #region Keyvault
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Keyvault"/>.</em></p><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetKeyvault(this AzureAdAppCredentialResetSettings toolSettings, string keyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = keyvault;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Keyvault"/>.</em></p><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetKeyvault(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Password"/>.</em></p><p>App password, aka 'client secret'.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetPassword(this AzureAdAppCredentialResetSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Password"/>.</em></p><p>App password, aka 'client secret'.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetPassword(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Years
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Years"/>.</em></p><p>Number of years for which the credentials will be valid.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetYears(this AzureAdAppCredentialResetSettings toolSettings, int? years)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = years;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Years"/>.</em></p><p>Number of years for which the credentials will be valid.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetYears(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetSubscription(this AzureAdAppCredentialResetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetSubscription(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetDebug(this AzureAdAppCredentialResetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetDebug(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetHelp(this AzureAdAppCredentialResetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetHelp(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetOutput(this AzureAdAppCredentialResetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetOutput(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetQuery(this AzureAdAppCredentialResetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetQuery(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppCredentialResetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings SetVerbose(this AzureAdAppCredentialResetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppCredentialResetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppCredentialResetSettings ResetVerbose(this AzureAdAppCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppOwnerAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppOwnerAddSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerAddSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetId(this AzureAdAppOwnerAddSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerAddSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetId(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region OwnerObjectId
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerAddSettings.OwnerObjectId"/>.</em></p><p>Owner's object id.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetOwnerObjectId(this AzureAdAppOwnerAddSettings toolSettings, string ownerObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = ownerObjectId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerAddSettings.OwnerObjectId"/>.</em></p><p>Owner's object id.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetOwnerObjectId(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerAddSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetSubscription(this AzureAdAppOwnerAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerAddSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetSubscription(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetDebug(this AzureAdAppOwnerAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetDebug(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetHelp(this AzureAdAppOwnerAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetHelp(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetOutput(this AzureAdAppOwnerAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetOutput(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetQuery(this AzureAdAppOwnerAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetQuery(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings SetVerbose(this AzureAdAppOwnerAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppOwnerAddSettings ResetVerbose(this AzureAdAppOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppOwnerListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppOwnerListSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerListSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id of the application.</p></summary>
        [Pure]
        public static AzureAdAppOwnerListSettings SetId(this AzureAdAppOwnerListSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerListSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id of the application.</p></summary>
        [Pure]
        public static AzureAdAppOwnerListSettings ResetId(this AzureAdAppOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppOwnerListSettings SetSubscription(this AzureAdAppOwnerListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppOwnerListSettings ResetSubscription(this AzureAdAppOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppOwnerListSettings SetDebug(this AzureAdAppOwnerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppOwnerListSettings ResetDebug(this AzureAdAppOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppOwnerListSettings SetHelp(this AzureAdAppOwnerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppOwnerListSettings ResetHelp(this AzureAdAppOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppOwnerListSettings SetOutput(this AzureAdAppOwnerListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppOwnerListSettings ResetOutput(this AzureAdAppOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppOwnerListSettings SetQuery(this AzureAdAppOwnerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppOwnerListSettings ResetQuery(this AzureAdAppOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppOwnerListSettings SetVerbose(this AzureAdAppOwnerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppOwnerListSettings ResetVerbose(this AzureAdAppOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdAppOwnerRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdAppOwnerRemoveSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetId(this AzureAdAppOwnerRemoveSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.Id"/>.</em></p><p>Identifier uri, application id, or object id.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetId(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region OwnerObjectId
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.OwnerObjectId"/>.</em></p><p>Owner's object id.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetOwnerObjectId(this AzureAdAppOwnerRemoveSettings toolSettings, string ownerObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = ownerObjectId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.OwnerObjectId"/>.</em></p><p>Owner's object id.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetOwnerObjectId(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetSubscription(this AzureAdAppOwnerRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetSubscription(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetDebug(this AzureAdAppOwnerRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetDebug(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetHelp(this AzureAdAppOwnerRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetHelp(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetOutput(this AzureAdAppOwnerRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetOutput(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetQuery(this AzureAdAppOwnerRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetQuery(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdAppOwnerRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings SetVerbose(this AzureAdAppOwnerRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdAppOwnerRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdAppOwnerRemoveSettings ResetVerbose(this AzureAdAppOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCredentialDeleteSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCredentialDeleteSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetId(this AzureAdSpCredentialDeleteSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetId(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region KeyId
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.KeyId"/>.</em></p><p>Credential key id.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetKeyId(this AzureAdSpCredentialDeleteSettings toolSettings, string keyId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyId = keyId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.KeyId"/>.</em></p><p>Credential key id.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetKeyId(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.KeyId = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Cert"/>.</em></p><p>A certificate based credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetCert(this AzureAdSpCredentialDeleteSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Cert"/>.</em></p><p>A certificate based credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetCert(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetSubscription(this AzureAdSpCredentialDeleteSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetSubscription(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetDebug(this AzureAdSpCredentialDeleteSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetDebug(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetHelp(this AzureAdSpCredentialDeleteSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetHelp(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetOutput(this AzureAdSpCredentialDeleteSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetOutput(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetQuery(this AzureAdSpCredentialDeleteSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetQuery(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings SetVerbose(this AzureAdSpCredentialDeleteSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialDeleteSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialDeleteSettings ResetVerbose(this AzureAdSpCredentialDeleteSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCredentialListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCredentialListSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetId(this AzureAdSpCredentialListSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Id"/>.</em></p><p>Service principal name, or object id.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetId(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Cert"/>.</em></p><p>A certificate based credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetCert(this AzureAdSpCredentialListSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Cert"/>.</em></p><p>A certificate based credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetCert(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetSubscription(this AzureAdSpCredentialListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetSubscription(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetDebug(this AzureAdSpCredentialListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetDebug(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetHelp(this AzureAdSpCredentialListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetHelp(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetOutput(this AzureAdSpCredentialListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetOutput(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetQuery(this AzureAdSpCredentialListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetQuery(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings SetVerbose(this AzureAdSpCredentialListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialListSettings ResetVerbose(this AzureAdSpCredentialListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpCredentialResetSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpCredentialResetSettingsExtensions
    {
        #region Name
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Name"/>.</em></p><p>Name or app URI for the credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetName(this AzureAdSpCredentialResetSettings toolSettings, string name)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Name"/>.</em></p><p>Name or app URI for the credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetName(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Append
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Append"/>.</em></p><p>Append the new credential instead of overwriting.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetAppend(this AzureAdSpCredentialResetSettings toolSettings, string append)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Append = append;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Append"/>.</em></p><p>Append the new credential instead of overwriting.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetAppend(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Append = null;
            return toolSettings;
        }
        #endregion
        #region Cert
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Cert"/>.</em></p><p>Certificate to use for credentials.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetCert(this AzureAdSpCredentialResetSettings toolSettings, string cert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = cert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Cert"/>.</em></p><p>Certificate to use for credentials.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetCert(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Cert = null;
            return toolSettings;
        }
        #endregion
        #region CreateCert
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.CreateCert"/>.</em></p><p>Create a self-signed certificate to use for the credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetCreateCert(this AzureAdSpCredentialResetSettings toolSettings, string createCert)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = createCert;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.CreateCert"/>.</em></p><p>Create a self-signed certificate to use for the credential.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetCreateCert(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CreateCert = null;
            return toolSettings;
        }
        #endregion
        #region CredentialDescription
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.CredentialDescription"/>.</em></p><p>The description of the password.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetCredentialDescription(this AzureAdSpCredentialResetSettings toolSettings, string credentialDescription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialDescription = credentialDescription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.CredentialDescription"/>.</em></p><p>The description of the password.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetCredentialDescription(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.CredentialDescription = null;
            return toolSettings;
        }
        #endregion
        #region Keyvault
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Keyvault"/>.</em></p><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetKeyvault(this AzureAdSpCredentialResetSettings toolSettings, string keyvault)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = keyvault;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Keyvault"/>.</em></p><p>Name or ID of a KeyVault to use for creating or retrieving certificates.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetKeyvault(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Keyvault = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Password"/>.</em></p><p>The password used to log in.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetPassword(this AzureAdSpCredentialResetSettings toolSettings, string password)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Password"/>.</em></p><p>The password used to log in.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetPassword(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region Years
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Years"/>.</em></p><p>Number of years for which the credentials will be valid. Default: 1 year.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetYears(this AzureAdSpCredentialResetSettings toolSettings, int? years)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = years;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Years"/>.</em></p><p>Number of years for which the credentials will be valid. Default: 1 year.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetYears(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Years = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetSubscription(this AzureAdSpCredentialResetSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetSubscription(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetDebug(this AzureAdSpCredentialResetSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetDebug(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetHelp(this AzureAdSpCredentialResetSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetHelp(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetOutput(this AzureAdSpCredentialResetSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetOutput(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetQuery(this AzureAdSpCredentialResetSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetQuery(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpCredentialResetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings SetVerbose(this AzureAdSpCredentialResetSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpCredentialResetSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpCredentialResetSettings ResetVerbose(this AzureAdSpCredentialResetSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdSpOwnerListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdSpOwnerListSettingsExtensions
    {
        #region Id
        /// <summary><p><em>Sets <see cref="AzureAdSpOwnerListSettings.Id"/>.</em></p><p>Service principal name, or object id or the service principal.</p></summary>
        [Pure]
        public static AzureAdSpOwnerListSettings SetId(this AzureAdSpOwnerListSettings toolSettings, string id)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = id;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpOwnerListSettings.Id"/>.</em></p><p>Service principal name, or object id or the service principal.</p></summary>
        [Pure]
        public static AzureAdSpOwnerListSettings ResetId(this AzureAdSpOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Id = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdSpOwnerListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpOwnerListSettings SetSubscription(this AzureAdSpOwnerListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpOwnerListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdSpOwnerListSettings ResetSubscription(this AzureAdSpOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdSpOwnerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpOwnerListSettings SetDebug(this AzureAdSpOwnerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpOwnerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdSpOwnerListSettings ResetDebug(this AzureAdSpOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdSpOwnerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpOwnerListSettings SetHelp(this AzureAdSpOwnerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpOwnerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdSpOwnerListSettings ResetHelp(this AzureAdSpOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdSpOwnerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpOwnerListSettings SetOutput(this AzureAdSpOwnerListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpOwnerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdSpOwnerListSettings ResetOutput(this AzureAdSpOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdSpOwnerListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpOwnerListSettings SetQuery(this AzureAdSpOwnerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpOwnerListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdSpOwnerListSettings ResetQuery(this AzureAdSpOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdSpOwnerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpOwnerListSettings SetVerbose(this AzureAdSpOwnerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdSpOwnerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdSpOwnerListSettings ResetVerbose(this AzureAdSpOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupMemberAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupMemberAddSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetGroup(this AzureAdGroupMemberAddSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetGroup(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region MemberId
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.MemberId"/>.</em></p><p>The object ID of the contact, group, user, or service principal.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetMemberId(this AzureAdGroupMemberAddSettings toolSettings, string memberId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = memberId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.MemberId"/>.</em></p><p>The object ID of the contact, group, user, or service principal.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetMemberId(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = null;
            return toolSettings;
        }
        #endregion
        #region AdditionalProperties
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.AdditionalProperties"/>.</em></p><p>Unmatched properties from the message are deserialized this collection.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetAdditionalProperties(this AzureAdGroupMemberAddSettings toolSettings, string additionalProperties)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdditionalProperties = additionalProperties;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.AdditionalProperties"/>.</em></p><p>Unmatched properties from the message are deserialized this collection.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetAdditionalProperties(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AdditionalProperties = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetSubscription(this AzureAdGroupMemberAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetSubscription(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetDebug(this AzureAdGroupMemberAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetDebug(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetHelp(this AzureAdGroupMemberAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetHelp(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetOutput(this AzureAdGroupMemberAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetOutput(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetQuery(this AzureAdGroupMemberAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetQuery(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings SetVerbose(this AzureAdGroupMemberAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberAddSettings ResetVerbose(this AzureAdGroupMemberAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupMemberCheckSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupMemberCheckSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetGroup(this AzureAdGroupMemberCheckSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetGroup(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region MemberId
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.MemberId"/>.</em></p><p>The object ID of the contact, group, user, or service principal.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetMemberId(this AzureAdGroupMemberCheckSettings toolSettings, string memberId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = memberId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.MemberId"/>.</em></p><p>The object ID of the contact, group, user, or service principal.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetMemberId(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetSubscription(this AzureAdGroupMemberCheckSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetSubscription(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetDebug(this AzureAdGroupMemberCheckSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetDebug(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetHelp(this AzureAdGroupMemberCheckSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetHelp(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetOutput(this AzureAdGroupMemberCheckSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetOutput(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetQuery(this AzureAdGroupMemberCheckSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetQuery(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberCheckSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings SetVerbose(this AzureAdGroupMemberCheckSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberCheckSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberCheckSettings ResetVerbose(this AzureAdGroupMemberCheckSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupMemberListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupMemberListSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberListSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetGroup(this AzureAdGroupMemberListSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberListSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetGroup(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetSubscription(this AzureAdGroupMemberListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetSubscription(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetDebug(this AzureAdGroupMemberListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetDebug(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetHelp(this AzureAdGroupMemberListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetHelp(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetOutput(this AzureAdGroupMemberListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetOutput(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetQuery(this AzureAdGroupMemberListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetQuery(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings SetVerbose(this AzureAdGroupMemberListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberListSettings ResetVerbose(this AzureAdGroupMemberListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupMemberRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupMemberRemoveSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetGroup(this AzureAdGroupMemberRemoveSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetGroup(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region MemberId
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.MemberId"/>.</em></p><p>The object ID of the contact, group, user, or service principal.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetMemberId(this AzureAdGroupMemberRemoveSettings toolSettings, string memberId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = memberId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.MemberId"/>.</em></p><p>The object ID of the contact, group, user, or service principal.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetMemberId(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MemberId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetSubscription(this AzureAdGroupMemberRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetSubscription(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetDebug(this AzureAdGroupMemberRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetDebug(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetHelp(this AzureAdGroupMemberRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetHelp(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetOutput(this AzureAdGroupMemberRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetOutput(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetQuery(this AzureAdGroupMemberRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetQuery(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupMemberRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings SetVerbose(this AzureAdGroupMemberRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupMemberRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupMemberRemoveSettings ResetVerbose(this AzureAdGroupMemberRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupOwnerAddSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupOwnerAddSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetGroup(this AzureAdGroupOwnerAddSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetGroup(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region OwnerObjectId
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.OwnerObjectId"/>.</em></p><p>Owner's object id.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetOwnerObjectId(this AzureAdGroupOwnerAddSettings toolSettings, string ownerObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = ownerObjectId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.OwnerObjectId"/>.</em></p><p>Owner's object id.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetOwnerObjectId(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetSubscription(this AzureAdGroupOwnerAddSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetSubscription(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetDebug(this AzureAdGroupOwnerAddSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetDebug(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetHelp(this AzureAdGroupOwnerAddSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetHelp(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetOutput(this AzureAdGroupOwnerAddSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetOutput(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetQuery(this AzureAdGroupOwnerAddSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetQuery(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings SetVerbose(this AzureAdGroupOwnerAddSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerAddSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerAddSettings ResetVerbose(this AzureAdGroupOwnerAddSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupOwnerListSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupOwnerListSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerListSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings SetGroup(this AzureAdGroupOwnerListSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerListSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings ResetGroup(this AzureAdGroupOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings SetSubscription(this AzureAdGroupOwnerListSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerListSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings ResetSubscription(this AzureAdGroupOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings SetDebug(this AzureAdGroupOwnerListSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerListSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings ResetDebug(this AzureAdGroupOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings SetHelp(this AzureAdGroupOwnerListSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerListSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings ResetHelp(this AzureAdGroupOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings SetOutput(this AzureAdGroupOwnerListSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerListSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings ResetOutput(this AzureAdGroupOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings SetQuery(this AzureAdGroupOwnerListSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerListSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings ResetQuery(this AzureAdGroupOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings SetVerbose(this AzureAdGroupOwnerListSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerListSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerListSettings ResetVerbose(this AzureAdGroupOwnerListSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AzureAdGroupOwnerRemoveSettingsExtensions
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AzureAdGroupOwnerRemoveSettingsExtensions
    {
        #region Group
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetGroup(this AzureAdGroupOwnerRemoveSettings toolSettings, string group)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = group;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.Group"/>.</em></p><p>Group's object id or display name(prefix also works if there is a unique match).</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetGroup(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Group = null;
            return toolSettings;
        }
        #endregion
        #region OwnerObjectId
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.OwnerObjectId"/>.</em></p><p>Owner's object id.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetOwnerObjectId(this AzureAdGroupOwnerRemoveSettings toolSettings, string ownerObjectId)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = ownerObjectId;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.OwnerObjectId"/>.</em></p><p>Owner's object id.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetOwnerObjectId(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OwnerObjectId = null;
            return toolSettings;
        }
        #endregion
        #region Subscription
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetSubscription(this AzureAdGroupOwnerRemoveSettings toolSettings, string subscription)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = subscription;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.Subscription"/>.</em></p><p>Name or ID of subscription. You can configure the default subscription using `az account set -s NAME_OR_ID`.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetSubscription(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Subscription = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetDebug(this AzureAdGroupOwnerRemoveSettings toolSettings, string debug)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.Debug"/>.</em></p><p>Increase logging verbosity to show all debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetDebug(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetHelp(this AzureAdGroupOwnerRemoveSettings toolSettings, string help)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.Help"/>.</em></p><p>Show this help message and exit.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetHelp(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetOutput(this AzureAdGroupOwnerRemoveSettings toolSettings, AzureOutput output)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.Output"/>.</em></p><p>Output format.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetOutput(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Query
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetQuery(this AzureAdGroupOwnerRemoveSettings toolSettings, string query)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = query;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.Query"/>.</em></p><p>JMESPath query string. See <a href="http://jmespath.org/">http://jmespath.org/</a> for more information and examples.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetQuery(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Query = null;
            return toolSettings;
        }
        #endregion
        #region Verbose
        /// <summary><p><em>Sets <see cref="AzureAdGroupOwnerRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings SetVerbose(this AzureAdGroupOwnerRemoveSettings toolSettings, string verbose)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = verbose;
            return toolSettings;
        }
        /// <summary><p><em>Resets <see cref="AzureAdGroupOwnerRemoveSettings.Verbose"/>.</em></p><p>Increase logging verbosity. Use --debug for full debug logs.</p></summary>
        [Pure]
        public static AzureAdGroupOwnerRemoveSettings ResetVerbose(this AzureAdGroupOwnerRemoveSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Verbose = null;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AdAppKeyType
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AdAppKeyType : Enumeration
    {
        public static AdAppKeyType asymmetricx509cert = new AdAppKeyType { Value = "asymmetricx509cert" };
        public static AdAppKeyType password = new AdAppKeyType { Value = "password" };
        public static AdAppKeyType symmetric = new AdAppKeyType { Value = "symmetric" };
    }
    #endregion
    #region AdAppKeyUsage
    /// <summary><p>Used within <see cref="AzureAdTasks"/>.</p></summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    public partial class AdAppKeyUsage : Enumeration
    {
        public static AdAppKeyUsage sign = new AdAppKeyUsage { Value = "sign" };
        public static AdAppKeyUsage verify = new AdAppKeyUsage { Value = "verify" };
    }
    #endregion
}
