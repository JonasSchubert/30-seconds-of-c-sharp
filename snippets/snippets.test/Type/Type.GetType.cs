using FluentAssertions;
using snippets.Type;
using System;
using System.Collections.Generic;
using Xunit;

namespace snippets.test.Type
{
    /// <summary>
    /// Unit tests for Type.GetType-Snippet
    /// </summary>
    public class TypeGetTypeUnitTest
    {
        public static IEnumerable<object[]> Data => new List<object[]> { new object[] { new DateTime() }, new object[] { "Hello World" } };

        /// <summary>
        /// Type.GetType Unit test
        /// </summary>
        [Theory]
        [MemberData(nameof(Data))]
        public void GetType_ShouldReturnExpectedResult_ForGivenObjects(object obj)
        {
            // Act
            var typeResult = SnippetsType.GetType(obj);

            // Assert
            typeResult.Should().Be(obj.GetType());
        }
    }
}
