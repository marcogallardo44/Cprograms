// Mgallardo ex 22.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int n, b, d, rev = 0;

	cout << "Enter a number: ";
	cin >> b;

	n = b;

	do
	{
		d = b % 10;
		rev = (rev * 10) + d;
		b = b / 10;

	} while (b != 0);

	cout << " Thereverse of the number is: " << rev << endl;

	if (n == rev)
	{
		cout << "The number is a palindrome." << endl;
	}
	else
	{
		cout << "The number is not a palindrome." << endl;
	}




	system("pause");
	return 0;
}

