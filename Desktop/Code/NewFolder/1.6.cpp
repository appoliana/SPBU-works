/* 
 * File:   main.cpp
 * Author: polinapicchio
 *
 * Created on 11 сентября 2017 г., 19:23
 */

#include <cstdlib>
#include <stdio.h>
#include <string.h>
#include <iostream>

using namespace std;

/*
 * 
 */
int main(int argc, char** argv) {
    char s;
       cin>>s;
    char s1;
       cin>>s1;
    int i = 0;
    int pos = -1;
    int count = -1;
    while (pos!= - 1){
        i = s.IndexOf(s1, pos+1);
        pos = i;
        count++;
    }
    printf("%d", count);
    return 0;
}
