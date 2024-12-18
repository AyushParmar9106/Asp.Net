using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
 
    internal class Area
    {
        public void printArea()
        {
            Console.WriteLine("this is area of circle");
        }
        public int printArea(int r)
        {
            return(int)Math.PI * r*r;
        }
        public int printArea(int b,int height)
        {
            return (b * height) / 2;
        }

        public double printArea(double l)
        {
            return l * l;
        }
    }
}
