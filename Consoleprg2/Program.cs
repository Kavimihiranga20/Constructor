using System;

namespace Consoleprg2
{
    class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student();
            Console.WriteLine(student1.student_id);
            Console.WriteLine(student1.student_name);

            student student2 = new student(231334,"Harry");
            Console.WriteLine(student2.student_id);
            Console.WriteLine(student2.student_name);
        }

        class student
        {
            public int student_id;
            public string student_name;

            public student()
            {

                student_id = 1323433;
                student_name = "John";
            
            }

            public student(int id, string name)
            {

                student_id = id;
                student_name = name;
            
            }
        





        }



    }



}
