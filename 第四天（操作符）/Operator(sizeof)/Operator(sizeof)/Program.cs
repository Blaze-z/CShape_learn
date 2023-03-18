using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_sizeof_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sizeof  1.默认情况下查看类型占多少字节
            int x = sizeof(int);
            Console.WriteLine(x);


            //2.查看在unsafe下可以获取自定义结构体的尺寸
            unsafe
            {
                int y = sizeof(Student);
                Console.WriteLine(y);
            }
        }
        struct Student
        {
            int Id;
            string Name;
        }
    }
}
