#include <iostream>
#include <string>
#include <fstream>
#include "list.h"
#include "hashTable.h"

using namespace std;

int main(int argc, char** argv)
{
    int size = 0;
    cout << "Введите размерность хэш-таблицы" << endl;
    cin >> size;
    
    HashTable *hashTable = createHashTable(size);
    
    ifstream input("file.txt");
    while (!input.eof())
    {
        string word = "";
        input >> word;
        addToHashTable(hashTable, word);
    }
    
    printHashTable(hashTable);
    
    deleteHashTable(hashTable);
    
    return 0;
}
