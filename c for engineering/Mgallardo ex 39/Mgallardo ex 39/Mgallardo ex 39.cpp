// test.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{

	int i;
	char grade = 'F';
	cout << "enter the score: ";
	cin >> i;
	
	switch (i/10)
	{
	case 10:
	case 9: grade = 'A';
		break;
	case 8: grade = 'B';
		break;
	case 7: grade = 'C';
		break;
	case 6: grade = 'D';
		break;
	default: grade = 'F';
		break;
	}

	cout << grade << endl;






	system("pause");
	return 0;
}

