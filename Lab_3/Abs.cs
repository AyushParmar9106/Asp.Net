using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public abstract class SUM 
    {
        public abstract int sumTwo(int a,int b);

        public abstract int sumThree(int a, int b,int c );
    }

    internal class Abs : SUM
    {
       public override int sumTwo(int a,int b)
        {
            return a + b;
        }
        public override int sumThree(int a, int b,int c)
        {
            return a + b + c;
        }
    }
}
