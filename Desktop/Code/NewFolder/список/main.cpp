#include <iostream>
#include <cstdlib>
#include <stdio.h>
#include "list.h"

using namespace std;


int main(int argc, char** argv) {
    List* list = createList();
    
    insert(sentinel(list), 5);
    insert(first(list), 6);
    insert(next(first(list)), 7);
    
    for (ListElement *i = first(list); !isEnd(i); i = next(i)) { //next - по текущему эл-ту возвращает следующий
        cout << value(i) << " ";
    }
    
    deleteList(list);
    
    return 0;
}

