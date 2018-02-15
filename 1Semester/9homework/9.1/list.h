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

// создание списка
List *createList();

// вернуть указатель на голову
ListElement *head(List *list);

// вернуть количество
int elementCount(ListElement *element); 

// добавление в список
void insert(List *list, ElementType element);

// увеличение количества
void increaseElementCounter(ListElement *element);

// вернуть указатель на следующий элемент
ListElement* nextElement(ListElement *element);

// значение ключа, по которому происходит обращение к элементу
std::string elementKey(ListElement *element);

// удаление списка
void clear(List *list);