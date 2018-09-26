using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericList
{
    /// <summary>
    /// Класс LIst<typeparamref name="T"/>, который наследуется от IList<typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class List<T> : IList<T>
    {
        private Element head;
        private Element tail;

        public int Count { get; private set; } = 0;

        public bool IsReadOnly => false;

        /// <summary>
        /// Метод, который реализует доступ к элементу списка по его индексу.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T this[int i]
        {
            get
            {
                if (i >= 0 && i <= Count)
                {
                    var temp = head;
                    for (var j = 0; j < i; j++)
                    {
                        temp = temp.Next;
                    }
                    return temp.Value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (IsReadOnly)
                {
                    throw new InvalidOperationException();
                }

                if (i >= 0 && i <= Count)
                {
                    var temp = head;
                    for (var j = 0; j < i; j++)
                    {
                        temp = temp.Next;
                    }
                    temp.Value = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// Метод, который реализует добавление элемента в список.
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            if (IsReadOnly)
            {
                throw new InvalidOperationException();
            }

            if (Count == 0)
            {
                head = new Element(null, element);
                tail = head;
            }
            else
            {
                tail.Next = new Element(null, element);
                tail = tail.Next;
            }

            Count++;
        }

        /// <summary>
        /// Метод, который удаляет список.
        /// </summary>
        public void Clear()
        {
            if (IsReadOnly)
            {
                throw new InvalidOperationException();
            }

            head = null;
            tail = null;
            Count = 0;
        }

        /// <summary>
        /// Метод, который проверяет, содержится ли элемент в списке.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Contains(T element)
        {
            var temp = head;
            while (temp != null && !Equals(temp.Value, element))
            {
                temp = temp.Next;
            }

            return temp != null;
        }

        /// <summary>
        /// Метод, который копирует элементы списка в массив, начиная с некоторого места.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        public void CopyTo(T[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (array.Length - (index + Count) < 0)
            {
                throw new IndexOutOfRangeException();
            }

            foreach (var element in this)
            {
                array[index] = element;
                index++;
            }
        }

        public IEnumerator<T> GetEnumerator() => new Enumerator(head);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// Метод, который возвращает индекс элемента.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public int IndexOf(T element)
        {
            var answer = 0;
            var temp = head;

            while (temp != null && !Equals(temp.Value, element))
            {
                temp = temp.Next;
                answer++;
            }

            if (temp == null)
            {
                throw new NotImplementedException();
            }

            return answer;
        }

        /// <summary>
        /// Метод, который добавляет элемент в писок по индексу.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="element"></param>
        public void Insert(int index, T element)
        {
            if (IsReadOnly)
            {
                throw new InvalidOperationException();
            }

            if (index == 0)
            {
                head = new Element(head, element);
                Count++;
                return;
            }

            if (index > Count + 1 || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            var temp = head;
            for (var i = 1; i < index; i++)
            {
                temp = temp.Next;
            }
            temp.Next = new Element(temp.Next, element);
            Count++;
        }

        /// <summary>
        /// Метод, который удаляет элемент по значению.
        /// </summary>
        /// <param name="element">Значение элемента.</param>
        /// <returns></returns>
        public bool Remove(T element)
        {
            if (IsReadOnly)
            {
                throw new InvalidOperationException();
            }

            if (Count == 0)
            {
                throw new InvalidOperationException();
            }

            if (Equals(head.Value, element))
            {
                head = head.Next;
                Count--;
                return true;
            }

            var temp = head;
            while (temp.Next != null && !Equals(temp.Next.Value, element))
            {
                temp = temp.Next;
            }

            if (temp.Next == null)
            {
                throw new InvalidOperationException();
            }

            if (temp.Next == tail)
            {
                tail = temp;
            }
            temp.Next = temp.Next.Next;
            Count--;
            return true;
        }

        /// <summary>
        /// Метод, который удаляет элемент по индексу.
        /// </summary>
        /// <param name="index"> Позиция элемента в списке. </param>
        public void RemoveAt(int index)
        {
            if (IsReadOnly)
            {
                throw new InvalidOperationException();
            }

            if (Count == 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                head = head.Next;
                Count--;
                return;
            }

            var temp = head;
            for (int i = 1; i < index; i++)
            {
                temp = temp.Next;
            }

            if (index + 1 == Count)
            {
                tail = temp;
            }
            temp.Next = temp.Next.Next;
            Count--;
        }

        /// <summary>
        /// Метод, который реализует 
        /// </summary>
        private class Element
        {
            public Element Next { get; set; }

            public T Value { get; set; }

            public Element(Element next, T value)
            {
                Next = next;
                Value = value;
            }
        }

        /// <summary>
        /// Класс Enumerator.
        /// </summary>
        private class Enumerator : IEnumerator<T>
        {
            private Element head;
            private Element current;

            /// <summary>
            /// Конструктор класса Enumerator.
            /// </summary>
            /// <param name="head"></param>
            public Enumerator(Element head)
            {
                this.head = head;
            }

            /// <summary>
            /// Метод, который возвращает текущее значение.
            /// </summary>
            public T Current => current.Value;

            object IEnumerator.Current => Current; 

            public void Dispose() { }

            /// <summary>
            /// Метод, который переходит к следующему элементу коллекции.
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                if (head == null)
                {
                    return false;
                }

                if (current == null)
                {
                    current = head;
                    return true;
                }

                if (current.Next == null)
                {
                    return false;
                }

                current = current.Next;
                return true;
            }

            public void Reset()
            {
                current = null;
            }
        }
    }
}
