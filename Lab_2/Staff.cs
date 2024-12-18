using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Staff
    {
        public string name;
        public string Department;
        public string Designation;
        public string Experience;
        public double salary;

       

        public void Display()
        {
            if (Designation == "hod") {
                Console.WriteLine("name=" + name);
                Console.WriteLine("salary=" + salary);
            }
        }
    }
}
