namespace JonasSchubert.Snippets.Math
{
    /// <summary>
    /// Partial class for math snippets
    /// </summary>
    public static partial class Math
    {
        /// <summary>
        /// Converts an angle from radians to degrees.
        /// </summary>
        public static double RadToDeg(this decimal radians) => (double)radians * 180.0 / System.Math.PI;

        /// <summary>
        /// Converts an angle from radians to degrees.
        /// </summary>
        public static double RadToDeg(this double radians) => radians * 180.0 / System.Math.PI;

        /// <summary>
        /// Converts an angle from radians to degrees.
        /// </summary>
        public static double RadToDeg(this float radians) => radians * 180.0 / System.Math.PI;

        /// <summary>
        /// Converts an angle from radians to degrees.
        /// </summary>
        public static double RadToDeg(this int radians) => radians * 180.0 / System.Math.PI;

        /// <summary>
        /// Converts an angle from radians to degrees.
        /// </summary>
        public static double RadToDeg(this uint radians) => radians * 180.0 / System.Math.PI;
    }
}
