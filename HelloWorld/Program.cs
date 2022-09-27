using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HEllo World");
            Emp emp = new Emp { ID = 20, Name = "tom", salary = 4000 };
            Console.WriteLine("EmployeeDetails");
        }
    }
}
