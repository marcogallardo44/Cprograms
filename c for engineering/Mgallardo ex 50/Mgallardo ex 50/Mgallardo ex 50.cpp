// Mgallardo ex 50.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "ctime"

using std::time;
using namespace std;

int main()
{
	srand(time(0));

	int m;
	int n;
	int prod = 1;
	int sum = 0;
	m = 3 + rand() % 4;
	n = 1 + rand() % 5;
	cout << m << endl;
	cout << n << endl;

	for (int j = 1; j <= m; j++)
	{
		for (int i = 1; i <= n; i++)
		{
			sum = sum + i;
		}
		prod = prod * sum;
	}

	cout << prod << endl;

	sum = 0;
	prod = 1;
	for (int i = 1; i <= n; i++)
	{
		for (int j = 1; j <= i; j++)
		{
			prod = prod*j;
		}
		sum = sum + prod;;
	}
	cout << sum << endl;

	system("pause");
    return 0;
}

