using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[27];
            double[] second = new double[27];

            Random r_obj = new Random();
            double b;
            double tot=0;
            double avg = 0;
            double fill;
            int cnt=0;
            int median=0;

            

            for(int i =0; i <27;i++)
            {
                b = r_obj.NextDouble()*(100.0- 50.0) +50.0;
                b = Math.Round(b, 1);
                a[i] = b;
                second[i] = b;
                
            }
           

            for (int i =0;i<26;i++)
            {
                tot = tot + a[i];
            }
            
            
            avg = tot / 27;
            avg = Math.Round(avg, 1);
            
            for (int i =0;i<27;i++)
            {
                if (avg < a[i])
                    cnt++;
            }


            for (int i = 0; i < 27; i++)
            {

                if (a[i] > avg)
                {
                    Console.WriteLine((i + 1) + "{0,10}    Higher", a[i]);
                }
                else
                {
                    Console.WriteLine((i + 1) + "{0,10}    ", a[i]);
                }
            }
            Console.WriteLine("Now we will sort these in order: ");


            Array.Sort(a);

            


            for (int i =0;i<27;i++)
            {
   
                if (a[i]>avg)
                {
                    Console.WriteLine((i + 1) + "{0,10}    Higher", a[i]);
                }
                else
                {
                    Console.WriteLine((i + 1) + "{0,10}    ", a[i]);
                }
            }
            for (int i = 0; i < 27; i++)
            {
                
                if (second[i]==a[13])
                    median = i+1;
                
            }

            Console.WriteLine("average: " + avg);
            Console.WriteLine(cnt + " students are above average.");
            Console.WriteLine("student: " + median + " is the median.");







        }
    }
}
