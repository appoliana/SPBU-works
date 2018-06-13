using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniqueList.Tests
{
    [TestClass]
    public class UniqueListTests
    {
        private UniqueListClass.UniqueList list;

        [TestInitialize]
        public void Init()
        {
            this.list = new UniqueListClass.UniqueList();
        }

        [TestMethod]
        public void AddElementToUniqueList()
        {
            list.Add(3);
            list.Add(5);
            list.Print();
        }

        [TestMethod]
        public void DeleteElementToUniqueListTryToUseClassList()
        {
            list.Add(3);
            list.Add(5);
            list.Remove(3);
            list.Print();
        }

        [TestMethod]
        [ExpectedException(typeof(DeleteNotExistingElementException))]
        public void DeleteNotExistingElementException()
        {
            list.Add(3);
            list.Add(5);
            list.Add(7);
            list.Remove(16);
        }

        [TestMethod]
        [ExpectedException(typeof(AddExistingElementException))]
        public void AddExistingElementTest()
        {
            list.Add(3);
            list.Add(5);
            list.Add(5);
        }
    }
}
