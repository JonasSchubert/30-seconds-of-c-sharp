using System;
using FluentAssertions;
using snippets.Array;
using Xunit;

namespace snippets.test.Array
{
    /// <summary>
    /// Unit tests for Array.All-Snippet
    /// </summary>
    public class ArrayInitialize2DArrayUnitTest
    {
        [Fact]
        public void ShouldReturnAnExpectedArray()
        {
            // Arrange
            var expected = new int[2, 2] { { 0, 0 }, { 0, 0 } };

            // Act
            var actual = SnippetsArray.Initialize2DArray(2, 2, 0);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ShouldThrowArgumentException_IfWidthIs0()
        {
            // Act
            Action action = () => SnippetsArray.Initialize2DArray<string>(0, 1);

            // Assert
            action.Should().Throw<ArgumentException>("Minimum width has to be 1", "width");
        }

        [Fact]
        public void ShouldThrowArgumentException_IfHeightIs0()
        {
            // Act
            Action action = () => SnippetsArray.Initialize2DArray<double>(1, 0);

            // Assert
            action.Should().Throw<ArgumentException>("Minimum height has to be 1", "height");
        }

        [Fact]
        public void ShouldWorkForComplexTypes_IfProvided()
        {
            // Arrange
            var person = new Person
            {
                Name = "Herbert",
                Address = new Address
                {
                    Street = "Frauentormauer"
                }
            };
            var expected = new[,] { { person, person }, { person, person } };

            // Act
            var actual = SnippetsArray.Initialize2DArray<Person>(2, 2, person);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void ShouldWorkForComplexTypes_IfNotProvided()
        {
            // Arrange
            var expected = new[,] { { default(Person), default(Person) }, { default(Person), default(Person) } };

            // Act
            var actual = SnippetsArray.Initialize2DArray<Person>(2, 2);

            // Assert
            actual.Should().BeEquivalentTo(expected);
        }

        private class Person
        {
            public Address Address { get; set; }

            public string Name { get; set; }
        }

        private class Address
        {
            public string Street { get; set; }
        }
    }
}
