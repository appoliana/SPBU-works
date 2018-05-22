using System;

namespace traversingTheArrayInASpiral
{
    class Program
    {
        public static void Print(int[,] array)
        {
            Console.Write(array[(array.GetLength(0) / 2), (array.GetLength(0) / 2)] + " ");
            int dop = 1;
            int count = 1;
            int i = array.GetLength(0) / 2;
            int j = array.GetLength(1) / 2 ;
            while (count < array.Length)
            {
                int наСколькоНамНужноСейчасПодвинутьсяВнизИлиВверх = 0;
                while (наСколькоНамНужноСейчасПодвинутьсяВнизИлиВверх != dop)
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
                    ++наСколькоНамНужноСейчасПодвинутьсяВнизИлиВверх;
                    ++count;
                    if (count == array.Length)
                    {
                        return;
                    }
                }
                int наСколькоНамНужноСейчасПодвинутьсяВправоИлиВлево = 0;
                while (наСколькоНамНужноСейчасПодвинутьсяВправоИлиВлево != dop)
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
                    ++наСколькоНамНужноСейчасПодвинутьсяВправоИлиВлево;
                    ++count;
                    if (count == array.Length)
                    {
                        return;
                    }
                }
                ++dop;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            if (size % 2 == 0)
            {
                Console.Write("Нужно ввести массив нечетной размерности.");
                Console.ReadLine();
                return;
            }
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
            Print(array);
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}

