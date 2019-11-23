namespace JonasSchubert.Snippets.Math
{
    /// <summary>
    /// Partial class for math snippets
    /// </summary>
    public static partial class Math
    {
        /// <summary>
        /// Converts an angle from degrees to radians.
        /// </summary>
        public static double DegToRad(this decimal degree) => (double)degree * System.Math.PI / 180.0;

        /// <summary>
        /// Converts an angle from degrees to radians.
        /// </summary>
        public static double DegToRad(this double degree) => degree * System.Math.PI / 180.0;

        /// <summary>
        /// Converts an angle from degrees to radians.
        /// </summary>
        public static double DegToRad(this float degree) => degree * System.Math.PI / 180.0;

        /// <summary>
        /// Converts an angle from degrees to radians.
        /// </summary>
        public static double DegToRad(this int degree) => degree * System.Math.PI / 180.0;

        /// <summary>
        /// Converts an angle from degrees to radians.
        /// </summary>
        public static double DegToRad(this uint degree) => degree * System.Math.PI / 180.0;
    }
}
