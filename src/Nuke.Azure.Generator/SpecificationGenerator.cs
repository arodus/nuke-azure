// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using Nuke.Azure.Generator.Model;
using Nuke.Azure.Generator.Utility;
using Nuke.CodeGeneration.Model;
using Nuke.Common;

namespace Nuke.Azure.Generator
{
    public class SpecificationGenerator
    {
        public static void GenerateSpecifications(SpecificationGeneratorSettings settings)
        {
            Console.WriteLine("Generating Azure specifications...");
            Console.WriteLine($"Max depth: {settings.MaxDepth}");
            Console.WriteLine($"Min depth for category: {settings.MinDepthForCategory}");
            Console.WriteLine($"Min sub tasks for category: {settings.MinSubTasksForCategory}");
            Console.WriteLine($"Generate extensions: {settings.GenerateExtension}");
            Console.WriteLine();

            Console.WriteLine("Parsing ToC...");
            var tocs = DefinitionLoader.LoadTablesOfContent(settings.DefinitonFolder);
            var referenceToc = tocs.Single(x => x.Uid == "az");
            Console.WriteLine($"ToC parsed. Commands found: {referenceToc.TotalCommandsInTable}.");

            Console.WriteLine("Parsing definitons...");
            var definitons = DefinitionLoader.LoadCommandDefinitons(settings.DefinitonFolder, settings.Reference);
            var generator = new SpecificationGenerator(settings, definitons, referenceToc);

            Console.WriteLine("Generating specifications...");
            var tools = generator.Generate(out var categories).ToList();
            SpecificationWriter.Write(settings.OutputFolder,
                tools,
                categories.ToArray(),
                settings.BaseNamespace);

            Console.WriteLine();
            Console.WriteLine("Generation finished.");
            Console.WriteLine($"Created Tools: {tools.Count}");
            Console.WriteLine($"Created Tasks: {tools.Aggregate(seed: 0, func: (x, tool) => x + tool.Tool.Tasks.Count)}");
            Console.WriteLine($"Created Data Classes: {tools.Aggregate(seed: 0, func: (x, tool) => x + tool.Tool.DataClasses.Count)}");
            Console.WriteLine($"Created Enumerations: {tools.Aggregate(seed: 0, func: (x, tool) => x + tool.Tool.Enumerations.Count)}");
        }

        private readonly IReadOnlyCollection<Definiton> _definitons;
        private readonly TableOfContentsEntry _toc;
        private readonly SpecificationGeneratorSettings _settings;

        private SpecificationGenerator(
            SpecificationGeneratorSettings settings,
            IReadOnlyCollection<Definiton> definitons,
            TableOfContentsEntry referenceToc)
        {
            _settings = settings;
            _definitons = definitons;
            _toc = referenceToc;
        }

        private IEnumerable<ToolContext> Generate(out IEnumerable<TableOfContentsEntry> categories)
        {
            categories = _toc.GetCategories(_settings.MinDepthForCategory, _settings.MinSubTasksForCategory, _settings.MaxDepth);
            return CreateTools(_toc, categories);
        }

        private IEnumerable<ToolContext> CreateTools(
            TableOfContentsEntry toc,
            IEnumerable<TableOfContentsEntry> categories,
            TypeResolver typeResolver = null)
        {
            var tools = new List<ToolContext>();
            var tableOfContentsEntries = categories as TableOfContentsEntry[] ?? categories.ToArray();
            var ns = GetNamespace(toc);
            typeResolver = typeResolver?.Clone(ns) ?? new TypeResolver(ns);

            if (tableOfContentsEntries.Contains(toc)) tools.Add(CreateTool(toc, ns, typeResolver));

            foreach (var tableOfContentsEntry in toc.Items)
            {
                tools.AddRange(CreateTools(tableOfContentsEntry,
                    tableOfContentsEntries,
                    typeResolver));
            }

            return tools;
        }

        private ToolContext CreateTool(TableOfContentsEntry toc, string ns, TypeResolver typeResolver)
        {
            var referenceDepth = CalculateReferenceDepth(toc);
            var references = toc.IncludedReferences(referenceDepth, _settings.MinSubTasksForCategory);

            var globalParameters = new Parameter[0];
            var includedItems = new List<Item>();
            foreach (var definiton in _definitons)
            {
                foreach (var definitonItem in definiton.Items)
                {
                    if (definitonItem.Uid != toc.Uid && !references.Contains(definitonItem.Uid)) continue;
                    includedItems.Add(definitonItem);
                    if (globalParameters.Length == 0) globalParameters = definiton.GlobalParameters;
                }
            }

            return new ToolContext(ns, DefinitonParser.Parse(toc, ns, includedItems, globalParameters, typeResolver));
        }

        private int CalculateReferenceDepth(TableOfContentsEntry toc)
        {
            if (toc.Parent == null /*|| toc.Depth >= _settings.MinDepthForCategory*/) return 0;
            var referenceDepth = toc.Depth - _settings.MaxDepth;
            referenceDepth = referenceDepth < 0 ? 0 : referenceDepth;
            referenceDepth = Math.Max(referenceDepth, _settings.MinDepthForCategory - 1);
            return referenceDepth;
        }

        private string GetNamespace(TableOfContentsEntry toc)
        {
            if (_settings.SingleNamespace) return _settings.BaseNamespace;

            var ns = _settings.BaseNamespace;
            var baseToc = toc;
            while (baseToc.Depth < _settings.MinDepthForCategory)
            {
                if (baseToc.Parent == null) break;
                baseToc = baseToc.Parent;
            }

            var name = baseToc.DisplayName ?? baseToc.Uid.NotNull().Replace("_", " ");
            var segments = name.Length > 2 ? name.Substring(startIndex: 3).Split(separator: ' ') : new string[0];
            var current = string.Empty;
            for (var i = 0; i < segments.Length && i < _settings.MaxDepth; i++)
            {
                current += segments[i].ToPascalCase(separator: '-');
                if (i % _settings.MinDepthForCategory == 0)
                {
                    ns += '.' + current;
                    current = string.Empty;
                }
            }

            return ns;
        }

        internal struct ToolContext
        {
            public ToolContext(string ns, Tool tool)
            {
                Namespace = ns;
                Tool = tool;
            }

            public string Namespace { get; }
            public Tool Tool { get; }
        }
    }
}