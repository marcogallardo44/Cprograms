// test.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int main()
{

	char letter;
	cout << "enter a capital letter: ";
	cin >> letter;

	switch (letter)
	{
	case 'A':
	case 'E':
	case 'I':
	case 'O':
	case 'U':
		cout << "\nYou have entered a vowwel \n";
		break;
	default:
		cout << "\nYour letter is not a vowel \n";


	}








	system("pause");
	return 0;
}

