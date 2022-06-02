// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

#include "Employee.h" // include definition of class Employee

// function main begins program execution
int main()
{
	/* Create two Employee objects and assign them to Employee variables. */
	Employee employee1("Bob", "Jones", 34500);
	Employee employee2("Susan", "Baker", 37800);
	
	/* Output the first name, last name and salary for each Employee. */
	cout << "Employee 1: " << employee1.getFirstName() << " " << employee1.getLastName()
		<< "; " << "Yearly Salary: " << employee1.getSalary() << endl;

	cout << "Employee 2: " << employee2.getFirstName() << " " << employee2.getLastName()
		<< "; " << "Yearly Salary: " << employee2.getSalary() << endl;
	/* Give each Employee a 10% raise. */
	employee1.getSalary();
	employee1.setSalary(34500 * 1.10);
	
	employee2.getSalary();
	employee2.setSalary(37800 * 1.10);
	
	/* Output the first name, last name and salary of each Employee again. */
	cout << "Employee 1: " << employee1.getFirstName() << " " << employee1.getLastName()
		<< "; " << "Yearly Salary: " << employee1.getSalary() << endl;

	cout << "Employee 2: " << employee2.getFirstName() << " " << employee2.getLastName()
		<< "; " << "Yearly Salary: " << employee2.getSalary() << endl;

	system("pause");
    return 0;
}// end main

