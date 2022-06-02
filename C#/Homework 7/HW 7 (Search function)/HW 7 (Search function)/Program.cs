using System;

namespace HW_7__Search_function_
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 test = new Class1();

            int[] A = new int[26];
            int x = 0;
            int count = 0;

            Console.WriteLine("Please input the test scores of the students: ");

            for (int i = 0; i < 26; i++)
            {
                A[i] = test.InputVal("grade: ",-1,101);
            }

          



            for(int i =0; i <26; i++)
            {
                if (Search(A[i], 26, 100) != -1)
                {
                    x = i + 1;
                    Console.WriteLine("Student #" + x + " earned 100%");
                }
                else
                    count = count + 1;
                if (count == 26)
                    Console.WriteLine("None of the students earned 100%");

            }
            
               




        }

        static int Search(int A, int n, int key)
        {
            

            
            int x =-1;

            

            for(int i =0;i <n;i++)
            {
                if (A == key)
                {
                    x = i + 1;
                    break;
                }
               
            }
           



            return x;
            
        }

    }
}
