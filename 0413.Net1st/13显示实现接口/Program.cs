using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            I1 i = new Person();
            i.Test();
        }
    }
    class Person:I1
    {
        public void Test()
        {
            Console.WriteLine("Person Test");
        }

        //显示实现接口：告诉编译器，这个才是接口函数
        void I1.Test()
        {
            Console.WriteLine("I1 Test");
        }
    }
    interface I1
    {
        void Test();
    }
}
