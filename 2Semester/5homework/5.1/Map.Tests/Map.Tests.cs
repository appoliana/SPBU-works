using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Map.Tests
{
    [TestClass]
    public class MapTests
    {
        private Map.MapFunction list;

        [TestInitialize]
        public void Init()
        {
            this.list = new Map.MapFunction();
        }

        [TestMethod]
        public void Multiplication()
        {
            list.Add(2);
            list.Add(-4);
            list = MapFunction<int>.Map(list, x => x * 10);
            Assert.AreEqual(20, list[0]);
            Assert.AreEqual(-40, list[1]);
        }

        [TestMethod]
        public void Addition()
        {
            list.Add(2);
            list.Add(-4);
            list = MapFunction<int>.Map(list, x => x + x);
            Assert.AreEqual(4, list[0]);
            Assert.AreEqual(-8, list[1]);
        }
    }
}
