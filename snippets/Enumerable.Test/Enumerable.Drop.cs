using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Conplement.Snippets.Enumerable.Test
{
    public class EnumerableDropUnitTest
    {
        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfInt()
        {
            // Arrange
            var enumerable = new List<int> { 1, 2, 3, 4, 5 };
            var expected = new List<int> { 4, 5 };

            // Act
            var actual = enumerable.Drop(3);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Count > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForArrayOfBool()
        {
            // Arrange
            var enumerable = new bool[] { false, false, true, true };
            var expected = new bool[] { };

            // Act
            var actual = enumerable.Drop(4);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Length > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForArrayOfString()
        {
            // Arrange
            var enumerable = new string[] { "Hello", "This", "Is", "Conplement", "Awesome", ":D" };
            var expected = new string[] { "Hello", "This", "Is", "Conplement", "Awesome", ":D" };

            // Act
            var actual = enumerable.Drop(0);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
            if (expected.Length > 0)
            {
                actual.First().Should().Be(expected.First());
                actual.Last().Should().Be(expected.Last());
            }
        }

        [Fact]
        public void ShouldReturnExpectedEnumerable_ForListOfObject()
        {
            // Arrange
            var enumerable = new List<object> { new object(), new object(), new object() };
            var expected = new List<object> { new object(), new object() };

            // Act
            var actual = enumerable.Drop(1);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(expected.Count());
        }

        [Fact]
        public void ShouldThrowArgumentOutOfRangeException_WhenEnumerable_IsSmallerThenDropCount()
        {
            // Arrange
            var list = new string[] { "Hello", "world" };

            // Act
            Action action = () => list.Drop(3).ToList();

            // Assert
            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void ShouldThrowArgumentNullException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            List<int> list = null;

            // Act
            Action action = () => list.Drop(0).ToList();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }
    }
}
