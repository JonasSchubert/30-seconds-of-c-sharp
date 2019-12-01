using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringWordsUnitTest
    {
        public static readonly IEnumerable<object[]> TestMemberData = new[] {
                new object[] {"Hello World", new List<string> { "Hello", "World" } },
                new object[] {"Hello", new List<string> { "Hello" } },
                new object[] {"   ", new List<string> {  } }
            };

        [Theory]
        [MemberData(nameof(TestMemberData))]
        public void StringWords_ShouldReturnExpectedResult_ForGivenString(string input, List<string> expected)
        {
            // Arrange & Act
            var actual = input.Words();

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
