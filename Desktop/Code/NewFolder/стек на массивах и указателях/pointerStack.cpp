#include "arrayStack.h"

struct StackElement {
    int value;
    StackElement *next;
};

struct Stack
{
    StackElement *head;
};

Stack *createStack()
{
    return new Stack{};
}

void deleteStack(Stack *stack)
{
    while (!isEmpty(stack)) {
        pop(stack);
    }
    delete stack;
}

void push(Stack *stack, Value value)
{
    auto newElement = new StackElement{ value, stack->head};
    stack->head = newElement;
}

Value pop(Stack *stack)
{
    auto result = stack->head->value;
    auto oldHead = stack->head;
    stack->head = stack->head->next;
    delete oldHead;
    return result;
}

bool isEmpty(Stack *stack)
{
    return !stack->head;
}