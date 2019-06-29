using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09抽象类特点
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    abstract class Person
    {
        public abstract void SayHello();   
        public abstract void Test();
    }
    class student : Person
    {
        public override void SayHello()
        {
            Console.WriteLine("学生说hello");
        }
        public override void Test()
        {
            throw new NotImplementedException();
        }
    }
}
