using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMember2_property_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student stu1 = new Student();
                stu1.Age = 20;
                Student stu2 = new Student();
                stu2.Age = 20;
                Student stu3 = new Student();
                stu3.Age = 200;
                int averageAge = (stu1.Age + stu2.Age + stu3.Age) / 3;
                Console.WriteLine(averageAge);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        class Student
        {
            private int age;
            public int Age
            {
                get { return this.age; }
                set
                {
                    if (value >= 0 && value <= 120)
                    {
                        age = value;
                    }
                    else
                    {
                        throw new Exception("Age value has error!");
                    }
                }
            }
            private int score;

            public int Score
            {
                get { return score; }
                set
                {
                    if (value >= 0 && value <= 100)
                    {
                        score = value;
                    }
                    else { throw new Exception("Score value has error"); }
                }
            }

            //属性的完整声明
            private static int amount;

            public static int Amount
            {
                get { return amount; }
                set
                {
                    if (value >= 0)
                    {
                        amount = value;
                    }
                    else
                    {
                        throw new Exception("amount value has error");
                    }
                }
            }

            //属性的简略声明
            public int sex { get; set; }

            //可使用Ctrl+r + Ctrl+e 快速重构字段为属性。
            private string name;
        }
    }
}
