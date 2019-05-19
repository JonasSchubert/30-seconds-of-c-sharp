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
        /// Returns a new array with n elements removed from the right.
        /// Equal to Skip
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.skip?view=netframework-4.7.2
        /// </summary>
        public static IEnumerable<T> DropRight<T>(this IEnumerable<T> enumerable, uint dropCount)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (enumerable.Count() < dropCount)
            {
                throw new ArgumentOutOfRangeException(nameof(enumerable));
            }

            return enumerable.Take(enumerable.Count() - (int)dropCount);
        }
    }
}
