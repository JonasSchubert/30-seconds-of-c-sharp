using System.Linq;

namespace snippets.Math
{
    /// <summary>
    /// Partial class for math snippets
    /// </summary>
    public static partial class SnippetsMath
    {
        /// <summary>
        /// Returns the average of two or more decimal numbers.
        /// </summary>
        /// Linq documentation
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=netframework-4.7.2
        public static decimal Average(params decimal[] elements)
        {
            if (elements.Length == 0) return 0;
            return elements.Sum() / elements.Length;
        }

        /// <summary>
        /// Returns the average of two or more double numbers.
        /// </summary>
        /// Linq documentation
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=netframework-4.7.2
        public static double Average(params double[] elements)
        {
            if (elements.Length == 0) return 0;
            return elements.Sum() / elements.Length;
        }

        /// <summary>
        /// Returns the average of two or more float numbers.
        /// </summary>
        /// Linq documentation
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=netframework-4.7.2
        public static float Average(params float[] elements)
        {
            if (elements.Length == 0) return 0;
            return elements.Sum() / elements.Length;
        }

        /// <summary>
        /// Returns the average of two or more int numbers.
        /// </summary>
        /// Linq documentation
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=netframework-4.7.2
        public static double Average(params int[] elements)
        {
            if (elements.Length == 0) return 0;
            return ((double)elements.Sum()) / elements.Length;
        }

        /// <summary>
        /// Returns the average of two or more uint numbers.
        /// </summary>
        /// Linq documentation
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=netframework-4.7.2
        public static double Average(params uint[] elements)
        {
            if (elements.Length == 0) return 0;
            return elements.Aggregate(0.0, (current, element) => current + element) / elements.Length;
        }
    }
}
