// Mgallardo ex 24.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int a;
	cout << "Please input your age: ";
	cin >> a;

	if (a >= 55)
	{
		cout << "Your ticket price is $10.00 " << endl;
	}
	else if (a > 18)
	{
		cout << "Your ticket price is $15.00 " << endl;
	}
	else if (a > 12 && a <= 18)
	{
		cout << "Your ticket price is $7.00 " << endl;
	}


	else if (a <= 12)
	{
		cout << "Your ticket price is $5.00 " << endl;
	}




	system("pause");
    return 0;
}

