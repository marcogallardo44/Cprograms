// Mgallardo ex 21.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;


int main()
{
	int a, b, c;
	double av;
	cout << "Enter a grade: ";
	cin >> a;
	cout << "Enter a grade: ";
	cin >> b;
	cout << "Enter a grade: ";
	cin >> c;


	av = (a + b + c) / 3;
	cout << "The class average is: " << av << endl;


	if (a >= av)
	{
		cout << a << " is a passing score!" << endl;
	}
	else
	{
		cout << a << " is not a passing score." << endl;
	}

	if (b >= av)
	{
		cout << b << " is a passing score!" << endl;
	}
	else
	{
		cout << b << " is not a passing score." << endl;
	}

	if (c >= av)
	{
		cout << b << " is a passing score!" << endl;
	}

	else
	{
		cout << c << " is not a passing score." << endl;
	}



	system("pause");
    return 0;
}

