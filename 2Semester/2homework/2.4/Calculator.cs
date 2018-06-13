using System;

namespace StackCalculator
{
    public class Calculator
    {
        private IStack stack;
        public Calculator(IStack stack)
        {
            this.stack = stack;
        }
        public void CountExpression(char symbol)
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
