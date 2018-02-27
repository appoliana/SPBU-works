using System;

namespace _1._2
{
    class Program
    {
        public static int FibonacciNumbers(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            if (n > 2)
            {
                return FibonacciNumbers(n - 1) + FibonacciNumbers(n - 2);
            }
            return 0;
        }

        static void Main(string[] args)
        {
            int value = 0;
            Console.Write("Введите число, для которого хотите посчитать число Фибоначчи: ");
            value = Convert.ToInt32(Console.ReadLine());
            int result = fibonacciNumbers(value);
            Console.Write("Результат: " + result);
        }
    }
}
