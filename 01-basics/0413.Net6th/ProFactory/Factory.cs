using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProOperation;
using System.Reflection;
using System.IO;

namespace ProFactory
{
    public class Factory
    {
        public static Operation GetOper(string type, int n1, int n2)
        {
            Operation oper = null;
            //动态获得程序集
            string path = Path.Combine
                (AppDomain.CurrentDomain.BaseDirectory, "Plug");
            //文件夹路径
            //获得PATH路径下所有文件的全路径
            string[] files = Directory.GetFiles(path,"*.dll");
            Assembly ass = Assembly.LoadFile(path);

            return oper;
        }
    }
}
