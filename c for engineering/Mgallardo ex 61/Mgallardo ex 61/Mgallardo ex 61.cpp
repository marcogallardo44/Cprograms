// Mgallardo ex 61.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int factorial(int &k)
{
	int prod = 1;
	int a;
	a = k;
	for (int i = 1; i < a; i++)
	{
		k = k*i;

	}
	return 0;
}

int main()
{

	int x;
	cout << "Enter a number: ";
	cin >> x;

	factorial(x);

	cout << x << endl;




	system("pause");
	return 0;
}

