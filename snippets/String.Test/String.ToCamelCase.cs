using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringToCamelCaseUnitTest
    {
        [Theory]
        [InlineData("some_database_field_name", "someDatabaseFieldName")]
        [InlineData("Some label that needs to be camelized", "someLabelThatNeedsToBeCamelized")]
        [InlineData("some-javascript-property", "someJavascriptProperty")]
        [InlineData("some-mixed_string with spaces_underscores-and-hyphens", "someMixedStringWithSpacesUnderscoresAndHyphens")]
        public void StringToCamelCase_ShouldReturnExpectedResult_ForGivenString(string input, string expected)
        {
            // Arrange & Act
            var actual = input.ToCamelCase();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
