using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Program
    {
        public static int fibonacciNumbers(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            if (n > 2)
                return fibonacciNumbers(n - 1) + fibonacciNumbers(n - 2);
            return 0;
        }

        static void Main(string[] args)
        {
            int value = 0;
            Console.Write("Введите число, для которого хотите посчитать число Фибоначчи: ");
            value = Convert.ToInt32(Console.ReadLine());
            int result = fibonacciNumbers(value);
            Console.Write("Резултьат: " + result);
            int t = new int();
        }
    }
}
