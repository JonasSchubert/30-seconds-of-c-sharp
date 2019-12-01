using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringIsPalindromeUnitTest
    {
        [Theory]
        [InlineData("tacocat", true)]
        [InlineData("tAcocat", true)]
        [InlineData("tacoca", false)]
        public void StringIsPalindrome_ShouldReturnExpectedResult_ForGivenString(string input, bool expected)
        {
            // Arrange & Act
            var actual = input.IsPalindrome();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
