// test.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	
	int i;
	cout << "enter a number in range [0,3]: ";
	cin >> i;
	switch (i)
	{
	case 0:
		cout << "you have entered 0 \n";
		break;
	case 1:
		cout << "you have entered 1 \n";
		break;
	case 2:
		cout << "you have entered 2 \n";
		break;
	case 3:
		cout << "you have entered 3 \n";
		break;
	default:
		cout << "you have entered a number out of the specified range \n";
	}








	system("pause");
    return 0;
}

