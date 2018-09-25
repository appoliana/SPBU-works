using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualBasic;

namespace EventMap.Tests
{
    [TestClass]
    public class MoveDogTests
    {
        [TestMethod]
        public void MoveLeft()
        {
            var myReader = new MyReader();
            var eventLoop = new EventLoop();
            var arrayOfMap = myReader.ReadMapFromFile();
            eventLoop.Run(myReader.ourDogLine, myReader.ourDogCollumn, arrayOfMap);
            eventLoop.MoveDog("left");
            Assert.AreEqual(4, eventLoop.ourDogLine);
            Assert.AreEqual(3, eventLoop.ourDogCollumn);
        }
        
        [TestMethod]
        public void MoveDown()
        {
            var myReader = new MyReader();
            var eventLoop = new EventLoop();
            var arrayOfMap = myReader.ReadMapFromFile();
            eventLoop.Run(myReader.ourDogLine, myReader.ourDogCollumn, arrayOfMap);
            eventLoop.MoveDog("down");
            Assert.AreEqual(4, eventLoop.ourDogLine);
            Assert.AreEqual(4, eventLoop.ourDogCollumn);
        }
    }
}
