using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApplication.Controllers;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TutorialController tp = new TutorialController();
            string name = typeof(TutorialController).Name;
            Assert.AreEqual("venkat", "venkat");
        }
    }
}
