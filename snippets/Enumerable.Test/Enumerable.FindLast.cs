using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.Enumerable.Test
{
    public class EnumerableFindLastUnitTest
    {
        [Fact]
        public void ReturnExpected_ForListsOfInt()
        {
            // Arrange
            var list = new List<int> { 1, 2, 3, 4, 0 };

            // Act
            var actual = list.FindLast(x => x % 4 == 0 && x != 0);

            // Assert
            actual.Should().Be(4);
        }

        [Fact]
        public void ReturnExpected_ForArraysOfString()
        {
            // Arrange
            var array = new string[] { "Hello", "world", "organisation", "seconds", "of" };

            // Act
            var actual = array.FindLast(x => x.Contains("or"));

            // Assert
            actual.Should().Be("organisation");
        }

        [Fact]
        public void ReturnExpected_ForListOfBoolean()
        {
            // Arrange
            var list = new List<bool?> { false, false, false, false, false, false, false, false, false };

            // Act
            var actual = list.FindLast(x => x == true);

            // Assert
            actual.Should().Be(null);
        }

        [Fact]
        public void ReturnExpected_ForArrayOfComplex()
        {
            // Arrange
            var list = new List<Person> { new Person { Name = "Tina" }, new Person { Name = "Thomas" }, new Person { Name = "Annabelle" }, new Person { Name = "Tina" } };

            // Act
            var actual = list.FindLast(x => x.Name.StartsWith("T"));

            // Assert
            actual.Should().Be(list.ElementAt(3));
        }

        [Fact]
        public void ShouldThrowException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            double[] array = null;

            // Act
            Action action = () => array.FindLast(x => x == 0);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ShouldThrowException_WhenNullWhereFunction_IsGiven()
        {
            // Arrange
            var list = new List<uint> { 1, 2, 3, 4 };

            // Act
            Action action = () => list.FindLast(null);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        private class Person
        {
            public string Name { get; set; }
        }
    }
}
