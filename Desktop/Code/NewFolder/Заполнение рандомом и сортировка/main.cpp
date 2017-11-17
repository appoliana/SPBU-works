#include <cstdlib>
#include <stdio.h>
#include <memory>

using namespace std;

int main(int argc, char** argv) {
 int n = 0;
    printf("Введите количество эл-тов массива: \n");
    scanf("%d", &n);
    int A[n];
    for(int i = 0; i < n; i++){
        A[i] = rand () % 10;
        printf("%d,", A[i]);
    }
    printf("\n");
    printf("Первый элемент массива = %d", A[0]);
    int number = A[0];
    printf("\n");
    int min = 0;
    int max = 0;
    for(int i = 1; i < n; i++){
        if(A[i]>= number)
            max++;
        else{
            min++;
        }
    }
    
    swap(A[min+1],A[0]);
    
    printf("Элементов больше первог: ");
    printf("%d", max);
    printf("\n");
    printf("Элементов меньше первого: "); 
    printf("%d", min);
    printf("\n");
    
    for(int i = 0; i < number; i++){
        if (A[i] > A[i+1])
            swap(A[i],A[i+1]);
    }
    
    for(int i = 0; i < n; i++){
        printf("%d,", A[i]);
    }
        printf("\n");

    for(int i = number+1; i < n; i++){
        if (A[i] < A[i+1])
            swap(A[i],A[i+1]);
    }
           
    for(int i = 0; i < n; i++){
        printf("%d,", A[i]);
    }
        printf("\n");

    int dop = 0;
    for(int i = 0; i < number; i++){
        if (A[i] >= number)
            dop = i;
        break;
    }
       printf("dop = %d",dop);
       printf("\n");
    for(int i = 0; i < n; i++){
        printf("%d,", A[i]);
    }
        printf("\n");

    for(int i = dop; i < number; i++){
            swap(A[i],A[n-i]);
    }
    for(int i = 0; i < n; i++){
        printf("%d,", A[i]);
    }
    return 0;
}


