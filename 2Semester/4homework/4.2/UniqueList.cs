using System;

namespace UniqueListClass
{
    public class UniqueList : List
    {
        public new class ListElement
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

        public override void Add(int value)
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
                if (currentElement.Value == newElement.Value)
                {
                    throw new AddExistingElementException("This element has already existed!");
                }
                currentElement = currentElement.Next;
            }
            currentElement.Next = newElement;
        }
    }
}

