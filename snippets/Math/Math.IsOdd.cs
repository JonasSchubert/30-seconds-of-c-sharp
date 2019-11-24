namespace JonasSchubert.Snippets.Math
{
    /// <summary>
    /// Partial class for math snippets
    /// </summary>
    public static partial class Math
    {
        /// <summary>
        /// Returns true if the decimal is odd, false otherwise
        /// </summary>
        public static bool IsOdd(this decimal value) => value % 2 == 1;

        /// <summary>
        /// Returns true if the double is odd, false otherwise
        /// </summary>
        public static bool IsOdd(this double value) => value % 2 == 1;

        /// <summary>
        /// Returns true if the float is odd, false otherwise
        /// </summary>
        public static bool IsOdd(this float value) => value % 2 == 1;

        /// <summary>
        /// Returns true if the int is odd, false otherwise
        /// </summary>
        public static bool IsOdd(this int value) => value % 2 == 1;

        /// <summary>
        /// Returns true if the uint is odd, false otherwise
        /// </summary>
        public static bool IsOdd(this uint value) => value % 2 == 1;
    }
}
