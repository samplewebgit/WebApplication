using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApplication.Controllers;

namespace Myunittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //unit test code
            ValuesController v = new ValuesController();
            string value = v.Get(5);
            Assert.AreEqual("value", value);
        }
    }
}
