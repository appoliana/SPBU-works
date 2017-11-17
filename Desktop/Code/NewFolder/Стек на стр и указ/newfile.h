#pragma once

// Элемент из стека
struct StrackElement{
    
    char value;
    StackElement *next;
};

struct Stack{
    StackElement *head;
};

Stack *createStack();

void push(Stack *stack, int value);
void deleteStack (Stack *stack);