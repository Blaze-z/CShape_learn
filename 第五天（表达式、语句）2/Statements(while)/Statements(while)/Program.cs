using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Statements_while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            //while语句
            /*bool canContinue = true;
            while (canContinue)
            {
                Console.WriteLine("Please input first number:");
                string str1 = Console.ReadLine();
                int num1 = int.Parse(str1);

                Console.WriteLine("Please input second number:");
                string str2 = Console.ReadLine();
                int num2 = int.Parse(str2);

                int sum = num1 + num2;
                if (sum == 100)
                {
                    score++;
                    Console.WriteLine("Correct!{0}+{1}={2}", num1, num2, sum);
                }
                else
                {
                    Console.WriteLine("Error!{0}+{1}={2}", num1, num2, sum);
                    canContinue = false;
                }
            }*/

            //do...while
            int sum = 100;
            do
            {
                Console.WriteLine("Please input first number:");
                string str1 = Console.ReadLine();

                //break语句
                if (str1.ToLower() == "end")
                {
                    break;
                }
                //continue语句
                int num1;
                try
                {
                    num1 = int.Parse(str1);
                }
                catch 
                {
                    Console.WriteLine("First number has problem!Restart.");
                    continue;
                }

                Console.WriteLine("Please input second number:");
                string str2 = Console.ReadLine();

                //break语句
                if (str2.ToLower() == "end")
                {
                    break;
                }
                int num2 ;
                try
                {
                    num2 = int.Parse(str2);
                }
                catch 
                {
                    Console.WriteLine("Second number has problem!Restart.");
                    continue;
                }

                sum = num1 + num2;
                if (sum == 100)
                {
                    score++;
                    Console.WriteLine("Correct!{0}+{1}={2}", num1, num2, sum);
                }
                else
                {
                    Console.WriteLine("Error!{0}+{1}={2}", num1, num2, sum);

                }
            }
            while (sum == 100);

            Console.WriteLine("Your score is {0}", score);
        }
    }
}
