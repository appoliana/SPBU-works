#include <stdio.h>
#include <cstdlib>
#include <iostream>
#include <fstream>

using namespace std;


int main(int argc, char** argv) {
    FILE *out = fopen("HelloWorld.txt", "r"); 
        if (out == NULL){ 
            printf("File not opened");
            return 1;
        }
    return 0;
}

