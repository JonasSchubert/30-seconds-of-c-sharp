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
        /// Returns the index of the last element for which the provided function returns a truthy value.
        /// Returns -1 if nothing found at all.
        /// </summary>
        public static int FindLastIndex<T>(this IEnumerable<T> enumerable, Func<T, bool> whereFunction)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (whereFunction == null)
            {
                throw new ArgumentNullException(nameof(whereFunction));
            }

            var foundElement = enumerable.Where(whereFunction).Reverse().FirstOrDefault();
            if (foundElement == null)
            {
                return -1;
            }

            for (var index = enumerable.Count() - 1; index > -1; index--)
            {
                if (enumerable.ElementAt(index).Equals(foundElement))
                {
                    return index;
                }
            }

            throw new InvalidOperationException(nameof(FindLastIndex));
        }
    }
}
