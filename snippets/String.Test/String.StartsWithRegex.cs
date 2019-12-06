using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringStartsWithRegexUnitTest
    {
        [Theory]
        [InlineData("Hello World", @"[ehloEHLO]{5}", true)]
        [InlineData("Well, hello World", @"[ehloEHLO]{5}", false)]
        public void StringStartsWithRegex_ShouldReturnExpectedResult_ForGivenString(string testString, string substring, bool expected)
        {
            // Arrange & Act
            var regexResult = testString.StartsWithRegex(substring);

            // Assert
            regexResult.Should().Be(expected);
        }
    }
}
