using System;

namespace JonasSchubert.Snippets.Type2
{
    /// <summary>
    /// Partial class for Type snippets
    /// </summary>
    public static partial class Type2
    {
        /// <summary>
        /// Checks if a type is of numeric type
        /// </summary>
        /// <param name="type">The type</param>
        /// <returns>True or False if type is numeric</returns>
        public static bool IsNumericType(this Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }
    }
}
