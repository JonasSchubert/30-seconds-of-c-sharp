namespace JonasSchubert.Snippets.Math
{
    /// <summary>
    /// Partial class for math snippets
    /// </summary>
    public static partial class Math
    {
        /// <summary>
        /// Calculates the factorial of a number.
        /// </summary>
        public static uint Factorial(uint number)
        {
            var result = 1u;

            for (var index = number; index > 0; index--)
            {
                result *= index;
            }

            return result;
        }
    }
}
