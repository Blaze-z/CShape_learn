using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_一元_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ~ 按位取反
            int x = 12345678;
            int y = ~x;

            string xStr = Convert.ToString(x,2).PadLeft(32,'0');
            string yStr = Convert.ToString(y,2).PadLeft(32,'0');

            Console.WriteLine(xStr);
            Console.WriteLine(yStr);

            int a = -6;
            int b = a >> 1;
            string aStr = Convert.ToString(a, 2).PadLeft(32, '0');
            string bStr = Convert.ToString(b, 2).PadLeft(32, '0');
            Console.WriteLine(aStr);
            Console.WriteLine(bStr);

        }
    }
}
