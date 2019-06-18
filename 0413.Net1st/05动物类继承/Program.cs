using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05动物类继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //实现多态：声明父类去指向子类对象
            Animal[] a = { new Cat(), new Dog(), new Pig() };
            for (int i = 0; i < a.Length; i++)
            {
                a[i].Bark();
                a[i].Drink();
                a[i].Eat();
            }
        }
    }

    abstract class Animal
    {
        //抽象成员只能存在于抽象类中
        //不确定子类的具体实现,所以应该用抽象函数来实现
        public abstract void Bark();
        public void Eat()
        {
            Console.WriteLine("舔着吃");
        }
        public void Drink()
        {
            Console.WriteLine("舔着喝");
        }
    }

    //一个子类继承了一个抽象的父类，那么子类必须重写抽象父类所有抽象成员
    //按住下面的Animal，Alt + shift+ F10 快速实现重写
    class Cat : Animal
    {
        //Bark已经可以理解为是多态了
        public override void Bark()
        {
            Console.WriteLine("喵");
        }

       
    }
    class Dog : Animal
    {

        public override void Bark()
        {
            Console.WriteLine("汪");
        }
    }
    class Pig : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("哼");
        }
    }

}
