using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator_new_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////var 帮我们生命隐式类型变量
            //var x = 100;
            //Console.WriteLine(x.GetType().Name);//int32

            // new 1.调用实例构造器
            //Form myForm = new Form();
            //myForm.Text = "hello";
            //myForm.ShowDialog();

            // 2.调用实例初始化器
            //Form myForm_2 = new Form() { Text = "hello!", FormBorderStyle = FormBorderStyle.SizableToolWindow };
            //myForm_2.ShowDialog();

            //3.为匿名类型创建对象，并用隐式类型变量引用这个实例。
            var person = new { name = "Mr.Okey", age = 18 };
            Console.WriteLine(person.GetType().Name);
        }
    }
}
