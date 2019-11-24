using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Utility.Test
{
    public class UtilityExtendHexUnitTest
    {
        [Theory]
        [InlineData("#03f", "#0033ff")]
        [InlineData("05a", "#0055aa")]
        public void ExtendHex_ShouldReturnExpectedResult_ForGivenData(string test, string expected)
        {
            // Arrange + Act
            var actual = test.ExtendHex();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
