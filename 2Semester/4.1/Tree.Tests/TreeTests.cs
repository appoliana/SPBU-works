using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tree.Tests
{
    [TestClass]
    public class TreeTests
    {
        [TestMethod]
        public void ReadFromFile()
        {
            var tree = new TreeExpression.Tree();
            string expression = System.IO.File.ReadAllText("expression.txt");
            string result = "* ( / ( + 5 3 ) ( + 2 2 ) ) ( - 7 4 ) ";
            Assert.AreEqual(result, expression);
        }

        [TestMethod]
        public void CountTreeTest()
        {
            var tree = new TreeExpression.Tree();
            string expression = System.IO.File.ReadAllText("expression.txt");
            TreeExpression.Read.ReadExpressionFromString(tree, expression);
            Assert.AreEqual(6, tree.CountTree());
        }
    }
}
