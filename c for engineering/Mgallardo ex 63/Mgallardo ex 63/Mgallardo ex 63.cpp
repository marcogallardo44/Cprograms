// Mgallardo ex 63.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "math.h"
using namespace std;

double distance(double x1, double y1, double x2, double y2)
{
	double a;
	double b;
	double c;
	a = x1 - x2;
	b = y1 - y2;
	c = hypot(a, b);
	return c;
}


int main()
{
	double x1, x2, y1, y2;
	cout << "enter two different points (x1, y1), (x2, y2): " << endl;
	cin >> x1 >> y1 >> x2 >> y2;

	cout << distance(x1, y1, x2, y2) << endl;

	system("pause");
    return 0;
}

