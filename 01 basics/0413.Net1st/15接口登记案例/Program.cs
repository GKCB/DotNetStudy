using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15接口登记案例
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person需要登记
            //Hourse房子需要登记
            //汽车也需要登记
            //财产登记
            //这些都是不同的对象，但是却有相同的动作“登记”
            //登记必然是一个接口

            //写一个函数，实现以上物品的登记
            DengJi(new Preson());
            DengJi(new Hourse());
            DengJi(new Car());
            DengJi(new Money());

        }
        static void DengJi(IDengJi dj)
        {
            dj.DengJi();
        }

    }
    interface IDengJi
    {
        void DengJi();
    }
    class Preson : IDengJi
    {

        public void DengJi()
        {
            Console.WriteLine("Person 登记");
        }
    }

    class Hourse : IDengJi
    {

        public void DengJi()
        {
            Console.WriteLine("Hourse 登记");
        }
    }

    class Car : IDengJi
    {
        public void DengJi()
        {
            Console.WriteLine("Car 登记");
        }
    }
    class Money : IDengJi
    {
        public void DengJi()
        {
            Console.WriteLine("Money 登记");
        }
    }
}
