using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stack.Tests
{
    [TestClass]  
    public class UnitTest1
    {
        private Testing.Stack stack;

        [TestInitialize]  
        public void Init()
        {
            this.stack = new Testing.Stack();
        }

        [TestMethod]
        public void PushAndPopShallReturnSameValue()
        {     
            stack.Push(1);
            var result = stack.Pop();
            Assert.AreEqual(1, result); 
        }

        [TestMethod]
        public void PopFromEmptyStackShallNotCrash()
        {
            stack.Pop();
        }

        [TestMethod]
        public void ConsequentPusheAndPopsShallWork()
        {
            stack.Push(1);
            stack.Push(2);  
            stack.Push(3);

            Assert.AreEqual(3, stack.Pop()); 
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());

        }

        [TestMethod]
        public void PushZeroesShallWork()
        {
            for (int i = 0; i < 10; ++i) 
            {
                stack.Push(0);
            }
            for (int i = 0; i < 10; ++i)
            {
                Assert.AreEqual(0, stack.Pop());
            }
        }

        [TestMethod]
        public void PushStringShallNotWork()
        {
            stack.Push("string");
        }
    }
}

