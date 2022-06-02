using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
           


            for(int i =0;i < 11;i++)
            {
                sum = sum + integerPower(2, i);
                if (i < 10)
                { Console.Write(integerPower(2, i) + " + "); }
                else if (i==10)
                {
                    Console.Write(integerPower(2, i));
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("The Sum is : " + sum);
        }

        static int integerPower(int bas, int exponent)
        {
            int total = 1;
            for(int i =0;i < exponent;i++)
            {
                total = bas * total;
                
            }
            return total;
        }   

    }
}
