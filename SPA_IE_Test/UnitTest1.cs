using NUnit.Framework;
using SPA_IE.Models.Domain;

namespace SPA_IE_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           

        }

        [Test]
        public void Test1()
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