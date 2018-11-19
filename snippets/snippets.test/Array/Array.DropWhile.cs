using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using snippets.Array;
using Xunit;

namespace snippets.test.Array
{
    /// <summary>
    /// Unit tests for Array.DropWhile-Snippet
    /// </summary>
    public class ArrayDropWhileUnitTest
    {
        [Fact]
        public void ReturnEmptyArray_WhenTheConditionNeverMeet()
        {
            // Arrange
            var list = new List<int>
            {
                1, 2, 3, 4, 1
            };

            // Act
            IEnumerable<int> actual = list.DropWhile(x => false);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(0);
        }

        [Fact]
        public void ReturnEquivalentArray_WhenTheConditionAlwaysMeet()
        {
            // Arrange
            var list = new List<int>
            {
                1, 2, 3, 4, 1
            };

            // Act
            IEnumerable<int> actual = list.DropWhile(x => true);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(5);
            actual.Should().BeEquivalentTo(list);
        }

        [Fact]
        public void ReturnExpectedArray_ByGivenCondition()
        {
            // Arrange
            var list = new List<int>
            {
                1, 2, 3, 4, 1
            };

            // Act
            IEnumerable<int> actual = list.DropWhile(x => x > 2);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(3);
            actual.Should().BeEquivalentTo(new List<int> { 3, 4, 1 });
        }

        [Fact]
        public void ShouldThrowException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            List<int> list = null;

            // Act
            Action action = () => list.DropWhile(x => x > 2).ToList();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ShouldThrowException_WhenNullFilter_IsGiven()
        {
            // Arrange
            var list = new List<int>
            {
                1, 2, 3, 4, 1
            };

            // Act
            Action action = () => list.DropWhile(null).ToList();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }
    }
}
