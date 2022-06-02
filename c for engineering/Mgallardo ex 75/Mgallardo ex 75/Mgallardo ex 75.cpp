// Mgallardo ex 31.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "math.h"


using namespace std;


int gcd(int m, int n)
{
	if (m == n)
		return m;
	else if (m > n)
		return gcd(m - n, n);
	else
		return gcd(m, n - m);
}

int lcm(int a, int b)
{
	return ((a*b) / gcd(a, b));
}

int main()
{
	int m, n, g;
	cin >> m >> n;

	cout << gcd(m, n) << endl;

	cout << lcm(m, n) << endl;

	system("pause");
	return 0;
}



