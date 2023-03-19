using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Delegate_multicast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Yellow };
            Student stu2 = new Student() { ID = 1, PenColor = ConsoleColor.Green };
            Student stu3 = new Student() { ID = 1, PenColor = ConsoleColor.Blue };

            Action action1 = new Action(stu1.DoHomeWork);
            Action action2 = new Action(stu2.DoHomeWork);
            Action action3 = new Action(stu3.DoHomeWork);

            //单播委托
            /*action1.Invoke();
            action2.Invoke();
            action3.Invoke();*/

            action1 += action2; //将action2合并到action1中
            action1 += action3;
            //多播委托
            action1.Invoke();
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Main {0}", i);
                Thread.Sleep(1000);
            }
        }
    }
    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }
        public void DoHomeWork()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student{0} doing homework {1} hours.", this.ID, i);
                Thread.Sleep(1000);
            }
        }
    }

}
