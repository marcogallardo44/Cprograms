using System;

namespace temperature_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double temp1;
            Console.WriteLine("Please input a temperature in F:");
            temp1 = Convert.ToInt32(Console.ReadLine());
            temp1 = (temp1 - 32.0) * 5.0 / 9.0;
            temp1 = Math.Round(temp1,1);
            Console.WriteLine("Your temp in C is: " + temp1);
        }
    }
}
