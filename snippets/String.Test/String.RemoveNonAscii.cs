using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringRemoveNonAsciiUnitTest
    {
        [Theory]
        [InlineData("äÄçÇéÉêlorem ipsumöÖÐþúÚ", "lorem ipsum")]
        public void StringRemoveNonAscii_ShouldReturnExpectedResult_ForGivenString(string testString, string expected)
        {
            // Arrange & Act
            var regexResult = testString.RemoveNonAscii();

            // Assert
            regexResult.Should().Be(expected);
        }
    }
}
