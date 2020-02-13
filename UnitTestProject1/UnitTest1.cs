using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 540;
            int result = lab01.Program.Example(n);
            Assert.AreEqual(9, result);
        }
    }
}
