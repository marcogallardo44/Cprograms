// Mgallardo ex19.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int a;
	cout << "Enter a number: ";
	cin >> a;

	if (a >= 3 && a <= 10)
	{
		cout << a << " is within the range of 3, 10." << endl;
	}
	else
	{
		cout << a << " is not within the range of 3, 10." << endl;
	}
	system("pause");
    return 0;
}

