using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringToKebabCaseUnitTest
    {
        [Theory]
        [InlineData("camelCase", "camel-case")]
        [InlineData("some text", "some-text")]
        [InlineData("some-mixed_string With spaces_underscores-and-hyphens", "some-mixed-string-with-spaces-underscores-and-hyphens")]
        [InlineData("AllThe-small Things", "all-the-small-things")]
        [InlineData("IAmListeningToFmWhileLoadingDifferentUrlOnMyBrowserAndAlsoEditingXmlAndHtml", "i-am-listening-to-fm-while-loading-different-url-on-my-browser-and-also-editing-xml-and-html")]
        public void StringToKebabCase_ShouldReturnExpectedResult_ForGivenString(string input, string expected)
        {
            // Arrange & Act
            var actual = input.ToKebabCase();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
