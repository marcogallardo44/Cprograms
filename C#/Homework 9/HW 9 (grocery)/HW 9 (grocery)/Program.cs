using System;

namespace HW_9__grocery_
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk milk = new Milk();
            Bread bread = new Bread();
            Eggs eggs = new Eggs();

            Console.WriteLine("Item  Unit price   Quantity");
            Console.WriteLine(milk);
            Console.WriteLine(bread);
            Console.WriteLine(eggs);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Milk milk2 = new Milk(5.75,20);
            Bread bread2 = new Bread(4.50,10);
            Eggs eggs2 = new Eggs(6.99,12);
            Console.WriteLine(milk2);
            Console.WriteLine(bread2);
            Console.WriteLine(eggs2);
            Grocery groc = new Grocery(milk2, bread2, eggs2);
            groc.expense();
            Console.WriteLine(groc);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            Milk milk3 = new Milk();
            Bread bread3 = new Bread();
            Eggs eggs3 = new Eggs();
            milk3.Unit_Pirce = 4.75;
            milk3.Quantity = 1;
            bread3.Unit_Pirce = 2.50;
            bread3.Quantity = 2;
            eggs3.Unit_Pirce = 4.00;
            eggs3.Quantity = 3;
            Console.WriteLine(milk3);
            Console.WriteLine(bread3);
            Console.WriteLine(eggs3);
            Grocery groc2 = new Grocery(milk3, bread3, eggs3);
            groc2.expense();
            Console.WriteLine(groc2);



        }
    }
}
