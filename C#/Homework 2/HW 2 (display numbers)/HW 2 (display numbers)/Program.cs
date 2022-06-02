using System;

namespace HW_2__display_numbers_
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers;
            int convert, a, b, c, d, e;
            numbers = Console.ReadLine();
            Console.WriteLine(numbers);
            convert = Convert.ToInt32(numbers);
            a = convert / 10000;
            convert = convert % 10000;
            b = convert / 1000;
            convert = convert % 1000;
            c = convert / 100;
            convert = convert % 100;
            d = convert / 10;
            convert = convert % 10;
            e = convert;
            Console.WriteLine(a + "   " + b + "   " + c + "   " + d + "   " + e);
        }
    }
}
