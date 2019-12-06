using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringSplitLinesUnitTest
    {
        [Theory]
        [InlineData("This\nis a\nmultiline\nstring.\n", new string[] { "This", "is a", "multiline", "string.", "" })]
        public void StringSplitLines_ShouldReturnExpectedResult_ForGivenString(string testString, string[] expected)
        {
            // Arrange & Act
            var regexResult = testString.SplitLines();

            // Assert
            regexResult.Should().Equal(expected);
        }
    }
}
