using System;

namespace TreeExpression
{
    public class Operator : ITreeElement
    {
        public char Value { get; set; }

        public ITreeElement Left { get; set; }

        public ITreeElement Right { get; set; }

        /// <summary>
        /// Метод, который добавляет значения в дерево.
        /// </summary>
        /// <param name="newTreeElement"></param>
        /// <param name="elementIsAdded"></param>
        public void AddElement(ITreeElement newTreeElement, ref bool elementIsAdded)
        {
            if (!elementIsAdded)
            {
                if (Left == null)
                {
                    Left = newTreeElement;
                    elementIsAdded = true;
                    return;
                }

                if (Left is Operator)
                {
                    Left.AddElement(newTreeElement, ref elementIsAdded);
                }
            }

            if (!elementIsAdded)
            {
                if (Right == null)
                {
                    Right = newTreeElement;
                    elementIsAdded = true;
                    return;
                }

                if (Right is Operator)
                {
                    Right.AddElement(newTreeElement, ref elementIsAdded);
                }
            }
        }

        /// <summary>
        /// Метод, который считает значение выражения.
        /// </summary>
        /// <returns></returns>
        public int CountIt()
        {
            switch (Value)
            {
                case '+':
                    return (Left.CountIt() + Right.CountIt());
                case '-':
                    return (Left.CountIt() - Right.CountIt());
                case '*':
                    return (Left.CountIt() * Right.CountIt());
                case '/':
                    return (Left.CountIt() / Right.CountIt());
            }
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Метод, который печатает элементы дерева.
        /// </summary>
        /// <returns></returns>
        public string PrintElement()
        {
            return "(" + Left.PrintElement() + " " + Value.ToString() + " " + Right.PrintElement() + ")";
        }
    }
}
