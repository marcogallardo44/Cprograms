// Mgallardo ex 34.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{
	for (int i = 1; i <= 7; i++)
	{
		for (int j = 1; j < i; j++)
		{
			cout << "* ";
		}


		cout << "* " << endl;
	}

	cout << endl << endl;

	for (int i = 7; i > 0; i--)
	{
		for (int j = 1; j < i; j++)
		{
			cout << "* ";
		}
		cout << "* " << endl;
	}

	cout << endl << endl;

	for (int i = 7; i > 0; i--)
	{
		int a = 7;
		int b = 0;
		b = a - i;
		for (; b > 0; b--)
		{
			cout << "  ";
		}
		for (int j = 1; j < i; j++)
		{
			for (int k = 7; k < 7; k--)
			{
				cout << " ";
				
			}
			cout << "* ";
		}
		cout<< "* " << endl;
	}






	cout << endl << endl;

	

	for (int i = 1; i <= 7; i++)
	{
		int a = 7;
		int b = 0;
		b = a - i;
		for (; b > 0; b--)
		{
			cout << "  ";
		}

		for (int j = 1; j < i; j++)
		{
			cout << "* ";
		}


		cout << "* " << endl;
	}




	cout << endl << endl;

	for (int i = 1; i <= 5; i++)
	{
		for (int j = 1; j < i; j++)
		{
			cout << "* ";
		}


		cout << "* " << endl;
	}

	

	for (int i = 4; i > 0; i--)
	{
		for (int j = 1; j < i; j++)
		{
			cout << "* ";
		}
		cout << "* " << endl;
	}







	cout << endl << endl;


	system("pause");
    return 0;
}

