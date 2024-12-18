using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Add add = new Add();
              Console.WriteLine("Write a NUMBER:");
              int a = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Write a NUMBER:");
              int b= Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("sum of to int is:" + add.add(a, b));

              Console.WriteLine("Write a NUMBER:");
              float c = Convert.ToSingle(Console.ReadLine());
              Console.WriteLine("Write a NUMBER:");
              float d = Convert.ToSingle(Console.ReadLine());
              Console.WriteLine("sum of two float :"+add.add(c, d));*/

            /* Area area = new Area();
             area.printArea();
             Console.WriteLine("circle area:");
             int r =  Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("circle area is:"+area.printArea(r));


             Console.WriteLine("triangle");
             int b = Convert.ToInt32(Console.ReadLine());
             int h = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("triangle area is:" + area.printArea(b,h));

             Console.WriteLine("square");
             double l = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("square area is:" + area.printArea(l));*/

            /*ICICI i = new ICICI();
            SBI s = new SBI();
            HDFC h = new HDFC();
            Console.WriteLine("enter principle");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter rate of change");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter time");
            int t = Convert.ToInt32(Console.ReadLine());   

            i.calculateIntrest(a,r, t);
            s.calculateIntrest(a,r,t);
            h.calculateIntrest(a, r, t);*/

            /*  Hospitle h = new Hospitle();
              Hospitle app0lo = new Apollo();
              Hospitle Wockhardt = new Wockhardt();
              Hospitle Gokul  = new Gokul();

              h.HospitleDetail();
              app0lo.HospitleDetail();
              Wockhardt.HospitleDetail();
              Gokul.HospitleDetail();*/

            Console.WriteLine("enter your balance:");
            double i = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();
            BankAccount b=new BankAccount(name,i);

            Console.WriteLine("How much money you want");
            double m = Convert.ToDouble(Console.ReadLine());

            b.Withdraw(m);
            b.Deposite(m);

        }
    }
}
