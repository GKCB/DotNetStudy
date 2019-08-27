using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;//反射 Assembly

namespace _11反射
{
    class Program
    {
        static void Main(string[] args)
        {
            //首先加载程序集文件 需要的是绝对路径
            string path = Path.Combine
                (AppDomain.CurrentDomain.BaseDirectory, "Common.dll");
            //AppDomain.CurrentDomain.BaseDirectory 
            //获取当前exe所在的目录
            Assembly ass =
                Assembly.LoadFile(path);
            Console.WriteLine("加载程序集成功");

            //调用了Person类中默认无参数的构造函数，只能是无参数的
            //object o = ass.CreateInstance("Common.Person"); 
            //Console.WriteLine(o.GetType());

            //获取要创建的数据的类型
            Type t   = ass.GetType("Common.Person");
            object o = Activator.CreateInstance(t,"张三",18);
            //Console.WriteLine(o.GetType());

            //获得数据源的属性数组
            PropertyInfo[] pros = o.GetType().GetProperties();
            foreach(PropertyInfo item in pros)
            {
                Console.WriteLine(item.Name);                
            }
            
            //获得数据源中的方法
            MethodInfo[] md = o.GetType().GetMethods();
            foreach (MethodInfo item in md)
            {
                Console.WriteLine(item);
            }
            MethodInfo mdi = o.GetType().GetMethod("SayHello");
            mdi.Invoke(o,null);


            #region 获得程序集数据的三个函数
            //获得程序集中所有的公开的数据
            //Type[] types = ass.GetExportedTypes();

            //获得程序集中所有的数据 包括公开的和不公开的
            //Type[] types = ass.GetTypes();
            //foreach (Type item in types)
            //{
            //    Console.WriteLine(item.Name);       //类的名字
            //    Console.WriteLine(item.FullName);   //命名空间.Name
            //    Console.WriteLine(item.Namespace);  //命名空间
            //    Console.WriteLine();
            //}

            //Type[] types = ass.GetTypes();//获得所有的元数据，公私都可以
            //Type[] types = ass.GetExportedTypes(); //获得所有的公有的元数据

            //获得指定数据
            //Type t = ass.GetType("Common.Person");
            //Console.WriteLine(t.Name);
            #endregion


        }
    }
}
