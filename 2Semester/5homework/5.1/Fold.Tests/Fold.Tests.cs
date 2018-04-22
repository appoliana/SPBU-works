using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fold.Tests
{
    [TestClass]
    public class FoldTests
    {
        private Fold.FoldFunction list;

        [TestInitialize]
        public void Init()
        {
            this.list = new Fold.FoldFunction();
        }

        [TestMethod]
        public void Multiplication()
        {
            list.Add(2);
            list.Add(4);
            var result = FoldFunction<int>.Map(list, 0, (x,y) => x + y);
            Assert.AreEqual(6, result);
        }
    }
}

