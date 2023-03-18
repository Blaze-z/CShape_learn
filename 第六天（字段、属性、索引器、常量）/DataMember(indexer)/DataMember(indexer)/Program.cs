using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMember_indexer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            try
            {
            stu["Math"] = null;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(stu["Math"]);
        }
        class Student
        {
            private Dictionary<string , int> ScoreDictionary = new Dictionary<string , int>();
            public int? this[string subject]
            {
                get { 
                    if (ScoreDictionary.ContainsKey(subject)) return ScoreDictionary[subject];
                    else return null;
                }
                set 
                {
                    if (value.HasValue == false) throw new Exception("score value has error");
                    if (ScoreDictionary.ContainsKey(subject))
                    {
                        ScoreDictionary[subject] = value.Value;
                    }
                    else
                    {
                        ScoreDictionary.Add(subject, value.Value);
                    }
                }
            }
        }
    }
}
