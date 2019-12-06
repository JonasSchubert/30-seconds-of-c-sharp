using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringEndsWithRegexUnitTest
    {
        [Theory]
        [InlineData("Hello World", @"[dolrwDOLRW]{5}", true)]
        [InlineData("Hello World, this is it", @"[dolrwDOLRW]{5}", false)]
        public void StringEndsWithRegex_ShouldReturnExpectedResult_ForGivenString(string testString, string substring, bool expected)
        {
            // Arrange & Act
            var regexResult = testString.EndsWithRegex(substring);

            // Assert
            regexResult.Should().Be(expected);
        }
    }
}
