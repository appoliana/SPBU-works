using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HashTable.Tests
{
    [TestClass]
    public class HashTableTest
    {
        private HashTable hash;

        private int UserHashFunction(string inputString)
        {
            int hashf = 0;
            int length = inputString.Length;

            for (int i = 0; i < length; i++)
            {
                hashf += inputString[i];
            }

            return hashf % 15;
        }

        [TestInitialize]
        public void Initialize()
        {
            hash = new HashTable(50);
        }

        [TestMethod]
        public void AddTest()
        {
            hash.AddElement("sveta");
            Assert.IsTrue(hash.IsExist("sveta"));
            Assert.IsFalse(hash.IsExist("vanechka"));
        }

        [TestMethod]
        public void RemoveTest()
        {
            hash.AddElement("404");
            hash.RemoveElement("404");
            Assert.IsFalse(hash.IsExist("404"));
        }

        [TestMethod]
        public void Change()
        {
            hash.AddElement("punkabli");
            hash.AddElement("fructFamily");
            hash.ChangeHashFunction(UserHashFunction);
            Assert.IsTrue(hash.IsExist("punkabli"));
            Assert.IsTrue(hash.IsExist("fructFamily"));
        }

        [TestMethod]
        public void AddInChange()
        {
            hash.ChangeHashFunction(UserHashFunction);
            hash.AddElement("hello");
            Assert.IsTrue(hash.IsExist("hello"));
        }
    }
}

