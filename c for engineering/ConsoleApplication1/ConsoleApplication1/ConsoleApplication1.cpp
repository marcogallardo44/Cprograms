// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;


int main()
{
	char str[80];
	char str1[80];
	char str2[80];
	int i;
	cout << "Enter your first name: ";
	cin >> str;
	cout << "Enter your last name: ";
	cin >> str1;
	cout << "enter your age: ";
	cin >> i;
	cout << "What do you like? ";
	cin >> str2;

	cout << str << " " << str1 << " is " << i << " years old, and he likes " << str2 << endl;

    return 0;
}

