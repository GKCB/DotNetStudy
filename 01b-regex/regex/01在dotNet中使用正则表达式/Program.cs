using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01在dotNet中使用正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regex.IsMatch();
            //用来判断给定的字符串是否匹配某个正则表达式 
            
            //Regex.Match();
            //用来从给定的字符串中按照正则表达式的要求提取[一个]匹配
            
            //Regex.Matches();
            //用来从给定的字符串中按照正则表达式的要求提取[多个]匹配

            //Regex.Replace();
            //替换所有正则表达式匹配的字符串为另外一个字符串

            //while (true)
            //{
            //    Console.WriteLine("请输入一个字符串：");
            //    string str = Console.ReadLine();
            //    //验证给定的字符串是否为一个合法的邮政编码
            //    bool b = Regex.IsMatch(str,@"^\d{6}$");
            //    Console.WriteLine("是否是个合法的邮政编码：{0}",b);
            //    //但是有问题，只要整个字符串中有一部分能够匹配的上，那就都是TRUE
            //}

            //while (true)
            //{
            //    Console.WriteLine("请用户输入一个10-25之间的数字：");
            //    string n = Console.ReadLine();
            //    bool b = Regex.IsMatch(n, @"^(1[0-9]|2[0-5])$");
            //    Console.WriteLine("是否正确：{0}",b);
            //}

            //验证是否是合法的手机号
            //while (true)
            //{
            //    Console.WriteLine("手机号：");
            //    string num = Console.ReadLine();
            //    Regex.IsMatch(num,@"^1[0-9]{10}$");

            //}

            //while (true)
            //{
            //    Console.WriteLine("请输入：");
            //    string msg = Console.ReadLine();

            //}


            #region 判定一个字符串是不是身份证号码
            //1.长度为15位或者18位的字符串，首位不能是0
            //2.如果是15位，则全部是数字
            //3.如果是18位，则前17位都是数字，末位可能是数字也可能是x
            //while (true)
            //{
            //    Console.WriteLine("请输入身份证号：");
            //    string idNo = Console.ReadLine();
            //    //[1-9]\d{14}
            //    //[1-9]\d{16}[0-9xX]
            //    Console.WriteLine(Regex.IsMatch(idNo,@"^[1-9]\d{14}$"));
            //}

            #endregion

            #region 判定一个字符串是否是合法的邮箱地址
            while (true)
            {
                Console.WriteLine("输入邮箱地址：");
                string email = Console.ReadLine();
                //email12@mail.com
                //注意邮箱里的.要用转义符号
                Console.WriteLine(Regex.IsMatch(email, @"^\w+@\w+\.\w+$"));
            }

            #endregion

        }
    }
}
