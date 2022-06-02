#include "stdafx.h"
#include <cstdlib>  // It's always best to include this file before any others.
#include <iostream> // This is so we can use "cout"

int main()
{
	// first let's save ourselves a little typing
	using namespace std;

	// We're going to draw a box of stars ("*").
	// It will be 80 characters wide by 10 rows tall.
	//
	// Since we're writing to the console using 'cout',
	// we're just going to write one line at a time,
	// and then issue a carraige return to start printing
	// on the next line.

	// First let's draw the top "wall", which is a solid 
	// row of 80 stars, one at a time
	int stars;
	cout << "Enter length of side: ";
	cin >> stars;

	if (stars < 1)
	{
		stars = 1;
		cout << "Inbalid Input\nUsing default value 1\n";
	}
	else if (stars > 20)
	{
		stars = 20;
		cout << "Invalid input ";
	}
	for (int column = 0; column < stars; ++column)
	{
		cout << "*";
	}
	// now print a carraige return, so we can start printing on the next line
	cout << "\n";

	// Now we're going to print the sides.
	// There are 8 rows here.  Each row is a star, followed by
	// 78 spaces, followed by another star and a carraige return.
	for (int row = 0; row < stars - 2; ++row)
	{
		// print the left "wall"
		cout << "*";
		// now print 78 spaces
		for (int column = 0; column < stars - 2; ++column)
		{
			cout << " ";
		}
		// finally print the right "wall" and a carraige return
		cout << "*\n";
		// continue the for loop to print the next row
	}

	// Once the loop is done, we can print the bottom wall the same way we printed the top one.
	for (int column = 0; column < stars; ++column)
	{
		cout << "*";
	}
	// now print a carraige return, so we can start printing on the next line
	cout << "\n";


	system("pause");
	return 0;
}

