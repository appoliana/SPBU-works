#include <stdio.h>
#include <cstdlib>
#include <iostream>
#include "stek.h"

using namespace std;


int main(int argc, char** argv) {
    Stack* stack = createStack();
    push(stack, 8);
    push(stack, 4);
    push(stack, 6);
    push(stack, 17);
    for (int i = 0; i < 4; ++i) {
    int now = pop(stack);
    cout << now << endl;
    }
    deleteStack(stack);
    return 0;
}

