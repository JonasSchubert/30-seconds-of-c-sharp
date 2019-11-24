using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Enumerable.Test
{
    public class EnumerableNoneUnitTest
    {
        [Fact]
        public void ReturnTrue_WhenNonePredicateMatch_ListInt()
        {
            // Arrange & Act
            var actual = new List<int> { 3, 2, 0 }.None(x => x == 1);

            // Assert
            actual.Should().BeTrue();
        }

        [Fact]
        public void ReturnTrue_WhenNonePredicateMatch_StringArray()
        {
            // Arrange & Act
            var actual = new string[] { "Hello", "World" }.None(x => x.Length == 6);

            // Assert
            actual.Should().BeTrue();
        }

        [Fact]
        public void ReturnTrue_WhenNonePredicateMatch_StringBool()
        {
            // Arrange & Act
            var actual = new bool[] { true, false }.None(x => !x);

            // Assert
            actual.Should().BeFalse();
        }
    }
}
