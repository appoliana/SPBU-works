#include <iostream>
#include "tree.h"

using namespace std;

struct TreeNode
{
    string value;
    string key;
    TreeNode *left;
    TreeNode *right;
    TreeNode *parent;
};

struct BinarySearchTree
{
    TreeNode *root = nullptr;
};

TreeNode *findNode(TreeNode* tree, const string key);
void zig(BinarySearchTree *tree, TreeNode *node);
void zigZag(BinarySearchTree *tree, TreeNode *node);
void zigZig(BinarySearchTree *tree, TreeNode *node);
void splayTree(TreeNode *tree, string key);

BinarySearchTree *createTree()
{
    BinarySearchTree *tree = new BinarySearchTree;
    tree->root = nullptr;
    return tree;
}

void clearNode(TreeNode *node)
{
    cout << node << endl; 
    if (node == nullptr)
        return;

    clearNode(node->left);
    clearNode(node->right);
    delete node;
}

void clearTree(BinarySearchTree *tree)
{
    clearNode(tree->root);
    tree->root = nullptr;
}

TreeNode *findMax(TreeNode *node)
{
    if (node->right == nullptr) {
        return nullptr;
    }
    node = node->right;
    while (node->left != nullptr)
        node = node->left;
    return node;
}

void clearElement(BinarySearchTree *tree, TreeNode *element, string key) 
{
    if (element == nullptr) {
        return;
    }
    
    if (element->key == key) {
        while (tree->root != element) {
            splayTree(tree, element);
        }
        element = tree->root;
        TreeNode *dop = findMax(element);
        if (dop == nullptr) {
            tree->root = element->left;
            if (element->left != nullptr) {
                element->left->parent = nullptr;
            }
            
            delete element;
            return;
        }
        else {
            if (dop == element->right) {
                dop->left = element->left;
                element->left->parent = dop;
                tree->root = dop;
                dop->parent = nullptr;
                delete element;
                return;
            }
            else {
                dop->parent->left = dop->right; 
                cout << "else" << endl;
                if (element->left != nullptr) {
                    element->left->parent = dop;   
                }
                if (dop->right != nullptr) {
                    dop->right->parent = dop->parent;
                }
                dop->parent = nullptr;
                if (element->right != nullptr) {
                   element->right->parent = dop;
                }
                dop->left = element->left;
                dop->right = element->right;
                tree->root = dop;
            
                delete element;
                return;
            }
        }
    }

    if (key < element->key) {
        return clearElement(tree, element->left, key);
    }
    return clearElement(tree, element->right, key);
}

void clearElementNotrec(BinarySearchTree *tree, string key) {
    TreeNode *element = tree->root;
    clearElement(tree, element, key);
}

bool containsNode(BinarySearchTree *tree, TreeNode *node, const string key)
{
    if (node == nullptr)
        return false;
    
    if (node->key == key) {
        splayTree(tree, node);
        return true;
    }

    if (key < node->key)
        return containsNode(tree, node->left, key);
    return containsNode(tree, node->right, key);
}

bool contains(BinarySearchTree *tree, const string key)
{
    return containsNode(tree, tree->root, key);
}

string containsNodeReturn(BinarySearchTree *tree, TreeNode *node, const string key)
{
    if (node == nullptr)
        return "";
    
    if (node->key == key) {
        splayTree(tree, node);
        return node->value;
    }

    if (key < node->key) {
        return containsNodeReturn(tree, node->left, key);
    }
    return containsNodeReturn(tree, node->right, key);
}

string containsReturn(BinarySearchTree *tree, const string key)
{
    return containsNodeReturn(tree, tree->root, key);
}

TreeNode *createNode(string value, const string key, TreeNode *parent)
{
    TreeNode *node = new TreeNode;
    node->key = key;
    node->value = value;
    node->left = nullptr;
    node->right = nullptr;
    node->parent = parent;
    return node;
}

void addNode(BinarySearchTree *tree, TreeNode *&node, string value, const string key, TreeNode *parent)
{
    if (node == nullptr)
    {
        //cout << key << " " << value << endl;
        node = createNode(value, key, parent);
        splayTree(tree, node);
        //cout << key << " " << value << endl;
        return;
    }
    if (node->key == key) {
        node->value = value;
        splayTree(tree, node);
        
        return;
    }

    if (key < node->key) {
        return addNode(tree, node->left, value, key, node);
    }
    else {
        return addNode(tree, node->right, value, key, node);
    }
}

void add(BinarySearchTree *tree, string value, const string key)
{
    return addNode(tree, tree->root, value, key, nullptr);
}

void printRoot(BinarySearchTree *tree)
{
    if (tree->root == nullptr) {
        cout << "Дерево пустое" << endl;
    }
    else {
        cout << tree->root->key << endl;
    }
}

void zigZig(BinarySearchTree *tree, TreeNode *node)
{
    TreeNode *x = node;
    TreeNode *p = node->parent;
    zig(tree, p);
    zig(tree, x);
}

void zigZag(BinarySearchTree *tree, TreeNode *node)
{
    TreeNode *x = node;
    zig(tree, x);
    zig(tree, x);
}

void zig(BinarySearchTree *tree, TreeNode *node)
{
    TreeNode *x = node;
    TreeNode *p = node->parent;
    TreeNode *b1 = node->right;
    TreeNode *b2 = node->left;
    TreeNode *g = node->parent->parent;
    if (p->key > x->key) {
        x->right = p;
        p->left = b1;
        if (g != nullptr) {
            if (g->left == p) 
            {
                g->left = x;
            }
            else 
            {
                g->right = x;
            }
        }
    }
    if (p->key < x->key) {
        x->left = p;
        p->right = b2;
        if (g != nullptr) {
            if (g->left == p) 
            {
                g->left = x;
            }
            else 
            {
                g->right = x;
            }
        }
    }
    x->parent = p->parent;
    p->parent = x;
    if (x->parent == nullptr) {
        tree->root = x;
        //cout << "меняем корень" << endl;
    }
}

void splayTree(BinarySearchTree *tree, TreeNode *node)
{
    if (tree->root == node) {
        return;
    }
    if (tree->root->left == node || tree->root->right == node) {
        cout << "zig now" << endl;
        zig(tree, node);
        return;
    }
    TreeNode *element = node;
    if((element->parent->parent->key > element->parent->key && element->parent->key > element->key)
    || (element->parent->parent->key < element->parent->key && element->parent->key < element->key))
    {
        cout << "zigZig now" << endl;
        zigZig(tree, element);
        return;
    }
    if((element->parent->key > element->key && element->parent->parent == nullptr)
    || (element->parent->key < element->key && element->parent->parent == nullptr)) 
    {
        cout << "zig now" << endl;
        zig(tree, element);
        cout << "zig отработал";
        return;
    }
    if((element->parent->parent->key > element->parent->key && element->parent->key < element->key) 
    || (element->parent->parent->key < element->parent->key && element->parent->key > element->key))
    {
        cout << "zigZag now" << endl;
        zigZag(tree, element);
        return;
    }
}

TreeNode* findNode(TreeNode* tree, const string key)
{
    TreeNode* current = tree;
    while (current != nullptr) {
        if (key < current->key) {
            current = current->left;
        } 
        else {
            if (key > current->key) {
                current = current->right;
            } else {    
                return current;
            }
        }
    }
    return nullptr;
}
