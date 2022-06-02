using System;
using System.Collections.Generic;
using System.Text;

namespace HW_8_Employee_2
{
    class Employee
    {

        //data members
        double number;
        string first;
        string last;
        double sales;
        double total;
        double fed = .18;
        double retire = .1;
        double security = .06;

        //member methods
        public Employee()
        {
            number = 1;
            first = "Taylor";
            last = "Swift";
            sales = 1000000000;
            total = sales * .09;
            total = total - (total * fed + total * retire + total * security);
        }

        public Employee(double nbr, string frst, string lst, double sls)
        {
            nbr = number;
            frst = first;
            lst = last;
            sls = sales;
        }

        public double Number
        {
            get { return number; }
            set
            {
                if (value > 0) number = value;
                else number = 0;
            }
        }

        public string First
        {
            get { return first; }
            set
            {
                first = value;
            }
        }

        public string Last
        {
            get { return last; }
            set
            {
                last = value;
            }
        }

        public double Sales
        {
            get { return sales; }
            set
            {
                if (value > 0) sales = value;
                else sales = 0;
            }
        }

        public void TakeHome()
        {
            total = sales * .09;
            total = total - (total * fed + total * retire + total * security);
            
        }
       


        public void PrintData()
        {
            Console.WriteLine("Employee #{0}", number);
            Console.WriteLine("First name: {0}", first);
            Console.WriteLine("Last name: {0}", last);
            Console.WriteLine("With a total sales of: ${0}", sales);
            Console.WriteLine("And a take home pay of: ${0}", total);
        }



        ~Employee() { }
    }
}








