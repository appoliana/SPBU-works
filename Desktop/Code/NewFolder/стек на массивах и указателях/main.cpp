#include <cstdlib>
#include <iostream>
#include <stdio.h>
#include "arrayStack.h"

using namespace std;

int main(int argc, char** argv)
{
    auto stack = createStack();
    
    push(stack, 1);
    push(stack, 2);
    
    cout << pop(stack);
    cout << ", ";
    cout << pop(stack);
            
    return 0;
}

