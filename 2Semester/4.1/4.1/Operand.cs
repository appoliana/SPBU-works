using System;

namespace TreeExpression
{
        public class Operand : ITreeElement
        {
            public int Value { get; set; }

            /// <summary>
            /// Метод, который запрещает добавление числа в корень дерева. 
            /// </summary>
            /// <param name="newTreeElement"></param>
            /// <param name="elementIsAdded"></param>
            public void AddElement(ITreeElement newTreeElement, ref bool elementIsAdded)
            {
                throw new InvalidOperationException();
            }

            /// <summary>
            /// Метод, который возвращает почитанное значение.
            /// </summary>
            /// <returns></returns>
            public int CountIt() => Value;

            /// <summary>
            /// Метод, который перечает значение элемента.
            /// </summary>
            /// <returns></returns>
            public string PrintElement() => Value.ToString();
        }
}

