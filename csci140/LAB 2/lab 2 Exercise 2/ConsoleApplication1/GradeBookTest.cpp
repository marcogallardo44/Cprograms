// Lab 2: GradeBookTest.cpp
// Test program for modified GradeBook class.
#include "stdafx.h"
#include <iostream>
using namespace std;

// include definition of class GradeBook from GradeBook.h
#include "GradeBook.h"

// function main begins program execution
int main()
{

	// create a GradeBook object; pass a course name and instructor name
	GradeBook gradeBook("CS101 Introduction to C++ Programming", "Sam Smith");
	
	
	// display welcome message and instructor's name
	gradeBook.displayMessage();

	string(name);
	cout << "Please input the name of the new Instructor: " << endl;
	getline(cin, name);
	
	gradeBook.setInstructorName(name);
	gradeBook.displayMessage();

	system("pause");
	return 0;
} // end main