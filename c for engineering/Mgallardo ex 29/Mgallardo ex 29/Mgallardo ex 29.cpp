// Mgallardo ex 29.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int a = 0;
	int b = 0;
	int c =0;
	int d =0;

	cout << "Integer\t" << "square\t" << "cube" << endl;



	while (d <= 10)
	{
		cout << a << "\t" << b << "\t" << c << endl;
		a++;
		b = a*a;
		c = a*a*a;

		d++;
	}






	system("pause");
    return 0;
}

