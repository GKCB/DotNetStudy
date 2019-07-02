using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _02StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = string.Empty;
            //StringBuilder sb = new StringBuilder();
            //Stopwatch sp = new Stopwatch();
            //sp.Start();
            ////不停的在内存中开空间，需要耗时
            //for (int i = 0; i < 100000; i++)
            //{
            //    //str += i;
            //    sb.Append(i);
            //}

            //sp.Stop();
            //Console.WriteLine(sp.Elapsed);
            //Console.WriteLine(sb.ToString());
            StringBuilder sb = new StringBuilder();
            sb.Append("张三");
            sb.Append("李四");
            sb.Append("王狗蛋儿");
            sb.Insert(3,"*");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
