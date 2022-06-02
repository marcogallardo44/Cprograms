using System;
using System.Collections.Generic;
using System.Text;

namespace HW_10__student_hierarchy_
{
    class GraduateStudent:Student
    {
        string degree;
        string location;
        int years;
        string major;


        public GraduateStudent():base()
        {
            degree = "unknown";
            location = "unknown";
            years = 0;
            major = "unknown";
        }

        public GraduateStudent(int a, string f, string l, string s, int i, string d, string lo, int y, string aw) :base(a,f,l,s,i)
        {
            degree = d;
            location = lo;
            years = y;
            major = aw;
        }

        public override string ToString()
        {
            Console.WriteLine(first + " " + last + " is " + age + " years old, goes to " + school + " and has an id number of: " + id);
            return first + " " + last + " graduated " + location + " with a " + degree + " degree in " + major + " in " + years + " years.";
        }









        ~GraduateStudent() { }


    }
}
