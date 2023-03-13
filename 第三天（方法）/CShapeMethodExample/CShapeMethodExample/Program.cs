using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapeMethodExample
{
    internal class Program
    {

        /*
         方法（函数）的申明与使用
         */
        static void Main(string[] args)
        {
            //函数的使用
            Console.WriteLine(Calculator.GetCircularArea(10));
            Console.WriteLine("=============================");
            Console.WriteLine(Calculator.GetCylinderVolume(10,20));
            Console.WriteLine("=============================");
            Console.WriteLine(Calculator.GetConeVolume(10,20));
        }


        //申明一个类
        class Calculator
        {

            //申明类的方法（函数）。
            public static double GetCircularArea(double r)
            {
                return Math.PI * r * r;
            }
            public static double GetCylinderVolume(double r, double h)
            {
                return GetCircularArea(r) * h;
            }
            public static double GetConeVolume(double r, double h)
            {
                return GetCylinderVolume(r, h) / 3;
            }
        }
    }
}
