// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int account;
	/* Write declarations for four double variables:      
	balance, charges, credits and creditLimit */
	double balance;
	double charges;
	double credits;
	double creditlimit;
	int number;
	
	cout << "Enter account number (-1 to end): ";
	/*write code to read the customers account number*/
	
	cin >> number;
	//set floating-point number format
	/*Write code to use the stream manipulators fixed and
	setprecision to set the floating-point number format*/

	//exit if the input is -1 otherwise, proceed with the program
	/*Write a while loop with a condition that tests for the sentinel value*/
	while (number != -1)
	{	
		/* Write code to prompt for and input the customer's balance */
		cout << "Enter customer's balance: ";
		cin >> balance;
		cout << endl;
		/* Write code to prompt for and input the customer's charges */
		cout << "Enter customer's charges: ";
		cin >> charges;
		cout << endl;
		/* Write code to prompt for and input the customer's credits */
		cout << "Enter customer's credits: ";
		cin >> credits;
		cout << endl;
		/* Write code to prompt for and input the customer's credit limit */
		cout << "Enter customer's credit limi: ";
		cin >> creditlimit;
		cout << endl;
		// calculate and display new balance
		/* Write a statement to calculate the customer's new balance */
		balance = balance + charges - credits;
		/* Display the new balance */
		cout << "Your new balance: " << balance << endl;

		// display a warning if the user has exceed the credit limit
		/* Write an if statement to determine whether the credit limit is exceeded */
		if (balance > creditlimit)
		{
			cout << "Credit Limit Exceeded. " << endl;
		}
		/* Display a message if the credit limit was exceeded */

		cout << "\n\nEnter Account Number (or -1 to quit): ";
		/* Write code to input the next account number */
		cin >> number;
	} // end while 

	
	system("pause");
    return 0;
}

