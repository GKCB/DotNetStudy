using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProOperation
{
    public abstract class Operation
    {
        public int NumerOne { get; set; }
        public int NumerTwo { get; set; }
        public Operation(int n1, int n2)
        {
            this.NumerOne = n1;
            this.NumerTwo = n2;
        }

        //记录子类的计算类型 + - * /
        public abstract string Type
        {
            get; //设置为只读属性
        }

        //获得结果
        public abstract int GetResult();
    }
}
