using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPA_IE.Models.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPA_IE.Models.Data.Data.Tests
{
    [TestClass()]
    public class CourseDataTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Assert.AreEqual(1,1);
        }
        [TestMethod()]
        public void AddTestFail()
        {
            Assert.AreEqual(1, 2);
        }
    }
}