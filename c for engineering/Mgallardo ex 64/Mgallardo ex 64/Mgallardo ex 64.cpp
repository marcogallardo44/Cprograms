// Mgallardo ex 64.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int reverse(int x)
{
	int k;
	k = x / 10000;
	x = x % 10000;
	k = k + ((x / 1000) * 10);
	x = x % 1000;
	k = k + ((x / 100) * 100);
	x = x % 100;
	k = k + ((x / 10) * 1000);
	x = x % 10;
	k = k + (x * 10000);
	return k;
}

int main()
{
	int x;
	cin >> x;
	cout << reverse(x) << endl;

	system("pause");
    return 0;
}

