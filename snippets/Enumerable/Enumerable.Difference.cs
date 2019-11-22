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
        /// Returns the difference between two enumerables.
        /// </summary>
        public static IEnumerable<T> Difference<T>(this IEnumerable<T> enumerable1, IEnumerable<T> enumerable2)
        {
            if (enumerable1 == null)
            {
                throw new ArgumentNullException(nameof(enumerable1));
            }

            if (enumerable2 == null)
            {
                throw new ArgumentNullException(nameof(enumerable2));
            }

            return enumerable1.Where(x => !enumerable2.Any(y => x.Equals(y))).Concat(enumerable2.Where(x => !enumerable1.Any(y => x.Equals(y))));
        }
    }
}
