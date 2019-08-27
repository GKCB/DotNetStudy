using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //先确定类型
            List<int> list = new List<int>();
            //集合(长度不定)-->数组
            //Count    获取集合中实际包含的元素个数
            //Capcity  获取集合中“能够”包含的元素个数
            //list.Add(1);
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);

            //Add是添加单个元素
            //AddRange是添加集合
            list.Add(100);
            list.AddRange(new int[]{0,1,2,3,4,5,6});
            list.RemoveAll(n=>n>3); //把集合中大于3的数据全部删掉
            Console.WriteLine(list[5]);
            Console.ReadKey();

        }
    }
}
