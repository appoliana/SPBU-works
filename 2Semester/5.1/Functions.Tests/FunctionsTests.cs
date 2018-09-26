using System;
using System.Collections.Generic;
using FoldFilterAndMap;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilterFoldAndMap.Tests
{
    [TestClass]
    public class FunctionsTests
    {
        [TestMethod]
        public void FilterTest()
        {
            var list = new List<int>();
            list.Add(2);
            list.Add(10);
            list.Add(15);
            list.Add(20);
            list = FoldFilterAndMapFunction.Filter(list, x => (x > 10));
            Assert.AreEqual(15, list[0]);
            Assert.AreEqual(20, list[1]);
        }

        [TestMethod]
        public void FoldTest()
        {
            var list = new List<int>();
            list.Add(2);
            list.Add(4);
            var result = FoldFilterAndMapFunction.Fold(list, 0, (x, y) => x + y);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void FoldStringTest()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            var result = FoldFilterAndMapFunction.Fold(list, "", (x, y) => y + x.ToString());
            Assert.AreEqual("123", result);
        }

        [TestMethod]
        public void MapTest()
        {
            var list = new List<int>();
            var listResult = new List<int>();
            list.Add(2);
            listResult = FoldFilterAndMapFunction.Map(list, x => x + 2);
            Assert.AreEqual(true, listResult.Contains(4));
        }
    }
}