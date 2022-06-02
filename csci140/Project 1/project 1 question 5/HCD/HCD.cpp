// GCD.cpp, Marco Gallardo, C++ Language and Objects
//Project #1 PART 2 question 5,  MS Visual Express 2017, 10/9/2017
#include "stdafx.h"
#include <iostream>

using namespace std;

int main()
{
	int x;
	int y;
	int hcd = 0;
	cout << "Please enter 2 numbers: ";
	cin >> x >> y;
	if (y > x)
	{
		int temp = y;
		y = x;
		x = temp;
	}


	for (int i = 1; i <= y; ++i)
	{
		if (x % i == 0 && y % i == 0)
		{
			hcd = i;
		}
	}

	cout << "Highest Common Denominator: " << hcd << endl;


	system("pause");
	return 0;
}

//COMMENTS
/*Not too bad, just needed to remember what a GDC was.
Analasys: GDC is the largest number that divides into 2 numbers.
Design: used 3 ints, 2 for input, one to find GDC. Then i made an if
statement making sure that the first one is the largest is the first int.
I made a for loop that adds 1 to i everytime until i is less than
or equal to y. Then i made an if statement that if the remainder of
x divided by i and y divided by i are both equal to 0, the GDC is changed to i
this will happen until i is equal to y, and by that time the GDC will be found.
Test: I accidentally put y%x == 0, which made it come out wrong, eventually got
it fixed and ran perfectly.*/