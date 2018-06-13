using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace List.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private _2._2.List list;

        [TestInitialize]
        public void Init()
        {
            this.list = new _2._2.List();
        }

        [TestMethod]
        public void AddToHead()
        {
            list.Add(2);
            Console.WriteLine("Должна быть напечатана 2");
            list.Print();
        }

        [TestMethod]
        public void IsItWork()
        {
            Console.WriteLine("Кажется, список создался и прога не упала =)");
        }

        [TestMethod]
        public void PrintList()
        {
            list.Add(2);
            list.Add(7);
            list.Add(0);
            list.Add(13);
            list.Print();
        }

        [TestMethod]
        public void RemoveElementFromHead()
        {
            list.Add(2);
            list.Add(7);
            list.Remove(2);
            Console.WriteLine("Должна быть напечатана 7");
            list.Print();
        }

        [TestMethod]
        public void RemoveElementNotFromHead()
        {
            list.Add(2);
            list.Add(7);
            list.Remove(7);
            Console.WriteLine("Должна быть напечатана 2");
            list.Print();
        }

        [TestMethod]
        public void RemoveLastElement()
        {
            list.Add(2);
            list.Add(7);
            list.Add(3);
            list.Add(82);
            list.Remove(82);
            Console.WriteLine("Должно быть напечатано 2 7 3");
            list.Print();
        }

        [TestMethod]
        public void BinarySearch()
        {
            list.Add(2);
            list.Add(7);
            list.Add(3);
            Assert.AreEqual(list.BinarySearch(7), true);
            Assert.AreEqual(list.BinarySearch(9), false);
        }
    }
}
