using System;

namespace HW_10__student_hierarchy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            Console.WriteLine(a.ToString());
            Console.WriteLine();
            Console.WriteLine();

            Student a1 = new Student(30, "Taylor", "Swift", "Cal Poly Pomona" , 85657545 );
            Console.WriteLine(a1.ToString());
            Console.WriteLine();
            Console.WriteLine();

            UnderGraduate u1 = new UnderGraduate(30, "Taylor", "Swift", "Cal Poly Pomona", 85657545, "freshman", "on campus", 5, 15);
            Console.WriteLine(u1.ToString());
            Console.WriteLine();
            Console.WriteLine();


            GraduateStudent g1 = new GraduateStudent(30, "Taylor", "Swift", "Cal Poly Pomona", 85657545, "B.S.", "Cal Poly Pomona", 4, "Computer Engineering");
            Console.WriteLine(g1.ToString());





        }
    }
}
