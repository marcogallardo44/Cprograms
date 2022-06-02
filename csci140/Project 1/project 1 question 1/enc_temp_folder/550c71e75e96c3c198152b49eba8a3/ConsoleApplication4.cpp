// Mileage.cpp, Marco Gallardo, 
//

#include "stdafx.h"
#include <iostream>

using namespace std;


int main()
{
	double miles;
	double gallons;
	double milestotal = 0.0;
	double gallonstotal = 0.0;
	double mpgtrip;
	double mpgtotal;

	cout << "Enter miles dirven (-1 to quit): ";
	cin >> miles;
	

	while (miles != -1)
	{
		cout << "Enter gallons used: ";
		cin >> gallons;

		milestotal = milestotal + miles;
		gallonstotal = gallonstotal + gallons;

		mpgtrip = miles / gallons;
		mpgtotal = milestotal / gallonstotal;

		cout << "MPG this trip: " << mpgtrip << endl;
		cout << "Total MPG: " << mpgtotal << endl << endl;

		cout << "Enter miles dirven (-1 to quit): ";
		cin >> miles;
	}

	









	system("pause");
	return 0;
}

