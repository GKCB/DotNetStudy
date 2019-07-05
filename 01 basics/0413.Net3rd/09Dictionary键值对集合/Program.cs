using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09Dictionary键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "张三");
            //dic.Add(2, "李四");
            //dic.Add(3, "王五");
            //dic.Add(4, "赵六");
            ////键值对集合中的键必须是唯一的
            ////dic.Add(4, "田七");
            ////键值对集合中的值是可以重复的
            //dic.Add(5,"王五");

            //可以给键值对集合中的某一个值进行重新复制
            //dic[4] = "田七";
            //键值对集合常用函数
            //判断集合中是否已经包含某一个键
            //if (!dic.ContainsKey(3))
            //{
            //    dic.Add(3, "玩狗蛋儿");
            //}
            //else 
            //{
            //    dic[3] = "王狗蛋儿";
            //}
            //Console.WriteLine(dic[3]);//整体代表的就是值

            //使用foreach循环，通过遍历键值对的形式对键值对集合进行遍历
            //第一种遍历方式：遍历集合中的键
            //foreach (int item in dic.Keys)
            //{
            //    Console.WriteLine("1 键---{0}   值---{1}", item, dic[item]);
            //}

            //第二种遍历方式：遍历集合中的键值对
            //foreach (KeyValuePair<int,string> kv in dic)
            //{
            //    Console.WriteLine("2 键---{0}  值---{1}", kv.Key,kv.Value);
            //}



            Console.ReadKey();
        }
    }
}
