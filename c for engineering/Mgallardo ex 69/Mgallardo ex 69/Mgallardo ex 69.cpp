// Mgallardo ex 69.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int s(int i)
{
	int n = 0;
	if (i == 1)
	{
		n = 1;
	}
	else
	{
		n = i+s(i - 1);
	}
	cout << " " << n << ", ";
	return n;
}


int main()
{
	cout << "\n" << s(5) << "\n";





	system("pause");
    return 0;
}

