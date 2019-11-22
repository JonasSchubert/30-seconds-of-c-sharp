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
        /// Filters out the non-unique not null values in an enumerable.
        /// </summary>
        public static IEnumerable<T> FilterNonUnique<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            for (var index = 0; index < enumerable.Count(); index++)
            {
                if (enumerable.Where(x => x != null && x.Equals(enumerable.ElementAt(index))).Count() == 1)
                {
                    yield return enumerable.ElementAt(index);
                }
            }
        }
    }
}
