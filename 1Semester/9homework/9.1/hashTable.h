#pragma once
#include "list.h"
#include <string>

struct HashTable;

// создание хэш-таблицы
HashTable *createHashTable(int size);

// проверка на существование элемента 
bool exist(std::string &value, HashTable *table);

// удаление
void deleteHashTable(HashTable *table);

// добавление в хэш-таблицу
void addToHashTable(HashTable *table, std::string &value);

// печать
void printHashTable(HashTable *table);

// увеличение счетчика
void counterOfWords(const std::string &key, List *bucket);