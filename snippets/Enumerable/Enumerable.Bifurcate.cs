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
        /// Splits values into two groups. If an element in filter is truthy, the corresponding element in the collection belongs to the first group; otherwise, it belongs to the second group.
        /// </summary>
        public static (IEnumerable<T>, IEnumerable<T>) Bifurcate<T>(this IEnumerable<T> list, Func<T, bool> filter)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            IEnumerable<T> enumerable1 = list.Where(filter);
            IEnumerable<T> enumerable2 = list.Where(x => !enumerable1.Any(y => y.Equals(x)));

            return (enumerable1, enumerable2);
        }
    }
}
