using System;

namespace StackCalculator
{
    public class ListStack : IStack
    {
        private class StackElement
        {
            public int Value
            {
                get;
                set;
            }
            public StackElement Next
            {
                get;
                set;
            }
        }

        public void Push(int value)
        {
            var newElement = new StackElement()
            {
                Next = head,
                Value = value
            };
            head = newElement;
        }

        private StackElement head = null;

        public int Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty :(");
                throw new InvalidOperationException();
            }
            int temp = head.Value;
            head = head.Next;
            return temp;
        }

        public bool IsEmpty() => head == null;
    }
}
