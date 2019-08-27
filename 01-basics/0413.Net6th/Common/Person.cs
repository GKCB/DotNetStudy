using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Common
{
    public class Person
    {
        public void Write()
        {
            File.WriteAllText("1.txt", "张三李四王五钱六田七");
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age  = age;
        }
        public int Age { get; set; }

        public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine("我是Person类中的函数");
        }
    }
}
