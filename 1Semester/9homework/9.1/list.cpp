#include <iostream>
#include "list.h"
#include <string>

using namespace std;

struct ListElement
{
    ElementType value;
    ListElement *next;
};

struct List
{
    ListElement *head;
    ListElement *end;
};

List *createList()
{
    List *result = new List;
    ListElement *sentinel = new ListElement;
    sentinel->value = nullptr;
    sentinel->next = nullptr;
    result->head = sentinel;
    result->end = sentinel;
    result->end->next = nullptr;
    return result;
}

ListElement *createListElement()
{
    ListElement *newElement = new ListElement;
    newElement->value = nullptr;
    newElement->next = nullptr;
    return newElement;
}

void insert(List *list, ElementType value)
{
    ListElement *newElement = createListElement();
    list->end->next = newElement;
    list->end = newElement;
    list->end->value = value;
}

void clear(List *list)	
{
    ListElement *temp = list->head;
    while (temp != nullptr)
    {
        ListElement *temp2 = temp;
        temp = temp->next;
        delete temp2->value;
        delete temp2;
    }
    delete list;
}

ListElement* nextElement(ListElement *element)
{
    return element->next;
}

ListElement *head(List *list)
{
    return list->head->next;
}

string elementKey(ListElement *element)
{
    return element->value->key;
}

int elementCount(ListElement *element)
{
    return element->value->count;
}

void increaseElementCounter(ListElement *element)
{
    element->value->count++;
}