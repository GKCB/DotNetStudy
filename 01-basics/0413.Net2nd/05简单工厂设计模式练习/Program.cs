using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05简单工厂设计模式练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你想要的笔记本品牌");
            string brand = Console.ReadLine();
            //整个简单工厂的核心   工厂
            //根据用户的输入 返回相应的笔记本 父类
            NoteBook nb = GetNoteBook(brand);
            if (nb != null)
            {
                nb.SayHello();
            }
            else
            {
                Console.WriteLine("没有你想要的电脑品牌！！！！");
            }
        }
        static NoteBook GetNoteBook(string name)
        {
            NoteBook nb = null;
            switch (name)
            {
                case "IBM":
                    nb = new IBM();
                    break;
                case "Lenovo":
                    nb = new Lenovo();
                    break;
                case "Dell":
                    nb = new Dell();
                    break;
                case "Acer":
                    nb = new Acer();
                    break;
                default:
                    nb = null;
                    break;
            }
            return nb;
        }
    
    } 
    
    abstract class NoteBook
    {
        public abstract void SayHello();
    }

    class IBM : NoteBook
    {
        //虚拟成员或抽象成员不能是私有的
        public override void SayHello()
        {
            Console.WriteLine("IBM");
        }
    }
    class Lenovo : NoteBook
    {
        //虚拟成员或抽象成员不能是私有的
        public override void SayHello()
        {
            Console.WriteLine("Lenovo");
        }
    }
    class Dell : NoteBook
    {
        //虚拟成员或抽象成员不能是私有的
        public override void SayHello()
        {
            Console.WriteLine("Dell");
        }
    }
    class Acer : NoteBook
    {
        //虚拟成员或抽象成员不能是私有的
        public override void SayHello()
        {
            Console.WriteLine("Acer");
        }
    }
}
