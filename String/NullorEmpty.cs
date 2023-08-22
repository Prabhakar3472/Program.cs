using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.String
{
    internal class NullorEmpty
    {
        static void Main(string[] args)
        {
            string str = " ";

            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("string is empty");
            }
            Console.WriteLine(str);


            Console.WriteLine("Enter a Number");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name is reqired");
            }
            else
            {
                Console.WriteLine("Hello"+name);    
            }
        }

        
    }
}
