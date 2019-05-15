using System;
using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Conplement.Snippets.Enumerable.Test
{
    public class EnumerableAllEqualUnitTest
    {
        public struct TestStruct { public int Num { get; set; } }

        public static readonly object TestObject = new object();

        public static readonly TestStruct TestStruct0 = new TestStruct { Num = 0 };

        public static readonly IEnumerable<object[]> SimpleListsWhereAllItemsShouldBeEqual = new[] {
                new object[] {new object[] { 2, 2, 2, 2, 2}},
                new object[] {new List<object> {"hello", "hello", "hello"}},
                new object[] {new List<object> {null, null, null}},
                new object[] {new List<object> {TestObject, TestObject, TestObject}},
                new object[] {new List<object> {TestStruct0, TestStruct0}},
                new object[] {new List<object> {TestStruct0, new TestStruct {Num = 0}}},
                new object[] {new List<object> { }},
                new object[] {new List<object> {1}},
            };

        public static readonly IEnumerable<object[]> SimpleListsWhereItemsShouldNotBeEqual = new[] {
                new object[] {new List<object> {1.25, 1.25, 1.5, -1.5}},
                new object[] {new object[] { "foo", "bar"}},
                new object[] {new List<object> {TestObject, null}},
                new object[] {new List<object> {null, TestObject}},
                new object[] {new object[] {new TestStruct {Num = 0}, new TestStruct {Num = 1}}},
            };

        [Theory]
        [MemberData(nameof(SimpleListsWhereAllItemsShouldBeEqual))]
        public void SimpleTrueEqualTest(IEnumerable<object> list)
        {
            // Act
            var actual = list.AllEqual();

            // Assert
            actual.Should().BeTrue();
        }

        [Theory]
        [MemberData(nameof(SimpleListsWhereItemsShouldNotBeEqual))]
        public void SimpleFalseEqualTest(IEnumerable<object> list)
        {
            // Act
            var actual = list.AllEqual();

            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void ReturnTrue_WhenAllEntriesAreEqual()
        {
            // Arrange
            var list = new List<int> { 2, 2, 2 };

            // Act
            var actual = list.AllEqual();

            // Assert
            actual.Should().BeTrue();
        }

        [Fact]
        public void ReturnFalse_WhenEntriesAreDifferent()
        {
            // Arrange
            var list = new double[] { 1.25, 1.25, 1.5, -1.5 };

            // Act
            var actual = list.AllEqual();

            // Assert
            actual.Should().BeFalse();
        }

        [Fact]
        public void ShouldThrowException_WhenNullEnumerable_IsGiven()
        {
            // Arrange
            List<string> list = null;

            // Act
            Action action = () => list.AllEqual();

            // Assert
            action.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ShouldReturnTrue_WhenEqualsTestObjectsAreEqual()
        {
            // Arrange
            var item1 = new TestClass("blubb", 1);
            var item2 = new TestClass("foo", 1);
            var item3 = new TestClass("bar", 1);

            var list = new List<TestClass> { item1, item2, item3 };

            // Act
            var actual = list.AllEqual();

            // Arrange
            actual.Should().BeTrue();
        }

        [Fact]
        public void ShouldReturnFalse_WhenEqualsTestObjectsAreNotEqual()
        {
            // Arrange
            var item1 = new TestClass("blubb", 1);
            var item2 = new TestClass("foo", 2);
            var item3 = new TestClass("bar", 1);

            var list = new List<TestClass> { item1, item2, item3 };

            // Act
            var actual = list.AllEqual();

            // Arrange
            actual.Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnTrue_WhenSpecialEnumerableIsTested()
        {
            // Arrange
            var enumerable = new SpecialEnumerable();

            // Act
            var actual = enumerable.AllEqual();

            // Arrange
            actual.Should().BeTrue();
        }

        [Fact]
        public void ShouldReturnFalse_WhenComparedClassesHaveNoEqualsMethodAndAreDifferentInstances()
        {
            // Arrange
            var item1 = new TestClassWithoutEquals(1);
            var item2 = new TestClassWithoutEquals(1);
            var list = new List<object> { item1, item2 };

            // Act
            var actual = list.AllEqual();

            // Arrange
            actual.Should().BeFalse();
        }

        private class TestClass
        {
            public TestClass(string irrelevantText, int relevantNumber)
            {
                IrrelevantText = irrelevantText;
                RelevantNumber = relevantNumber;
            }

            public string IrrelevantText { get; }

            public int RelevantNumber { get; }

            public override bool Equals(object obj)
            {
                var item = (TestClass)obj;
                return RelevantNumber == item.RelevantNumber;
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }

        private class SpecialEnumerable : IEnumerable<int>
        {
            private static int counter = 0;

            private static IEnumerable<int> GetList()
            {
                var value = counter++;
                var list = new List<int>();
                for (var i = 0; i < 10; i++)
                {
                    list.Add(value);
                }

                return list;
            }

            public IEnumerator<int> GetEnumerator()
            {
                return GetList().GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetList().GetEnumerator();
            }
        }

        private class TestClassWithoutEquals
        {
            public TestClassWithoutEquals(int number)
            {
                Number = number;
            }

            public int Number { get; }
        }
    }
}
