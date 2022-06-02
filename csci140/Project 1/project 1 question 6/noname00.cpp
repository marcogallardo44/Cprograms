                                           // Mileage.cpp, Marco Gallardo, C++ Language and Objects
//Project #1 PART 2 question 1,  MS Visual studio 2017, 10/9/2017


#include<conio.h>
#include<stdio.h>


int main()
{
	double miles;
	double gallons;
	double milestotal = 0.0;
	double gallonstotal = 0.0;
	double mpgtrip;
	double mpgtotal;

	printf  ("Enter miles dirven (-1 to quit): ");

	scanf("%f",&miles);


	while (miles != -1)
	{
		printf("Enter gallons used: ");
		scanf("%f", &gallons);

		milestotal = milestotal + miles;
		gallonstotal = gallonstotal + gallons;

		mpgtrip = miles / gallons;
		mpgtotal = milestotal / gallonstotal;

		printf("MPG this trip: ", mpgtrip);
		printf("Total MPG: ", mpgtotal);

		printf("Enter miles dirven (-1 to quit): ");
		scanf("%f", &miles);
	}
	 getch();


	return 0;

}


//COMMENTS:
//hated using turbo. its too outdated.
//This problem was easy because the output was already shown
//so all i had to do was try and make it look exactly
//how it did in the book.
/*Analasys:Looked easy to begin with because it was just calculating mpg
Design:designing was easy because it was shown in the book how its supposed to look
Test: forgot to add another cout cin statement in the while so it took me
a couple of tries before i got it completly right.*/