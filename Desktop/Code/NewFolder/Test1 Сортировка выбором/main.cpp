#include <iostream>
#include <cstdlib>
#include <stdio.h>
#include <memory>

using namespace std;

void sortInserts(int *arrayLength, int length) {
    int item = 0; // индекс предыдущего элемента
    for (int counter = 1; counter < length; ++counter)
    {
        item = counter - 1; //индекс предыдущего элемента массива
        while(item >= 0 && arrayLength[item] > arrayLength[counter])
        {
            swap(arrayLength[item + 1], arrayLength[counter]); 
            item--;
        }
    }
    cout << "Отсортированный массив: " << endl;
    for (int counter = 0; counter < 10; counter++) {
        cout << arrayLength[counter] << ", ";
    }
}

int main(int argc, char** argv) {
    int length = 10;
    int *arrayLength = new int[length];
    cout << "Введите элементы массива: ";
    for (int i = 0; i < 10; i++) {
        arrayLength[i] = 0;
        cin >> arrayLength[10];
    }
    
    sortInserts(arrayLength, length);
    
    delete[] arrayLength;
    return 0;
}
