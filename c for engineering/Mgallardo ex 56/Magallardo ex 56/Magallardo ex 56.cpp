// Magallardo ex 56.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"

using namespace std;

int time(int x, int y, int z)
{
	char a;
	int t;
	cout << "give me the hour of the day: ";
	cin >> x;
	cout << "give me the minutes of the day: ";
	cin >> y;
	cout << "give me the seconds of the day: ";
	cin >> z;
	cout << "AM(a) or PM(p): ";
	cin >> a;
	if (a == 'a')
	{
		t = 3600 * x + 60 * y + z;
	}
	else if (a == 'p')
	{
		t = (x + 12) * 3600 + 60 * y + z;
	}

	return t;
}



int main()
{
	int x=1;
	int y=1;
	int z=1;
	

	cout << time(x, y, z) << endl;




	system("pause");
    return 0;
}

