using System;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose = 0;
            Console.WriteLine("Введите 1 для создания стека на массиве, 2 - для создания стека на списке, 0 - для завершения работы программы: ");
            Console.ReadLine(choose);
            var stack;
            switch (choose)
            {
                case 1:
                    {
                        stack = new ArrayStack;
                        break;
                    }
                case 2:
                    {
                        stack = new ListStack;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введена неопознанная команда =( ");
                        return;
                    }
            }

            int choose1 = 0;
            Console.WriteLine("Введите 1 для продолжения работы с калькулятором, 0 - для завершения работы программы");
            Console.ReadLine(choose1);
            Console.WriteLine("Введите через первое число: ");
            var number1;
            Console.ReadLine(number1);
            stack.Push(number1);
            switch (choose1)
            {
                case 0:
                    {
                        return;

                    }
                case 1:
                    {
                        Console.WriteLine("Введите через пробел операцию(‘+’, ‘-’, ‘/’ или ‘*’), второе число: ");
                        var operator;
                        var number2;
                        Console.ReadLine(operator);
                        Console.ReadLine(number2);
                        stack.Push(number2);
                        CountExcpression(operator);
                        var result = stack.Pop();
                        Console.WriteLine(result + " ");
                        stack.Push(result);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введена неопознанная команда =( ");
                        return;
                    }
            }
        }
    }
}
