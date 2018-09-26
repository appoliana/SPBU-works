using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EventMap.Tests
{
    /// <summary>
    /// Класс FileTest.
    /// </summary>
    [TestClass]
    public class FileTest
    {
        /// <summary>
        /// Метод, который тестирует файл на чтение и запись.
        /// </summary>
        [TestMethod]
        public void IsFileCanBeReadAndWrite()
        {
            using (FileStream file = new FileStream(@"Map.txt", FileMode.Open, FileAccess.ReadWrite))
            {
                Assert.AreEqual(file.CanRead, true);
                Assert.AreEqual(file.CanWrite, true);
                file.Close();
            }
        }
    }
}
