using System;

namespace TreeExpression
{
    public class Tree
    { 
        private Operator head = null;

        /// <summary>
        /// Метод, который добавляет оператор в дерево.
        /// </summary>
        /// <param name="value"></param>
        public void AddTreeElement(char value)
        {
            var newTreeElement = new Operator()
            {
                Value = value,
                Left = null,
                Right = null
            };

            if (head == null)
            {
                head = newTreeElement;
                return;
            }

            bool elementIsAdded = false;
            head.AddElement(newTreeElement, ref elementIsAdded);
        }

        /// <summary>
        /// Метод, который добавляет операнд в дерево.
        /// </summary>
        /// <param name="value"></param>
        public void AddTreeElement(int value)
        {
            var newTreeElement = new Operand()
            {
                Value = value,
            };

            bool elementIsAdded = false;
            head.AddElement(newTreeElement, ref elementIsAdded);
        }

        /// <summary>
        /// Метод, который возвращает посчитанное значение выражения.
        /// </summary>
        /// <returns></returns>
        public int CountTree() => head.CountIt();

        /// <summary>
        /// Метод, который печатает дерево.
        /// </summary>
        /// <returns></returns>
        public string PrintTree() => head.PrintElement();

    }
}
