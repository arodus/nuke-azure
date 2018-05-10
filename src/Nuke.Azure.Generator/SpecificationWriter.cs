// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Nuke.Azure.Generator.Model;
using Nuke.Azure.Generator.Utility;
using Nuke.Common;

namespace Nuke.Azure.Generator
{
    internal static class SpecificationWriter
    {
        public static void Write(
            string outputFolder,
            IReadOnlyCollection<SpecificationGenerator.ToolContext> tools,
            IReadOnlyCollection<TableOfContentsEntry> categories,
            string baseNamespace)
        {
            ControlFlow.Assert(tools.Count == categories.Count, "tools.Count == categories.Count()");
            var pairs = tools.Select(x =>
                new KeyValuePair<SpecificationGenerator.ToolContext, TableOfContentsEntry>(x,
                    categories.Single(y => y.Uid.NotNull().Replace("az", "azure").ToPascalCase('_', '-') == x.Tool.Name)));

            foreach (var pair in pairs)
            {
                var toolDirectory = outputFolder;
                var ns = pair.Key.Namespace.Replace(baseNamespace, string.Empty).TrimStart('.');
                if (!string.IsNullOrEmpty(ns))
                {
                    toolDirectory = pair.Key.Namespace.Replace(baseNamespace, string.Empty).Split(separator: '.')
                        .Aggregate(toolDirectory, Path.Combine);
                }

                Directory.CreateDirectory(toolDirectory);

                var toolPath = Path.Combine(toolDirectory, pair.Key.Tool.Name + ".json");
                File.WriteAllText(toolPath,
                    JsonConvert.SerializeObject(pair.Key.Tool,
                        new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            Formatting = Formatting.Indented,
                            DefaultValueHandling = DefaultValueHandling.Include
                        }));
            }
        }
    }
}