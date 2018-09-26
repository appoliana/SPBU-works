using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace InfiniteSequence.Tests
{
    [TestClass]
    public class ContainsElementTest
    {
        [TestMethod]
        public void FirstNumberIsTrue()
        {
            var firstNumber = Infinite.InfiniteSequence.GetNumbers().First();
            Assert.AreEqual(firstNumber, 2);
        }

        [TestMethod]
        public void FifthNumber()
        {
            var fifthNumber = Infinite.InfiniteSequence.GetNumbers().ElementAt(5);
            Assert.AreEqual(fifthNumber, 9);
        }

        [TestMethod]
        public void TenthNumber()
        {
            var tenthNumber = Infinite.InfiniteSequence.GetNumbers().ElementAt(10);
            Assert.AreEqual(tenthNumber, 23);
        }
    }
}
