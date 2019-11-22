using System.Linq;

namespace JonasSchubert.Snippets.Math
{
    /// <summary>
    /// Partial class for math snippets
    /// </summary>
    public static partial class Math
    {
        /// <summary>
        /// Returns the average of one or more decimal numbers.
        /// </summary>
        /// Linq documentation
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=netframework-4.7.2
        public static decimal Average(this decimal[] elements)
        {
            if (elements.Length == 0) return 0;
            return elements.Sum() / elements.Length;
        }

        /// <summary>
        /// Returns the average of one or more double numbers.
        /// </summary>
        /// Linq documentation
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=netframework-4.7.2
        public static double Average(this double[] elements)
        {
            if (elements.Length == 0) return 0;
            return elements.Sum() / elements.Length;
        }

        /// <summary>
        /// Returns the average of one or more float numbers.
        /// </summary>
        /// Linq documentation
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=netframework-4.7.2
        public static float Average(this float[] elements)
        {
            if (elements.Length == 0) return 0;
            return elements.Sum() / elements.Length;
        }

        /// <summary>
        /// Returns the average of one or more int numbers.
        /// </summary>
        /// Linq documentation
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=netframework-4.7.2
        public static double Average(this int[] elements)
        {
            if (elements.Length == 0) return 0;
            return ((double)elements.Sum()) / elements.Length;
        }

        /// <summary>
        /// Returns the average of one or more uint numbers.
        /// </summary>
        /// Linq documentation
        /// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=netframework-4.7.2
        public static double Average(this uint[] elements)
        {
            if (elements.Length == 0) return 0;
            return elements.Aggregate(0.0, (current, element) => current + element) / elements.Length;
        }
    }
}
