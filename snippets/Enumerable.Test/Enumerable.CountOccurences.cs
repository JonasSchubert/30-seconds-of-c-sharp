using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Enumerable.Test
{
    public class EnumerableCountOccurencesUnitTest
    {
        [Fact]
        public void ShouldReturnExpectedDictionary_ForListOfInt()
        {
            // Arrange
            var enumerable = new List<int> { 1, 2, 3, 2, 1 };

            // Act
            var actual = enumerable.CountOccurences(2);

            // Assert
            actual.Should().Be(2);
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForArrayOfBool()
        {
            // Arrange
            var enumerable = new bool[] { false, false, true, true, true };

            // Act
            var actual = enumerable.CountOccurences(true);

            // Assert
            actual.Should().Be(3);
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForArrayOfString()
        {
            // Arrange
            var enumerable = new string[] { "Hello", "Hello", "Hello", "World", "Hello", "", string.Empty };

            // Act
            var actual = enumerable.CountOccurences("Hello");

            // Assert
            actual.Should().Be(4);
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfObject()
        {
            // Arrange
            var object1 = new object();
            var object2 = new object();
            var object3 = new object();
            var enumerable = new List<object> { object1, object2, object3 };

            // Act
            var actual = enumerable.CountOccurences(object2);

            // Assert
            actual.Should().Be(1);
        }

        [Fact]
        public void ShouldThrowArgumentNullException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            List<int> enumerable = null;

            // Act
            Action action = () => enumerable.CountOccurences(2);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }
    }
}
