// Mgallardo ex 60.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int factorial(int k)
{
	int prod =1;
	for (int i = 1; i <=k; i++)
	{
		prod = prod*i;

	}
	return prod;
}

int main()
{

	int x;
	cout << "Enter a number: ";
	cin >> x;

	x = factorial(x);

	cout << x << endl;




	system("pause");
    return 0;
}

