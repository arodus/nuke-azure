// Copyright Sebastian Karasek, Matthias Koch 2018.
// Distributed under the MIT License.
// https://github.com/nuke-build/azure/blob/master/LICENSE

using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using JetBrains.Annotations;

namespace Nuke.Azure.Generator.Utilities
{
    internal static class StringUtils
    {
        [CanBeNull]
        public static string RemoveNewLines([CanBeNull] this string value)
        {
            return value?.Replace("\r", string.Empty).Replace("\n", string.Empty);
        }

        [CanBeNull]
        public static string ToCamelCase([CanBeNull] this string value, char separator)
        {
            if (value == null) return null;

            var index = value.IndexOf(separator);
            while (index > 0)
            {
                value = value.Substring(startIndex: 0, length: index) + char.ToUpper(value[index + 1]) + value.Substring(index + 2);
                index = value.IndexOf(separator);
            }

            return value;
        }

        [CanBeNull]
        public static string ToCamelCase([CanBeNull] this string value, params char[] separators)
        {
            return separators.Aggregate(value, (current, separator) => current.ToCamelCase(separator));
        }

        [CanBeNull]
        public static string ToPascalCase([CanBeNull] this string value, char separator)
        {
            var camelCase = value.ToCamelCase(separator);
            if (string.IsNullOrEmpty(camelCase)) return camelCase;
            return char.ToUpper(camelCase[index: 0]) + camelCase.Substring(startIndex: 1);
        }

        [CanBeNull]
        public static string ToPascalCase([CanBeNull] this string value, params char[] separators)
        {
            if (string.IsNullOrEmpty(value)) return value;
            if (separators.Length == 0) return char.ToUpper(value[index: 0]) + (value.Length > 1 ? value.Substring(startIndex: 1) : string.Empty);
            return separators.Aggregate(value, (current, separator) => current.ToPascalCase(separator));
        }

        [Pure]
        [CanBeNull]
        public static string AddTailingPeriodIfNeeded([CanBeNull] this string value)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value[value.Length - 1] == '.' ? value : value + '.';
        }

        [Pure]
        [CanBeNull]
        public static string EscapeForXmlDoc([CanBeNull] this string value)
        {
            if (string.IsNullOrEmpty(value)) return value;
            string Escape(string str) => str.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");

            var regex = new Regex(@"(<a.*>)(.+)(<\/a>)");
            var start = 0;
            var sb = new StringBuilder();
            var match = regex.Match(value);

            while (match.Success)
            {
                sb.Append(value.Substring(start, match.Index));
                sb.Append(match.Groups[groupnum: 1].Value);
                sb.Append(Escape(match.Groups[groupnum: 2].Value));
                sb.Append(match.Groups[groupnum: 3].Value);

                start = match.Index + match.Length;
                match = match.NextMatch();
            }

            sb.Append(Escape(value.Substring(start)));
            return sb.ToString();
        }

        [Pure]
        [CanBeNull]
        public static string FormatForXmlDoc([CanBeNull] this string value)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value
                .Replace(oldChar: '‘', newChar: '\'')
                .Replace(oldChar: '’', newChar: '\'')
                .RemoveNewLines()
                .EscapeForXmlDoc()
                .AddTailingPeriodIfNeeded();
        }
    }
}