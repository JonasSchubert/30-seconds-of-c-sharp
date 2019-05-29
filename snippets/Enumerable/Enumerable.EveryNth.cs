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
        /// Returns every nth element in an enumerable.
        /// </summary>
        public static IEnumerable<T> EveryNth<T>(this IEnumerable<T> enumerable, uint nth)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (nth == 0u)
            {
                throw new ArgumentNullException(nameof(nth));
            }

            for (var index = nth - 1; index < enumerable.Count(); index += nth)
            {
                yield return enumerable.ElementAt((int)index);
            }
        }
    }
}
