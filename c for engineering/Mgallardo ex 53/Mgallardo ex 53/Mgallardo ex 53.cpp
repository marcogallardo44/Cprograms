// Mgallardo ex 53.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;
double total_cost();
int quantity;
double unit_price;

int main()
{
	
	


	cout << "Enter quantity: ";
	cin >> quantity;
	cout << "Enter unit_price: ";
	cin >> unit_price;

	cout << total_cost() << endl;

	system("pause");
    return 0;
}

double total_cost()
{
	double total;
	total = quantity * unit_price;

	return total;
}



