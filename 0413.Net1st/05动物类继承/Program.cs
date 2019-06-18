using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05动物类继承
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Animal
    {
        //不确定子类的具体实现,所以应该用抽象函数来实现
        public abstract void Bark()
        {
 
        }
    }
    class Cat : Animal
    {

    }
    class Dog : Animal
    {
    }
    class Pig : Animal
    { 
    }

}
