using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QueueWithPriority.Tests
{
    [TestClass]
    public class QueueWithPriorityTest
    {
        private QueueWithPriority.Queue<int> queue;

        [TestInitialize]
        public void Init()
        {
            this.queue = new QueueWithPriority.Queue<int>();
        }

        [TestMethod]
        public void AddElementsToQueue()
        {
            queue.Enqueue(2, 5);
        }
        [TestMethod]
        public void DeueueFromQueue()
        {
            queue.Enqueue(2, 5);
            queue.Enqueue(5, 3);
            queue.Enqueue(1, 4);
            Assert.AreEqual(queue.Dequeue(), 2);
            Assert.AreEqual(queue.Dequeue(), 1);
        }
        [TestMethod]
        public void AddTheSamePriority()
        {
            queue.Enqueue(2, 5);
            queue.Enqueue(3, 5);
            Assert.AreEqual(queue.Dequeue(), 2);
        }

        /*[TestMethod] //исключение не доступно из-за уровня защиты ? это как там все public:(
        [ExpectedException(typeof(RemoveFromEmptyQueueException))]
        public void RemoveFromEmptyQueueException()
        {
            queue.Dequeue();
        }
        */
    }
}
