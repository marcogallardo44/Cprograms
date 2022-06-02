// Mgallardo ex 14.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;


int main()
{
	int a;
	int b;
	int c;
	int largest;

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





	system("pause");
    return 0;
}

