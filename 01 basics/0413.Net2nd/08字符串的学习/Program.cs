using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace _08字符串的学习
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "张三";
            string s2 = "张三";
            Console.WriteLine("s1={0},s1的地址是:{1}", s1, getMemory(s1));
            Console.WriteLine("s2={0},s2的地址是:{1}", s2, getMemory(s2));
            Console.ReadKey();
        }
        public static string getMemory(object o) // 获取引用类型的内存地址方法
        {
            GCHandle h = GCHandle.Alloc(o, GCHandleType.Pinned);
            IntPtr addr = h.AddrOfPinnedObject();
            return "0x" + addr.ToString("X");
        }
    }
    

}
