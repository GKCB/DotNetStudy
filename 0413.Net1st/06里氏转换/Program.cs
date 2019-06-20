using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //子类可以赋值给父类,声明一个父类指向子类
            Person person = new Student();
            //is as
            if (person is Teacher)
            {
                //是失败的,因为他没有做转换
                ((Teacher)person).TeacherSayHello();
            }
            else
            {
                Console.WriteLine("转换失败");
            }

            //Student s = person as Student;
            //if (s is Student)
            //{
            //    s.StudentSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}

        }
    }

    class Person
    {
        public void PersonSayHello()
        {
            Console.WriteLine("我是Person");
        }
    }

    class Student : Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }

    class Teacher : Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("我是老师");
        }
    }

}
