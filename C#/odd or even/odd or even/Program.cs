using System;

namespace odd_or_even
{
    class Program
    {

        static void Main(string[] args)
        {
            double number;
            string x;
            Console.WriteLine("input a number");
            x = Console.ReadLine();
            
            bool IsValid = double.TryParse(x, out double b);
            if (IsValid)
            {
                number = double.Parse(x);
                if (number % 2 == 0)
                {
                    Console.WriteLine("{0} is even.", number);
                }
                else
                    Console.WriteLine("{0} is odd.", number);
            }
            else
                Console.WriteLine("The input is Invalid.");
           // Another way to take away letter inputs



            double a;
            while (!Double.TryParse(x, out a))
            {
                Console.WriteLine("Not a valid number, try again.");

                x = Console.ReadLine();
            }
            // one way to take out letters

            number = double.Parse(x);
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is even.", number);
            }
            else
                Console.WriteLine("{0} is odd.", number);
        }
    }
}
