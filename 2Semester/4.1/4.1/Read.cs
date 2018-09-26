using System;

namespace TreeExpression
{
    public class Read
    {
        /// <summary>
        /// Метод, который осуществляет разбор строки на дерево.
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="expression"></param>
        public static void ReadExpressionFromString(Tree tree, string expression)
        {
            while (expression.Length != 1)
            {
                string OperatorOrOperand = expression.Remove(expression.IndexOf(' '));

                switch (OperatorOrOperand)
                {
                    case "(":
                    case ")":
                        break;
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        tree.AddTreeElement(OperatorOrOperand[0]);
                        break;
                    default:
                        tree.AddTreeElement(Int32.Parse(OperatorOrOperand));
                        break;
                }

                expression = expression.Remove(0, OperatorOrOperand.Length);
                if (expression.Length != 1)
                {
                    expression = expression.Remove(0, 1);
                }
            }
        }
    }
}
