// Mgallardo ex 65.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int square(int x)
{
	return x*x;
}

double square(double x)
{
	return x*x;
}



int main()
{

	cout << square(3) << endl;
	cout << square(3.0) << endl;




	system("pause");
    return 0;
}

