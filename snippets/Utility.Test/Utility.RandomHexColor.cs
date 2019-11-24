using FluentAssertions;
using System.Text.RegularExpressions;
using Xunit;

namespace JonasSchubert.Snippets.Utility.Test
{
    public class UtilityRandomHexColorUnitTest
    {
        [Fact]
        public void RandomHexColor_ShouldReturnExpectedResult_ForGivenData()
        {
            // Arrange + Act
            var actual = Utility.RandomHexColor();

            // Assert
            actual.Length.Should().Be(7);
            Regex.IsMatch(actual, "[#]{1}[0-9A-F]{6}").Should().BeTrue();
        }
    }
}
