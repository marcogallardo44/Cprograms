using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Utilities
    {
        public double InputVal(string item, double a, double b)//pos double
        {
            double x = 0;
            string x_str;
            bool valid = true;


            do
            {
                Console.WriteLine("Enter " + item + " :");
                x_str = Console.ReadLine();
                x = 0;
                valid = double.TryParse(x_str, out x);
                if (!valid)
                    Console.WriteLine("Invalid input, has to be a number. Please try again.");
                else if (x <= a || x >=b)
                {
                    Console.WriteLine("Invalid input, has to be between {0} and {1}. Try again.", a,b);

                }
                else;


            } while (!valid || x <= a||x>=b);

            return x;
        }
    }
}
