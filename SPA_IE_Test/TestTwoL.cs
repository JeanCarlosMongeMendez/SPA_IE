using NUnit.Framework;
using SPA_IE.Models.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPA_IE_Test
{
    class TestTwoL
    {

        [Test]
        public void Test1()
        {
            string name = "Lyka";

            TestxTwo testxTwo = new TestxTwo();
            String result = testxTwo.stringTest("X");

            Assert.AreEqual(name, result);
        }

    }
}
