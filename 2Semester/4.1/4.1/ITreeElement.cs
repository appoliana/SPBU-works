using System;

namespace TreeExpression
{
    /// <summary>
    /// Интерфейс ITreeElement.
    /// </summary>
    public interface ITreeElement
    {
            void AddElement(ITreeElement newTreeElement, ref bool elementIsAdded);

            int CountIt();

            string PrintElement();
    }
}
