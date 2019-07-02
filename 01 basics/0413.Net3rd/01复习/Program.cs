using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //单例模式 保证对象在应用程序的唯一性

            //简单工厂 将所有的子类都当做父类来看

            //字符串 不可变性 GC


            //1.判断用户输入的是否是邮箱.
            //while (true)
            //{
            //    Console.WriteLine("请输入一个字符串");
            //    string input = Console.ReadLine();
            //    //@ .com .cn
            //    if (input.Contains("@") && input.Contains(".com")
            //        || input.Contains(".cn"))
            //    {
            //        Console.WriteLine("是一个邮箱");
            //    }
            //    else
            //    {
            //        Console.WriteLine("不是邮箱");
            //    }
            //}

            // { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串。
            //string[] names =  {"马龙", "迈克尔乔丹", "雷吉米勒", "科比布莱恩特", "蒂姆邓肯"  };   
            //string max = names[0];
            //for (int i = 0; i < names.Length;i++ )
            //{
            //    if (names[i].Length > max.Length)
            //    {
            //        max = names[i];
            //    }
            //}
            //Console.WriteLine("最长的是: {0}",max);



        }


    }
}
