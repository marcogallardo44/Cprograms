// Mgallardo ex 55.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

void my_addition(int first, int second)
{
	int sum;
	for (int d = 1; d <= 10; d++)
	{
		sum = first + second;
		first = second;
		second = sum;
		cout << sum << endl;
	}
	
}

int main()
{
	cout << 1 << endl;
	cout << 1 << endl;
	my_addition (1,1);



	system("pause");
    return 0;
}

