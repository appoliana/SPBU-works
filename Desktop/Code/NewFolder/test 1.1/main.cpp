#include <iostream>
#include <cstdlib>
#include <stdio.h>

using namespace std;

int main(int argc, char** argv) {
    int a = 0b00000000;
    int b = 0b00000000;
    cout << "Введите первый элемент: ";
    cin >> a;
    cout << "Введите второй элемент: ";
    cin >> b;
    char array1[8] = {0};
    char array2[8] = {0};
    for (int i = 7; i >= 0; --i) {
        array1[i] = a % 10 > 0 ? true : false;
        array2[i] = b % 10 > 0 ? true : false;
        a = a / 10;
        b = b / 10;
    }
    
    char dop = 0;
    for (int i = 0; i < 8; i++) {
        if (array1[i] == array2[i]) {
            continue;
        }
        if (array1[i] >  array2[i] || array2[i] > array1[i]) {
            dop = array1[i] > array2[i] ? '1' : '2';
            break;
        }
    }
    cout << endl;
    cout << "Из двух элементов " << dop << " больше";
    return 0;
}

