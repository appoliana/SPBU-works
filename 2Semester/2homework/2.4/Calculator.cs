using System;

namespace CalculatorClass
{
    public class Calculator
    {
        public void CountExcpression(char symbol)
        {
            int secondNumber = stack.Pop();
            int firstNumber = stack.Pop();
            switch (symbol)
            {
                case '+':
                    {
                        stack.Push(firstNumber + secondNumber);
                        break;
                    }
                case '-':
                    {
                        stack.Push(firstNumber - secondNumber);
                        break;
                    }
                case '/':
                    {
                        stack.Push(firstNumber / secondNumber);
                        break;
                    }
                case '*':
                    {
                        stack.Push(firstNumber * secondNumber);
                        break;
                    }
            }
        }
    }
}
