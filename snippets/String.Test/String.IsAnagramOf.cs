using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringIsAnagramOfUnitTest
    {
        [Theory]
        [InlineData("iceman", "cinema", true)]
        [InlineData("icemAn", "cinema", true)]
        [InlineData("icem an", "cinema", false)]
        [InlineData("ic.EMan", "cinema", false)]
        [InlineData("icman", "cinema", false)]
        public void StringIsAnagramOf_ShouldReturnExpectedResult_ForGivenString(string input, string compare, bool expected)
        {
            // Arrange & Act
            var actual = input.IsAnagramOf(compare);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
