using System;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

/*
 using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericList
{
    /// <summary>
    /// Класс, реализующий генериковый список.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyList<T> : IList<T>
    {
        /// <summary>
        /// Класс, в котором создается список.
        /// </summary>
        private class ListElement
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

        /// <summary>
        /// Присваивание голове списка значения null.
        /// </summary>
        private ListElement head = null;

        public int Count => throw new System.NotImplementedException();

        public bool IsReadOnly => throw new System.NotImplementedException();

        public T this[int index] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /*
        /// <summary>
        /// Печать списка.
        /// </summary>
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

        /// <summary>
        /// Добавление элемента в список.
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// Поиск по списку.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Search(T value)
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

        /// <summary>
        /// Удаление из списка.
        /// </summary>
        /// <param name="value"></param>
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
                return;
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
        }

      
        /// <summary>
        /// Метод, который возвращает энемератор, выполняющий итерации по коллекции.
        /// </summary>
        /// <returns></returns>
       /* 
        * 
        *
IList IEnumerable.GetEnumerator()
{
    return GetEnumerator();
}


public IEnumerator<T> GetEnumerator()
{
    return new MyListEnum(this);
}

public int IndexOf(T item)
{
    throw new System.NotImplementedException();
}

public void Insert(int index, T item)
{
    throw new System.NotImplementedException();
}

public void RemoveAt(int index)
{
    throw new System.NotImplementedException();
}

public void Clear()
{
    throw new System.NotImplementedException();
}

public bool Contains(T item)
{
    throw new System.NotImplementedException();
}

public void CopyTo(T[] array, int arrayIndex)
{
    throw new System.NotImplementedException();
}

bool ICollection<T>.Remove(T item)
{
    throw new System.NotImplementedException();
}

IEnumerator IEnumerable.GetEnumerator()
{
    throw new System.NotImplementedException();
}

        /*

        /// <summary>
        /// Класс, реализующий генериковый список.
        /// </summary>
        private class MyListEnum : IEnumerator<T>
        {
            private MyList<T> list;
            private ListElement currentElement;

            public MyListEnum(MyList<T> list)
            {
                this.list = list;
            }

            /// <summary>
            /// Метод, реализующий перебор элементов коллекции.
            /// </summary>
            /// <returns></returns>
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

            /// <summary>
            /// Устанавливает перечислитель в начало коллекции.
            /// </summary>
            public void Reset()
            {
                currentElement = null;
            }

            /// <summary>
            /// Возвращает ссылку на текущий экземпрял коллекции.
            /// </summary>
            public object Current
            {
                get { return currentElement.Value; }
            }

            /// <summary>
            /// Возвращает значение текущего экземпляра.
            /// </summary>
            T IEnumerator<T>.Current
            {
                get { return currentElement.Value; }
            }

            public void Dispose() {}*/
 