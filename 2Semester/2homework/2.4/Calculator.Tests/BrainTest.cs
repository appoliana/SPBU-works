using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCalculator;

namespace Calculator.Tests
{
    [TestClass]
    public class BrainTest
    {
        private StackCalculator.ListStack stackList;

        [TestInitialize]
        public void Init()
        {
            this.stackList = new StackCalculator.ListStack();
        }

        [TestMethod]
        public void MainProgrammTest()
        {
            stackList.Push(1);
            stackList.Push(3);
            char symbol = Convert.ToChar("+");
            var calculator = new StackCalculator.Calculator(stackList);
            calculator.CountExpression(symbol);
            var result = stackList.Pop();
            Assert.AreEqual(4, result);
        }
    }
}
