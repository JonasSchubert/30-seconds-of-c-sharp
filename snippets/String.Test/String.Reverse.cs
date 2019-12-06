using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringReverseUnitTest
    {
        [Theory]
        [InlineData("Hello", "olleH")]
        [InlineData("World", "dlroW")]
        [InlineData("My name is Jonas Schubert", "trebuhcS sanoJ si eman yM")]
        [InlineData("With a number of 123456789", "987654321 fo rebmun a htiW")]
        [InlineData("!This is, maybe not, but important...", "...tnatropmi tub ,ton ebyam ,si sihT!")]
        public void StringReverse_ShouldReturnExpectedResult_ForGivenString(string input, string expected)
        {
            // Arrange & Act
            var actual = input.Reverse();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
