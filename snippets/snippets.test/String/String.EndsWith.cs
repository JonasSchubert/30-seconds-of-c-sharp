using System;
using System.Text.RegularExpressions;
using FluentAssertions;
using snippets.String;
using Xunit;

namespace snippets.test.String
{
    /// <summary>
    /// Unit tests for String.EndsWith-Snippet
    /// </summary>
    public class StringEndsWithUnitTest
    {
        /// <summary>
        /// String.EndsWith Unit test
        /// </summary>
        [Fact]
        public void StringEndsWith_ShouldReturnExpectedResult_ForGivenString()
        {
            // Arrange
            const string testString = "Hello World";

            var regex = new Regex(@"[dolrwDOLRW]{5}$");
            const string value = "World";
            const string valueStringComparison = "world";
            const StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;

            // Act
            var regexResult = SnippetsString.EndsWith(testString, regex);
            var valueResult = SnippetsString.EndsWith(testString, value);
            var stringComparisonResult = SnippetsString.EndsWith(testString, valueStringComparison, stringComparison);

            // Assert
            regexResult.Should().BeTrue();
            valueResult.Should().BeTrue();
            stringComparisonResult.Should().BeTrue();
        }
    }
}
