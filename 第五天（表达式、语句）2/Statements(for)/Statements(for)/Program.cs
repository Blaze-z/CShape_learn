using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements_for_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //99乘法表
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    int res = i * j;
                    Console.Write("{0}*{1}={2}\t", i, j, res);
                }
                Console.WriteLine();
            }

            //等腰三角形
            for (int i = 1; i < 10; i++)
            {
                for (int y = 10 - i; y >= 1; y--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //空心等腰三角形
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5 - i; j >= 1; j--)
                {
                    Console.Write(' ');
                }
                Console.Write('*');
                for (int y = 1; y <= 2 * i - 3; y++)
                { Console.Write(y); }
                if (i != 1)
                    Console.Write('*');
                Console.WriteLine();
            }
        }
    }
}
