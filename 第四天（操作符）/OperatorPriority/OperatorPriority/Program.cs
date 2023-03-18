using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorPriority
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //x = 3 + 4 + 5; // x=12

            int x = 100;
            int y = 200;
            x = x + y;  // 与x+=y等价，x等于300
        }
    }
}
