// Mgallardo ex 33.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int sum = 0;
	int sum1 = 0;
	int product = 1;
	int sum2 = 0;
	int sum3 = 0;



	for (int i = 1; i <= 3; i++)
	{
		for (int j = 1, x = 1; j <= i; j++)
		{

			cout << x << " * " << j << " = ";
			x = x * j;
			product = x;
			cout << product << endl;
		}
		cout << "----------------" << endl;
		cout << sum << " + " << product << " = ";
		sum = sum + product;
		cout << sum << endl;
	}

	cout << "final product: " << sum << endl << endl << endl;

	
	
	
	



	for (int i = 1; i <= 10; i++)
	{
		for (int j = 1; j <= i; j++)
		{
			for (int k = 1; k <= j; k++)
			{
				cout << sum3 << " + " << k << " = ";
				sum3 +=  k;
				cout << "sum3: "<< sum3 << endl;
				
			}
			
			
		}
		
		
	}
	
	cout << "final sum: " << sum3 << endl;














	system("pause");
	return 0;
}

