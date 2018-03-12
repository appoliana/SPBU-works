using System;

namespace _1._5
{
    class Program
    {
        public static void SwapColumn(int[,] array, int columnNumber)
        {
            for (int lineNumber = 0; lineNumber < array.Length; ++lineNumber)
            {
                int dop = array[lineNumber, columnNumber];
                array[lineNumber, columnNumber] = array[lineNumber, columnNumber + 1];
                array[lineNumber, columnNumber + 1] = dop;
            }
        }

        public static void SortAndPrint(int[,] array)
        {
            Console.WriteLine();
            for (int counter = 0; counter < array.Length - 1; ++counter)
            {
                for (int columnNumber = 0; columnNumber < array.Length - columnNumber; ++columnNumber)
                {
                    if (array[0, columnNumber] > array[0, columnNumber + 1])
                    {
                        SwapColumn(array, columnNumber);
                    }
                }
            }
            for (int lineNumber = 0; lineNumber < array.Length; ++lineNumber)
            {
                for (int columnNumber = 0; columnNumber < array.Length; ++columnNumber)
                {
                    Console.Write(array[lineNumber, columnNumber] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int size = 0;
            Console.Write("Введите размерность массива: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[size, size];
            Random rand = new Random();

            for (int lineNumber = 0; lineNumber < size; ++lineNumber)
            {
                for (int columnNumber = 0; columnNumber < size; ++columnNumber)
                {
                    array[lineNumber, columnNumber] = rand.Next(0, 10);
                    Console.Write(array[lineNumber, columnNumber] + " ");
                }
                Console.WriteLine();
            }
            SortAndPrint(array);
            Console.ReadLine();
        }
    }
}
