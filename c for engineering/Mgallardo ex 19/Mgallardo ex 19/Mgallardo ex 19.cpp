// Mgallardo ex 19.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
using namespace std;


int main()
{
	int a;

	cout << "Enter a number: ";
	cin >> a;

	if (a % 2 == 0 && a % 3 == 0)
	{
		cout << a << " / 2 = " << a / 2 << endl;
		cout << a << " / 3 = " << a / 3 << endl;
		cout << "Your number is divisible by 2 and 3!" << endl;

	}

	else
	{
		cout << "Your number is not divisible by 2 and 3 :(" << endl;
	}
	system("pause");
    return 0;
}

