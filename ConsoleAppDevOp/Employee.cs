using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDevOp
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Position: {Position}");
        }
    }
}
