using System;
using System.Collections.Generic;
using System.Text;

namespace HW_10__student_hierarchy_
{
    class Student
    {
        protected int age;
        protected string first;
        protected string last;
        protected string school;
        protected int id;

        public Student()
        {
            age = 0;
            first = "Unknown";
            last = "Unknown";
            school = "Unknown";
            id = 0;
        }

        public Student( int a , string f, string  l, string s, int i)
        {
            age = a;
            first = f;
            last = l;
            school = s;
            id = i;
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0) age = value;
                else age = 0;
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

        public string School
        {
            get { return school; }
            set
            {
                school = value;
            }
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0) id = value;
                else id = 0;
            }
        }

        public override string ToString()
        {
            return first + " " + last + " is " + age + " years old, goes to " + school + " and has an id number of: " + id;
        }


        ~Student() { }




    }
}
