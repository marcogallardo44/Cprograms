using System;

namespace HW_3__area_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like the area of a circle, rectangle, or cylinder? Please type your response in lower case.");
            double x, y, r, a;
            string input1, input2, input3;
            input1 = Console.ReadLine();
          
           



            if (input1 == "circle")
            {
                Console.WriteLine("Please input the radius of the circle.");
                input2 = Console.ReadLine();
                bool v11 = Double.TryParse(input2, out x);
                if (v11 & x > 0)
                {
                    x = Double.Parse(input2);
                    a = Math.PI * x * x;
                    a = Math.Round(a, 3);
                    Console.WriteLine("The area of the circle is: " + a);
                }
                else
                    Console.WriteLine("invalid input");

            }
            else if (input1 == "rectangle")
            {
                Console.WriteLine("Please input the Length of the rectangle.");
                input2 = Console.ReadLine();
                bool v11 = Double.TryParse(input2, out x);
                Console.WriteLine("Please input the Width of the rectangle.");
                input3 = Console.ReadLine();
                bool v21 = Double.TryParse(input3, out y);
                if (v11 & v21 & x > 0 && y >0)
                {
                    x = Double.Parse(input2);
                    
                    y = Double.Parse(input3);
                    
                    a = x * y;
                    a = Math.Round(a, 3);
                    Console.WriteLine("The area of the rectangle is: " + a);
                }
                else
                    Console.WriteLine("invalid input");

            }
            else if (input1 == "cylinder")
            {
                Console.WriteLine("Please input the height of the cylinder.");
                input2 = Console.ReadLine();
                bool v11 = Double.TryParse(input2, out x);
                Console.WriteLine("Please input the radius of the cylinder.");
                input3 = Console.ReadLine();
                bool v21 = Double.TryParse(input3, out r);
                if (v11 & v21 & x > 0 && r>0)
                {
                    x = Double.Parse(input2);
                    r = Double.Parse(input3);
                    a = 2 * Math.PI * r * x + 2 * Math.PI * r * r;
                    a = Math.Round(a, 3);
                    Console.WriteLine("The area of the cylinder is: " + a);
                }
                else
                    Console.WriteLine("invalid input");
            }

            else
            {  
               Console.WriteLine("invalid input, Please try again.");     
            }
                
                
                
            
        }
    }
}
