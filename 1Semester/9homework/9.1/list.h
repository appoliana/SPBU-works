#pragma once
#include <string>

struct ListElement;

struct List;

struct Value
{
    int count;
    std::string key;
};

typedef Value *ElementType;

// сощдание списка
List *createList();

// вернуть указатель на голову
ListElement *head(List *list);

// вернуть количетсво
int elementCount(ListElement *element); 

// добавление в список
void insert(List *list, ElementType element);

// увеличение количества
void increaseElementCounter(ListElement *element);

// вернуть указатель на следующий элемент
ListElement* nextElement(ListElement *element);

// вернуться значение ключа
std::string elementKey(ListElement *element);

// удаление списка
void clear(List *list);