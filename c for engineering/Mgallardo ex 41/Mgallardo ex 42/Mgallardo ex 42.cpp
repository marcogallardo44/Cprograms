// Mgallardo ex 42.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "math.h"

using namespace std;

int main()
{
	double x;
	double y;
	double z;
	cout << "Enter one leg of a triangle: ";
	cin >> x;
	cout << "Enter the other leg of a triangle: ";
	cin >> y;

	z = sqrt(pow(x, 2) + pow(y, 2));

	cout << "The hypotenuse of this triangle is: " << z << endl;



	system("pause");
    return 0;
}

