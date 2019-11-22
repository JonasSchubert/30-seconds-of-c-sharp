using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Enumerable.Test
{
    public class EnumerableIndexOfAllUnitTest
    {
        [Fact]
        public void ReturnExpected_ForListsOfInt()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3, 4, 0 };
            var expected = new List<int> { 3, 4 };

            // Act
            var actual = list.IndexOfAll(x => x % 4 == 0);

            // Assert
            actual.Count().Should().Be(expected.Count());
            for (var index = 0; index < actual.Count(); index++)
            {
                actual.ElementAt(index).Should().Be(expected.ElementAt(index));
            }
        }

        [Fact]
        public void ReturnExpected_ForArraysOfString()
        {
            // Arrange
            var array = new string[] { "Hello", "world", "organisation", "seconds", "or" };
            var expected = new List<int> { 1, 2, 4 };

            // Act
            var actual = array.IndexOfAll(x => x.Contains("or"));

            // Assert
            actual.Count().Should().Be(expected.Count());
            for (var index = 0; index < actual.Count(); index++)
            {
                actual.ElementAt(index).Should().Be(expected.ElementAt(index));
            }
        }

        [Fact]
        public void ReturnExpected_ForListOfBoolean()
        {
            // Arrange
            var list = new List<bool?> { false, false, false, false, false, false, false, false, false };

            // Act
            var actual = list.IndexOfAll(x => x == true);

            // Assert
            actual.Should().BeEmpty();
        }

        [Fact]
        public void ReturnExpected_ForArrayOfComplex()
        {
            // Arrange
            var list = new List<Person> { new Person { Name = "Tina" }, new Person { Name = "Thomas" }, new Person { Name = "Annabelle" }, new Person { Name = "Tina" } };
            var expected = new List<int> { 0, 1, 3 };

            // Act
            var actual = list.IndexOfAll(x => x.Name.StartsWith("T"));

            // Assert
            actual.Count().Should().Be(expected.Count());
            for (var index = 0; index < actual.Count(); index++)
            {
                actual.ElementAt(index).Should().Be(expected.ElementAt(index));
            }
        }

        [Fact]
        public void ShouldThrowException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            double[] array = null;

            // Act
            Action action = () => array.IndexOfAll(x => x == 0).ToList();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ShouldThrowException_WhenNullWhereFunction_IsGiven()
        {
            // Arrange
            var list = new List<uint> { 1, 2, 3, 4 };

            // Act
            Action action = () => list.IndexOfAll(null).ToList();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        private class Person
        {
            public string Name { get; set; }
        }
    }
}
