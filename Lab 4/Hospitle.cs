using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Apollo:Hospitle
    {
        public override void HospitleDetail()
        {
            Console.WriteLine("this is data about Apollo hospitle");
            Console.WriteLine("It's in Rajkot");
            Console.WriteLine("It's private");
        }
    }

    class Wockhardt: Hospitle
    {
        public override void HospitleDetail()
        {
            Console.WriteLine("this is data about Wockhardt hospitle");
            Console.WriteLine("It's in morbi");
            Console.WriteLine("It's Government");
        }
    }

    class Gokul :Hospitle
    {
        public override void HospitleDetail()
        {
            Console.WriteLine("this is data about Wockhardt hospitle");
            Console.WriteLine("It's in russia");
            Console.WriteLine("It's semi Government");
        }
    }

    public class Hospitle
    {
        public virtual void HospitleDetail()
        {
            Console.WriteLine("this is data about hospitle");
        }
    }
}
