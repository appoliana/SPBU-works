using System;

namespace HashTableClass
{
    public class List
    {
        private class ListElement
        {
            public string Value
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

        private ListElement head = hull;

        public void Add(string value)
        {
            var NewElement = new ListElement()
            { 
                Value = value,
                Next = null
            };

            if (head == null)
            {
                head = NewElement;
                return;
            }

            var currentElement = head;
            while (currentElement.Next != null)
            {
                currentElement = currentElement.Next;
            }
            currentElement.Next = NewElement;
        }

        public bool BinarySearch(string value)
        {
            var currentElement = head;
            while (currentElement.Next != null)
            {
                if (currentElement.Value == value)
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove(string value)
        {
            if (head.Value == value)
            {
                head = head.Next;
                return;
            }

            var currentElement = head;
            while (currentElement.Next != null)
            {
                if (currentElement.Value == value)
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
            Console.WhriteLine("Нельзя удалит элемент, котоого нет в списке =)");
        }
	}
}

