// Mgallardo ex 71.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int base(int b, int x)
{
	if (x == 0)
		return 1;
	else
		return b*base(b, x - 1);
}

int main()
{
	int b, x;
	cin >> b >> x;

	cout << base(b, x) << endl;



	system("pause");
    return 0;
}

