// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Linq;

namespace Nuke.Azure.Generator.Model
{
    internal interface IDefinition
    {
        string Name { get; }
        string InstanceName { get; }
        IDefinition Root { get; }
    }
}