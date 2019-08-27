using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _06FileStream文件流的操作
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            //文件流资源，GC不会主动释放
            //在using结束时，回收所有using段内的内存
            using (FileStream fsRead = new FileStream(@"../../工资.txt", 
                FileMode.OpenOrCreate,FileAccess.Read))
            {
                byte[] buffer = new byte[1024*1024*5];//这里缓存大小是5M
                //实际读取到的字节
                int r = fsRead.Read(buffer, 0, buffer.Length);
                //数据要先读取到缓冲区里，不是一次性直接存到硬盘里的
                //缓冲区大小要考虑限制
                //Encoding.Default.GetString 可能会出现乱码
                //Encoding.UTF8处理可能出现的乱码
                str = Encoding.UTF8.GetString(buffer, 0, r);

            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
