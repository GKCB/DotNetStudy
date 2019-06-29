using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _01进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //导入所在的命名空间 alt+shift+F10
            //返回的是，存储着当前正在运行的进程
            //Process[] pro = Process.GetProcesses();
            //foreach (var item in pro)
            //{
            //    //逐个打印现在运行的进程
            //    Console.WriteLine(item.ProcessName);
            //}

            Process.Start("notepad");//打开记事本这个进程
            //Process.Start("iexplore","http://www.baidu.com");//ie浏览器

            //使用进程打开文件
            //psi 封装要打开的文件,但是并不打开这个文件。实际打开它还得用进程            
            ProcessStartInfo psi = 
                new ProcessStartInfo(@"C:\Users\cb\Desktop\贷款收入证明.doc");
            //创建进程对象
            Process pro = new Process();
            //告诉进程要打开的文件信息
            pro.StartInfo = psi;
            //对象调出来的进程，实例函数
            pro.Start();

        }
    }
}
