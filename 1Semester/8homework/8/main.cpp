#include <iostream>
#include "tree.h"

using namespace std;

int main(int argc, char** argv)
{
    BinarySearchTree *tree = createTree();

    add(tree, "2", "a");
    
    cout << contains(tree, "a") << endl;
    
    cout << containsReturn(tree, "a") << endl;
    
    add(tree, "3", "b");
    
    cout << containsReturn(tree, "b") << endl;
    
    cout << containsReturn(tree, "a") << endl;
    
    add(tree, "4", "d");
    cout << "4?" << endl;
    printRoot(tree);
    add(tree, "6", "e");
    printRoot(tree);
    add(tree, "8", "l");
    printRoot(tree);
    add(tree, "10", "v");
    printRoot(tree);
    
    cout << "Удаляем элемент l" << endl;
    clearElementNotrec(tree, "l");
    
    cout << "значение d" << endl;
    cout << containsReturn(tree, "d") << endl;
  
    clearTree(tree);
    return 0;
}
