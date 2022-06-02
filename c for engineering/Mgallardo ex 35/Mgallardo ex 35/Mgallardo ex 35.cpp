// Mgallardo ex 35.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	int i = 1;
	int sum = 0;
	
	do 
	{
		sum = sum + i;
		i++;
	} while (i <= 20);

	cout << sum << endl;







	system("pause");
    return 0;
}

