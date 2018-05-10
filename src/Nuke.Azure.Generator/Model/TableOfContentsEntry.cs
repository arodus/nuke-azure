// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Nuke.Azure.Generator.Model
{
    [DebuggerDisplay("{" + nameof(Uid) + "}")]
    internal class TableOfContentsEntry
    {
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }

        [JsonProperty(PropertyName = "uid")]
        [CanBeNull]
        public string Uid { get; set; }

        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        [JsonProperty(PropertyName = "items")] public List<TableOfContentsEntry> Items { get; set; } = new List<TableOfContentsEntry>();

        [JsonIgnore] public bool HasItems => Items.Count > 0;
        [JsonIgnore] public TableOfContentsEntry Parent { get; set; }

        [JsonIgnore] public int Depth { get; set; }
        [JsonIgnore] public int TotalCommandsInTable { get; set; }

        public IReadOnlyCollection<string> IncludedReferences(int maxDepth = 1, int minItemsForCategory = 0)
        {
            if (!HasItems) return new string[0];
            var references = new List<string>();
            foreach (var tableOfContentsEntry in Items)
            {
                if (tableOfContentsEntry.Depth > maxDepth && tableOfContentsEntry.TotalCommandsInTable > minItemsForCategory) continue;

                references.Add(tableOfContentsEntry.Uid);
                references.AddRange(tableOfContentsEntry.IncludedReferences(maxDepth, minItemsForCategory));
            }

            return references.AsReadOnly();
        }

        public IEnumerable<TableOfContentsEntry> GetCategories(int minDepthForCategory, int minItemsForCategory, int maxDepth = -1)
        {
            if (Depth == 0) return new TableOfContentsEntry[0];
            if (maxDepth == 0) return new[] { this };
            if (TotalCommandsInTable < minItemsForCategory) return new[] { this };
            if (Depth < minDepthForCategory) return new[] { this };

            var result = new List<TableOfContentsEntry> { this };

            foreach (var contentItem in Items) result.AddRange(contentItem.GetCategories(minDepthForCategory, minItemsForCategory, maxDepth - 1));

            return result;
        }
    }
}