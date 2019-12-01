using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringTruncateUnitTest
    {
        [Theory]
        [InlineData("Hello World", 2, "He...")]
        [InlineData("Hello World", 4, "H...")]
        [InlineData("Hello World", 8, "Hello...")]
        [InlineData("Hello World", 12, "Hello World")]
        [InlineData("Hello World", 20, "Hello World")]
        public void StringTruncate_ShouldReturnExpectedResult_ForGivenString(string input, int maxLength, string expected)
        {
            // Arrange & Act
            var actual = input.Truncate(maxLength);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
