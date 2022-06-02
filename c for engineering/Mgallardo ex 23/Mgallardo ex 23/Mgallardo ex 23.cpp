// Mgallardo ex 23.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int a;

	cout << "Please insert the number grade: ";
	cin >> a;

	if (a >= 90)
	{
		cout << "your grade is an A." << endl;
	}
	else if (a >= 80)
	{
		cout << "your grade is a B." << endl;
	}
	else if (a >= 70)
	{
		cout << "your grade is a C." << endl;
	}
	else if (a >= 60)
	{
		cout << "your grade is a D." << endl;
	}
	else if (a >= 50)
	{
		cout << "your grade is an F." << endl;
	}
	else
	{
		cout << "your grade is an F." << endl;
	}

	system("pause");
    return 0;
}

