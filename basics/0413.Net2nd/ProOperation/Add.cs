using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProOperation
{
    public class Add:Operation
    {
        //父类里面有显示函数，子类也需要实现
        public Add(int n1, int n2)
            : base(n1, n2)
        { }
        public override int GetResult()
        {
            return this.NumberOne + this.NumberTwo;
        }
    }
}
