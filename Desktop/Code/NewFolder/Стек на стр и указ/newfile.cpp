#include "stack.h"
#include "newfile.h"


Stack *createStack()
{
    return new Stack{}; //инициализация стека нулевыми значениями

void push(Stack *stack, int value)
{
    StackElement *newHead = new StrackElement;
    newHead -> value = value;
    newHead -> next = stack ->head;
    stack ->head = newHead;
}

void deleteStackElements(StackElement *element)
{
    if (element = NULL){
        return;
    }
    StackElement * next = element ->next;
    delete element;
    deleteStackElements(next);
}

void deleteStack(Stack *stack)
{
    StackElement *next = stack ->head->next;
    delete stack;
}
