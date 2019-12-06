namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Pads a string on both sides with the specified character, if it's shorter than the specified length.
        /// Use `PadLeft()` and `PadRight()` to pad both sides of the given string.
        /// Omit the third argument, `char`, to use the whitespace character as the default padding character.
        /// </summary>
        public static string Pad(this string input, int length, char pad = ' ') => input.PadLeft((input.Length + length) / 2, pad).PadRight(length, pad);
    }
}
