/* 
 * File:   main.cpp
 * Author: polinapicchio
 *
 * Created on 9 сентября 2017 г., 13:02
 */

#include <iostream>
#include <cstdlib>
#include <stdio.h>

using namespace std;

/*
 * 
 */
void Chandge (int *A, int left, int right){
for( int i = left; i < (left + right)/2 ; i++){
    int dop = A[i];
    A[i] = A[right - i - 1];
    A[right - i - 1] = dop;
}
}

int main(int argc, char** argv){
    int n = 0;
    int m = 0; 
    cin >> n;
    cin >> m;
    int sum = n + m;
    int A[sum];
    
    for( int i = 0; i < sum; i++){
        A[i] = rand () % 10;
        printf("%d", A[i]);
    }
    
    for( int i = 0; i < sum; i++){
        Chandge(A, 0, n);
        Chandge(A, n, sum);
        Chandge(A, 0, sum);
       
    }
     printf("\n");
    for(int i = 0; i < sum; i++){
        printf("%d", A[i]);
    }
    return 0;
}