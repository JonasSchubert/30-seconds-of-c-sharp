using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Enumerable.Test
{
    public class EnumerableChunkUnitTest
    {
        [Fact]
        public void ShouldReturnExpected_ForListOfBoolean()
        {
            // Arrange
            var list = new List<bool> { true, true, true, true, false, true, false };

            // Act
            var actual = list.Chunk(2);

            // Assert
            actual.Count.Should().Be(4);
            actual[0].Count.Should().Be(2);
            actual[0][0].Should().BeTrue();
            actual[0][1].Should().BeTrue();
            actual[1].Count.Should().Be(2);
            actual[1][0].Should().BeTrue();
            actual[1][1].Should().BeTrue();
            actual[2].Count.Should().Be(2);
            actual[2][0].Should().BeFalse();
            actual[2][1].Should().BeTrue();
            actual[3].Count.Should().Be(1);
            actual[3][0].Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnExpected_ForArrayOfString()
        {
            // Arrange
            var list = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" };

            // Act
            var actual = list.Chunk(6);

            // Assert
            actual.Count.Should().Be(2);
            actual[0].Count.Should().Be(6);
            actual[1].Count.Should().Be(5);
        }

        [Fact]
        public void ShouldReturnExpected_ForArrayOfInteger()
        {
            // Arrange
            var list = new int[] { 0, 1, 2 };

            // Act
            var actual = list.Chunk(6);

            // Assert
            actual.Count.Should().Be(1);
            actual[0].Count.Should().Be(3);
        }
    }
}
