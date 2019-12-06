using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringMaskUnitTest
    {
        [Theory]
        [InlineData("1234567890", 4, '*', "******7890")]
        [InlineData("1234567890", 3, '*', "*******890")]
        [InlineData("1234567890", 0, '*', "**********")]
        [InlineData("1234567890", -4, '*', "1234******")]
        [InlineData("1234567890", 20, '-', "----------")]
        [InlineData("1234567890", -20, '.', "1234567890")]
        public void StringMask_ShouldReturnExpectedResult_ForGivenString(string testString, int length, char mask, string expected)
        {
            // Arrange & Act
            var actual = testString.Mask(length, mask);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
