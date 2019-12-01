using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringToTitleCaseUnitTest
    {
        [Theory]
        [InlineData("some_database_field_name", "Some Database Field Name")]
        [InlineData("Some label that needs to be title-cased", "Some Label That Needs To Be Title Cased")]
        [InlineData("some-package-name", "Some Package Name")]
        [InlineData("some-mixed_string with spaces_underscores-and-hyphens", "Some Mixed String With Spaces Underscores And Hyphens")]
        public void StringToTitleCase_ShouldReturnExpectedResult_ForGivenString(string input, string expected)
        {
            // Arrange & Act
            var actual = input.ToTitleCase();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
