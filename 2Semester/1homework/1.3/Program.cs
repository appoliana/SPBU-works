using System;

namespace _1._3
{
    class Program
    {
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; ++i)
            {
                for (int j = 0; j < array.Length - 1; ++j)
                {
                    if (array[j] > array[j + 1])
                    {
                        int dop = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = dop;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int length = 0;
            Console.Write("Введите количеcтво элементов массива: ");
            length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Console.Write("Введите элементы массива: ");
            for (int i = 0; i < length; ++i)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(array);
            Console.Write("Oтсортированный массив: ");
            for (int i = 0; i < length; ++i)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadLine();
        }
    }
}