#pragma once
#include <string>

struct TreeNode;

struct BinarySearchTree;

// создание дерева
BinarySearchTree *createTree();

// удаление узла
void clearNode(TreeNode *node);

// удаление дерева  
void clearTree(BinarySearchTree *tree);

// поиск значения
bool contains(BinarySearchTree *tree, std::string key);

// возвращает value
std::string containsReturn(BinarySearchTree *tree, const std::string key);

// добавление значения
void add(BinarySearchTree *tree, std::string value, const std::string key);

// печать дерева
void printRoot(BinarySearchTree *tree);

// балансировка дерева
void splayTree(BinarySearchTree *tree, TreeNode* node);

void clearElementNotrec(BinarySearchTree *tree, std::string key);