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
        /// Returns the difference between two enumerables, after applying the provided function to each enumerable element of both.
        /// </summary>
        public static IEnumerable<K> DifferenceSelect<T, K>(this IEnumerable<T> enumerable1, IEnumerable<T> enumerable2, Func<T, K> selectFunction)
        {
            if (enumerable1 == null)
            {
                throw new ArgumentNullException(nameof(enumerable1));
            }

            if (enumerable2 == null)
            {
                throw new ArgumentNullException(nameof(enumerable2));
            }

            if (selectFunction == null)
            {
                throw new ArgumentNullException(nameof(selectFunction));
            }

            var selectedEnumerable1 = enumerable1.Select(selectFunction);
            var selectedEnumerable2 = enumerable2.Select(selectFunction);

            return selectedEnumerable1.Where(x => !selectedEnumerable2.Any(y => x.Equals(y))).Concat(selectedEnumerable2.Where(x => !selectedEnumerable1.Any(y => x.Equals(y))));
        }
    }
}
