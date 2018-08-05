// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Linq;

namespace Nuke.Azure.Generator
{
    public class SpecificationGeneratorSettings
    {
        public string DefinitionFolder { get; set; }
        public string OutputFolder { get; set; }
        public string BaseNamespace { get; set; }
        public string Reference { get; set; } = "live";
        public bool SingleNamespace { get; set; }
        public bool GenerateExtension { get; set; }
        public int MinDepthForCategory { get; set; } = 1;
        public int MinSubTasksForCategory { get; set; }
        public int MaxDepth { get; set; } = 10;
    }
}