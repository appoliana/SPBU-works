#include <stdio.h>
#include <cstdlib>


using namespace std;


int main(int argc, char** argv) {
    int n = 0;
    scanf("%d", &n);
    int A[n];
    bool flag = true;
    for (int i = 0; i < n; i++){
       scanf("%d", &A[i]);
    }
    int d = A[1] - A[0];
    for (int i = 1; i < n; i++){
        if(d == A[i] - A[i-1]){
            continue;
        }
        else{ flag = false;
        break;
        }
    }
    if (flag == true){
        int number = A[n-1] + d;
        printf("%d", number);
    }
    else{
        printf("%d", A[n-1]);
    }
    return 0;
}

