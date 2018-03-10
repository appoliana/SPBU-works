using System;

namespace UniqueListClass
{
    public class List
    {
        public class ListElement
        {
            public int Value
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

        virtual public void Add(int value)
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

        public bool BinarySearch(int value)
        {
            var currentElement = head;
            while (currentElement.Next != null)
            {
                if (currentElement.Value == value)
                {
                    return true;
                }
                currentElement = currentElement.Next;
            }
            return false;
        }

        public void Remove(int value)
        {
            if (head == null)
            {
                throw new DeleteNotExistingElementException("This element does not existed!");
            }
            if (head.Value == value)
            {
                head = head.Next;
                return;
            }
            var currentElement = head;
            while (currentElement.Next != null)
            {
                if (currentElement.Next.Value == value)
                {
                    if (currentElement.Next.Next == null)
                    {
                        currentElement.Next = null;
                        return;
                    }
                    var dop = currentElement.Next.Next;
                    currentElement.Next = null;
                    currentElement.Next = dop;
                    return;
                }
                currentElement = currentElement.Next;
            }
            throw new DeleteNotExistingElementException("This element does not existed!");
        }
    }
}
