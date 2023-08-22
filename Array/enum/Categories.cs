using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Array.Enum
{
    public enum Categories { Furniture=1, Electonics, Cloths,HomeNeeds}
    public class Product
    {
        private int id, price;
        private string name;
        private Categories category;

        public Product(int id, string name, int price, Categories category)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.category = category;
        }

        public override string ToString()
        {
            return $" id= {id} Name= {name} Price={price} Category= {category}";
        }
    }
        public class Program
        {
            static void Main(string[] args)
            {
                Product p1 = new Product(1,"pen", 30, Categories.Furniture);
                Console.WriteLine(p1);
            }
        }
    

}

