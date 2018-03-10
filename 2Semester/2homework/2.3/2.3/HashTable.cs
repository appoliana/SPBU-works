using System;

namespace HashTableClass
{
	public class HashTable
	{
        private int capacity = 10;
        private List[] arrayOfHashTable;

        public HashTable()
        {
            arrayOfHashTable = new List[capacity];
            for ( int i = 0; i < capacity; ++i)
            {
                arrayOfHashTable = new List();
            }
        }

        private int HashFunction(string value)
        {
            int result = 0;
            for (int i = 0; i < value.Length; ++i)
            {
                result = abs(result + (value[i]));
            }
            return result % capacity;
        }

        public void AddElement(string value)
        {
            if (!Excist(value))
            {
                arrayOfHashTable[HashFunction(value)].Add(value);
                return;
            }
            Console.WriteLine("This element has already excisted");
        }

        public void DeleteElement(string value)
        {
            if (!Excist(value))
            {
                Console.WriteLine("This element does not exist :)");
                return;
            }
            arryOfHashTable[HashFunction(value)].Remove(value);
        }

        public void Excist(string value)
        {
            return arrayOfHashTable[HashFunction(value)].BinarySearch(value);
        }
	}
}
