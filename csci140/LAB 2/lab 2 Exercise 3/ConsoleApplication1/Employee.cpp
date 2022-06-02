// Lab 3: Employee.cpp
// Employee class member-function definitions.
#include "stdafx.h"
#include <iostream>
using namespace std;

#include "Employee.h" // Employee class definition

/* Define the constructor. Assign each parameter value to the appropriate data
member. Write code that validates the value of salary to ensure that it is
not negative. */
Employee::Employee(string first, string last, int salary)
{
	setFirstName(first);
	setLastName(last);
	setSalary(salary);
	if (salary < 0)
	{
		cout << "Not valid salary" << endl;
	}
}
/* Define a set function for the first name data member. */
void Employee::setFirstName(string first)
{
	firstName = first;
}
/* Define a get function for the first name data member. */
string Employee::getFirstName()
{
	return firstName;
}
/* Define a set function for the last name data member. */
void Employee::setLastName(string last)
{
	lastName = last;
}
/* Define a get function for the last name data member. */
string Employee::getLastName()
{
	return lastName;
}
/* Define a set function for the monthly salary data member. Write code
that validates the salary to ensure that it is not negative. */
void Employee::setSalary(int salary)
{
	if (salary >= 0)
	{
		Salary = salary;
	}
	else
	{
		Salary = -salary;
	}
}
/* Define a get function for the monthly salary data member. */
int Employee::getSalary()
{
	return Salary;
}

