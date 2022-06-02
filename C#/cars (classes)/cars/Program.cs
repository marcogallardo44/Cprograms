using System;

namespace cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car yourCar = new Car();

            yourCar.Drive();
            yourCar.PrintData();

            Car myCar = new Car("red", 20000, "Honda");
            myCar.PrintData();

            Car car3 = new Car(35000, "toyota");
            car3.PrintData();


            Console.WriteLine("Write the new color of your car.");
            string color = Console.ReadLine();
            myCar.SetColor(color);
            Console.WriteLine("The new color of your car is: {0}", myCar.GetColor());
            myCar.PrintData();

            Console.WriteLine("Write the new price of your car");
            double price = double.Parse(Console.ReadLine());
            myCar.SetPrice(price);
            Console.WriteLine("The new price of your car is: ${0}", myCar.GetPrice());
            myCar.PrintData();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Write the new color of your car.");
            color = Console.ReadLine();
            car3.Color = color;
            Console.WriteLine("Write the new price of your car.");
            price = double.Parse(Console.ReadLine());
            car3.Price = price;

            
            Console.WriteLine("The new color of your car is: {0}", car3.Color);
            Console.WriteLine("The new price of your car is: ${0}", car3.Price);
            Console.WriteLine("The make of your car is: {0}", car3.Make);
            car3.PrintData();





            /* Car[] test = new Car[3];
            string clr, mk;
            double p;
            for (int i=0; i < 3; i++)
            {
                Console.WriteLine("Enter the color for the car#{0}", i + 1);
                clr = Console.ReadLine();
                Console.WriteLine("Enter the make for the car#{0}", i + 1);
                mk = Console.ReadLine();
                Console.WriteLine("Enter the price for the car#{0}", i + 1);
                p = Double.Parse(Console.ReadLine());
                test[i] = new Car(clr, p, mk);
            }
            for(int i =0; i < 3;i++)
            {
                Console.Write("car #{0} : ", i + 1);
                test[i].PrintData();
                    
            }
            */




        }
    }
}
