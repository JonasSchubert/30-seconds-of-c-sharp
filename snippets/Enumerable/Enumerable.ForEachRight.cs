using System;
using System.Linq;
using System.Collections.Generic;

namespace JonasSchubert.Snippets.Enumerable
{
    /// <summary>
    /// Partial class for Enumerable snippets
    /// </summary>
    public static partial class Enumerable
    {
        /// <summary>
        /// Executes a provided function once for each enumerable element, starting from the enumerable's last element.
        /// </summary>
        public static void ForEachRight<T>(this IEnumerable<T> enumerable, Action<T> function)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (function == null)
            {
                throw new ArgumentNullException(nameof(function));
            }

            foreach (var element in enumerable.Reverse())
            {
                function(element);
            }
        }
    }
}
