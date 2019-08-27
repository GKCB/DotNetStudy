using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _11为什么会有委托
{
    public delegate void DelSayHi(string name);
    class Program
    {        
        static void Main(string[] args)
        {
            //List<int> list = new List<int> {1,2,3,4,5,6 };
            //list.RemoveAll(number => number>2);

            //DelSayHi del = SayHiChinese;//new DelSayHi(SayHiChinese);
            //del("张三");
            //SayHi("张三", SayHiChinese);

            SayHi("张三", delegate(string name)
            {
                Console.WriteLine("O ha Yo" + name);
            });                 //匿名函数

            //SayHi("张三", (name) => { Console.WriteLine("O ha yo" + name); });

        }
        static void SayHi(string name,DelSayHi del)
        {
            del(name);
        }
        static void SayHiChinese(string name)
        {
            Console.WriteLine("吃了么"+name);
        }
        static void SayHiEnglish(string name)
        {
            Console.WriteLine("Hi" + name);
        }
        static void SayHiJapanese(string name)
        {
            Console.WriteLine("Kuniqiwa" + name);
        }

    }
}
