using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Filter.Tests
{
    [TestClass]
    public class FilterTests
    {
        private Filter.FilterFunction list;

        [TestInitialize]
        public void Init()
        {
            this.list = new Filter.FilterFunction();
        }

        [TestMethod]
        public void IsFunctionFilterWork()
        {
            list.Add(2);
            list.Add(10);
            list.Add(15);
            list.Add(20);
            list = FilterFunction<int>.Map(list, x => (x > 10));
            Assert.AreEqual(15, list[0]);
            Assert.AreEqual(20, list[1]);
        }
    }
}
