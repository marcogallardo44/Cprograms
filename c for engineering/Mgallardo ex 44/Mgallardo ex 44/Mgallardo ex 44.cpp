// Mgallardo ex 31.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "math.h"


using namespace std;

int main()
{
	int i;
	for (i = 1; i <= 50; i++)
	{
		cout << 1 + rand() % 6 << "\t";
	}


	system("pause");
	return 0;
}

