// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure-cli/blob/master/LICENSE

using System;
using System.Linq;

namespace Nuke.Azure.Generator
{
    internal class Program
    {
        private static void Main()
        {
            var args = Environment.GetCommandLineArgs();
            SpecificationGenerator.GenerateSpecifications(new SpecificationGeneratorSettings { DefinitonFolder = args[1], OutputFolder = args[2] });
        }
    }
}