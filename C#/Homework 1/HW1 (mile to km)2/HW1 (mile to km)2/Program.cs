﻿using System;

namespace HW1__mile_to_km_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double mile1, km1;
            Console.WriteLine("Please input 2 different miles to be converted into kilometer:");
            string mile = Console.ReadLine();
            mile1 = double.Parse(mile);
            km1 = mile1 * 1.609;
            km1 = Math.Round(km1, 2);
            Console.WriteLine("Your mile in km is: " + km1);
        }
    }
}
