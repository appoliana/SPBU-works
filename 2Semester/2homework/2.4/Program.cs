using System;

namespace StackCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 для создания стека на массиве, 2 - для создания стека на списке, 0 - для завершения работы программы: ");
            int choose = Convert.ToInt32(Console.ReadLine());
            IStack stack;
            switch (choose)
            {
                case 1:
                    {
                        stack = new ArrayStack();
                        break;
                    }
                case 2:
                    {
                        stack = new ListStack();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введена неопознанная команда =( ");
                        return;
                    }
            }

            var calculator = new Calculator(stack);

            Console.WriteLine("Введите первое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            stack.Push(number1);

            while (true)
            {
                Console.WriteLine("Введите 1 для продолжения работы с калькулятором, 0 - для завершения работы программы");
                int choose1 = Convert.ToInt32(Console.ReadLine()); 
                switch (choose1)
                {
                    case 0:
                        {
                            return;

                        }
                    case 1:
                        {
                            Console.WriteLine("Введите через enter операцию(‘+’, ‘-’, ‘/’ или ‘*’), второе число: ");
                            char symbol = Convert.ToChar(Console.ReadLine());
                            int number2 = Convert.ToInt32(Console.ReadLine());
                            stack.Push(number2);
                            calculator.CountExpression(symbol);
                            var result = stack.Pop();
                            Console.WriteLine($"Результат: {result} ");
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
}
