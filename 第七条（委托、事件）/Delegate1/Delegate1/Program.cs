using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C#已经申明了一些委托如：Action和func

            Calculator cal = new Calculator();
            Action action = new Action(cal.Report);
            cal.Report(); //直接调用
            action.Invoke(); //间接调用(可简略写成 action();)

            Func<int, int, int> func1 = new Func<int, int, int>(cal.Add);
            Func<int, int, int> func2 = new Func<int, int, int>(cal.Sub);

            int x = 100;
            int y = 200;
            int z = 0;
            z = func1(x, y);
            Console.WriteLine(z);
            z = func2(x, y);
            Console.WriteLine(z);
        }
    }
    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 menthods");
        }
        public int Add(int x, int y)
        {
            int res = x + y;
            return res;
        }
        public int Sub(int x, int y)
        {
            int res = x - y;
            return res;
        }
    }
}
