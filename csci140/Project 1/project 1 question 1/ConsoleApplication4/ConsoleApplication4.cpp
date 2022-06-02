// Mileage.cpp, Marco Gallardo, C++ Language and Objects
//Project #1 PART 2 question 1,  MS Visual studio 2017, 10/9/2017

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

//COMMENTS:
//love using this compiler.
//This problem was easy because the output was already shown
//so all i had to do was try and make it look exactly 
//how it did in the book.
/*Analasys:Looked easy to begin with because it was just calculating mpg
Design:designing was easy because it was shown in the book how its supposed to look
Test: forgot to add another cout cin statement in the while so it took me
a couple of tries before i got it completly right.*/