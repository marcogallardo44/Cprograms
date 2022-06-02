// lab2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <cmath>
#include <iomanip>
#include <map>
#include <sstream>
#include <vector>

using namespace std;

int main()
{


	char grade = 'A';
	char sign = '+';
	double score = 0.0;

	cout << "Please input your letter grade: " << endl;
	cin >> grade >> sign;

		switch (grade)
		{
		case 'A': score = 4.0; break;
		case 'B': score = 3.0; break;
		case 'C': score = 2.0; break;
		case 'D': score = 1.0; break;
		case 'F': score = 0.0; break;
		default: ""; break;
		}
		
	

	switch (sign)
	{
	case '+': score = score + .03; break;
	case '-': score = score - .03; break;
	default: ""; break;
	}
	
	if (score >= 4.0)
	{
		cout << 4.0 << endl;
	}
	
	else if (score <= 0.0)
	{
		cout << 0.0 << endl;
	}

	else
	{
		cout << score << endl;
	}

	
	
	system("pause");
    return 0;
}

