// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Diagnostics;
using System.Linq;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Nuke.Azure.Generator.Model
{
    [UsedImplicitly]
    [DebuggerDisplay("Reference: {" + nameof(ReferenceUrl) + "}")]
    internal class Definiton : IDefinition
    {
        [JsonProperty(PropertyName = "items")] public Item[] Items { get; set; }

        [JsonProperty(PropertyName = "globalParameters")]
        public Parameter[] GlobalParameters { get; set; }

        [JsonProperty(PropertyName = "doc_source_url_repo")] [CanBeNull]
        public string DocSourceUrlRepo { get; set; }

        [JsonProperty(PropertyName = "doc_source_url_path")] [CanBeNull]
        public string DocSourceUrlPath { get; set; }

        [JsonProperty(PropertyName = "original_content_git_url")] [CanBeNull]
        public string OriginalContentGitUrl { get; set; }

        [JsonProperty(PropertyName = "gitcommit")] [CanBeNull]
        public string GitCommit { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "ms.date")]
        public DateTime? MsDate { get; set; }

        [JsonIgnore] public string ReferenceUrl { get; internal set; }

        public string Name => Items[0].Name;
        public string InstanceName => Items[0].InstanceName;
        public IDefinition Root => this;
    }
}