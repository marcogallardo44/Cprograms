using System;

namespace quiz_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] year = new double[100];
            double[] value = new double[100];
            double[] withdrawn = new double[100];
            int count = 0;
            Console.WriteLine("Year     Amccount Value    Amount Withdrawn");

            year[0] = 0;
            value[0] = 500000;
            withdrawn[0] = 0;

            Console.WriteLine(year[0] + "{0,18} {1,12}" , "$" +value[0]+".00" , "$"+withdrawn[0]+".00");


            for (int i = 1; i < 100; i++)
            {
                
                year[i] = i;
                if (i == 1)
                    withdrawn[i] = 25750;
                else
                    withdrawn[i] = (withdrawn[i-1] * .03) + withdrawn[i-1];
                withdrawn[i] = Math.Round(withdrawn[i], 2);

                value[i] = (value[i-1] * .04 + value[i-1]) - withdrawn[i];

                value[i] = Math.Round(value[i], 2);
                if (value[i] <= 0)
                    break;
                if(i == 1)
                    Console.WriteLine(year[i] + "{0,18} {1,16}" , "$" + value[i] + ".00", "$" + withdrawn[i] + ".00");
                else if (i == 2)
                    Console.WriteLine(year[i] + "{0,18} {1,16}", "$" + value[i] + "0", "$" + withdrawn[i] + "0");
                else if (i==3 || i <10)
                    Console.WriteLine(year[i] + "{0,19} {1,16}", "$" + value[i] + "0", "$" + withdrawn[i] + "0");
                else if (i==10 || i <21)
                    Console.WriteLine(year[i] + "{0,17} {1,16}", "$" + value[i], "$" + withdrawn[i]);
                else 
                    Console.WriteLine(year[i] + "{0,16} {1,17}", "$" + value[i] , "$" + withdrawn[i]);


                count++;
               
            }

            Console.WriteLine("");
            Console.WriteLine("The money will last for {0} years", count);


            

        }
    }
}
