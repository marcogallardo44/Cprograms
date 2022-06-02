using System;

namespace HW_3__grades_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input your grade: ");
            int x, y, r, a;
            string input1;
            input1 = Console.ReadLine();
            bool v11 = int.TryParse(input1, out x);
            if (!v11)
                Console.WriteLine("Invalid unput");
            else
            {
                x = int.Parse(input1);
                if (x > 100 || x <0)
                {
                    Console.WriteLine("Invalid Input");
                }

               else
                {
                    x = x / 10;
                    switch (x)
                    {

                        case 0:
                            Console.WriteLine("Your grade is an F");
                            break;
                        case 1:
                            Console.WriteLine("Your grade is an F");
                            break;
                        case 2:
                            Console.WriteLine("Your grade is an F");
                            break;
                        case 3:
                            Console.WriteLine("Your grade is an F");
                            break;
                        case 4:
                            Console.WriteLine("Your grade is an F");
                            break;
                        case 5:
                            Console.WriteLine("Your grade is an F");
                            break;
                        case 6:
                            Console.WriteLine("Your grade is a D");
                            break;
                        case 7:
                            Console.WriteLine("Your grade is a C");
                            break;
                        case 8:
                            Console.WriteLine("Your grade is a B");
                            break;
                        case 9:
                            Console.WriteLine("Your grade is an A");
                            break;

                        case 10:
                            Console.WriteLine("Your grade is an A");
                            break;
                        default:
                            Console.WriteLine("default case");
                            break;

                    }
                }
              
            }
        }
    }
}
