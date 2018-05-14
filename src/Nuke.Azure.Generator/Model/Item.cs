// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Azure.Generator.Utility;

namespace Nuke.Azure.Generator.Model
{
    [UsedImplicitly]
    [DebuggerDisplay("Uid: {" + nameof(Uid) + "}")]
    internal class Item : IBrowsableDefinition

    {
        [JsonProperty(PropertyName = "uid")] public string Uid { get; set; }

        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        [JsonProperty(PropertyName = "description")] [CanBeNull]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "langs")] public string[] Languages { get; set; }

        [JsonProperty(PropertyName = "children")]
        public List<string> Children { get; set; } = new List<string>();

        [JsonProperty(PropertyName = "parameters")]
        public List<Parameter> Parameters { get; set; } = new List<Parameter>();

        [JsonProperty(PropertyName = "displayName")] [CanBeNull]
        public string DisplayName { get; set; }

        [JsonProperty(PropertyName = "items")] public List<Item> Items { get; set; } = new List<Item>();

        [JsonIgnore] public string FullyQualifiedName => Name.ToPascalCase(' ', '-');

        [JsonProperty(PropertyName = "name")] public string Name { get; set; }
        [JsonIgnore] [NotNull] public IDefinition Parent { get; set; }

        [JsonIgnore] public string InstanceName => Name.Length < 3
            ? string.Empty
            : (Parent.Name == Name ? Name.Substring(startIndex: 3) : Name.Replace(Parent.Name, string.Empty)).Trim().ToPascalCase(' ', '-');

        [JsonIgnore] public IDefinition Root => Parent.Root;
        public string RawUrl { get; set; }
        public string BrowseUrl { get; set; }
    }
}