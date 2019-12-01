using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringToSnakeCaseUnitTest
    {
        [Theory]
        [InlineData("camelCase", "camel_case")]
        [InlineData("some text", "some_text")]
        [InlineData("some-mixed_string With spaces_underscores-and-hyphens", "some_mixed_string_with_spaces_underscores_and_hyphens")]
        [InlineData("AllThe-small Things", "all_the_small_things")]
        [InlineData("IAmListeningToFmWhileLoadingDifferentUrlOnMyBrowserAndAlsoEditingXmlAndHtml", "i_am_listening_to_fm_while_loading_different_url_on_my_browser_and_also_editing_xml_and_html")]
        public void StringToSnakeCase_ShouldReturnExpectedResult_ForGivenString(string input, string expected)
        {
            // Arrange & Act
            var actual = input.ToSnakeCase();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
