using System;

namespace Testing
{
    public class Stack
    {
        private class StackElement 
        {
            private int value;
            public int Value
            {
                get => this.value;
                set
                {
                    if (value < 0)
                    {
                        throw new Exception("Field is negative");
                    }
                }
            }
            public StackElement Next { get; set; }  
        }

        private StackElement head = null;
        public void Push(int value)
        {
            this.head = new StackElement
            {
                Next = this.head,
                Value = value
            };
        }

        public int Pop()
        {
            if (this.Empty)
            {
                return -1;
            }
            var value = this.head.Value;
            this.head = this.head.Next;
            return value;
        }
        public bool Empty => this.head == null;  
    }      
}
