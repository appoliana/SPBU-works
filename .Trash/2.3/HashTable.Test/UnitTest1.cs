using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HashTable.Test
{
    [TestClass]
    public class UnitTest1
    {
        private HashTableClass.HashTable hashTable;

        [TestInitialize]
        public void Init()
        {
            this.hashTable = new HashTableClass.HashTable();
        }

        [TestMethod]
        public void AddElementToHashTable()
        {
            hashTable.AddElement("try");
            hashTable.AddElement("program");
            Assert.AreEqual(hashTable.Excist("try"), true);
        }

        [TestMethod]
        public void DeleteElementFromHashTable()
        {
            hashTable.AddElement("try");
            hashTable.AddElement("program");
            hashTable.DeleteElement("program");
            Assert.AreEqual(hashTable.Excist("program"), false);
        }

        [TestMethod]
        public void ExcistElementFromHashTable()
        {
            hashTable.AddElement("try");
            hashTable.AddElement("program");
            Assert.AreEqual(hashTable.Excist("program"), true);
            Assert.AreEqual(hashTable.Excist("LoveSweta"), false);
        }
    }
}
