using System;
using System.Collections.Generic;
using System.Linq;

namespace Conplement.Snippets.Enumerable
{
    /// <summary>
    /// Partial class for Enumerable snippets
    /// </summary>
    public static partial class Enumerable
    {
        /// <summary>
        /// Removes elements from the end of an array until the passed function returns true. Returns the remaining elements in the array.
        /// </summary>
        public static IEnumerable<T> DropRightWhile<T>(this IEnumerable<T> enumerable, Func<T, bool> filter)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            var reachedDropPoint = false;

            for (var index = enumerable.Count() - 1; index >= 0; index--)
            {
                var element = enumerable.ElementAt(index);

                if (!reachedDropPoint && !filter(element))
                {
                    continue;
                }

                reachedDropPoint = true;

                yield return element;
            }

            yield break;
        }
    }
}
