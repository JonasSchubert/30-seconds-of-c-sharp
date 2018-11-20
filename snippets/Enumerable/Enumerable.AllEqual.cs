using System;
using System.Collections.Generic;
using System.Linq;

namespace conplement.snippets.Enumerable
{
    /// <summary>
    /// Partial class for Enumerable snippets
    /// </summary>
    public static partial class Enumerable
    {
        /// <summary>
        /// Check if all elements in an array are equal.
        /// </summary>
        public static bool AllEqual<T>(this IEnumerable<T> list) where T : struct
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            return list.All(entry => list.First().Equals(entry));
        }
    }
}
