using System;

namespace HashTable
{
    interface HashTableInterface
    {
            void ChangeHashFunction(Func<string, int> userHashFunction);

            void AddElement(string value);

            void RemoveElement(string value);

            bool IsExist(string value);

            void PrintList(string value);
    }
}

