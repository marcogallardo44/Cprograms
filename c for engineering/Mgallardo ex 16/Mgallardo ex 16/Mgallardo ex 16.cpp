// Mgallardo ex 16.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
using namespace std;

int main()
{
	int a , b;

	cout << "Input two numbers: ";
	cin >> a >> b;

	if (b%a == 0)
	{
		cout << a << " is a multiple of " << b << endl;
	}
	else
	{
		cout << a << " is not a multiple of " << b << endl;
	}

	system("pause");
    return 0;
}

