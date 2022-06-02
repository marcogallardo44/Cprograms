// Mileage.cpp, Marco Gallardo, C++ Language and Objects
//Project #1 PART 2 question 2,  MS Visual Express 2017, 10/9/2017

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int numbers;
	int x;
	int y;
	int z;
	int w;
	int v;
	
	cout << "Please enter 5 numbers: ";
	cin >> numbers;

	x = numbers / 10000;
	numbers = numbers % 10000;
	y = numbers / 1000;
	numbers = numbers % 1000;
	z = numbers / 100;
	numbers = numbers % 100;
	w = numbers / 10;
	numbers = numbers % 10;
	v = numbers;

	cout << x << y << z << w << v << endl;

	if (x == v && y == w)
	{
		cout << "The numbers you entered are a palindrome." << endl;
	}
	else
	{
		cout << "The numbers you entered are not a palindrome." << endl;
	}


	system("pause");
    return main();
}

