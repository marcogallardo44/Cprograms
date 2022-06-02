// lab 2 Exercise 8.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream> 
using namespace std;


int main()
{
	int value; // current value
	int count = 0; // number of inputs
	int total; // sum of inputs 

			   // prompt for input
	cout << "Enter integers (9999 to end):" << endl;
	cin >> value;

	// loop until sentinel value read from user 
	/* Write a for header to initialize total to 0
	and loop until value equals 9999 */
	for (total = 0; value != 9999;)
	{
		/* Write a statement to add value to total */
		total = total + value;
		/* Write a statement to increment count */
		count++;

		cin >> value; // read in next value
	}

	// if user entered at least one value 
	if (count != 0)
		cout << "\nThe average is: "
		<< double(total) / count << endl;
	else
		cout << "\nNo values were entered." << endl;



	system("pause");
	return 0;
}
