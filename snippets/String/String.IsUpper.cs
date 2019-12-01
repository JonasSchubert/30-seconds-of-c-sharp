namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Checks if a string is upper case.
        /// </summary>
        public static bool IsUpper(this string input) => input == input.ToUpper();
    }
}
