#include <fstream>
#include <cstdlib>
#include <iostream>
#include <stdio.h>

using namespace std;

int main(int argc, char** argv) {
    
    FILE *out = fopen("file.txt", "r");
    int c;
    if (out == NULL)
    {
        printf("File not opened");
        return 1;
    }
    else
    {
        while (!feof(out)) {
            c = fgetc(out);
            if (c == ';')
            {
                for ( ;c != EOF; ) {
                cout << c;
                }
            }
        } 
    fclose(out);
  }
  return 0;
}

