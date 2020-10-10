using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApplication.Controllers;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //// Arrange
            //ValuesController controller = new ValuesController(); // <1>

            //// Act
            //IEnumerable<string> result = controller.Get(); // <2>

            //// Assert // <3>
            //Assert.IsNotNull(result);
            //Assert.AreEqual(2, result.Count());
            //Assert.AreEqual("value1", result.ElementAt(0));
            //Assert.AreEqual("value2", result.ElementAt(1));
            Tutorial tp = new Tutorial();
            Assert.AreEqual(tp.,"venkat");
        }
    }
}
