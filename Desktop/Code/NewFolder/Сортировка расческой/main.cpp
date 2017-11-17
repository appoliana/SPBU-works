#include <stdio.h>
#include <cstdlib>
#include <iostream>
#include <memory>

using namespace std;


int main(int argc, char** argv) {
    int n = 0;
    double factor = 1.247;
    cout << "Введите количесество элементов массива: ";
    cin >> n;
    int step = n/factor;
    int array[n];
    cout << "Массив: " << endl;
    for (int i = 0; i < n; i++) {
        cin >> array[i];
    }
    
    while (step > 1) {
    for (int i = 0; i + step < n; i++) {
        if (array[i] > array[i + step]) {
            swap (array[i], array[i + step]);
        }
    }
    step = step / factor;
    }
    
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n-i-1; j++) {
            if (array[j] > array[j+1]) {
                swap(array[j], array[j + 1]);
            }
        }
    }
    
    cout << "Отсортированный массив: " << endl;
    for (int i = 0; i < n; i++) { 
        cout << array[i];
    }
            
    return 0;
}

