// Mgallardo ex 70.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int s(int i)
{
	if (i == 0)
		return -1;
	else
		if (i == 1)
			return 2;
		else
			return s(i - 1) + 3 * s(i - 2);
}


int main()
{
	int n;
	cout << "enter number >= 0 : ";
	cin >> n;

	cout << s(n) << endl;

	system("pause");
    return 0;
}

