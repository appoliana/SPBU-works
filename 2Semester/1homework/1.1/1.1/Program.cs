using System;

namespace 1.1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            int result = 1;
            Console.Write("Enter the positive number you want to find the factorial: ");
            value = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= value; ++i)
            {
                result *= i;
            }
            Console.Write("Factorial of " + value + " is " + result);
            Console.ReadLine();
        }
    }
}
