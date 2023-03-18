using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Arguments_this_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3.1415926;
            //double y = Math.Round(x,4); //普通写法。
            double y = x.Round(4);
            Console.WriteLine(y);

            List<int> myList = new List<int> { 12, 22, 31, 11 };
            bool result = myList.All(item => item >= 10);
            Console.WriteLine(result);
        }
        

    }

    //必须是静态类（一般命名为SomeTypeExtension）
    static class DoubleExtension
    {

        //方法必须是公有的、静态的（pubic static）
        //必需是形参列表中的第一个，有this修饰
        public static double Round(this double input, int digits)
        {
            double result = Math.Round(input, digits);
            return result;
        }
    }
}
