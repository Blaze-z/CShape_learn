using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *当函数有多个重载（overload）时，会自动选择一个合适的进行执行。
             */
            //第一个构造函数创造的实例
            Student stu1 = new Student(10, "Mr.Okey");
            Console.WriteLine(stu1.ID);
            Console.WriteLine(stu1.Name);
            Console.WriteLine("==================");
            //第二个构造函数创造的实例
            Student stu2 = new Student();
            Console.WriteLine(stu2.ID);
            Console.WriteLine(stu2.Name);

        }

        class Student
        {

            //构造函数快捷键ctor
            public Student(int intiID,string intiName) 
            {
                this.ID = intiID;
                this.Name = intiName;
            }


            //方法的重载（overload)
            public Student()
            {
                this.ID = 1;
                this.Name = "No Name";               
            }
            public int ID;
            public string Name;
        }
    }
}
