#include "arrayStack.h"

struct StackElement {
    
};

struct Stack {
    Value empty = 0;
    Value array[1000];
};

Stack *createStack()
{
    return new Stack;
}

void deleteStack(Stack *stack)
{
    delete stack;
}

void push(Stack *stack, int value) 
{
    stack->array[stack->empty] = value;
    ++stack->empty;
}

Value pop(Stack *stack)
{
    Value temp = stack->array[(stack->empty) - 1];
    stack->array[stack->empty] = 0;
    --(stack->empty);
    return temp;
}

bool isEmpty(Stack *stack)
{
    return stack->empty == 0;
}