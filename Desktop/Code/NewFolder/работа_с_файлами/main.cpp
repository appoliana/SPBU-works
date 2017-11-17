#include <stdio.h>
#include <cstdlib>
#include <fstream>
#include <iostream>

using namespace std;

/*
 * 
 */
int main(int argc, char** argv) {
    FILE *out = fopen ("file.txt", w);
    if (out == NULL) {
        printf("File not opend")
        return 1;
    }
    return 0;
}

