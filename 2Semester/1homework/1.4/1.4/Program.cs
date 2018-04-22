using System;

namespace _1._4
{
    class Program
    {
        public static void Print(int[,] array, int size)
        {
            Console.Write(array[(size / 2) + 1, (size/ 2) + 1] + " ");
            int dop = 1;
            int count = 1;
            int i = size / 2 + 1;
            int j = size / 2 + 1;
            while (count < array.Length)
            {
                int dop1 = 0;
                while (dop1 != dop)
                {
                    if (dop % 2 == 0)
                    {
                        --i;
                    }
                    else
                    {
                        ++i;
                    }
                    Console.Write(array[i, j] + " ");
                    ++dop1;
                    ++count;
                }
                int dop2 = 0;
                while (dop2 != dop)
                {
                    if (dop % 2 == 0)
                    {
                        --j;
                    }
                    else
                    {
                        ++j;
                    }
                    Console.Write(array[i, j] + " ");
                    ++dop2;
                    ++count;
                }
                ++dop;
                if (count == array.Length)
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine();
            Print(array, size);
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}

