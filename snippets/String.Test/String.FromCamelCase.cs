using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringFromCamelCaseUnitTest
    {
        [Theory]
        [InlineData("someDatabaseFieldName", " ", true, "Some database field name.")]
        [InlineData("someLabelThatNeedsToBeCamelized", "-", false, "some-label-that-needs-to-be-camelized")]
        [InlineData("someJavascriptProperty", "_", false, "some_javascript_property")]
        public void StringFromCamelCase_ShouldReturnExpectedResult_ForGivenString(string input, string separator, bool isSentence, string expected)
        {
            // Arrange & Act
            var actual = input.FromCamelCase(separator, isSentence);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
