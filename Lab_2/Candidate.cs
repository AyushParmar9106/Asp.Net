using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Candidate
    {
        public int id;
        public string name;
        public int age;
        public int Weight;
        public int height;
       
        public void GetDetail()
        {
            Console.WriteLine("enter id:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("enter age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Weight");
            Weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height");
            height = Convert.ToInt32(Console.ReadLine());


        }

        public void Display()
        {
            Console.WriteLine("id="+id);
            Console.WriteLine("name="+name);
            Console.WriteLine("age="+age);
            Console.WriteLine("height="+height);
            Console.WriteLine("Weight="+Weight);
        }
    }
}
