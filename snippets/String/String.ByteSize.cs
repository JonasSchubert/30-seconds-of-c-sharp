namespace JonasSchubert.Snippets.String
{
    /// <summary>
    /// Partial class for string snippets
    /// </summary>
    public static partial class String
    {
        /// <summary>
        /// Returns the length of a string (Default) in bytes.
        /// </summary>
        public static int ByteSize(this string input) => System.Text.Encoding.Default.GetByteCount(input);

        /// <summary>
        /// Returns the length of a string (Ascii) in bytes.
        /// </summary>
        public static int ByteSizeAscii(this string input) => System.Text.Encoding.ASCII.GetByteCount(input);

        /// <summary>
        /// Returns the length of a string (BigEndianUnicode) in bytes.
        /// </summary>
        public static int ByteSizeBigEndianUnicode(this string input) => System.Text.Encoding.BigEndianUnicode.GetByteCount(input);

        /// <summary>
        /// Returns the length of a string (Unicode) in bytes.
        /// </summary>
        public static int ByteSizeUnicode(this string input) => System.Text.Encoding.Unicode.GetByteCount(input);

        /// <summary>
        /// Returns the length of a string (Utf7) in bytes.
        /// </summary>
        public static int ByteSizeUtf7(this string input) => System.Text.Encoding.UTF7.GetByteCount(input);

        /// <summary>
        /// Returns the length of a string (Utf8) in bytes.
        /// </summary>
        public static int ByteSizeUtf8(this string input) => System.Text.Encoding.UTF8.GetByteCount(input);

        /// <summary>
        /// Returns the length of a string (Utf32) in bytes.
        /// </summary>
        public static int ByteSizeUtf32(this string input) => System.Text.Encoding.UTF32.GetByteCount(input);
    }
}
