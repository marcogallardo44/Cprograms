// Lab 2: GradeBook.cpp
// Member-function definitions for class GradeBook.
#include "stdafx.h"
#include <iostream>
using namespace std;

// include definition of class GradeBook from GradeBook.h
#include "GradeBook.h"

// constructor initializes courseName and instructorName
// with strings supplied as arguments
GradeBook::GradeBook(string course, string instructor)
{
	setCourseName(course); // initializes courseName
	setInstructorName(instructor); // initialiZes instructorName
} // end GradeBook constructor

  // function to set the course name
void GradeBook::setCourseName(string name)
{
	courseName = name; // store the course name
} // end function setCourseName

  // function to retrieve the course name
string GradeBook::getCourseName()
{
	return courseName;
} // end function getCourseName

string GradeBook::getInstructorName()
{
	return instructorName;
} // end function getCourseName

void GradeBook::setInstructorName(string name)
{
	instructorName = name; // store the course name
} // end function setCourseName

  // display a welcome message and the instructor's name
void GradeBook::displayMessage()
{
	// display a welcome message containing the course name
	cout << "Welcome to the grade book for\n" << getCourseName() << "!"
		<< endl;
	cout << "This course is presented by: " << getInstructorName() << endl;
} // end function displayMessage