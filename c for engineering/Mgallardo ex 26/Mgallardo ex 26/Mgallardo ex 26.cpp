// Mgallardo ex 26.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;


int main()
{
	int a = 2;
	int b = 20;
	int c = 1;
	int d = 1;
	while (c <= b)
	{
		cout << a << " ^ " << c << " = ";
		d = d * a;
		cout << d << endl;
		c++;
	}


	


	system("pause");
	return 0;
}

