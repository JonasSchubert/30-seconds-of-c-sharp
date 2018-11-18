using FluentAssertions;
using snippets.Method;
using System;
using Xunit;

namespace snippets.test.Method
{
    /// <summary>
    /// Unit tests for Method.Times-Snippet
    /// </summary>
    public class MethodTimesUnitTest
    {
        /// <summary>
        /// Method.Times Unit test
        /// </summary>
        [Fact]
        public void MethodTimes_ShouldCallMethod_ExpectedTimes()
        {
            // Arrange
            bool BoolFunc() => true;
            int IntFunc() => new Random().Next(0, 100);

            // Act
            var boolFuncResult = SnippetsMethod.Times(BoolFunc, 5);
            var intFuncResult = SnippetsMethod.Times(IntFunc, 3);

            // Assert
            boolFuncResult.Count.Should().Be(5);
            intFuncResult.Count.Should().Be(3);
        }
    }
}
