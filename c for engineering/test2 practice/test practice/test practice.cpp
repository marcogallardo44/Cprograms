// test practice 1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

double prod = 1;
double fact = 1;
double e = 1;


double taylor(double x, double i)
{



	
		if (i == 8)
		{
			return e;
		}
		else
		{
			prod = prod * x;
			fact = fact * i;
			e = e + (prod / fact);
			
			return taylor(x, i + 1);

		}


}




int main()
{
	double x;
	double i = 1;
	cout << "input x in e^x: ";
	cin >> x;

	

	cout << taylor(x,1) << endl;

	
	return 0;
}

