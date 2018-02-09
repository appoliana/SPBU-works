#pragma once
#include "list.h"
#include <string>

struct HashTable;

// создание хэш-таблицы
HashTable *createHashTable(int size);

// проверка на существование элемента 
bool exist(const std::string &value, HashTable *table);

// удаление
void deleteHashTable(HashTable *table);

// добавление в хэш-таблицу
void addToHashTable(HashTable *table, const std::string &value);

// печать
void printHashTable(HashTable *table);

// увеличение счетчика
void counterOfWords(const std::string &key, List *bucket);

// подсчет наибольшей длины списка в сегменте таблицы
int maxLengthOfList(HashTable *table);

// подсчет средней длины списка в сегменте таблицы
int middleLengthOfList(HashTable *table) ;