using System;

namespace HW_8_Employee_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();
            newEmployee.PrintData();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please enter your employee number: ");
            newEmployee.Number = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please write your first name: ");
            newEmployee.First = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            newEmployee.Last = Console.ReadLine();
            Console.WriteLine("Please enter how many sales you've had: ");
            newEmployee.Sales = Double.Parse(Console.ReadLine());
            newEmployee.TakeHome();
            newEmployee.PrintData();




        }
    }
}
