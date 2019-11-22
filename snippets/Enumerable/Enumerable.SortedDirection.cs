using System;
using System.Collections.Generic;
using System.Linq;

namespace JonasSchubert.Snippets.Enumerable
{
    /// <summary>
    /// The direction enum
    /// </summary>
    public enum Direction
    {
        /// <summary>
        /// Not sorted
        /// </summary>
        NotSorted,

        /// <summary>
        /// Sorted ascending
        /// </summary>
        Ascending,

        /// <summary>
        /// Sorted descending
        /// </summary>
        Descending
    }

    /// <summary>
    /// Partial class for Enumerable snippets
    /// </summary>
    public static partial class Enumerable
    {
        /// <summary>
        /// Returns 1 if the enumerable is sorted in ascending order, -1 if it is sorted in descending order or 0 if it is not sorted.
        /// </summary>
        public static Direction SortedDirection<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (enumerable.Count() <= 1)
            {
                return Direction.NotSorted;
            }

            var direction = enumerable.GetDirection(0, 1);
            if (enumerable.Count() > 2)
            {
                for (var index = 2; index < enumerable.Count(); index++)
                {
                    var currentDirection = enumerable.GetDirection(index - 1, index);
                    direction = direction == Direction.NotSorted ? currentDirection : direction;

                    if (direction != currentDirection)
                    {
                        return Direction.NotSorted;
                    }
                }
            }

            return direction;
        }

        /// <summary>
        /// Returns a direction (not sorted|ascending|descending) from one index to another within an enumerable
        /// </summary>
        /// <typeparam name="T">The generic type</typeparam>
        /// <param name="enumerable">The enumerable</param>
        /// <param name="indexStart">Index from where to start</param>
        /// <param name="indexEnd">Index from where to end</param>
        /// <returns>Direction</returns>
        private static Direction GetDirection<T>(this IEnumerable<T> enumerable, int indexStart, int indexEnd)
        {
            var compareResult = Comparer<T>.Default.Compare(enumerable.ElementAt(indexStart), enumerable.ElementAt(indexEnd));
            return compareResult < 0 ? Direction.Ascending : compareResult > 0 ? Direction.Descending : Direction.NotSorted;
        }
    }
}
