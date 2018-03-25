// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure-cli/blob/master/LICENSE

using System;
using System.Diagnostics;
using System.Linq;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Azure.Generator.Utility;

namespace Nuke.Azure.Generator.Model
{
    [UsedImplicitly]
    [DebuggerDisplay("{" + nameof(Name) + "}")]
    internal class Parameter : IDefinition
    {
        [JsonProperty(PropertyName = "isReqired")]
        public bool? IsRequired { get; set; }

        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "defaultValue")] [CanBeNull]
        public string DefaultValue { get; set; }

        [JsonProperty(PropertyName = "parameterValueGroup")] [CanBeNull]
        public string ParameterValueGroup { get; set; }

        [JsonIgnore] public string FormatString =>
            Name?.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault(x => x.StartsWith("--"));

        [JsonIgnore] public string[] ParameterValueGroups =>
            ParameterValueGroup?.Split(separator: ',').Select(x => x.ToLowerInvariant().Trim()).ToArray();

        [JsonProperty(PropertyName = "name")] public string Name { get; set; }

        [JsonIgnore] public string InstanceName => FormatString?.TrimStart('-', ' ').ToPascalCase(separator: '-');
        [JsonIgnore] [NotNull] public IDefinition Parent { get; set; }
        [JsonIgnore] public IDefinition Root => Parent.Root;
    }
}