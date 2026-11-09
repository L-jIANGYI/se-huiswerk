using week4;

namespace Wee4.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Test_MiddelsteLetter()
        {
            // arrange
            string expected = "r";
            string input = "Sarah";

            // act
            string actual = Program.MiddelsteLetter(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_MiddelsteLetter2()
        {
            // arrange
            string expected = "dp";
            string input = "deadpool";

            // act
            string actual = Program.MiddelsteLetter(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_MiddelsteLetter3()
        {
            // arrange
            string expected = "n";
            string input = "jiangyi";

            // act
            string actual = Program.MiddelsteLetter(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}