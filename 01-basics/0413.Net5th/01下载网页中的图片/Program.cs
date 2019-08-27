using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;

namespace _01下载网页中的图片
{
    class Program
    {
        static void Main(string[] args)
        {
            //检测网页： https://mall.autohome.com.cn/list/0-110100-0-0-0-0-0-0-0-1.html?prefix=%E5%90%89%E5%88%A9%E6%B1%BD%E8%BD%A6&isSearch=1#pvareaid=2018496
            WebClient web = new WebClient();
            //DownloadString  默认中文编码
            //DownloadData返回字节数组 UTF-8可以使用
            string html = web.DownloadString("https://mall.autohome.com.cn/list/0-110100-0-0-0-0-0-0-0-1.html?prefix=%E5%90%89%E5%88%A9%E6%B1%BD%E8%BD%A6&isSearch=1#pvareaid=2018496");
            MatchCollection mc = Regex.Matches(html, @"<img.+?(?<picSrc>//car\d\..+?\.jpg)");
            //本身靠 <img.+?//car\d\..+?\.jpg 就可以把它们提取出来
            //?<picSrc>这里表示给它一个组名
            int i = 0;
            foreach(Match item in mc)
            {
                if (item.Success)
                {
                    i++;
                    //Console.WriteLine(item.Value);
                    Console.WriteLine(item.Groups["picSrc"].Value);
                    //获得源路径
                    string src = item.Groups["picSrc"].Value;
                    //下载到电脑上
                    string target = @"../../" + i +".jpg";
                    //开始下载
                    web.DownloadFile(@"http:" + src, target);
                    //注意原来的网页中http部分被截取了。这里需要补上。
                }                
            }
            Console.WriteLine("下载成功");


        }
    }
}
