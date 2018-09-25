#include <iostream>
#include <string>
#include <fstream>
#include "list.h"
#include "hashTable.h"

using namespace std;

int main(int argc, char** argv)
{
    double size = 0;
    cout << "Введите размерность хэш-таблицы" << endl;
    cin >> size;
    
    HashTable *hashTable = createHashTable(size);
    
    ifstream input("file.txt");
    double counterOfWords = 0;
    while (!input.eof())
    {
        string word = "";
        input >> word;
        counterOfWords++;
        addToHashTable(hashTable, word);
    }
    
    cout << "Коэффицент заполнения хэш-таблицицы: " << counterOfWords / size << endl;
    
    cout << "Максимальная длина списка в сегменте: " << maxLengthOfList(hashTable) << endl; 
    
    cout << "Средняя длина списка в сегменте: " << averageLengthOfList(hashTable) << endl; 
    
    printHashTable(hashTable);
    
    deleteHashTable(hashTable);
    
    return 0;
}
