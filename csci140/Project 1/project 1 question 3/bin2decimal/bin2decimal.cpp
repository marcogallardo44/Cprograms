// bin2decimal.cpp, Marco Gallardo, C++ Language and Objects
//Project #1 PART 2 question 3,  MS Visual Express 2017, 10/9/2017

#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int number;
	int x;
	int remainder;
	int decimal = 0;
	int base = 1;
	

	cout << "Please input a binary number: ";
	cin >> number;
	x = number;
	while (number > 0)
	{
		remainder = number % 10;
		decimal = decimal + remainder * base;
		base = base * 2;
		number = number / 10;
	}

	cout << "The decimal of your input: " << x << " is: " << decimal << endl;


	system("pause");
    return main ();
}

//COMMENTS:
/*This one was harder cause i didnt understand binary too much, now i do
Analasys:Needed to find a way to figure out if its a 1 or a 0,
calculate how much that would be in decimal for the first part,
change the next position multiplier by 2, and change the input to the next number.
Desighn: Needed 5 variables (one for input, one to copy the input, one to calculate
a 1 or 0, one to calculate the decimal number, and one to multiply by 2 each time.
created a while loop intil the input hits 0. In the loop it calculates the remainter
to be a 1 or 0, calculates the decimal number by adding it first from 0 plus the remainder
times what the base is, then the base changes by a multiple of 2 each time, last it
changes the input to what ever it was divided by 10.
Test:Worked fine.*/