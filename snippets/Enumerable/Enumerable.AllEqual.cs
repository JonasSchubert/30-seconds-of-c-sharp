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
        /// Check if all elements in an enumerable are equal.
        /// </summary>
        public static bool AllEqual<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            var testList = enumerable.ToList();
            if (testList.Count <= 1)
            {
                return true;
            }

            var compareObject = testList[0];
            for (int index = 0; index < testList.Count; index++)
            {
                var entry = testList[index];
                if ((entry == null || !entry.Equals(compareObject))
                    && !(entry == null && compareObject == null))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
