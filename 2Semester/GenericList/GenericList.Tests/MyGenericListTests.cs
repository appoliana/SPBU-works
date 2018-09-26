using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericList.Tests
{
    [TestClass]
    public class MyGenericListTests
    {
        [TestMethod]
        public void AddTest()
        {
            var firstList = new List<int>();
            firstList.Add(1);
            int a = firstList[0];
            firstList.Add(3);
            foreach (int i in firstList)
            Assert.IsTrue(firstList.Contains(1));
            Assert.IsTrue(firstList.Contains(3));
        }

        [TestMethod]
        public void SearchList()
        {
            var firstList = new List<int>();
            firstList.Add(1);
            firstList.Add(3);
            Assert.IsTrue(firstList.Contains(1));
            Assert.IsFalse(firstList.Contains(2));
        }

        [TestMethod]
        public void RemoveTest()
        {
            var firstList = new List<int>();
            firstList.Add(1);
            firstList.Add(3);
            firstList.Add(2);
            firstList.Remove(3);
            Assert.IsFalse(firstList.Contains(3));
        }

        [TestMethod]
        public void CopyToTest()
        {
            var firstList = new List<int>();
            firstList.Add(1);
            firstList.Add(2);
            var array = new int[4];
            firstList.CopyTo(array, 2);
            Assert.AreEqual(array[2], 1);
            Assert.AreEqual(array[3], 2);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexOutOfRangeExceptionTest()
        {
            var firstList = new List<int>();
            firstList.Add(1);
            firstList.Add(2);
            var array = new int[2];
            firstList.CopyTo(array, 2);
            Assert.AreEqual(array[2], 1);
            Assert.AreEqual(array[3], 2);
        }

        [TestMethod]
        public void ForeachTest()
        {
            var firstList = new List<int>();
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            var array = new int[3];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            int i = 0;
            foreach (var element in firstList)
            {
                Assert.AreEqual(element, array[i]);
                ++i;
            }
        }
    }
}
