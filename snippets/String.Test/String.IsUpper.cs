using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringIsUpperUnitTest
    {
        [Theory]
        [InlineData("ABC", true)]
        [InlineData("A3@$", true)]
        [InlineData("aB4", false)]
        public void StringIsUpper_ShouldReturnExpectedResult_ForGivenString(string input, bool expected)
        {
            // Arrange & Act
            var actual = input.IsUpper();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
