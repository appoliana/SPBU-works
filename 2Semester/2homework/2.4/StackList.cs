using System;

namespace CalculatorClass
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
            }
            int temp = head.Value;
            head = head.Next;
            return temp;
        }

        public bool IsEmpty()
        {
            return head == null;
        }
    }
}
