// lab 2 Exercise 9.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream> 
using namespace std;

int main()
{
	int count = 0; // number of triples found 
	short int hypotenuseSquared; // hypotenuse squared
	short int sidesSquared; // sum of squares of sides 
	long int loopcounter = 0;

	cout << "Side 1\tSide 2\tSide3" << endl;

	// side1 values range from 1 to 500
	/* Write a for header for side1 */
	for(int side1 = 1; side1 < 500;side1++ )
	{
		
		// side2 values range from current side1 to 500 
		/* Write a for header for side2 */
		for(int side2 = side1; side2 <= 500;side2++ )
		{

			// hypotenuse values range from current side2 to 500 
			/* Write a for header for hypotenuse */
			for(int side3 = side2; side3 <= 500;side3++ )
			{
				
				// calculate square of hypotenuse value
				/* Write a statement to calculate hypotenuseSquared */
				hypotenuseSquared = pow(side3, 2);

				// calculate sum of squares of sides 
				/* Write a statement to calculate the sum of the sides Squared */
				sidesSquared = pow(side1, 2) + pow(side2, 2);
				// if (hypotenuse)^2 = (side1)^2 + (side2)^2, 
				// Pythagorean triple 
				if (hypotenuseSquared == sidesSquared)
				{
					if (side1 == 8)
					{
						continue;
					}
					loopcounter++;
					// display triple
					cout << side1 << '\t' << side2 << '\t'
						<< side3 << '\n';
					++count; // update count
					
				} // end if 
			} // end for
		} // end for
	} // end for
	  // display total number of triples found 
	cout << "A total of " << count << " triples were found." << loopcounter << endl;


	system("pause");
    return 0;
}

