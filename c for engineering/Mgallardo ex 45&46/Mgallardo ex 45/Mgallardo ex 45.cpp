// Mgallardo ex 31.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "math.h"
#include "ctime"

using namespace std;
using std::time;

int main()
{
	int i;
	int j;
	char x;
	cout << "Enter a lterr to play, enter 'e' to exit: ";
	cin >> x;
	srand(time(0));
	while (x != 'e')
	{
		
		cout << 1 + rand() % 6 << endl;
		cout << 1 + rand() % 6 << endl;
		cout << "----------" << endl;
		return main();
	}
		

	
	return 0;
}

