using FluentAssertions;
using Xunit;

namespace JonasSchubert.Snippets.String.Test
{
    public class StringByteSizeUnitTest
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("Hello World", 11)]
        [InlineData("This is 30 seconds of C.", 24)]
        public void StringByteSize_ShouldReturnExpectedResult_ForGivenString(string testString, int expected)
        {
            // Arrange & Act
            var actual = testString.ByteSize();
            var actualAscii = testString.ByteSizeAscii();
            var actualBigEndianUnicode = testString.ByteSizeBigEndianUnicode();
            var actualUnicode = testString.ByteSizeUnicode();
            var actualUtf7 = testString.ByteSizeUtf7();
            var actualUtf8 = testString.ByteSizeUtf8();
            var actualUtf32 = testString.ByteSizeUtf32();

            // Assert
            actual.Should().Be(expected);
            actualAscii.Should().Be(expected);
            actualBigEndianUnicode.Should().Be(expected * 2);
            actualUnicode.Should().Be(expected * 2);
            actualUtf7.Should().Be(expected);
            actualUtf8.Should().Be(expected);
            actualUtf32.Should().Be(expected * 4);
        }
    }
}
