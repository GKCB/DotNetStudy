using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12键值对集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome, to Chinaworld
            //统计每个字符出现的次数
            //string str = "Welcome, to Chinaworld";
            ////字母--->次数
            ////根据键找到值，所以字符是键，次数是值
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    //空格和逗号，其实都不是需要统计的对象
            //    if (str[i] == ' ' || str[i] == ',')
            //    {
            //        continue;
            //    }
            //    //如果字母在集合的键中是第一次出现
            //    if (!dic.ContainsKey(str[i]))
            //    {
            //        dic.Add(str[i],1);
            //    }
            //    else
            //    {
            //        //之前已经建立了
            //        dic[str[i]]++;
            //    }
            //}

            //foreach (KeyValuePair<char, int> kv in dic)
            //{
            //    Console.WriteLine("字母{0}出现了{1}",kv.Key,kv.Value);
            //}



            Console.ReadKey();
        }
    }
}
