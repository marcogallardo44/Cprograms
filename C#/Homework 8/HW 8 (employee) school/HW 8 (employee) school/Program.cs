using System;

namespace HW_8__employee__school
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();
            Employee newEmployee2 = new Employee();

            newEmployee.PrintData();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            newEmployee2.Number = 5;
            newEmployee2.First = "Marco";
            newEmployee2.Last = "Gallardo";
            newEmployee2.Salary = 5000;
            newEmployee2.AnualPay();
            newEmployee2.PrintData();
        }
    }
}
