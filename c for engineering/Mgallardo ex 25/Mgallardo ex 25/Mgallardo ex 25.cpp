// Mgallardo ex 25.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int x;
	int n = 1;
	cin >> x;


	while (x > 1)
	{
		n = x * n;
		cout << n << '\n';
		x--;
	}
	
	system("pause");
	return 0;
}

