using System;
using System.Collections.Generic;
using System.Text;

namespace HW_7__Search_function_
{
    class Class1
    {
        public int InputVal(string item, int a, int b)//pos double
        {
            int x = 0;
            string x_str;
            bool valid = true;


            do
            {
                Console.WriteLine("Enter " + item);
                x_str = Console.ReadLine();
                x = 0;
                valid = Int32.TryParse(x_str, out x);
                if (!valid)
                    Console.WriteLine("Invalid input, has to be a number. Please try again.");
                else if (x <= a || x >= b)
                {
                    Console.WriteLine("Invalid input, has to be between {0} and {1}. Try again.", a, b);

                }
                else;


            } while (!valid || x <= a || x >= b);

            return x;
        }
    }
}
