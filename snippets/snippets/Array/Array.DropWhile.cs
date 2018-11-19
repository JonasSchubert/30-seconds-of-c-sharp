using System;
using System.Collections.Generic;

namespace snippets.Array
{
    /// <summary>
    /// Partial class for array snippets
    /// </summary>
    public static partial class SnippetsArray
    {
        public static IEnumerable<T> DropWhile<T>(this IEnumerable<T> list, Func<T, bool> filter)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            var continueToEnd = false;

            foreach (var element in list)
            {
                if (!continueToEnd && !filter(element))
                {
                    continue;
                }

                continueToEnd = true;

                yield return element;
            }

            yield break;
        }
    }
}
