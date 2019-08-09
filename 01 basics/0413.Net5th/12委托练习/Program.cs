using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12委托练习
{
    public delegate string DelProStr(string str);
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "abcdDE", "DEdfsEFDd", "ASFdf" };
            //三个需求：
            //将所有元素转换成大写
            //将所有元素转换成小写
            //将所有元素两边加上一个双引号
            //ProString(names,Test1);
            ProString(names, (name) => { return name.ToUpper(); });
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void ProString(string[] names,DelProStr del)
        {
            for (int i = 0; i < names.Length; i++)
            {
                //传入一个处理字符串的方式
                names[i] = del(names[i]);
            }
        }
        //static string Test1(string str)
        //{
        //    return str.ToUpper();
        //}
        //static void ProToUpper(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = names[i].ToUpper();
        //    }
        //}
        //static void ProToLower(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = names[i].ToLower();
        //    }
        //}
        //static void ProSYH(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = "\"" + names[i] + "\"";
        //    }
        //}
    }
}
