using System;

namespace fibonacciNumber
{
    class Program
    {
        public static double FibonacciNumbers(int n)
        {
            double dop = System.Math.Pow(((1 + Math.Sqrt(5)) / 2), n);
            double dop2 = System.Math.Pow(((1 - Math.Sqrt(5)) / 2), n);
            double number = (1 / Math.Sqrt(5)) * (dop - dop2);
            return number;
        }

        static void Main(string[] args)
        {
            int value = 0;
            Console.Write("Введите число, для которого хотите посчитать число Фибоначчи: ");
            value = Convert.ToInt32(Console.ReadLine());
            double result = FibonacciNumbers(value);
            Console.Write("Результат: " + result);
            Console.ReadLine();
        }
    }
}
