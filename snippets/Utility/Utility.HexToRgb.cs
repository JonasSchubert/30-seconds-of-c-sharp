using System.Globalization;
using System.Linq;

namespace JonasSchubert.Snippets.Utility
{
    /// <summary>
    /// Partial class for utility snippets
    /// </summary>
    public static partial class Utility
    {
        /// <summary>
        /// Converts a color code to a `rgb()` or `rgba()` string if alpha value is provided.
        /// </summary>
        public static string HexToRgb(string value)
        {
            value = value.Replace("#", "");
            var hasAlpha = value.Length == 8;
            value = value.Length == 3 ? string.Join("", value.Select(x => $"{x}{x}")) : value;
            var valueAsInt = int.Parse(value, NumberStyles.HexNumber);

            var red = valueAsInt >> (hasAlpha ? 24 : 16);
            var green = (valueAsInt & (hasAlpha ? 0x00ff0000 : 0x00ff00)) >> (hasAlpha ? 16 : 8);
            var blue = (valueAsInt & (hasAlpha ? 0x0000ff00 : 0x0000ff)) >> (hasAlpha ? 8 : 0);
            var alpha = hasAlpha ? $"{ valueAsInt & 0x000000ff}" : null;

            return $"rgb{(hasAlpha ? "a" : "")}({red}, {green}, {blue}{(hasAlpha ? $", {alpha}" : "")})";
        }
    }
}
