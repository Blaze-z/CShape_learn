using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            //通过委托调用方法
            Action myAction = new Action(c.SayHello);
            myAction(); //输出"hello!"
        }

        class Calculator
        {
            public double Add(double x, double y)
            {
                return x + y;
            }
            public void SayHello()
            {
                Console.WriteLine("hello!");
            }
        }
    }
}
