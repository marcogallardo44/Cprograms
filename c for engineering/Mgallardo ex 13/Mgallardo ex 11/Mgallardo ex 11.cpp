// Mgallardo ex 11.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
using namespace std;

int main()
{
	int n1, n2;
	int larger;
	cout << "\nEnter the first number .... ";
	cin >> n1;
	cout << "\nEnter the second number .... ";
	cin >> n2;
	if (n1 == n2)
	{
		cout << "\nthe two numbers are the same \n";
	}
	else
	{
		if (n1 < n2)
		{
			larger = n2;
			cout << "The larger number is: " << larger << endl;
		}
		else
		{
			larger = n1;
			cout << "The larger number is: " << larger << endl;
		}
	}
	//system("pause");
    return 0;
}

