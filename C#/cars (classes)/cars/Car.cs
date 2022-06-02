using System;
using System.Collections.Generic;
using System.Text;

namespace cars
{
    class Car
    {
        // data members
        string color;
        double price;
        string make;



        // member methods

        public Car()
        {
            color = "silver";
            price = 32000;
            make = "Honda";
        }

        public Car(string clr, double p, string mk)
        {
            color = clr;
            price = p;
            make = mk;
        }


        public Car(double p, string mk)
        {
            color = "black";
            price = p;
            make = mk;
        }

        //accessorrs and mutators and properties
        public string GetColor()
        {
            return color;
        }

        public void SetColor(string clr)
        {
            color = clr;
        }

        // get and set together
        public string Color
        {
            get { return color; }
            set { color = value; }
        }




        public double GetPrice()
        {
            return price;

        }

        public void SetPrice(double p)
        {
            if (p > 0) price = p;
            else
            {
                p = 0;
                Console.WriteLine("The price is invalid.");
            }
        }

        //get and set together
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0) price = value;
                else price = 0;
            }
        }


        public string Make
        {
            get { return make; }
        }



        public void Drive()
        {
            Console.WriteLine("Someone is driving the car.");
        }

        public void PrintData()
        {
            Console.WriteLine("A {0} {1}, at the price of ${2}", color, make, price);
        }


        ~Car() { }


    }
}
