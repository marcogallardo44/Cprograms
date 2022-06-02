using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Student
    {
        // data members
        string name;
        double age;
        string major;



        // member methods

        public Student()
        {
            name = "";
            age = 0;
            major = "undefined";
        }

        public Student(double ag, string mjr)
        {
            name = "Bob Bobby";
                age = ag;
            major = mjr;
        }

        public Student(string nm, double ag, string mjr)
        {
            name = nm;
            age = ag;
            major = mjr;
        }

        public void getStudent()
        {
            name = Console.ReadLine();
            age = Double.Parse(Console.ReadLine());
            major = Console.ReadLine();

        }





        public void Welcome()
        {
            Console.WriteLine("Welcome to school, please insert your name, age, and major.");
        }

        public void Printdata()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("major: " + major);
        }


    }
}
