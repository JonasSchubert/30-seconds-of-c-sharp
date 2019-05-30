using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Conplement.Snippets.Enumerable.Test
{
    public class EnumerableForEachRightUnitTest
    {
        [Fact]
        public void PerformExpected_ForListsOfInt()
        {
            // Arrange
            var testNumber = 0;
            var list = new List<int> { 1, 2, 3, 4, 0 };
            void function(int x) => testNumber += x;

            // Act
            list.ForEachRight(function);

            // Assert
            testNumber.Should().Be(10);
        }

        [Fact]
        public void PerformExpected_ForArraysOfString()
        {
            // Arrange
            var testString = "";
            var array = new string[] { "world", "Hello" };
            void function(string x) => testString = testString + " " + x;

            // Act
            array.ForEachRight(function);

            // Assert
            testString.Should().Be(" Hello world");
        }

        [Fact]
        public void PerformExpected_ForListOfBoolean()
        {
            // Arrange
            var testBool = true;
            var list = new List<bool> { true, true, true, false, true, true, true };
            void function(bool x) => testBool &= x;

            // Act
            list.ForEachRight(function);

            // Assert
            testBool.Should().BeFalse();
        }

        [Fact]
        public void PerformExpected_ForArrayOfComplex()
        {
            // Arrange
            var testPerson = new Person { Name = string.Empty };
            var list = new List<Person> { new Person { Name = "Tina" }, new Person { Name = "Thomas" }, new Person { Name = "Annabelle" } };
            void function(Person x) => testPerson.Name = testPerson.Name == string.Empty ? x.Name : testPerson.Name;

            // Act
            list.ForEachRight(function);

            // Assert
            testPerson.Name.Should().Be("Annabelle");
        }

        [Fact]
        public void ShouldThrowException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            double[] array = null;
            void function(double x) => array[0] *= x;

            // Act
            Action action = () => array.ForEachRight(function);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ShouldThrowException_WhenNullFunction_IsGiven()
        {
            // Arrange
            var list = new List<uint> { 1, 2, 3, 4 };

            // Act
            Action action = () => list.ForEachRight(null);

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        private class Person
        {
            public string Name { get; set; }
        }
    }
}
