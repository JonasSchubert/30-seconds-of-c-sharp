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
        /// Returns all indices of a value in an enumerable. If the value never occurs, returns empty.
        /// </summary>
        public static IEnumerable<int> IndexOfAll<T>(this IEnumerable<T> enumerable, Func<T, bool> whereFunction)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (whereFunction == null)
            {
                throw new ArgumentNullException(nameof(whereFunction));
            }

            var foundElements = enumerable.Where(whereFunction);
            if (foundElements.Any())
            {
                for (var index = 0; index < enumerable.Count(); index++)
                {
                    if (foundElements.Any(x => x.Equals(enumerable.ElementAt(index))))
                    {
                        yield return index;
                    }
                }
            }
        }
    }
}
