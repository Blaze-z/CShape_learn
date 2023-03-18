using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMember1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Student stu1 = new Student();
            stu1.age = 25;
            stu1.score = 90;

            Student stu2 = new Student();
            stu2.age = 35;
            stu2.score = 50;*/

            List<Student> students = new List<Student>();
            for (int i = 0; i < 100; i++) {
                Student stu = new Student();
                stu.age = 26;
                stu.score = i;
                students.Add(stu);
            }
            int totalAge = 0;
            int totalScore = 0;
            foreach (Student student in students)
            {
                totalAge += student.age;
                totalScore += student.score;
            }
            Student.AverageScore = totalScore / Student.Amount;
            Student.AverageAge = totalAge / Student.Amount;

            Student.ReportAverageScore();
            Student.ReportAverageAge();
            Student.ReportAmount();
        }
        class Student
        {
            public int age;
            public int score;
            public static int AverageAge;
            public static int AverageScore;
            public static int Amount;
            public Student()
            {
                Student.Amount++;

            }
            public static int ReportAmount()
            {
                Console.WriteLine(Amount);
                return Amount;
            }
            public static void ReportAverageAge()
            {
                Console.WriteLine(AverageAge);
            }
            public static void ReportAverageScore()
            {
                Console.WriteLine(AverageScore);
            }
        }

    }
}
