// Mgallardo ex 54.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int my_addition(int first, int second)
{
	int sum;
	sum = first + second;
	return sum;
}

int main()
{
	int first;
	int second;
	cin >> first;
	cin >> second;

	cout << my_addition(first,second) << endl;



	system("pause");
    return 0;
}

