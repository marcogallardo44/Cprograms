using System;
using System.Collections.Generic;
using System.Text;

namespace HW_9__grocery_
{
    class Milk
    {
        double unit_price;
        int quantity;

        public Milk ()
        {
            unit_price = 0;
            quantity = 0;
        }

        public Milk(double price, int quant)
        {
            unit_price = price;
            quantity = quant;
        }

        public double Unit_Pirce
        {
            get { return unit_price; }
            set
            {
                if (value >= 0) unit_price = value;
                else unit_price = 0;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0) quantity = value;
                else value = 0;
            }
        }

        public double total_price()
        {
            return unit_price * quantity;
        }

        public override string ToString()
        {
            return "Milk    $" + string.Format("{0:#.00}", Convert.ToDecimal(unit_price.ToString())) + "         " + quantity.ToString();
        }



    }
}
