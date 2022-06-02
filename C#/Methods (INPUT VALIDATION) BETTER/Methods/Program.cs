using System;

namespace Methods
{
    class Program
    {

       


        static void Main(string[] args)
        {
            Utilities test = new Utilities();


            double side1 = test.InputVal("side1",0,999999);
            double side2 = test.InputVal("side2",0,999999);
            double side3 = test.InputVal("side3",0,999999);

            

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



       

    }

}
