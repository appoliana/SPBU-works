using System;

namespace HashTable
{
    public class HashTable : HashTableInterface
    {
        private int size;
        private List[] hashTable;
        private Func<string, int> hashFunction;

        public HashTable(int size)
        {
            this.size = size;
            this.hashTable = new List[size];
            for (int i = 0; i < size; i++)
            {
                hashTable[i] = new List();
            }
            this.hashFunction = HashFunctionPolynom;
        }

        public HashTable(int maxSize, Func<string, int> userHashFunction) : this(maxSize)
        {
            hashFunction = userHashFunction;
        }

        public void ChangeHashFunction(Func<string, int> userHashFunction)
        {
            this.hashFunction = userHashFunction;

            List[] dop = new List[size];
            for (int i = 0; i < size; i++)
            {
                dop[i] = new List();
            }

            for (int i = 0; i < size; i++)
            {
                if (hashTable[i] != null)
                {
                    int length = hashTable[i].Length;
                    for (int j = 0; j < length; j++)
                    {
                        string value = hashTable[i].ReturnValue(j);
                        int index = userHashFunction(value);
                        dop[index].Add(value);
                    }
                }
            }
            hashTable = dop;
        }

        private static int HashFunctionPolynom(string inputString)
        {
            int primeNumber = 67;
            int degree = 1;
            int length = inputString.Length;
            int result = 0;
            for (int i = 0; i < length; i++)
            {
                result = ((inputString[i] * degree) % 100 + result) % 5;
                degree = (degree * primeNumber) % 10;
            }
            return result;
        }

        public void AddElement(string value)
        {
            hashTable[hashFunction(value)].Add(value);
        }

        public void RemoveElement(string value)
        {
            hashTable[hashFunction(value)].RemoveElement(value);
        }

        public bool IsExist(string value)
        {
            return hashTable[hashFunction(value)].IsExist(value);
        }

        public void PrintList(string value)
        {
            hashTable[hashFunction(value)].PrintList();
        }
    }
}
