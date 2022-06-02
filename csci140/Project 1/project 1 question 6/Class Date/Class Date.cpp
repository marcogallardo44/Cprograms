// Class Date.cpp, Marco Gallardo, C++ Language and Objects
//Project #1 PART 2 question 6,  MS Visual Express 2017, 10/9/2017
#include "stdafx.h"
#include <iostream>

#include "Date.h"
using namespace std;

int main()
{
	int month;
	int day;
	int year;
	cout << "Input month day year: ";
	cin >> month >> day >> year;

	Date date1(month, day, year);

	cout << "Date: " << date1.getMonth() << "/" << date1.getDay() << "/" << date1.getYear() << endl;



	system("pause");
    return main();
}

//COMMENTS:
/*We did something like this in the lab so the concept wasnt hard.
Analasys: Create a class that hold the class, and get/set for each variable,
then create a new cpp file that defines each of those get and set.
then impliment them in the main.
Design:In my Class i named it date and made it 3 ints. asigned get and set to
each of those get and set, and created a name for each int.
in the new cpp file, defined the get and set functions, but for the month
made it so it can only be between 1 and 12, and if input anything else
its automatically a 1. Finally in the main, called the date class, and made
it so it can input your own dates, then finally used the get function
to cout the whole thing.
Test:Worked just fine.*/