// Mgallardo test 1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;


int main()
{
	double x;
	double prod = 1;
	double fact = 1;
	double sum = 0;
	double e = 1;
	cout << "Enter a number: ";
	cin >> x;
	
	while (x >= 0)
	{
		if (x < 0)
		{
			return 0;
		}
		for (int i = 1; i <= 10; i++)
		{
			prod = prod * x;
			fact = fact * i;
			e = e + (prod / fact);

		}
		
		cout << e << endl;
		
		return main();
	} 

	system("pause");
    return 0;
}

