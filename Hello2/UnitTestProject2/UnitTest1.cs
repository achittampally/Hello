using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        private const string expected = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Hello2.Program.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }
    }
}
