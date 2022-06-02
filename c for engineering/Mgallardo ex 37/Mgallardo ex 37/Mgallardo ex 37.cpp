// Mgallardo ex 37.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int a = 0;
	int b = 1;
	int c = 0;
	int d = 1;
	cout << a << " , " << b << " , ";


	do
	{
		c = a + b;
		a = b;
		b = c;
		cout << c << " , ";
		d++;
	} while (d <= 20);





	system("pause");
    return 0;
}

