﻿// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Nuke.Azure.Generator.Model;
using Nuke.Azure.Generator.Utilities;
using Nuke.CodeGeneration.Model;
using Nuke.Common;

namespace Nuke.Azure.Generator
{
    internal class DefinitionParser
    {
        private const string c_defaultHelpText = "General Tasks.";

        public static Tool Parse(TableOfContentsEntry toc, string ns, List<Item> items, Parameter[] parameters, TypeResolver typeResolver)
        {
            return new DefinitionParser(toc, ns, items, parameters, typeResolver).Parse();
        }

        private readonly TableOfContentsEntry _toc;
        private readonly string _namespace;
        private readonly List<Item> _items;
        private readonly Parameter[] _parameters;
        private readonly TypeResolver _typeResolver;
        private readonly Tool _tool;

        private DefinitionParser(TableOfContentsEntry toc, string ns, List<Item> items, Parameter[] parameters, TypeResolver typeResolver)
        {
            _toc = toc;
            _namespace = ns;
            _items = items;
            _parameters = parameters;
            _typeResolver = typeResolver;
            _tool = CreateTool();
        }

        private Tool Parse()
        {
            PopulateEnumerations();
            PopulateCommonTaskProperties();
            PopulateTasks();
            return _tool;
        }

        private void PopulateCommonTaskProperties()
        {
            _tool.CommonTaskProperties = _parameters.Select(ParseParameter).Where(x => x != null).ToList();
        }

        private void PopulateEnumerations()
        {
            _typeResolver.PopulateEnumerations(_items.SelectMany(x => x.Parameters).Concat(_parameters).ToList(), _namespace, _toc.Parent == null);
            _tool.Enumerations = _typeResolver
                .GetGeneratedEnumerations()
                .Select(x => new Enumeration
                             {
                                 Name = x.Key.Replace(_namespace, string.Empty).TrimStart('.'),
                                 Values = x.Value.ToList(),
                                 Tool = _tool
                             })
                .ToList();
        }

        private void PopulateTasks()
        {
            foreach (var item in _items)
            {
                ControlFlow.Assert(!(item.Children.Any() && item.Parameters.Any()), "!(item.Children.Any() && item.Parameters.Any())");
                if (item.Children.Any()) continue;

                var postfix = ("Azure" + item.FullyQualifiedName.Substring(startIndex: 2)).Replace(_tool.Name, string.Empty);
                //if (string.IsNullOrEmpty(postfix) && ) postfix = "Azure";
                var task = new Task
                           {
                               Postfix = postfix,
                               DefiniteArgument = item.Name.Replace("az", string.Empty).TrimStart(),
                               Tool = _tool
                           };
                var settingsClass = new SettingsClass
                                    {
                                        Tool = _tool,
                                        Task = task,
                                        Properties = item.Parameters.Select(ParseParameter).Where(x => x != null).ToList()
                                    };
                task.SettingsClass = settingsClass;
                _tool.Tasks.Add(task);
            }
        }

        [CanBeNull]
        private Property ParseParameter(Parameter parameter)
        {
            if (parameter.InstanceName == null) return null;
            var type = _typeResolver.Resolve(parameter, _namespace);
            var name = parameter.InstanceName;
            // if separator has a value the type is either a dictionary or a list and thus can't be a secret.
            var isSecret = !type.Separator.HasValue && (name.IndexOf("secret", StringComparison.OrdinalIgnoreCase) >= 0
                                                        || name.IndexOf("password", StringComparison.OrdinalIgnoreCase) >= 0);
            name = parameter.InstanceName == "EnvironmentVariables" ? "AzureEnvironmentVariables" : parameter.InstanceName;
            var property = new Property
                           {
                               Name = name,
                               Type = type.Type,
                               Format = type.Format,
                               ItemFormat = type.ItemFormat,
                               Separator = type.Separator,
                               Help = parameter.Summary.FormatForXmlDoc(),
                               Secret = isSecret
            };
            return property;
        }

        private Tool CreateTool()
        {
            var name = ("azure" + _toc.Uid.NotNull().Substring(startIndex: 2)).ToPascalCase('_', '-');
            var item = _items.FirstOrDefault(x => x.Uid == _toc.Uid);

            if (item == null)
                return null;
            var help = string.IsNullOrEmpty(item.Summary) ? c_defaultHelpText : item.Summary;
            var tool = new Tool
                       {
                           Name = name,
                           PathExecutable = "az",
                           References = new HashSet<string>(_items.Select(x => x.RawUrl)).ToList(),
                           Help = help,
                           OfficialUrl = GetOfficialUrl()
                       };

            return tool;
        }

        private string GetOfficialUrl()
        {
            var subDir = "reference-index";
            //var appendix = string.Empty;
            var uidSplit = _toc.Uid.NotNull().Split('_');

            if (uidSplit.Length >= 2)
            {
                subDir = uidSplit[1];
                //appendix = _toc.Depth == 0 ? _toc.Uid : string.Empty;
            }

            return $"https://docs.microsoft.com/en-us/cli/azure/{subDir}?view=azure-cli-latest";
        }
    }
}