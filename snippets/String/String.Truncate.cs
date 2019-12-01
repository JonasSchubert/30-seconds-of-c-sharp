namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Truncates a string up to a specified length.
        /// </summary>
        public static string Truncate(this string input, int maxLength) =>
            input.Length > maxLength ? $"{input.Substring(0, maxLength > 3 ? maxLength - 3 : maxLength)}..." : input;
    }
}
