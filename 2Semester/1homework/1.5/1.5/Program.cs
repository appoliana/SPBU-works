using System;

namespace _1._5
{
    class Program
    {
        public static void SwapColumn(int[,] array, int i, int size)
        {
            for (int f = 0; f < size; ++f)
            {
                int dop = array[f, i];
                array[f, i] = array[f, i + 1];
                array[f, i + 1] = dop;
            }
        }

        public static void SortAndPrint(int[,] array, int size)
        {
            Console.WriteLine();
            for (int i = 0; i < size - 2 ++i)
            {
                for (int j = 0; j < size - 2; ++j)
                { 
                    if (array[0, j] > array[0, j + 1])
                    {
                        SwapColumn(array, j, size);
                    }
                ]
            }
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    Console.Write(array[i, j] + " ");
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

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    array[i, j] = rand.Next(0, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            SortAndPrint(array, size);
            Console.ReadLine();
        }
    }

}
    