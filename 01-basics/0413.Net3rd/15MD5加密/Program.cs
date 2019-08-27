using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace _15MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //用户名：张三abc 密码：abc123
            //但是密码不可能用明文
            string str = "123";
            //202cb962ac59075b964b07152d234b70
            //202cb962ac59075b964b07152d234b70
            string md5Str = GetMd5(str);
            Console.WriteLine(md5Str);
            Console.ReadKey();
        }
        static string GetMd5(string str)
        {
            MD5 md5 = MD5.Create();
            //ComputeHash需要的参数是bytes
            //使用Encoding.Default.GetBytes进行转换
            byte[] buffer = Encoding.Default.GetBytes(str);
            //加密
            byte[] bufferMd5 = md5.ComputeHash(buffer);
            //但是又需要返回字符串
            //string result = Encoding.Default.GetString(bufferMd5);            
            //return result;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bufferMd5.Length; i++)
            {
                sb.Append(bufferMd5[i].ToString("x2"));
                //"x"表示将10进制转成16进制 2表示每次都是两位数
            }
            return sb.ToString();
        }
    }
}
