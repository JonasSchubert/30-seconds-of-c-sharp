using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Conplement.Snippets.Enumerable.Test
{
    public class EnumerableFindLastIndexUnitTest
    {
        [Fact]
        public void ReturnExpected_ForListsOfInt()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3, 4, 0 };

            // Act
            var actual = list.FindLastIndex(x => x % 4 == 0 && x != 0);

            // Assert
            actual.Should().Be(3);
        }

        [Fact]
        public void ReturnExpected_ForArraysOfString()
        {
            // Arrange
            var array = new string[] { "Hello", "world", "organisation", "seconds", "of" };

            // Act
            var actual = array.FindLastIndex(x => x.Contains("or"));

            // Assert
            actual.Should().Be(2);
        }

        [Fact]
        public void ReturnExpected_ForListOfBoolean()
        {
            // Arrange
            var list = new List<bool?> { false, false, false, false, false, false, false, false, false };

            // Act
            var actual = list.FindLastIndex(x => x == true);

            // Assert
            actual.Should().Be(-1);
        }

        [Fact]
        public void ReturnExpected_ForArrayOfComplex()
        {
            // Arrange
            var list = new List<Person> { new Person { Name = "Tina" }, new Person { Name = "Thomas" }, new Person { Name = "Annabelle" }, new Person { Name = "Tina" } };

            // Act
            var actual = list.FindLastIndex(x => x.Name.StartsWith("T"));

            // Assert
            actual.Should().Be(3);
        }

        [Fact]
        public void ShouldThrowException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            double[] array = null;

            // Act
            Action action = () => array.FindLastIndex(x => x == 0);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ShouldThrowException_WhenNullWhereFunction_IsGiven()
        {
            // Arrange
            var list = new List<uint> { 1, 2, 3, 4 };

            // Act
            Action action = () => list.FindLastIndex(null);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        private class Person
        {
            public string Name { get; set; }
        }
    }
}
