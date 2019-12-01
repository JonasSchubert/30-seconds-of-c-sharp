using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringIsLowerUnitTest
    {
        [Theory]
        [InlineData("abc", true)]
        [InlineData("a3@$", true)]
        [InlineData("Ab4", false)]
        public void StringIsLower_ShouldReturnExpectedResult_ForGivenString(string input, bool expected)
        {
            // Arrange & Act
            var actual = input.IsLower();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
