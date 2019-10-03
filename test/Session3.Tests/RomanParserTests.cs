using Xunit;

namespace Session3.Tests
{
    public class RomanParserTests
    {
        [Fact]
        public void RomanToInt_ReturnsIntegerValue()
        {
            // Given
            var parser = new RomanParser();            

            // When
            var actual = parser.RomanToInt(string.Empty);

            // Expect
            Assert.IsType<int>(actual);
        }

        [Fact]
        public void RomanToInt_ReturnsRightValue()
        {
            // Given
            var parser = new RomanParser();            
            var romanNumber = "III";
            var expected = 3;

            // When
            var actual = parser.RomanToInt(romanNumber);

            // Expect
            Assert.Equal(expected, actual);
        }
    }
}
