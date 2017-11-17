#include <stdio.h>
#include <cstdlib>

using namespace std;

int main(int argc, char** argv) {
    int m = 0;
    int n = 0;
    int p = 0;
    int q = 0;
    int count = 0;
    scanf("%d", &m);
    scanf("%d", &n);
    scanf("%d", &p);
    scanf("%d", &q);
    int A[m][n];
    int B[m][n] = {0};
    for (int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
             scanf("%d", &A[i][j]);
        }
    }
    for (int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            if (A[i][j] == '*'){
                B[i][j] = 0;
            }
            if(A[i][j] = '.'){
                continue;
            }
            if(A[i][j] > 'A' && A[i][j] < 'Z'){
    
        }if (A[i][j] == '*'){
                B[i][j] = 0;
            }
            if(A[i][j] = '.'){
                continue;
            }
            }
        }
    return 0;
}

