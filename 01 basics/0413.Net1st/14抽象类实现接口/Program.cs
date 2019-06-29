using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14抽象类实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            I1 i = new PersonSon();
            i.Test();
        }
    }
    abstract class Person:I1
    {
        public void Test()
        {
            Console.WriteLine("抽象类实现接口");
        }
    }
    interface I1
    {
        void Test();
    }

    class PersonSon : Person
    { }

}
