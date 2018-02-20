#include <iostream>
#include <cstdlib>
#include "list.h"

using namespace std;

/*void menu(List *list) {
    cout << "Введите 1, если хотите отсортировать записи по имени" << endl;
    cout << "Введите 2, если хотите отсортировать записи по номеру" << endl;
    cout << "Введите 0, если хотите выйти из программы";
    int choose = 0;
    cin >> choose;
    switch(choose) {
        case 0:
        {
            return;
        }
        case 1:
        {
            sortByName(list);
            mergeSort(list, first(list), length(list), nullptr, nullptr);
            break;
        }
        case 2:
        {
            sortBePhone(list);
            change(notebook);
            mergeSort(notebook, first(list), length(list), nullptr, nullptr);
            change(notebook);
            break;
        }
        default:
        {
            return;
        }
    }
}
*/

int main(int argc, char** argv) 
{
    List *notebook = createNotebook();
    
    addNote("poly", "8980", List *notebook);
    addNote("mama", "8970", List *notebook);
    addNote("babylya", "7980", List *notebook);

    bool choose = menu;
    if (choose == 1) {
        realMergeSort(notebook, first(notebook), length(notebook), nullptr, nullptr);
    }
    else {
        changeNameNumbers(notebook);
        realMergeSort(notebook, first(notebook), length(notebook), nullptr, nullptr);
        changeNameNumbers(notebook);
    }

    print(notebook);

    deleteNotebook(notebook);

    return 0;
}

