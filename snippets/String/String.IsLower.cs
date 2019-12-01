namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Checks if a string is lower case.
        /// </summary>
        public static bool IsLower(this string input) => input == input.ToLower();
    }
}
