namespace JonasSchubert.Snippets.Math
{
    /// <summary>
    /// Partial class for math snippets
    /// </summary>
    public static partial class Math
    {
        /// <summary>
        /// Returns true if the decimal is even, false otherwise
        /// </summary>
        public static bool IsEven(this decimal value) => value % 2 == 0;

        /// <summary>
        /// Returns true if the double is even, false otherwise
        /// </summary>
        public static bool IsEven(this double value) => value % 2 == 0;

        /// <summary>
        /// Returns true if the float is even, false otherwise
        /// </summary>
        public static bool IsEven(this float value) => value % 2 == 0;

        /// <summary>
        /// Returns true if the int is even, false otherwise
        /// </summary>
        public static bool IsEven(this int value) => value % 2 == 0;

        /// <summary>
        /// Returns true if the uint is even, false otherwise
        /// </summary>
        public static bool IsEven(this uint value) => value % 2 == 0;
    }
}
