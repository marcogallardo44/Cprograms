// test 2 practice 2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "ctime"


using namespace std;
using std::time;

double prod = 1;
double total = 0;

double mult(double i, double x)
{
	if (x == 0)
		prod = 1;
	if (i == 0)
		return prod;
	else
	{
		prod = prod * i;
		//cout << "prod = " << prod << endl;
		return mult(i - 1,1);
	}
}

double sum(double n)
{
	if (n == 0)
		return total;
	else
	{
		total = total + (1 / n) * mult(n,1);
		//cout << "total = " << total << endl;
		mult(1, 0);
		return sum(n - 1);
	}
}

int main()
{
	double n;
	srand(time(0));
	n = 6 + (rand() % 5);
	cout << n << endl;


	cout << sum(5) << endl;






	system("pause");
    return main();
}

