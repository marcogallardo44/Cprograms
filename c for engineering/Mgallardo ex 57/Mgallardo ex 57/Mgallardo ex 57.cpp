// Mgallardo ex 57.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

double integerPower(int base, int exponent)
{
	int prod = 1;
	for (int i = 1; i <= exponent; i++)
	{
		prod = prod*base;
	}
	
	
	
	return prod;
}


int main()
{
	int a;
	int b;

	cout << "enter the base: ";
	cin >> a;
	cout << "enter the power: ";
	cin >> b;

	cout << integerPower(a, b) << endl;





	system("pause");
    return 0;
}

