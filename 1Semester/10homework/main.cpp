#include <iostream>
#include <cstdlib>
#include <fstream>

using namespace std;

int theEnd(int arrayOfTowns[], int numberOfTowns);

void initialization(int &numberOfTowns, int &numberOfRoads, int &numberOfCountries, int *&arrayOfCountries, int **&matrix, int &maxLength) {
    ifstream input("file.txt");
    input >> numberOfTowns >> numberOfRoads;
    
    cout << "Список смежности: " << endl;
    for (int i = 0; i < numberOfTowns; ++i) {
        matrix[i] = new int [3];
        for (int j = 0; j < 3; ++j) {
            input >> matrix[i][j];
            if (matrix[i][2] > maxLength) {
                maxLength = matrix[i][2];
            }
            cout << matrix[i][j] << " ";
        }
        cout << endl;
    }
    input >> numberOfCountries;
    for (int i = 0; i < numberOfCountries; ++i) {
        input >> arrayOfCountries[i];
    }
    input.close();
}

void towns(int *&arrayOfTowns, int numberOfTowns, int numberOfCountries, int arrayOfCountries[]) {
    cout << "Массив городов: " << endl;
    for (int i = 0; i < numberOfTowns; ++i) {
        arrayOfTowns[i] = 0;
        for (int j = 0; j < numberOfCountries; ++j) {
            if (i + 1 == arrayOfCountries[j]) {
                arrayOfTowns[i] = i + 1;
            }
        }
        cout << arrayOfTowns[i] << " ";
    }
    cout << endl;
}

int main(int argc, char** argv) {
    int numberOfTowns = 0;
    int numberOfRoads = 0;
    int numberOfCountries = 0;
    int maxLength = 0;
    int *arrayOfCountries = new int[numberOfCountries];
    int **matrix = new int *[numberOfTowns];
    
    initialization(numberOfTowns, numberOfRoads, numberOfCountries, arrayOfCountries, matrix, maxLength);
    
    int *arrayOfTowns = new int[numberOfTowns];
    towns(arrayOfTowns, numberOfTowns, numberOfCountries, arrayOfCountries);
    
    int minLength = maxLength;
    int town = -1;
    int dop = 0;
    for (int j = 0; j < numberOfCountries; ++j) {
        for (int i = 0; i < numberOfTowns && theEnd(arrayOfTowns, numberOfTowns) != 0; ++i) {
            cout << "столица сейчас " << arrayOfCountries[j] << endl;
            if (arrayOfTowns[i] == arrayOfCountries[j]) {
                cout << "yes" << endl;
                for (int f = 0; f < numberOfTowns; ++f) {
                    cout << f << "now" << endl;
                    if (matrix[f][0] == i + 1 || matrix[f][1] == i + 1) {
                        cout << "yes matrix" << endl;
                        cout << matrix[f][2] << endl;
                        cout << matrix[f][0] << endl;
                        cout << arrayOfTowns[f];
                        if (matrix[f][2] <= minLength && arrayOfTowns[f] == 0) {
                            minLength = matrix[f][2];
                            matrix[f][0] == i + 1 ? town = matrix[f][1] : town = matrix[f][0];
                            cout << minLength << endl;
                        }
                    }
                    dop = j;
                }
            }
        }
        for (int d = 0; d < numberOfTowns; ++d) {
            if (d + 1 == town) { 
                arrayOfTowns[d] = arrayOfCountries[dop];
                cout << town << " присвоен столице" << arrayOfCountries[dop] << endl;
            }
        }
    }
    
    for (int j = 0; j < numberOfCountries; ++j) {
        cout << arrayOfCountries[j] << " столице принадлежат города: ";
        for (int i = 0; i < numberOfTowns; ++i) {
            if (arrayOfTowns[i] == arrayOfCountries[j]) {
                cout << i + 1;
            } 
        }
        cout << endl;
    }
    
    delete[] arrayOfTowns;
    delete[] arrayOfCountries;
    for (int i = 0; i < numberOfTowns; i++) {
        delete[] matrix[i];
    }
    delete [] matrix;
    return 0;
}

int theEnd(int arrayOfTowns[], int numberOfTowns) {
    for (int i = 0; i < numberOfTowns; ++i) {
        if (arrayOfTowns[i] == 0)
            return 1;
    }
    return 0;
}
