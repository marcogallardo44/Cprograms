// Mgallardo ex 65.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "math.h"


using namespace std;

int largest(int x, int y, int z, int a, int b)
{
	if (x >= y && x >= z && x >= a && x >= b)
	{
		cout << x << " is the largest." << endl;
	}
	else if (y >= x && y >= z && y >= a && y >= b)
	{
		cout << y << " is the largest." << endl;
	}
	else if (z >= x && z >= y && z >= a && z >= b)
	{
		cout << z << " is the largest." << endl;
	}
	else if (a >= x && a >= y && a >= z && a >= b)
	{
		cout << a << " is the largest." << endl;
	}
	else if (b >= x && b >= y && b >= z && b >= a)
	{
		cout << b << " is the largest." << endl;
	}


	return 0;
}

double largest(double x, double y, double z, double a, double b)
{
	if (x >= y && x >= z && x >= a && x >= b)
	{
		cout << x << " is the largest." << endl;
	}
	else if (y >= x && y >= z && y >= a && y >= b)
	{
		cout << y << " is the largest." << endl;
	}
	else if (z >= x && z >= y && z >= a && z >= b)
	{
		cout << z << " is the largest." << endl;
	}
	else if (a >= x && a >= y && a >= z && a >= b)
	{
		cout << a << " is the largest." << endl;
	}
	else if (b >= x && b >= y && b >= z && b >= a)
	{
		cout << b << " is the largest." << endl;
	}


	return 0;
}



int main()
{
	int x, y, z, a, b;

	cout << "enter 5 values: ";
	cin >> x >> y >> z >> a >> b;

	largest(x, y, z, a, b);

	double q, w, e, r, t;

	cout << "enter 5 values: ";
	cin >> q >> w >> e >> r >> t;

	largest(q, w, e, r, t);



	system("pause");
	return 0;
}



