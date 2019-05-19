using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Conplement.Snippets.Enumerable.Test
{
    public class EnumerableDropRightWhileUnitTest
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
            IEnumerable<int> actual = list.DropRightWhile(x => false);

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
            IEnumerable<int> actual = list.DropRightWhile(x => true);

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
            IEnumerable<int> actual = list.DropRightWhile(x => x > 2);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(4);
            actual.Should().BeEquivalentTo(new List<int> { 1, 2, 3, 4 });
        }

        [Fact]
        public void ShouldThrowException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            List<int> list = null;

            // Act
            Action action = () => list.DropRightWhile(x => x > 2).ToList();

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
            Action action = () => list.DropRightWhile(null).ToList();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }
    }
}
