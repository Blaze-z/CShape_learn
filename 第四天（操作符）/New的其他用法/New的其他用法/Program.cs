using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New的其他用法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Report();
            CsStudent cs = new CsStudent();
            cs.Report();
        }
        class Student
        {
            public void Report()
            {
                Console.WriteLine("I'm a student.");
            }
        }

        class CsStudent:Student 
        {
            new public void Report() { Console.WriteLine("I'm a CS student."); }
        }
    }
}
