// Mgallardo ex 20.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int n1, n2, n3;

	cout << "Enter two numbers: ";
	cin >> n1 >> n2;
	cout << "Enter a third number: ";
	cin >> n3;

	if (n3 >= n1 && n3 <= n2)
	{
		cout << n3 << " is within the range of " << n1 << " and " << n2 << endl;
	}
	else if (n3 >= n2 && n3 <= n1)
	{
		cout << n3 << " is within the range of " << n1 << " and " << n2 << endl;
	}
	else
	{
		cout << n3 << " is not within the range of " << n1 << " and " << n2 << endl;
	}

	system("pause");
    return 0;
}

