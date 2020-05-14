using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPA_IE.Models.Domain;

namespace UnitTestSPA_IE
{
    /// <summary>
    /// Descripción resumida de UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {

        [TestMethod]
        public void TestMethod1()
        {
            string name = "Lyk";

            TestxTwo testxTwo = new TestxTwo();
            String result = testxTwo.stringTest("X");

            Assert.AreEqual(name, result);

        }
    }
}
