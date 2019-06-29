using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12接口案例
{
    class Program
    {
        static void Main(string[] args)
        {
            //麻雀 会飞 企鹅不会飞 鸵鸟不会飞 鹦鹉会飞 飞机 会飞
            IFly[] flys = { new MaBird(), new YingBird(), new Plane() };

            for (int i = 0; i < flys.Length; i++)
            {
                flys[i].Fly();
            }
        }
    }
    class Bird
    {
        public void CHLSS()
        {
            Console.WriteLine("鸟都会吃喝拉撒睡");
        }
    }
    interface IFly
    {
        void Fly();
    }
    class MaBird : Bird, IFly
    {

        public void Fly()
        {
            Console.WriteLine("麻雀在飞");
        }
    }

    class TuoBird : Bird
    { }

    class YingBird : Bird, IFly
    {

        public void Fly()
        {
            Console.WriteLine("鹦鹉在飞");
        }
    }

    class QQ : Bird
    { }

    class Plane : IFly
    {
        public void Fly()
        {
            Console.WriteLine("飞机在飞");
        }
    }
}
