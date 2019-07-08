using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _01File类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取"工资.txt"文件，每个人的工资加倍
            string path = @"../../工资.txt";
            string[] contents = File.ReadAllLines(path,
                Encoding.Default);//默认utf-8
            
            for (int i = 0; i < contents.Length; i++)
            {
                string[] temp = contents[i].Split(new char[]{'\t'},StringSplitOptions.RemoveEmptyEntries);
                contents[i] = temp[0] + '\t' + int.Parse(temp[1])*2;
            } 
            File.WriteAllLines(path,contents,Encoding.Default);
            Console.WriteLine("操作成功");
            Console.ReadKey();
        }
    }
}
