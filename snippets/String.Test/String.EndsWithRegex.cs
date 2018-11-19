using System.Text.RegularExpressions;
using FluentAssertions;
using Xunit;

namespace conplement.snippets.String.Test
{
    public class StringEndsWithRegexUnitTest
    {
        [Fact]
        public void StringEndsWithRegex_ShouldReturnExpectedResult_ForGivenString()
        {
            // Arrange
            const string testString = "Hello World";
            var regex = new Regex(@"[dolrwDOLRW]{5}$");

            // Act
            var regexResult = testString.EndsWithRegex(regex);

            // Assert
            regexResult.Should().BeTrue();
        }
    }
}
