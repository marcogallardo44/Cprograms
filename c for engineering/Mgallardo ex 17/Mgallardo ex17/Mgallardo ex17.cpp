// Mgallardo ex17.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	double a, b, c;
	double largest;
	cout << "Input a number: ";
	cin >> a;
	cout << "Input a number: ";
	cin >> b;
	cout << "Input a number: ";
	cin >> c;

	if (a > b && a > c)
	{
		largest = a;
		cout << "The largest of the three was: " << largest << endl;
	}

	else if (b > a && b > c)
	{
		largest = b;
		cout << "The largest of the three was: " << largest << endl;
	}

	else if (c > b && c > a)
	{
		largest = c;
		cout << "The largest of the three was: " << largest << endl;
	}

	if (largest * largest == a * a + b * b)
	{
		cout << "The three sides " << largest << " " << a << " " << b
			<< " form a triangle." << endl;
	}
	else 
	{
		cout << "The three sides " << largest << " " << a << " " << b
			<< " do not form a triangle." << endl;
	}



	system("pause");
    return 0;
}

