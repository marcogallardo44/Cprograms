using System;

namespace HW_4__invest_bs_save
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************* Investing vs. Saving ***********************");
            
            Console.WriteLine("\nAge             Linda's Account         John's Account");
            Console.WriteLine("---------------------------------------------------------------");

            double x = 1000.00;
            double y = .06;
            double perc;
            double a = 1000.00;
            double b = .015;
            double tot;


            Console.WriteLine("20              $1000.00                $1000.00\n");

            for (int i =20; i <=60; i ++)
            {
                if (i>20 && i % 10 == 0)
                {
                    Console.WriteLine("{0,-16}${1,-23}${2}\n", i, x = Math.Round(x, 2), a = Math.Round(a, 2));
                }
                perc = x * y;
                x = x + perc;
                
                tot = a * b;
                a = a + tot;
                
               
            }

            
        }
    }
}
