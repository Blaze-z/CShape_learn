using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_箭头_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                // ->箭头操作符：通过指针访问对象
                Student stu = new Student();
                stu.Id = 1;
                stu.Score = 100;

                //&取地址符号
                Student* pStu = &stu;
                pStu->Score = 101;

                //* 取引用符号
                (*pStu).Score = 202;
                Console.WriteLine(stu.Score);
            }
        }
        struct Student
        {
            public int Id;
            public int Score;
        }
    }
}
