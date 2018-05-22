using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueWithPriority
{
    public class Queue<T>
    {
        class QueueElement
        {
            public T Value { get; set; }
            public int Priority { get; set; }
            public QueueElement Next { get; set; }
        }

        private QueueElement first = null;

        /// <summary>
        /// Добавляет элемент в очередь в зависимости от приоритета
        /// </summary>
        public void Enqueue(T value, int priority)
        {
            var newElement = new QueueElement()
            {
                Value = value,
                Priority = priority,
                Next = null
            };

            if (first == null)
            {
                first = newElement;
                return;
            }

            var currentElement = first;

            if (newElement.Priority > first.Priority)
            {
                var dop = first;
                first = newElement;
                newElement.Next = dop;
                return;
            }

            if (first.Next == null)
            {
                first.Next = newElement;
                return;
            }

            while (currentElement.Next.Priority > newElement.Priority)
            {
                currentElement = currentElement.Next;
            }
            if (currentElement.Next == null)
            {
                currentElement.Next = newElement;
            }
            else
            {
                var dop = currentElement.Next;
                currentElement.Next = newElement;
                newElement.Next = dop;
            }
        }

        /// <summary>
        /// Удаляет первый элемент в очереди и возвращает значение
        /// </summary>
        public T Dequeue()
        {
            if (first == null)
            {
                throw new RemoveFromEmptyQueueException();
            }
            var elementWithTheMostPriority = first;
            first = first.Next;
            return elementWithTheMostPriority.Value;
        }
    }
}
