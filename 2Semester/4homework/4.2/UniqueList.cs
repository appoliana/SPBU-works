using System;

namespace UniqueList
{
    public class UniqueList : List
    {
        public override void Add(int value)
        {
            if (IsElement(value))
            {
                throw new AddExistingElementException();
            }
            base.Add(value);
        }
    }
}

