using System;

namespace CalculatorClass
{
    public class ArrayStack : IStack
    {
        private int[] array;
        private const int capacity = 50;
        private int size;

        public void CreateStack()
        {
            this.size = 0;
            this.array = new int[capacity];
        }

        public bool isEmpty()
        {
            return this.size == 0;
        }

        public virtual int Count
        {
            get
            {
                return this.size;
            }
        }

        public int Pop()
        {
            if (this.size == 0)
            {
                throw new InvalidOperationException();
            }
            return this.array[--this.size];
        }

        public void Push(int newElement)
        {
            if (this.size == this.array.Length) //если у нас переполнение
            {
                int[] newArray = new int[2 * this.array.Length];
                Array.Copy(this.array, 0, newArray, 0, this.size);
                this.array = newArray;
            }
            this.array[this.size++] = newElement;
        }
    }
}
