using System;

namespace HW_4__fib_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1, c = 0,x=2;
            Console.Write("{0,-10}{1,-10}", a, b);
            for (int i = 2; i < 30 && x<31; i++,x++)
            {
                c = a + b;

                if(x%5==0)
                {
                    Console.WriteLine("");
                }
                    Console.Write("{0,-10}", c);
                
                a = b;
                b = c;
            }
        }
    }
}
