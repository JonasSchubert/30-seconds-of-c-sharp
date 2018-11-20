using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace conplement.snippets.Enumerable.Test
{
    public class EnumerableAllEqualUnitTest
    {
        [Fact]
        public void ReturnTrue_WhenAllEntriesAreEqual()
        {
            // Arrange
            var list = new List<int>
            {
                2, 2, 2, 2, 2
            };

            // Act
            bool actual = list.AllEqual();

            // Assert
            actual.Should().BeTrue();
        }

        [Fact]
        public void ReturnFalse_WhenEntriesAreDifferent()
        {
            // Arrange
            var list = new List<double>
            {
                1.25, 1.25, 1.5, -1.5
            };

            // Act
            bool actual = list.AllEqual();

            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void ShouldThrowException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            List<int> list = null;

            // Act
            Action action = () => list.AllEqual();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }
    }
}
