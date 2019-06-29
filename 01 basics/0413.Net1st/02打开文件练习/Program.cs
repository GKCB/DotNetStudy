using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace _02打开文件练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入打开文件的路径");
            string filePath = Console.ReadLine();
            Console.WriteLine("请输入打开文件名字");
            string fileName = Console.ReadLine();

            //通过简单工厂设计模式返回父类
            BaseFile bf = GetFile(filePath, fileName);
            if (bf != null)
            {
                bf.OpenFile();
            }
        }
        static BaseFile GetFile(string filePath, string fileName)
        {
            BaseFile bf = null;
            //3.txt获得的就是".txt"
            string strExtension = Path.GetExtension(fileName);
            switch (strExtension)
            {
                case ".txt":
                    bf = new TxtFile(filePath, fileName);
                    break;
                case ".mp4":
                    bf = new MP4(filePath, fileName);
                    break;
            }
            return bf;
        }
        class BaseFile
        {
            //字段、属性、构造函数、函数、索引器
            private string _filePath; //字段前面不要忘了有个下划线
            //按下 Ctrl + R + E可以实现字段的快速封装
            public string FilePath
            {
                get { return _filePath; }
                set { _filePath = value; }
            }

            //自动属性 pro+两下tab
            //public int MyProperty { get; set; }
            //属性的本质是两个函数，get, set 所以首字母大写
            public string FileName { get; set; }
            
            //构造函数
            public BaseFile(string filePath, string fileName)
            {
                this.FilePath = filePath;
                this.FileName = fileName;
            }

            //public BaseFile()
            //{

            //}

            //设计一个函数，在这里应该是打开指定文件
            public void OpenFile()
            {
                ProcessStartInfo psi =
                new ProcessStartInfo(this.FilePath+ "\\" + this.FileName);
                Process pro = new Process();
                pro.StartInfo = psi;
                pro.Start();
            }
        }
        //设计子类
        class TxtFile:BaseFile //继承父类 BaseFile
        {
            //子类会默认调用父类中的无参书构造函数，
            //但是在这里无参构造函数被有参数的构造函数替代了
            //所以，父类中的无参数构造函数少不了

            //在子类中显示调用父类构造函数
            //或者在子类中调用有参数的构造函数，如下
            public TxtFile(string filePath, string fileName)
                : base(filePath, fileName)
            { 
            }
            //如果是 : this 是调用当前自己的
        }

        class MP4 : BaseFile
        {
            public MP4(string filePath, string fileName)
                : base(filePath, fileName)
            {
            }
        }
    }
}
