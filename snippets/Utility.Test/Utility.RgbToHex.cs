using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Utility.Test
{
    public class UtilityRgbToHexUnitTest
    {
        [Theory]
        [InlineData(0, 0, 0, "#000000")]
        [InlineData(1, 1, 1, "#010101")]
        [InlineData(1, 165, 255, "#01A5FF")]
        [InlineData(255, 165, 1, "#FFA501")]
        [InlineData(165, 165, 165, "#A5A5A5")]
        [InlineData(255, 255, 255, "#FFFFFF")]
        public void RgbToHex_ShouldReturnExpectedResult_ForGivenData(int red, int green, int blue, string expected)
        {
            // Arrange + Act
            var actual = Utility.RgbToHex(red, green, blue);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
