using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 341;

            int result = ConsoleApp1.Program.first(a);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int b = 341;
            int result = ConsoleApp1.Program.last(b);
            Assert.AreEqual(1, result);
        }
    }
}