// Mgallardo ex 36.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int i = 1;
	int product = 1;

	do
	{
		product = product * i;
		i = i + 2;
	} while (i <= 15);

	cout << product << endl;






	system("pause");
    return 0;
}

