using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Student
    {
         public int enroll_no;
        public string name;
        public int sem;
        public int spi;
        public int cpi;

        public Student(int enroll_no,
        string name,
        int sem,
        int spi,
         int cpi)
        {
            this.name = name;
            this.enroll_no = enroll_no;
            this.sem = sem;
            this.spi = spi;
            this.cpi = cpi;
        }
        public void display()
        {
            Console.WriteLine("name=" + name);
            Console.WriteLine("enroll=" + enroll_no);
            Console.WriteLine("cpi=" + cpi);
            Console.WriteLine("sem=" + sem);
            Console.WriteLine("spi=" +spi);
        }
    }
}
