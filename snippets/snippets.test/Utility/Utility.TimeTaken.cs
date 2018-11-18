using FluentAssertions;
using snippets.Utility;
using System;
using Xunit;

namespace snippets.test.Utility
{
    /// <summary>
    /// Unit tests for Utility.TimeTaken-Snippet
    /// </summary>
    public class UtilityTimeTakenUnitTest
    {
        /// <summary>
        /// Utility.TimeTaken Unit test
        /// </summary>
        [Fact]
        public void TimeTaken_ShouldReturnExpectedResult_ForGivenFunctions()
        {
            // Arrange
            bool BoolFunc() => true;
            int RandomFunc() => new Random().Next(0, 1000);

            // Act
            var boolFuncResult = SnippetsUtility.TimeTaken(BoolFunc);
            var randomFuncResult = SnippetsUtility.TimeTaken(RandomFunc);

            // Assert
            boolFuncResult.Item1.Should().BeGreaterOrEqualTo(0);
            boolFuncResult.Item2.Should().BeTrue();
            randomFuncResult.Item1.Should().BeGreaterOrEqualTo(0);
            randomFuncResult.Item2.Should().BeInRange(0, 1000);
        }
    }
}
