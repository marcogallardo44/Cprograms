// Mgallardo ex 73.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int stars(int x)
{
	if (x == 0)
		return 0;
	else
	{
		for (int j = 1; j <= x; j++)
		{
			cout << "*";
		}
		cout << endl;
		return stars(x - 1);
	}

}



int main()
{
	int x;
	cout << "enter a numer: ";
	cin >> x;

	stars(x);

	cout << endl;
	system("pause");
    return 0;
}

