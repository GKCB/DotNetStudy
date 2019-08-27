using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _14File类的操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //File 
            //Exist()：判断指定的文件是否存在
            //Create():创建
            //Move():剪切
            //Copy()
            //Delete()

            //if (!File.Exists("1.txt"))
            //{
            //    File.Create("1.txt");
            //}
            //if (File.Exists("1.txt"))
            //{
            //    File.Delete("1.txt");
            //}
            //File.Copy(@"../../english.txt", @"../../new.txt");
            //File.Move(@"../../new.txt",@"C:\Users\cb\Desktop\bbb.txt");

            Console.WriteLine("操作成功");
            Console.ReadKey();


        }
    }
}
