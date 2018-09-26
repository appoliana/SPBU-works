using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualBasic;
using System.Linq;

namespace EventMap.Tests
{
    /// <summary>
    /// Класс MoveDogTests.
    /// </summary>
    [TestClass]
    public class MoveDogTests
    {
        /// <summary>
        /// Метод, который тестирует нажатие клавиши "влево".
        /// </summary>
        [TestMethod]
        public void MoveLeft()
        {
            var game = new Game();
            var reader = new MyReader();
            var arrayOfMap = new string[6];
            var ourDogLine = 0;
            var ourDogCollumn = 0;
            (arrayOfMap, ourDogLine, ourDogCollumn) = reader.ReadMapFromFile();
            Assert.AreEqual(4, ourDogCollumn);
            Assert.AreEqual(4, ourDogLine);
            game.OnLeft(null, EventArgs.Empty);
            (ourDogCollumn, ourDogLine) = game.returnDog();
            Assert.AreEqual(3, ourDogCollumn);
            Assert.AreEqual(4, ourDogLine);
        }

        /// <summary>
        /// Метод, который тестирует поведение собаки при движении в стенку.
        /// </summary>
        [TestMethod]
        public void CannotMoveIfWall()
        {
            var game = new Game();
            var reader = new MyReader();
            var arrayOfMap = new string[6];
            var ourDogLine = 0;
            var ourDogCollumn = 0;
            (arrayOfMap, ourDogLine, ourDogCollumn) = reader.ReadMapFromFile();
            Assert.AreEqual(4, ourDogCollumn);
            Assert.AreEqual(4, ourDogLine);
            game.OnLeft(null, EventArgs.Empty);
            game.OnLeft(null, EventArgs.Empty);
            (ourDogCollumn, ourDogLine) = game.returnDog();
            Assert.AreEqual(3, ourDogCollumn);
            Assert.AreEqual(4, ourDogLine);
        }
    }
}
