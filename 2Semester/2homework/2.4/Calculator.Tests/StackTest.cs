using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class StackTest
    {
        private StackCalculator.ListStack stackList;
        private StackCalculator.ArrayStack stackArray;

        [TestInitialize]
        public void Init()
        {
            this.stackList = new StackCalculator.ListStack();
            this.stackArray = new StackCalculator.ArrayStack();
        }

        [TestMethod]
        public void PushAndPopShallReturnSameValueForStackList()
        {
            stackList.Push(1);
            var result = stackList.Pop();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void PushAndPopShallReturnSameValueForStackArray()
        {
            stackArray.Push(1);
            var result = stackArray.Pop();
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PopFromEmptyStackShallThrowForStackList()
        {
            stackList.Pop();
        }

        public void PopFromEmptyStackShallNotCrashForStackArray()
        {
            stackArray.Pop();
        }

        [TestMethod]
        public void ConsequentPushAndPopsShallWorkForStackList()
        {
            stackList.Push(1);
            stackList.Push(2);
            stackList.Push(3);

            Assert.AreEqual(3, stackList.Pop());
            Assert.AreEqual(2, stackList.Pop());
            Assert.AreEqual(1, stackList.Pop());
        }

        [TestMethod]
        public void ConsequentPushAndPopsShallWorkForStackArray()
        {
            stackArray.Push(1);
            stackArray.Push(2);
            stackArray.Push(3);

            Assert.AreEqual(3, stackArray.Pop());
            Assert.AreEqual(2, stackArray.Pop());
            Assert.AreEqual(1, stackArray.Pop());
        }
    }
}
