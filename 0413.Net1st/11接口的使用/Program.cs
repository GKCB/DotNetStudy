using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11接口的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            IKouLanable kl = new Student();
            kl.KouLan();
            IKouLanable kl2 = new Teacher();
            kl2.KouLan();
        }
    }
    class Person
    {
        public void CHLSS()
        {
            Console.WriteLine("人类可以吃喝拉撒睡");
        }
    }
    class Student : Person, IKouLanable
    {        
        public void KouLan()
        {
            Console.WriteLine("学生可以扣篮");
        }
    }
    interface IKouLanable
    {
        //接口中的函数啥都不要用
        void KouLan();
    }

    class Teacher : Person, IKouLanable
    {
        public void KouLan()
        {
            Console.WriteLine("老师可以扣篮");
        }
    }


    //由于继承的单根性，学生不可能再继承一个NBAPlayer类。
    //只能用接口
    class NBAPlayer : Person
    {
        public void KouLan()
        {
            Console.WriteLine("NBA球员可以扣篮");
        }
    }
}
