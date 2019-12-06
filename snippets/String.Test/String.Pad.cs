using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringPadUnitTest
    {
        [Theory]
        [InlineData("Hello World.", 20, ' ', "    Hello World.    ")]
        [InlineData("Hello World.", 5, '-', "Hello World.")]
        [InlineData("Dog", 8, ' ', "  Dog   ")]
        [InlineData("42", 6, '0', "004200")]
        public void StringPad_ShouldReturnExpectedResult_ForGivenString(string testString, int length, char pad, string expected)
        {
            // Arrange & Act
            var actual = testString.Pad(length, pad);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
