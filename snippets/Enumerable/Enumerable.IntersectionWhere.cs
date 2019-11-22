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
        /// Returns an enumerable of elements that exist in both enumerables, using a provided comparator function.
        /// </summary>
        public static IEnumerable<T> IntersectionWhere<T>(this IEnumerable<T> enumerable1, IEnumerable<T> enumerable2, Func<T, bool> whereFunction)
        {
            if (enumerable1 == null)
            {
                throw new ArgumentNullException(nameof(enumerable1));
            }

            if (enumerable2 == null)
            {
                throw new ArgumentNullException(nameof(enumerable2));
            }

            if (whereFunction == null)
            {
                throw new ArgumentNullException(nameof(whereFunction));
            }

            var selectedEnumerable1 = enumerable1.Where(whereFunction);
            var selectedEnumerable2 = enumerable2.Where(whereFunction);

            return selectedEnumerable1.Where(x => selectedEnumerable2.Any(y => x.Equals(y))).Concat(selectedEnumerable2.Where(x => selectedEnumerable1.Any(y => x.Equals(y)))).Distinct();
        }
    }
}
