using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Common
{
    public class Person
    {
        public void Write()
        {
            File.WriteAllText("1.txt", "张三李四王五钱六田七");
        }
    }
}
