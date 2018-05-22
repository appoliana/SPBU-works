using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BubbleSort.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SortIntArray()
        {
            int size = 10;
            int[] array = new int[size];
            for (int i = 9; i >= 0; --i)
            {
                array[i] = i;
            }

            Comparer<int> comparer = Comparer<int>.Default;
            BubbleSort<int>(array, comparer);
            Assert.AreEqual(array[0], 0);
        }

        [TestMethod]
        public void SortStringArray()
        {
            int size = 3;
            string[] array = new string[size];
            array[0] = "a";
            array[1] = "c";
            array[2] = "b";

            Comparer<string> comparer = Comparer<string>.Default;
            BubbleSort<string>(array, comparer);

            Assert.AreEqual(array[1], "b");
        }
    }
}
