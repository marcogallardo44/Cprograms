// Mgallardo ex 47.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;


int main()
{
	int coin;
	double heads =0;
	double tails =0;
	double x = 10000;
	double prob;
	for (int i = 1; i <= x; i++)
	{
		coin = 1 + rand() % 2;
		if (coin == 1)
		{
			heads++;
		}
		else
		{
			tails++;
		}
	}


	cout << "heads: " << heads << endl;
	cout << "tails: " << tails << endl;

	prob = (heads / x) * 100;
	cout << "heads prob: " << prob << endl;



	system("pause");
    return 0;
}

