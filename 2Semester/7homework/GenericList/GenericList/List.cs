using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericList
{
    public class MyList<T> : IEnumerable<T>
    {
        public class ListElement
        {
            public T Value
            {
                get;
                set;
            }
            public ListElement Next
            {
                get;
                set;
            }
        }

        private ListElement head = null;

        public void Print()
        {
            Console.WriteLine("Список: ");
            var currentElement = head;
            while (currentElement.Next != null)
            {
                Console.WriteLine(currentElement.Value + " ");
                currentElement = currentElement.Next;
            }
            Console.WriteLine(currentElement.Value + " ");
        }

        public void Add(T value)
        {
            var newElement = new ListElement()
            {
                Value = value,
                Next = null
            };

            if (head == null)
            {
                head = newElement;
                return;
            }

            var currentElement = head;
            while (currentElement.Next != null)
            {
                currentElement = currentElement.Next;
            }
            currentElement.Next = newElement;
        }

        public bool BinarySearch(T value)
        {
            var currentElement = head;
            Comparer<T> comparer = Comparer<T>.Default;
            while (currentElement != null)
            {
                if (comparer.Compare(currentElement.Value, value) == 0)
                {
                    return true;
                }
                currentElement = currentElement.Next;
            }
            return false;
        }

        public void Remove(T value)
        {
            if (head == null)
            {
                throw new RemoveFromEmptyListException();
            }

            Comparer<T> comparer = Comparer<T>.Default;
            if (comparer.Compare(head.Value, value) == 0)
            {
                head = head.Next;
            }

            var currentElement = head;

            while (currentElement.Next.Next != null)
            {
                if (comparer.Compare(currentElement.Next.Value, value) == 0)
                {
                    if (currentElement.Next.Next == null)
                    {
                        currentElement.Next = null;
                    }
                    else
                    {
                        currentElement.Next = currentElement.Next.Next;
                    }
                    return;
                }
                currentElement = currentElement.Next;
            }
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyListEnum(this);
        }

        private class MyListEnum : IEnumerator<T>
        {
            private MyList<T> list;
            private ListElement currentElement = null;

            public MyListEnum(MyList<T> list)
            {
                this.list = list;
            }

            public bool MoveNext()
            {
                if (currentElement == null)
                {
                    currentElement = list.head;
                }
                else
                {
                    currentElement = currentElement.Next;
                }
                return currentElement != null;
            }

            public void Reset()
            {
                currentElement = null;
            }

            public object Current
            {
                get { return currentElement.Value; }
            }

            T IEnumerator<T>.Current
            {
                get { return currentElement.Value; }
            }

            public void Dispose() {}
        }
    }
}
