// lab 2 Exercise 10.cpp : Defines the entry point for the console application.
//

//#include "stdafx.h"
#include <iostream> 
#include <iomanip> 
using namespace std;

int main()
{
	int i = 1;
	int j;
	double a;
	double b;

	cout << setprecision(2);

	for (i; i <= 2; i++)
	{
		cout << "i is now equal to " << i << endl;
		
		for (j = 0; j <= 3; j++)
		{
			cout << "\tj is now equal to " << j << endl;

			cout << "\t\ti + j = " << i + j << "\ti - j = "
				<< i - j << endl;
			cout << "\t\ti * j = " << i * j << "\ti ^ j = "
				<< pow(i, j) << endl;

			if (j == 0)
				continue;
			else
			{
				a = i;
				b = j;
				cout << "\t\ti / j = " << a / b
					<< "\ti % j = " << int(a) % int(b) << endl;
			} // end else 
		} // end for 
	}
	cout << "\nThe final values of i and j are: " << i
		<< " and " << j << endl;



	system("pause");
	return 0;
}

