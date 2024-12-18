using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class RBI
    {
        public int principle;
        public double rate;
        public int time;
        public virtual void calculateIntrest(int principle,double rate,int time)
        {
            double intrest = (principle * rate * time) * 0.01;
            Console.WriteLine("this is the interest of rbi bank"+intrest);
        }
    }
    class HDFC :RBI
    {
        public override void calculateIntrest(int principle, double rate, int time)
        {
            double intrest = (principle * rate * time) * 0.01;
            Console.WriteLine("this is the interest of hdfc bank" + intrest);
        }
    }
    class SBI : RBI
    {
        public override void calculateIntrest(int principle, double rate, int time)
        {
            double intrest = (principle * rate * time) * 0.01;
            Console.WriteLine("this is the interest of SBI bank"+intrest);
        }
    }
    class ICICI : RBI
    {
        public override void calculateIntrest(int principle, double rate, int time)
        {
            double intrest = (principle * rate * time) * 0.01;
            Console.WriteLine("this is the interest of icici bank"+intrest);
        }
    }
  
}
