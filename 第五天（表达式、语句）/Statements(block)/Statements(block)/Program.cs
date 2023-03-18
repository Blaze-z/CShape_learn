using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements_block_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 块语句：在方法体里面被大括号包裹起来的语句
            {
                /*helle: Console.WriteLine("Hello,Wrold!");
                    goto helle;*/

            }

            // if 语句

            //switch
            /*int score = -101;
            switch (score / 10)
            {
                case 10:
                    if(score ==100)
                        Console.WriteLine("A");
                    else
                        Console.WriteLine("input error");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("A");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("B");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("C");
                    break;
                case 0:
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("input error");
                    break;
            }*/

            /*Level myLevel = Level.High;
            switch (myLevel)
            {
                case Level.High:
                    break;
                case Level.Mid:
                    break;
                case Level.Low:
                    break;
                default:
                    break;
            }*/

            //try 语句
            Calculator ca = new Calculator();
            //int result = ca.Add("abc", "100");

            //处理抛出的异常
            int result = 0;
            try
            {
                result = ca.Add("asd", "001");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            Console.WriteLine(result);
        }
        enum Level
        {
            High,
            Mid,
            Low
        }
        class Calculator
        {
            public int Add(string arg1, string arg2)
            {

                int a = 0;
                int b = 0;
                bool hasError = false;

                //try语句
                try
                {
                    a = int.Parse(arg1);
                    b = int.Parse(arg2);
                }
                /*
                 //通用：
                 catch 
                {
                    Console.WriteLine("your argument have error!");
                }
                 */

                //分类catch
                catch (ArgumentNullException ane)
                {
                    //Console.WriteLine("your argument is null");
                    hasError = true;
                    Console.WriteLine(ane.Message);
                }
                catch (FormatException fe)
                {
                    //Console.WriteLine("your argument is not a number");
                    hasError = true;
                    Console.WriteLine(fe.Message);
                }
                catch (OverflowException oe)
                {
                    //Console.WriteLine("out of range");
                    //hasError = true;
                    //Console.WriteLine(oe.Message);

                    //抛出异常，谁调用，谁处理（oe可以省略）
                    throw oe;
                }

                //finally:无论是否发生异常，都会执行。（可选）
                finally
                {
                    if (hasError)
                    {
                        Console.WriteLine("has Error!");
                    }
                    else
                    {
                        Console.WriteLine("Done!");
                    }
                }
                int res = a + b;
                return res;
            }
        }
    }
}
