// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Nuke.Azure.Generator.Model;
using Nuke.Azure.Generator.Utility;
using Nuke.Core;
using Nuke.Core.Utilities;

namespace Nuke.Azure.Generator
{
    internal class TypeResolver
    {
        public struct TypeReference
        {
            public string Type { get; set; }
            public string Format { get; set; }
            public char? Separator { get; set; }
            public string ItemFormat { get; set; }
        }

        private readonly List<string> _createdEnumerations = new List<string>();
        private readonly string _baseNamespace;
        private Dictionary<string[], string> _resolvedEnumerations = new Dictionary<string[], string>(new SequenceEqualityComparer());

        public TypeResolver(string baseNamespace)
        {
            _baseNamespace = baseNamespace;
        }

        public TypeResolver Clone(string baseNamespace = null)
        {
            var resolver = new TypeResolver(baseNamespace ?? _baseNamespace) { _resolvedEnumerations = _resolvedEnumerations.Clone() };
            return resolver;
        }

        [CanBeNull]
        private string GetEnumeration(string[] values)
        {
            return !_resolvedEnumerations.TryGetValue(values, out var name) ? null : name;
        }

        public void PopulateEnumerations(IEnumerable<Parameter> parameters, string ns, bool isRoot)
        {
            var enumerationParameterGroups = parameters.Where(IsEnumeration).GroupBy(x => x.InstanceName);
            foreach (var enumerationParameterGroup in enumerationParameterGroups)
            {
                // Unique name, unique value
                if (enumerationParameterGroup.Count() == 1)
                {
                    var enumeration = enumerationParameterGroup.Single();

                    var name = ns + '.' + (isRoot ? string.Empty : enumeration.Root.InstanceName)
                               + (enumeration.Root.InstanceName == enumeration.Parent.InstanceName ? string.Empty : enumeration.Parent.InstanceName)
                               + enumeration.InstanceName;

                    CreateEnumaration(name, enumeration.ParameterValueGroups);
                }
                else
                {
                    var groupByValue = enumerationParameterGroup.GroupBy(x => x.ParameterValueGroups, new SequenceEqualityComparer());

                    foreach (var valueGroup in groupByValue)
                    {
                        // same name differen value
                        if (valueGroup.Count() == 1)
                        {
                            var enumeration = valueGroup.Single();
                            var name = ns + '.' + enumeration.Root.InstanceName + enumeration.Parent.InstanceName + enumeration.InstanceName;
                            CreateEnumaration(name, valueGroup.Key);
                        }
                        // Multiple names same values
                        else
                        {
                            foreach (var enumeration in valueGroup)
                            {
                                var name = ns + '.' + (isRoot ? string.Empty : enumeration.Root.InstanceName) + enumeration.InstanceName;
                                CreateEnumaration(name, enumeration.ParameterValueGroups);
                            }
                        }
                    }
                }
            }
        }

        public TypeReference Resolve(Parameter parameter, string baseNamespace)
        {
            var summary = parameter.Summary;
            var typeReference = new TypeReference
                                {
                                    Format = parameter.FormatString
                                };

            if (IsBoolFlag(parameter))
                typeReference.Type = "bool";
            else if (IsBool(summary))
            {
                typeReference.Type = "bool";
                typeReference.Format += " {value}";
            }
            else if (IsEnumeration(parameter))
            {
                typeReference.Type = GetEnumeration(parameter.ParameterValueGroups).NotNull()
                    .Replace(baseNamespace, string.Empty)
                    .TrimStart('.');
            }
            else if (IsInt(summary))
                typeReference.Type = "int";
            else if (IsDictionary(summary))
            {
                typeReference.Type = "Dictionary<string,string>";
                typeReference.ItemFormat = "{key}={value}";
                typeReference.Separator = ' ';
            }

            else
                typeReference.Type = "string";

            if (IsSpaceSpearatedList(summary))
            {
                typeReference.Type = $"List<{typeReference.Type}>";
                typeReference.Separator = ' ';
            }
            else if (IsCommaSeparatedList(summary))
            {
                typeReference.Type = $"List<{typeReference.Type}>";
                typeReference.Separator = ',';
            }

            if (typeReference.Type != "bool") typeReference.Format += " {value}";

            return typeReference;
        }

        public IEnumerable<KeyValuePair<string, string[]>> GetGeneratedEnumerations()
        {
            return _resolvedEnumerations.Where(x => _createdEnumerations.Contains(x.Value))
                .Select(x => new KeyValuePair<string, string[]>(x.Value, x.Key));
        }

        private void CreateEnumaration(string name, string[] values)
        {
            var enumeration = GetEnumeration(values);
            if (enumeration != null) return;

            _resolvedEnumerations.Add(values, name);
            _createdEnumerations.Add(name);
        }

        private bool IsBoolFlag(Parameter parameter)
        {
            return parameter.Summary.StartsWith("Specifies whether", StringComparison.OrdinalIgnoreCase)
                   || parameter.Summary.StartsWith("Show the")
                   || parameter.Summary == "Show public ip address, FQDN, and power states. command will run slow."
                   || parameter.Summary.IndexOf("Wheter", StringComparison.OrdinalIgnoreCase) == 0 || parameter.FormatString == "--service-principal"
                   || parameter.FormatString == "--identity" || parameter.FormatString == "--allow-no-subscriptions"
                   || parameter.ParameterValueGroups != null && parameter.ParameterValueGroups.Length == 2
                                                             && parameter.ParameterValueGroups.Contains("true")
                                                             && parameter.ParameterValueGroups.Contains("false");
        }

        private bool IsBool(string summary)
        {
            return summary.StartsWith("A Boolean", StringComparison.OrdinalIgnoreCase);
        }

        private bool IsInt(string summary)
        {
            return summary.StartsWith("number", StringComparison.OrdinalIgnoreCase) || summary.Contains("Maximum Number")
                                                                                    || summary.Contains("Minimum Number")
                                                                                    || summary.IndexOf("The priority",
                                                                                        StringComparison.OrdinalIgnoreCase) == 0;
        }

        private bool IsDictionary(string summary)
        {
            return summary.IndexOf("Space-separated list of key=value pairs", StringComparison.OrdinalIgnoreCase) >= 0
                   || summary.IndexOf("in space-separated key=value pairs", StringComparison.OrdinalIgnoreCase) >= 0
                   || summary.EndsWith(" in 'key=value' format.", StringComparison.OrdinalIgnoreCase)
                   || summary.IndexOf("A list of name-value pairs", StringComparison.OrdinalIgnoreCase) == 0;
        }

        private bool IsCommaSeparatedList(string summary)
        {
            return !IsDictionary(summary) && summary.IndexOf("comma-separated", StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private bool IsSpaceSpearatedList(string summary)
        {
            return !IsDictionary(summary) && summary.IndexOf("Space-separated list of", StringComparison.OrdinalIgnoreCase) == 0;
        }

        private bool IsEnumeration(Parameter parameter)
        {
            return parameter.ParameterValueGroups != null && !IsBoolFlag(parameter);
        }
    }
}