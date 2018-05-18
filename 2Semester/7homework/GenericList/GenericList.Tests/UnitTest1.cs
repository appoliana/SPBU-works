using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericList.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var firstList = new MyList<int>();
            var secondList = new MyList<int>();
            firstList.Add(1);
            firstList.Add(3);
            firstList.Add(2);
            foreach (int i in firstList)
            {
                secondList.Add(i);
            }
            Assert.AreEqual(true, secondList.BinarySearch(1));
            Assert.AreEqual(true, secondList.BinarySearch(2));
            Assert.AreEqual(true, secondList.BinarySearch(3));
            Assert.AreEqual(false, secondList.BinarySearch(8));
        }
    }
}
