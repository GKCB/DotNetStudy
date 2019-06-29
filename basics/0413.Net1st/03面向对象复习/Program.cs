using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03面向对象复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person('男');
            p.Name = "李四";
        }
    }
    class Person
    {
        //字段、属性、函数、构造函数....
        //字段：存储数据
        //属性：保护字段 get set
        //函数：描述对象的行为
        //构造函数：初始化对象，给对象的每个属性进行赋值
        string _name;
        int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Name
        {
            get { return _name; }  //取属性的值
            set { _name = value; } //给属性赋值
        }
        //自动属性，get set 没法写具体的 类似_name之类的内容
        //自动属性，需要使用构造函数来完成
        public char Gender { get; set; }
        //新的构造函数会替换原有的默认构造函数
        public Person(char gender)
        {
            this.Gender = gender;
        }
        public void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
    class People
    {
        public void SayHello() 
        {
            Console.WriteLine("我是人类");
        }
    }
    class Student : People
    {

        public new void SayHello() //使用new隐藏了父类中的SayHello函数
        {
            Console.WriteLine("我是学生");
        }
    }
}
