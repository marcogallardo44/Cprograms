// Mgallardo ex 72.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;
int sum = 0;
int summation(int x) //call by value
{
	
	
	if (x == 0)
		return sum;
	else
	{
		sum = sum + x;
		
		return summation(x - 1);
	}
}


int main()
{
	int x;
	cout << "enter a nubmer: ";
	cin >> x;

	cout << summation(x) << endl;




	system("pause");
    return 0;
}

