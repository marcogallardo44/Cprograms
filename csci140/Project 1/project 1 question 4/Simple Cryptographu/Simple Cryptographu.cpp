// Simple Cryptographu.cpp, Marco Gallardo, C++ Language and Objects
//Project #1 PART 2 question 4,  MS Visual Express 2017, 10/9/2017

#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;
void rot13(char str[])
{
	for (int i = 0; str[i] != 0; i++)
	{
		if (str[i] >= 'a' && str[i] <= 'm')
		{
			str[i] += 13;
		}
		else if (str[i] > 'm' && str[i] <= 'z')
		{
			str[i] -= 13;
		}
		else if (str[i] >= 'A' && str[i] <= 'M')
		{
			str[i] += 13;
		}
		else if (str[i] > 'M' && str[i] <= 'Z')
		{
			str[i] -= 13;
		}
	}
}


int main()
{
	
	char mystring[] = "Programming is fun!";
	cout << "Original: " << mystring << endl;

	rot13(mystring);
	cout << "Encrypted message: " << mystring << endl;


	rot13(mystring);
	cout << "Encrypted message: " << mystring << endl;


	system("pause");
    return 0;
}

//COMMENTS:
//I feel like decoding this without a key wouldbe pretty hard.
//A computer program would help alot because it can do tons of tries
/*Kinda hard to figure this out because i didnt know what this was
to begin with.
Analasys: Had to figure out what rot13 was and how to impliment it,
figured it was a function
Design: Created a function "rot13" that decided if the letter is between a and m
then adds 13, or n and z then subtracts 13 and changes the character accordingly.
In the main I maid a string with a quote, cout the quote, used the function
to change the quote, cout the changed quote, the used the function again
to change it back and cout it.
Test: I messed up in the function not making str >= a, when changing the quote
every n would be an a, then not change back to an n. fixed it though.*/