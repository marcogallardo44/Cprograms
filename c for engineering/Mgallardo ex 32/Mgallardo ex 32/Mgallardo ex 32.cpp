// Mgallardo ex 32.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int a = 0;
	int b = 1;
	int c = 0;
	cout << a << " , " << b << " , ";


	for (int d = 1; d <= 20; d++)
	{
		c = a + b;
		a = b;
		b = c;
		cout << c << " , ";
	}
	
	
	
	
	system("pause");
	return 0;
}

