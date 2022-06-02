using System;

namespace Project_1__guess_a_number_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string again = "y";

            
            while (again == "y")
            {
                Console.WriteLine("Guess a number between 1 and 100.");
                Random r_obj = new Random();
                int a = r_obj.Next(1, 101);
                int guess = 0;
                bool check = false;
                
                string no;

                while (check == false)
                {
                    no = Console.ReadLine();
                    int num = -1;
                    if (!int.TryParse(no, out num))
                    {
                        Console.WriteLine("you didnt input a number number :(");
                        Console.WriteLine("please input a number :)");
                        check = false;
                    }

                    else
                    {
                        guess = Int32.Parse(no);


                        if (guess < 0 || guess >100)
                        {
                            Console.WriteLine("please enter a number between 1 and 100 :)");
                            check = false;
                            
                        }





                        if (guess == a)
                        {
                            check = true;
                        }
                        else if (guess < a)
                        {
                            Console.WriteLine("your guess is less than mine :)");
                            check = false;
                        }
                        else if (guess > a)
                        {
                            Console.WriteLine("your guess is greater than mine D:");
                            check = false;
                        }
                    }
                }
                if (check == true)
                {
                    Console.WriteLine("Congrats you guessed: " + guess + " and mine is: " + a);
                    Console.WriteLine("you guessed correctly, would you like to play again? (y or n)");
                }
                again = Console.ReadLine();
            }

            Console.WriteLine("Hope you had fun :)");
            
            

           


        }
    }
}
