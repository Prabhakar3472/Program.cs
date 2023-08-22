using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Array.Override
{
    public class Product
    {
        private int id, price;
        private string name;

        public Product(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public string Print()
        {
            return $" Id = {id} {name} {price}";
        }

        public override string ToString()
        {
            return $"Id= {id} Name= {name} Price= {price}";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "Pen" ,10);
            Console.WriteLine( p1.ToString());
        }
    }
}
