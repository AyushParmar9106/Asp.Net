using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Bank_Account
    {
        public int acc_no;
        public string email;
        public string name;
        public string acc_type;
        public double balance;

        public void getdetail()
        {
            Console.WriteLine("enter acc no");
            acc_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter email");
            email = Console.ReadLine();

            Console.WriteLine("enter name");
            name = Console.ReadLine();

            Console.WriteLine("enter type");
            acc_type = Console.ReadLine();

            Console.WriteLine("enter balance");
            balance = Convert.ToDouble(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine(acc_no);
            Console.WriteLine(email);
            Console.WriteLine(name);    
            Console.WriteLine(acc_type);
            Console.WriteLine(balance);
        }

    }
}
