using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Employee emp = new Employee();            
            //Manager m = new Manager();            
            //Programmer p = new Programmer();
            ////emp.DaKa();
            ////m.DaKa();
            ////p.DaKa();

            ////放到数组里，只能放到Employee 父类里面
            //Employee[] emps = { emp, m, p };
            //for (int i = 0; i < emps.Length; i++)
            //{
            //    Console.WriteLine("i is :{0}", i);
            //    //if (emps[i] is Employee)
            //    //{
            //    //    ((Employee)emps[i]).DaKa();
            //    //}
            //    //if (emps[i] is Manager)
            //    //{
            //    //    ((Manager)emps[i]).DaKa();
            //    //}
            //    //if (emps[i] is Programmer)
            //    //{
            //    //    ((Programmer)emps[i]).DaKa();
            //    //}
            //    //上面的太累赘了

            //    emps[i].DaKa();
            //}

            Console.WriteLine("-----------------");
            Employee empP = new Programmer();//new Manager(); //new Employee();
            empP.DaKa();
        }
    }
    class Employee
    {
        public virtual void DaKa()
        {
            Console.WriteLine("员工九点打卡");
        }
        
    }

    class Manager : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("经理11点打卡");
        }
    }
    class Programmer : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("程序员不打卡");
        }
    }
}
