using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab11.Models
{
    public class Calculate
    {
        public readonly int num1;
        public readonly int num2;
        public readonly string add;
        public readonly string sub;
        public readonly string mult;
        public readonly string div;

        public Calculate(int num1, int num2, string add, string sub, string mult, string div)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.add = add;
            this.sub = sub;
            this.mult = mult;
            this.div = div;
        }
    }
}