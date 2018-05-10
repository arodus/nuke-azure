// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;

namespace Nuke.Azure.Generator.Utility
{
    [Serializable]
    internal class SequenceEqualityComparer : IEqualityComparer<string[]>
    {
        public bool Equals(string[] x, string[] y)
        {
            if (x.Length != y.Length) return false;
            for (var i = 0; i < x.Length; i++)
            {
                if (x[i] != y[i])
                    return false;
            }

            return true;
        }

        public int GetHashCode(string[] obj)
        {
            var result = 17;

            for (var i = 0; i < obj.Length; i++)
            {
                unchecked
                {
                    result = result * 23 + i.GetHashCode();
                }
            }

            return result;
        }
    }
}