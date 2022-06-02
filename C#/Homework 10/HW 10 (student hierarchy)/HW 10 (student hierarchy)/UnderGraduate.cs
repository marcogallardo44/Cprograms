using System;
using System.Collections.Generic;
using System.Text;

namespace HW_10__student_hierarchy_
{
    class UnderGraduate:Student
    {
        string year;
        string housing;
        int classes;
        int units;


        public UnderGraduate():base()
        {
            year = "unknown";
            housing = "unknown";
            classes = 0;
            units = 0;
        }

        public UnderGraduate(int a, string f, string l, string s, int i, string y, string h, int c, int u) :base(a,f,l,s,i)
        {
            year = y;
            housing = h;
            classes = c;
            units = u;
        }

        public override string ToString()
        {
            Console.WriteLine(first + " " + last + " is " + age + " years old, goes to " + school + " and has an id number of: " + id);
            return "The student is an undergraduate " + year + " that lives " + housing + ". They are taking " + classes + " classes and " + units + " units.";
        }











        ~UnderGraduate() { }

    }
}
