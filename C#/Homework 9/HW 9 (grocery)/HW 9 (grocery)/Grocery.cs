using System;
using System.Collections.Generic;
using System.Text;

namespace HW_9__grocery_
{
    class Grocery
    {
        double total;

        Milk my_milk;
        Bread my_bread;
        Eggs my_eggs;

        public Grocery(Milk mlk, Bread brd, Eggs eg)
        {
            my_milk = mlk;
            my_bread = brd;
            my_eggs = eg;
        }

        public double expense()
        {
            total = my_milk.total_price() + my_eggs.total_price() + my_bread.total_price();
            return total;
        }

        public override string ToString()
        {
            return "The total price of these items is: $" + total.ToString();
        }

    }
}
