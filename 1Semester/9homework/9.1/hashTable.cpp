#include "hashTable.h"
#include "list.h"
#include <iostream>
#include <string>
#include <math.h>

using namespace std;

struct HashTable
{
    int size;
    List **table;
};

HashTable *createHashTable(int size)
{
    HashTable *result = new HashTable;
    result->table = new List* [size];
    for (int i = 0; i != size; i++)
    {
        result->table[i] = createList();
    }
    result->size = size;
    return result;
}

int hashFunction(string value)
{
    int result = 0;
    for (int i = 0; i < value.length(); ++i) {
        result = abs(result + (value[i]) % 10);
    }
    return result;
}

void deleteHashTable(HashTable *table)
{
    for (int i = 0; i != table->size; i++)
    {
        clear(table->table[i]);
    }
    delete[] table;
    delete table;
}

bool exist(string value, HashTable *table)
{
    bool flag = false;
    ListElement *temp = head(table->table[hashFunction(value) % table->size]);
    while (temp != 0)
    {
        if (elementKey(temp) == value) {
            flag = true;
        }
        temp = nextElement(temp);
    }
    return flag;
}

void printHashTable(HashTable *table)
{
    for (int i = 0; i != table->size; i++)
    {
        ListElement *temp = head(table->table[i]);
        while (temp != nullptr)
        {
            cout << elementKey(temp) << " " << elementCount(temp) << endl;
            temp = nextElement(temp);
        }
    }
}

void counterOfWods(string &key, List *table)
{
    ListElement *temp = head(table);
    while (temp != nullptr)
    {
        if (elementKey(temp) == key)
        {
            increaseElementCounter(temp);
            break;
        }
        temp = nextElement(temp);
    }
}

void addToHashTable(HashTable *table, string value)
{
    Value *temp = new Value;
    temp->count = 1;
    temp->key = value;
    if (exist(value, table)) {
        counterOfWods(value, table->table[hashFunction(value) % table->size]);
    }
    else {
        insert(table->table[hashFunction(value) % table->size], temp);
    }
}
