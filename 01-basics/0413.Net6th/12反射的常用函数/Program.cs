using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12反射的常用函数
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool IsAssignableFrom(Type c)
            bool b;
            //b = typeof(Person).IsAssignableFrom(typeof(Student));
            //Student 类型是否可以赋值给 Person， 可以子类可以赋值给父类

            //b = typeof(Person).IsAssignableFrom(typeof(Teacher));
            //Teacher Person 没啥关系，只能是False

            //bool IsInstanceOfType(object o): 
            //判断对象o是否是当前类的实例（当前类可以是o的类、父类、接口）
            Student s = new Student();
            Person p  = new Person();

            //b = typeof(Person).IsInstanceOfType(s);
            //b = typeof(I1).IsInstanceOfType(s);
            //p.GetType() 和 typeof用途相差不大。只是一个需要实例化
            //b = p.GetType().IsInstanceOfType(s);

            //bool IsSubclassOf(Type c):
            //判断当前类是否是类C的子类。类的事，没有接口的事
            //b = s.GetType().IsSubclassOf(typeof(Person));
            //s是否是Person的子类
            //b = s.GetType().IsSubclassOf(typeof(I1)); //但是没接口什么事

            //IsAbstract 判断是否为抽象的，含接口
            b = typeof(Person).IsAbstract;

            Console.WriteLine(b);            
        }
    }
    class Person
    { }
    class Teacher
    { }
    class Student : Person,I1
    {

        public void Test1()
        {
            
        }
    }
    interface I1
    {
        void Test1();
    }

}
