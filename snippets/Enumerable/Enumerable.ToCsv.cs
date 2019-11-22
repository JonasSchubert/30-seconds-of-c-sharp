using System;
using System.Collections.Generic;
using System.Linq;
using JonasSchubert.Snippets.Type2;

namespace JonasSchubert.Snippets.Enumerable
{
    /// <summary>
    /// Partial class for Enumerable snippets
    /// </summary>
    public static partial class Enumerable
    {
        /// <summary>
        /// Converts a 2D enumerable to a comma-separated values (CSV) string.
        /// </summary>
        public static string ToCsv<T>(this IEnumerable<IEnumerable<T>> enumerable, string delimiter = ",")
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            return string.Join("\n", enumerable.Select(subEnumerable => string.Join(delimiter, subEnumerable.Select(value => typeof(T).IsNumericType() ? value.ToString().Replace(",", ".") : value.ToString()))));
        }
    }
}
