using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventMap.Tests
{
    [TestClass]
    public class FileTest
    {
        [TestMethod]
        public void IsFileCanBeReadAndWrite()
        {
            FileStream file = new FileStream(@"C:\Users\Пользователь\Desktop\2semester\EventMap\EventMap\bin\Debug\Map.txt", FileMode.Open, FileAccess.ReadWrite);
            Assert.AreEqual(file.CanRead, true);
            Assert.AreEqual(file.CanWrite, true);
            file.Close();
        }
    }
}
