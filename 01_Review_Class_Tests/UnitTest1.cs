using Xunit;
using _01_Review_Class;

namespace _01_Review_Class_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestPerim()
        {
            Rectangle r1 = new Rectangle(10.0m, 20.0m);
            decimal actual = r1.Perim();
            Assert.Equal(60m, actual);
        }

        [Fact]
        public void TestArea()
        {
            Rectangle r1 = new Rectangle(10.0m, 20.0m);
            decimal actual = r1.Area();
            Assert.Equal(200m, actual);
        }

        [Fact]
        public void TestCheckRange10()
        {
            // Rule: one test per test funtion
            bool actual = Misc.CheckRange(10);
            Assert.Equal(true, actual);
            Assert.True(actual);
        }

        [Fact]
        public void TestCheckRange20()
        {
            // Rule: one test per test funtion
            bool actual = Misc.CheckRange(10);
            Assert.Equal(true, actual);
            Assert.True(actual);
        }
    }
}