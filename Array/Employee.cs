using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Array
{
    
    
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Sallary { get; set; }

        }
    public class Program
    {
        static void Main(string[] args)
        {
            Employee[] list = new Employee[3]
            {
                new Employee { Id = 1, Name = "Karana", Sallary = 2000},
                new Employee { Id = 5, Name = "Rohit", Sallary = 3000},
                new Employee { Id = 6, Name = " Pavan", Sallary = 7000}
            };
            foreach (Employee item in list)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Sallary}");
            }
        }
    }
}       
