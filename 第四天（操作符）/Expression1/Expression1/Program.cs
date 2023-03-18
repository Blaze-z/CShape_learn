using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            double b = 2;
            var c = (double)a;
            Console.WriteLine(c.GetType());

            int? x = null;
            var y = x ?? 100;
            Console.WriteLine(y.GetType());
        }
    }
}
