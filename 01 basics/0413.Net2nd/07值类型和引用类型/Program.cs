using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int number = 10;
        //    Test( number);//实参
        //    Console.WriteLine(number);
        //    Console.ReadKey();

            //不管是实参还是形参，在内存中都是开辟了空间的

            //Person zsPerson = new Person();
            //zsPerson.Name = "张三";
            //Person lsPerson = zsPerson;
            //lsPerson.Name = "李四";
            //Console.WriteLine(zsPerson.Name);
            //Console.WriteLine(lsPerson.Name);
            //Console.ReadKey();

            Person zsPerson = new Person();
            zsPerson.Name = "张三";
            Test(zsPerson); //实际上还是传递了地址
            Console.WriteLine(zsPerson.Name);
            Console.ReadKey();

        }

        static void Test(Person p)
        {
            p.Name = "王五"; //原来的“张三”地址被"王五"地址覆盖
            Person p2 = new Person();
            p2.Name = "田七";
            p = p2;         //“王五”地址被“田七”覆盖
        }

     

    }

    class Person
    {
        public string Name { get; set; }
    }
}
