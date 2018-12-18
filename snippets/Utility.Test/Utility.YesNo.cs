using FluentAssertions;
using Xunit;

namespace Conplement.Snippets.Utility.Test
{
    public class UtilityYesNoUnitTest
    {
        [Theory]
        [InlineData("", false)]
        [InlineData("y", true)]
        [InlineData("Y", true)]
        [InlineData("ye", false)]
        [InlineData("yes", true)]
        [InlineData("yEs", true)]
        [InlineData("n", false)]
        [InlineData("N", false)]
        [InlineData("no", false)]
        [InlineData("nO", false)]
        [InlineData("nö", false)]
        [InlineData("noyes", false)]
        [InlineData("yesno", false)]
        public void YesNo_ShouldReturnExpectedResult_ForGivenData(string test, bool expected)
        {
            // Arrange + Act
            var actual = test.YesNo();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
