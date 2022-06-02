// Mgallardo ex 15.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int a;
	cout << "Input a number: ";
	cin >> a;

	if (a % 2 > 0)
	{
		cout << "Your number is odd!" << endl;
	}

	else
	{
		cout << "Your number is even!" << endl;
	}


	system("pause");
    return 0;
}

