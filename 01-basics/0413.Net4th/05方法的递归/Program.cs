﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05方法的递归
{
    class Program
    {
        static void Main(string[] args)
        {
            //递归
            TellStroy();
        }
        static int i = 1;
        static void TellStroy()
        {
            Console.WriteLine("从前有座山，山里有座庙");
            Console.WriteLine("庙里有个老和尚和小和尚");
            Console.WriteLine("有一天，老和尚给小和尚讲了一个故事");
            i++;
            if (i >= 5)
            {
                return;
            }
            TellStroy();
            
        }
    }
}
