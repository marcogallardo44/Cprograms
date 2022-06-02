using System;
using System.Collections.Generic;
using System.Text;

namespace HW_8__employee__school
{
    class Employee
    {
        //data members
        double number;
        string first;
        string last;
        double salary;
        double total;

        //member methods
        public Employee()
        {
            number = 1;
            first = "Taylor";
            last = "Swift";
            salary = 1000000000;
            total = salary * 12;
        }

        public Employee(double nbr, string frst, string lst, double slry)
        {
            nbr = number;
            frst = first;
            lst = last;
            slry = salary;
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

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0) salary = value;
                else salary = 0;
            }
        }


        public void AnualPay()
        {

            total = salary * 12;

        }


        public void PrintData()
        {
            Console.WriteLine("Employee #{0}", number);
            Console.WriteLine("First name: {0}", first);
            Console.WriteLine("Last name: {0}", last);
            Console.WriteLine("With a monthly salary of: ${0}", salary);
            Console.WriteLine("And an anual salary of: ${0}", total);
        }



        ~Employee() { }
    }
}
