using Xunit;
using Diamond;

namespace Diamond_Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData('E', 'A', "    A    ")]
        public void TestdRAW(char dletter, char rletter, string expected)
        {
            string actual = DrawDiamond.OneLine(dletter, rletter);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMakeSpaces()
        {
            string actual = DrawDiamond.MakeSpaces(2);
            string expected = "  ";
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, "")]
        [InlineData(2, "  ")]
        [InlineData(5, "     ")]
        public void TestMakeSpaces2(int num, string expected)
        {
            string actual = DrawDiamond.MakeSpaces(num);
            Assert.Equal(expected, actual);

        }
        
    }
}

