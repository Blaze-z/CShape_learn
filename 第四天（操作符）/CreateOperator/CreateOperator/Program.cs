using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 操作符的本质：
             */

            //1.操作符不能脱离与它关联的数据类型
            /* int a = 4;
             int b = 5;
             int c = b / a;
             Console.WriteLine("c=" + c); //结果为1

             double x = 4;
             double y = 5;
             double z = y / x;
             Console.WriteLine("z=" + z); // 结果为1.25*/

            //2.操作符的本质是函数（算法）的“简记法”
            Person p1 = new Person();
            Person p2 = new Person();
            p1.Name = "beer";
            p2.Name = "beer's wife";
            //List<Person> nation = Person.GetMarry(p1,p2);//常规写法
            List<Person> nation = p1 + p2;//操作符写法
            foreach (var person in nation)
            {
                Console.WriteLine(person.Name);
            }
        }

        class Person
        {
            public string Name;
            //public static List<Person> GetMarry(Person p1, Person p2)//常规写法
            public static List<Person> operator +(Person p1, Person p2)//操作符写法
            {
                List<Person> people = new List<Person>();
                people.Add(p1);
                people.Add(p2);
                for (int i = 0; i < 11; i++)
                {
                    Person clid = new Person();
                    clid.Name = p1.Name + " & " + p2.Name + "'s clid" + (i + 1).ToString();
                    people.Add(clid);
                }
                return people;
            }
        }
    }
}
