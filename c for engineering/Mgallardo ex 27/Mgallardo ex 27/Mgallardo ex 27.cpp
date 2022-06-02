// Mgallardo ex 27.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int a = 0;
	int b = 1;
	int c = 0;
	int d = 0;
	cout << a << " , " << b << " , ";
	c = a + b;

	while (d < 18)
	{
		cout << c << " , ";
		a = b;
		b = c; 
		c = a + b;
		d++;
	}

	cout << endl;




	system("pause");
    return 0;
}

