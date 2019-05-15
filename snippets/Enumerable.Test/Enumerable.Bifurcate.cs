using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Conplement.Snippets.Enumerable.Test
{
    public class EnumerableBifurcateUnitTest
    {
        [Fact]
        public void ReturnArray1EmptyAndArray2Full_WhenTheFilterAlwaysMeet()
        {
            // Arrange
            var list = new List<int>
            {
                1, 2, 3, 4, 1
            };

            // Act
            (IEnumerable<int> actual1, IEnumerable<int> actual2) = list.Bifurcate(x => x > 0);

            // Assert
            actual1.Should().NotBeNull();
            actual1.Count().Should().Be(5);
            actual1.Should().BeEquivalentTo(list);
            actual2.Should().NotBeNull();
            actual2.Count().Should().Be(0);
        }

        [Fact]
        public void ReturnArray1FullAndArray2Empty_WhenTheFilterNeverMeets()
        {
            // Arrange
            var list = new List<string>
            {
                "Hello","world","organisation","seconds","of"
            };

            // Act
            (IEnumerable<string> actual1, IEnumerable<string> actual2) = list.Bifurcate(x => !x.Contains("o"));

            // Assert
            actual1.Should().NotBeNull();
            actual1.Count().Should().Be(0);
            actual2.Should().NotBeNull();
            actual2.Count().Should().Be(5);
            actual2.Should().BeEquivalentTo(list);
        }

        [Fact]
        public void ReturnExpectedSplittedArrays_WhenTheFilterPartiallyMeets()
        {
            // Arrange
            var list = new List<bool>
            {
                false, true, false, false, false, false, false, false, true
            };

            // Act
            (IEnumerable<bool> actual1, IEnumerable<bool> actual2) = list.Bifurcate(x => x);

            // Assert
            actual1.Should().NotBeNull();
            actual1.Count().Should().Be(2);
            actual2.Should().NotBeNull();
            actual2.Count().Should().Be(7);
        }

        [Fact]
        public void ShouldWorkForComplexTypes()
        {
            // Arrange
            var list = new List<Person>
            {
                new Person { Name = "Tina" },
                new Person { Name = "Thomas" },
                new Person { Name = "Annabelle" },
                new Person { Name = "John" },
                new Person { Name = "Richard" }
            };

            // Act
            (IEnumerable<Person> actual1, IEnumerable<Person> actual2) = list.Bifurcate(x => x.Name.StartsWith("T"));

            // Assert
            actual1.Should().NotBeNull();
            actual1.Count().Should().Be(2);
            actual2.Should().NotBeNull();
            actual2.Count().Should().Be(3);
        }

        [Fact]
        public void ShouldThrowException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            List<int> list = null;

            // Act
            Action action = () => list.Bifurcate(x => x > 2);

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
            Action action = () => list.Bifurcate(null);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        private class Person
        {
            public string Name { get; set; }
        }
    }
}
