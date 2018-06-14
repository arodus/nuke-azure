// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace Nuke.Azure.Generator.Model
{
    internal interface IDefinition
    {
        string Name { get; }
        [CanBeNull]string InstanceName { get; }

        IDefinition Root { get; }
        IDefinition Parent { get; set; }
    }

    internal interface IBrowsableDefinition : IDefinition
    {
        string RawUrl { get; set; }
        string BrowseUrl { get; set; }
        List<Item> Items { get; }
        List<Parameter> Parameters { get; }
    }
}