using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPA_IE.Models.Domain;

namespace UnitTestSPA_IE
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int numberOne = 4;
            int numberTwo = 4;
            int res = numberOne + numberTwo + 1;


            TestOne testOne = new TestOne();
            int resultSum = testOne.sum(4, 4);

            Assert.AreEqual(res, resultSum);

        }
    }
}
