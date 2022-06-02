// Mgallardo ex 28.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{

	int c = 0;
	int d = 0;

	cout << "The sum from 1 to 10 = ";
	while (d <= 10)
	{
		c = c + d;
		d++;
	}

	cout << c << endl;

	system("pause");
    return 0;
}

