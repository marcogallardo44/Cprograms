// Mgallardo ex 62.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int smallest(int x, int y, int z)
{
	if (x <= y && x <= z)
	{
		cout << x << " is the smallest." << endl;
	}
	else if (y <= x && y <= z)
	{
		cout << y << " is the smallest." << endl;
	}
	else if (z <= x && z <= y)
	{
		cout << z << " is the smallest." << endl;
	}
	return 0;
}

int main()
{
	int x, y, z;
	cout << "enter 3 values: ";
	cin >> x >> y >> z;

	smallest(x, y, z);



	system("pause");
    return 0;
}

