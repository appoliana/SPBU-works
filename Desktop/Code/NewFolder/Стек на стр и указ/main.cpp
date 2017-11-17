#include <stdio.h>
#include <cstdlib>
#include "newfile.h"

using namespace std;


int main(int argc, char** argv) 
{
    Stack *stack = createStack();
    push(stack, 1);
    push(stack, 2);
    
    delete stack;
    
    return 0;
}

