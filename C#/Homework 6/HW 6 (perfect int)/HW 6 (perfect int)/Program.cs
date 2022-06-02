using System;

namespace HW_6__perfect_int_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("perfect numbers btween 1 and 2000 include: ");
            for (int i =1;i<2000;i++)
            {
                
                isPerfect(i);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("perfect numbers btween 5 and 5000 include: ");
            for (int i = 5; i < 5000; i++)
            {

                isPerfect(i);
            }
        }

        static bool isPerfect(int number)
        {
            int sum = 0;
            int[] devisor = new int[5000];
            for(int i =1,j=0;i<number;i++,j++)
            {
                if(number%i==0)
                {
                    devisor[j] = i;
                    
                }

            }
            for(int i =0; i < 5000;i++)
            {
                sum = sum + devisor[i];
            }

            if (sum == number)
            {
                for(int i =0;i<5000; i++)
                {
                    if (devisor[i] != 0)
                        Console.WriteLine(number + " has a devisor of: " + devisor[i]);
                }
                return true;
            }
            else
                return false;

        }


    }
}
