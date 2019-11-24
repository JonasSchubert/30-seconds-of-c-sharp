namespace JonasSchubert.Snippets.Utility
{
    /// <summary>
    /// Partial class for utility snippets
    /// </summary>
    public static partial class Utility
    {
        /// <summary>
        /// Converts the values of RGB components to a color code.
        /// </summary>
        public static string RgbToHex(int red, int green, int blue) =>
            $"#{((red << 16) + (green << 8) + blue).ToString("X").PadLeft(6, '0')}";
    }
}
