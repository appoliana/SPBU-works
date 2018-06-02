using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Set.Tests
{
    [TestClass]
    public class SetTests
    {
        [TestMethod]
        public void AddTest()
        {
            var set1 = new Set<int>(false);
            var set = new List<int>();
            set.Add(2);
            set.Add(1);
            Assert.AreEqual(true, set.Contains(2));
            Assert.AreEqual(true, set.Contains(1));
        }
        
        [TestMethod]
        public void UnionTest()
        {
            var set1 = new Set<int>(false);
            var set = new List<int>();
            set.Add(2);
            set.Add(1);
            set1.UnionWith(set);
            Assert.AreEqual(true, set1.Contains(2));
            Assert.AreEqual(true, set1.Contains(1));
        }

        [TestMethod]
        public void IntersectionTest()
        {
            var set1 = new Set<int>(false);
            var set = new List<int>();
            var set2 = new List<int>();
            set.Add(2);
            set.Add(1);
            set2.Add(2);
            set1.UnionWith(set);
            set1.IntersectWith(set2);
            Assert.AreEqual(true, set1.Contains(2));
        }
    }
}

