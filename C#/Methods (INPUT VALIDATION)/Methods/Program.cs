using System;

namespace Methods
{
    class Program
    {

       


        static void Main(string[] args)
        {
            double side1 = InputVal("side1");
            double side2 = InputVal("side2");
            double side3 = InputVal("side3");


           

            isRightTriangle(side1, side2, side3);
        }

        static double Largest(double n1,double n2, double n3)
        {
            if (n2 > n1)
                n1 = n2;
            if (n1 < n3)
                n1 = n3;
            return n1;
        }

        static bool isRightTriangle(double x,double y, double z)
        {
            double total;
            double t =0;
            if ( x < y)
            {
                t = x;
                x = y;
                y = t;
                
            }
            if (x < z)
            {
                t = x;
                x = z;
                z = t;
            }
            total = y * y + z * z;
             x = x * x;
            if (x == total)
            {
                Console.WriteLine("These numbers create a right triangle.");
                return true;

            }
            else
            {
                Console.WriteLine("These numbers do not create a right triangle.");
                return false;
            }
        }



        static double InputVal(string item)//pos double
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
                else if (x <= 0)
                {
                    Console.WriteLine("Invalid input, has to be a positive number. Please try again.");

                }
                else;


            } while (!valid || x <= 0);

            return x;
        }

    }

}
