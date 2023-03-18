using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ctrl+. 修改所有命名


            //引用参数： 前面加ref修饰，会改变实参的值
            /* int y = 1;
             IWantSideEffect(ref y);
             //Console.WriteLine(y);*/

            //输出参数： 用out修饰
            /* Console.WriteLine("Input first number:");
             string str = Console.ReadLine();
             double num1 = 0;
             //使用out关键字将转换成功后的结果赋给num1
             bool b1 = double.TryParse(str, out num1);
             if (!b1)
             {
                 Console.WriteLine("Input has error!");
                 return;
             }
             else
             {
                 Console.WriteLine("Input second number:");
                 string str2 = Console.ReadLine();
                 double num2 = 0;
                 bool b2 = double.TryParse(str2, out num2);
                 if (!b2)
                 {
                     Console.WriteLine("Input has error!");
                     return;
                 }
                 else
                 {
                     double res = num1 + num2;
                     Console.WriteLine("{0}+{1}={2}",num1,num2,res);
                 }

             }*/

            //调用输出参数方法
            double x = 0;
            bool b = DoubleParser.TryParse("AAC", out x);
            if (b)
            {
                Console.WriteLine(x + 1);
            }
            else
            {
                Console.WriteLine(x);
            }
        }


        //引用参数
        /*static void IWantSideEffect(ref int x)
        {
            x += 100;
        }*/


        class DoubleParser
        {
            //声明输出参数的方法
            public static bool TryParse(string input, out double result)
            {
                try
                {
                    result = Double.Parse(input);
                    return true;
                }
                catch
                {
                    result = 0;
                    return false;
                }
            }
        }
    }
}
