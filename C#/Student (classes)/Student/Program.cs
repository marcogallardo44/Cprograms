using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student();
            newStudent.Welcome();
            newStudent.Printdata();
            Console.WriteLine();

            Student newStudent1 = new Student("Marco Gallardo" , 23 , "Computer Engineering");
            newStudent1.Welcome();
            newStudent1.Printdata();
            Console.WriteLine();


            Student newStudent2 = new Student();
            newStudent2.Welcome();
            newStudent2.getStudent();
            newStudent2.Printdata();
            Console.WriteLine();
        }
    }     
}
