#include <stdio.h>
#include <cstdlib>

using namespace std;

struct Point{
    int x;
    int y;
};

struct Point3d{
    int z = 10;
    Point *point2d = nullptr;
};

int main(int argc, char** argv) {
    
    Point p{10, 5};
    
    Point p1;
    p1.x = 10;
    p1.y = 5;
    
    Point *p2 = new Point{10, 5};
    printf("%d\n", p2 ->x);
    
    Point p3 = *p2;
    printf("%d\n", p2 ->x);
    
    Point3d *p3 = new Point3d{ 20, p2};
    printf("%d\n", p3 ->point2d ->x);
    return 0;
}

