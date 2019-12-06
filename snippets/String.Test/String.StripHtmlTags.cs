using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringStripHtmlTagsUnitTest
    {
        [Theory]
        [InlineData("<p><em>lorem</em> <strong>ipsum</strong></p>", "lorem ipsum")]
        [InlineData("<div><br/>Hello <br />World</div>", "Hello World")]
        public void StringStripHtmlTags_ShouldReturnExpectedResult_ForGivenString(string testString, string expected)
        {
            // Arrange & Act
            var regexResult = testString.StripHtmlTags();

            // Assert
            regexResult.Should().Be(expected);
        }
    }
}
