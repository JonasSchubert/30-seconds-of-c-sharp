using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Utility.Test
{
    public class UtilityHexToRgbUnitTest
    {
        [Theory]
        [InlineData("#fff", "rgb(255, 255, 255)")]
        [InlineData("#27ae60", "rgb(39, 174, 96)")]
        [InlineData("#27ae60ff", "rgba(39, 174, 96, 255)")]
        public void HexToRgb_ShouldReturnExpectedResult_ForGivenData(string hex, string expected)
        {
            // Arrange + Act
            var actual = Utility.HexToRgb(hex);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
