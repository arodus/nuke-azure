// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Nuke.Azure.Generator.Model;
using Nuke.Azure.Generator.Utilities;
using Nuke.CodeGeneration;
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

            foreach (var toolContext in tools)
            {
                var toolDirectory = outputFolder;
                var ns = toolContext.Namespace.Replace(baseNamespace, string.Empty).TrimStart('.');
                if (!string.IsNullOrEmpty(ns))
                {
                    toolDirectory = toolContext.Namespace.Replace(baseNamespace, string.Empty).Split(separator: '.')
                        .Aggregate(toolDirectory, Path.Combine);
                }

                Directory.CreateDirectory(toolDirectory);
                var toolPath = Path.Combine(toolDirectory, toolContext.Tool.Name + ".json");
                toolContext.Tool.SpecificationFile = toolPath;
                ToolSerializer.Save(toolContext.Tool, toolPath);
            }
        }
    }
}