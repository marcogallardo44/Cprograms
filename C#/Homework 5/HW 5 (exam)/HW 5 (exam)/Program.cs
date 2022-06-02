using System;

namespace HW_5__exam_
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int count = 0;
            double greatest = 0;
            string great = "";
            double[] score = new double[26];
            string[] name = new string[26];

            Console.WriteLine("First write 26 names: ");
            for (int i =0; i < 26; i++)
            {
                name[i] = Console.ReadLine();
                
            }
            Console.WriteLine("Now write their corresponding grades: ");
            for (int i = 0; i < 26; i++)
            {
                score[i] = Double.Parse(Console.ReadLine());

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Name          Score");

            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(name[i]+"          "+score[i]);

            }


            for (int i = 0; i < 26; i++)
            {
                if (score[i] > greatest)
                {
                    greatest = score[i];
                    great = name[i];
                }
            }

            Console.WriteLine(great + " has the highest score of " + greatest + " in the class.");


            for (int i =0;i<26;i++)
            {
                total = total + score[i];
            }
            double avg = total / 26;

            Console.WriteLine("The average is: "+avg);
            
            for (int i = 0; i < 26; i++)
            {
                if (score[i] > avg)
                {
                    count++;
                }

            }
            Console.WriteLine(count+"  Students are above average.");

            

        }
    }
}
