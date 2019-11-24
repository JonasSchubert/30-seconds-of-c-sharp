using System;

namespace JonasSchubert.Snippets.Math
{
    /// <summary>
    /// Partial class for math snippets
    /// </summary>
    public static partial class Math
    {
        /// <summary>
        /// Checks if the a decimal is divisible by another decimal.
        /// </summary>
        public static bool IsDivisibleBy(this decimal value, decimal divider) => divider == 0 ? throw new DivideByZeroException() : value % divider == 0;

        /// <summary>
        /// Checks if the a double is divisible by another double.
        /// </summary>
        public static bool IsDivisibleBy(this double value, double divider) => divider == 0 ? throw new DivideByZeroException() : value % divider == 0;

        /// <summary>
        /// Checks if the a float is divisible by another float.
        /// </summary>
        public static bool IsDivisibleBy(this float value, float divider) => divider == 0 ? throw new DivideByZeroException() : value % divider == 0;

        /// <summary>
        /// Checks if the a int is divisible by another int.
        /// </summary>
        public static bool IsDivisibleBy(this int value, int divider) => divider == 0 ? throw new DivideByZeroException() : value % divider == 0;

        /// <summary>
        /// Checks if the a uint is divisible by another uint.
        /// </summary>
        public static bool IsDivisibleBy(this uint value, uint divider) => divider == 0 ? throw new DivideByZeroException() : value % divider == 0;
    }
}
