using System;
using System.Linq;
using System.Collections.Generic;

namespace Conplement.Snippets.Enumerable
{
    /// <summary>
    /// Partial class for Enumerable snippets
    /// </summary>
    public static partial class Enumerable
    {
        /// <summary>
        /// Filters out the non-unique not null values in an enumerable, based on a provided comparator function (where linq statement).
        /// </summary>
        public static IEnumerable<T> FilterNonUniqueWhere<T>(this IEnumerable<T> enumerable, Func<T, bool> whereFunction)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (whereFunction == null)
            {
                throw new ArgumentNullException(nameof(whereFunction));
            }

            for (var index = 0; index < enumerable.Count(); index++)
            {
                if (enumerable.Where(whereFunction).Where(x => x != null && x.Equals(enumerable.ElementAt(index))).Count() == 1)
                {
                    yield return enumerable.ElementAt(index);
                }
            }
        }
    }
}
