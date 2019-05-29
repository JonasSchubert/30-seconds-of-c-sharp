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
        /// Checks an enumerable for duplicate values. Returns true if duplicate values exist and false if values are all unique.
        /// </summary>
        public static bool HasDuplicates<T>(this IEnumerable<T> enumerable) =>
            enumerable == null
                ? throw new ArgumentNullException(nameof(enumerable))
                : enumerable.Count() != enumerable.Distinct().Count();
    }
}
