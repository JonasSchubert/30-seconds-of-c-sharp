namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Replaces all but the last `length` of characters with the specified `mask` character.
        /// Omit the second argument, `length`, to keep a default of `4` characters unmasked.
        /// If `length` is negative, the unmasked characters will be at the start of the string.
        /// Omit the third argument, `mask`, to use a default character of `'*'` for the mask.
        /// </summary>
        public static string Mask(this string input, int length = 4, char mask = '*') =>
            length >= input.Length
            ? new string(mask, input.Length)
            : length >= 0
                ? input.Remove(0, input.Length - length).Insert(0, new string(mask, input.Length - length))
                : -length >= input.Length
                    ? input
                    : input.Remove(-length, input.Length + length).Insert(-length, new string(mask, input.Length + length));
    }
}
