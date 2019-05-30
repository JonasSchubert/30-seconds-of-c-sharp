using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Conplement.Snippets.Enumerable.Test
{
    public class EnumerableIntersectionWhereUnitTest
    {
        [Fact]
        public void ReturnIntersectionWhere_ForListsOfInt()
        {
            // Arrange
            var list1 = new List<int>
            {
                1, 2, 3, 4, 0
            };
            var list2 = new List<int>
            {
                1, 5, 3, 4, 1
            };

            // Act
            var actual = list1.IntersectionWhere(list2, x => x > 1);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(2);
            actual.ElementAt(0).Should().Be(3);
            actual.ElementAt(1).Should().Be(4);
        }

        [Fact]
        public void ReturnIntersectionWhere_ForArraysOfString()
        {
            // Arrange
            var array1 = new string[]
            {
                "Hello", "world", "organisation", "seconds", "of"
            };
            var array2 = new string[]
            {
                "of", "organisation", "conplement", "Hello", "of"
            };

            // Act
            var actual = array1.IntersectionWhere(array2, x => x.Contains("or"));

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(1);
            actual.ElementAt(0).Should().Be("organisation");
        }

        [Fact]
        public void ReturnIntersectionWhere_ForListOfBoolean()
        {
            // Arrange
            var list1 = new List<bool>
            {
                false, false, false, false, false, false, false, false, false
            };
            var list2 = new List<bool>
            {
                false, false, false, true, false, false, true, false, true
            };

            // Act
            var actual = list1.IntersectionWhere(list2, x => x);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(0);
        }

        [Fact]
        public void ReturnIntersectionWhere_ForArrayOfComplex_WithExactlyTheSame()
        {
            // Arrange
            var person1 = new Person { Name = "Tina" };
            var person2 = new Person { Name = "Thomas" };
            var person3 = new Person { Name = "Annabelle" };
            var person4 = new Person { Name = "Tina" };

            var list1 = new List<Person>
            {
                person1, person2, person3, person4
            };
            var list2 = new List<Person>
            {
                person1, person2, person3, person4
            };

            // Act
            var actual = list1.IntersectionWhere(list2, x => x.Name != null);

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(4);
            actual.ElementAt(0).Should().Be(person1);
            actual.ElementAt(1).Should().Be(person2);
            actual.ElementAt(2).Should().Be(person3);
            actual.ElementAt(3).Should().Be(person4);
        }

        [Fact]
        public void ReturnIntersectionWhere_ForArrayOfComplex_WithDifferences_ButCannotWorkProperly()
        {
            // Arrange
            var list1 = new List<Person>
            {
                new Person { Name = "Tina" },
                new Person { Name = "Thomas" },
                new Person { Name = "Annabelle" },
                new Person { Name = "John" },
                new Person { Name = "Richard" }
            };
            var list2 = new List<Person>
            {
                new Person { Name = "Annabelle" },
                new Person { Name = "John" },
                new Person { Name = "Richard" }
            };

            // Act
            var actual = list1.IntersectionWhere(list2, x => x.Name.EndsWith("as") || x.Name.StartsWith("A"));

            // Assert
            actual.Should().NotBeNull();
            actual.Count().Should().Be(0);
        }

        [Fact]
        public void ShouldThrowException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            double[] array1 = null;
            var array2 = new double[]
            {
                1, 2, 3, 4, 1
            };

            // Act
            Action action = () => array1.IntersectionWhere(array2, x => x / 2 < 5);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ShouldThrowException_WhenNullComparator_IsGiven()
        {
            // Arrange
            var list1 = new List<int>
            {
                1, 2, 3, 4, 1
            };

            // Act
            Action action = () => list1.IntersectionWhere(null, x => x * 5 == 5);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ShouldThrowException_WhenNullSelector_IsGiven()
        {
            // Arrange
            var list1 = new List<int>
            {
                1, 2, 3, 4, 1
            };
            var list2 = new List<int>
            {
                2, 4, 6, 7, 2
            };

            // Act
            Action action = () => list1.IntersectionWhere(list2, null);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        private class Person
        {
            public string Name { get; set; }
        }
    }
}
