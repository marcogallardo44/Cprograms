// Mgallardo ex 31.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	
	int j = 1;
	int sum = 0;
	int prod = 1;
	for (int i = 1; i <= 5; i++)
	{  
		
		while (j <= i)
		{
			prod = prod + (prod * j);
			j++;
		}
		sum = sum + prod + i;
		
		
	}
	
	cout << sum << endl;



	system("pause");
    return 0;
}

