using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18索引器的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //p.Numbers = new int[] { 1,2,3,4,5};
            //for (int i = 0; i < p.Numbers.Length; i++)
            //{
            //    Console.WriteLine(p.Numbers[i]);
            //}
            
            //索引器
            p[0] = 10;
            p[1] = 20;
            p[2] = 30;
            p[3] = 40;
            Console.WriteLine(p[0]);
            Console.WriteLine(p[1]);

            Console.WriteLine("----------------------");
            p["张三"] = "一个好人";
            p["大黄"] = "汪汪汪";
            Console.WriteLine(p["张三"]);
            Console.WriteLine(p["大黄"]);
        }
    }
    class Person
    {
        private int[] numbers = new int[5];
        public int[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }

        //索引器，让对象以索引的方式操作数组,很像属性
        //int 是索引类型
        public int this[int index]
        {
            get { return numbers[index]; }
            set { numbers[index] = value; }
        }

        Dictionary<string, string> dic = new Dictionary<string, string>();
        public string this[string index]
        {
            get { return dic[index];}
            set {dic[index] = value;}
        }

    }
}
