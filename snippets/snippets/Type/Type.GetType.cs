namespace snippets.Type
{
    /// <summary>
    /// Partial class for type snippets
    /// </summary>
    public static partial class SnippetsType
    {
        /// <summary>
        /// Returns the native type of a value.
        /// </summary>
        /// Already integrated into C#
        /// https://docs.microsoft.com/de-de/dotnet/api/system.object.gettype?view=netframework-4.7.2
        public static System.Type GetType(object obj)
        {
            return obj.GetType();
        }
    }
}
