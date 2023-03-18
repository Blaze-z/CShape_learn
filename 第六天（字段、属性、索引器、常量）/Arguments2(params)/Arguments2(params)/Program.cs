using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arguments2_params_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //无params时写法
            /*int[] myIntArray = new int[] {1,2,3};
            int res = CalculateSum(myIntArray);*/

            //有params时写法
            int res = CalculateSum(1, 2, 3);

            Console.WriteLine(res);

            //具名调用  可不受位置影响
            PrintInfo(age: 22, name: "张三");
        }
        static int CalculateSum( params int[] args) 
        {
            int sum = 0;
            foreach (int item in args)
            {
                sum += item;
            }
            return sum;
        }

        static void PrintInfo(string name , int age)
        {
            Console.WriteLine("name:{0},age:{1}",name,age);
        }
    }
}
