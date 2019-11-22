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
        /// Returns the last element for which the provided function returns a truthy value.
        /// </summary>
        public static T FindLast<T>(this IEnumerable<T> enumerable, Func<T, bool> whereFunction)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (whereFunction == null)
            {
                throw new ArgumentNullException(nameof(whereFunction));
            }

            return enumerable.Where(whereFunction).Reverse().FirstOrDefault();
        }
    }
}
