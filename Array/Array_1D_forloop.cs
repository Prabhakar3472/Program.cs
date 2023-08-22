using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Array
{
    internal class Array_1D_forloop
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            for(int i = 0; i< names.Length; i++)
            {
                Console.WriteLine("Enter Name");
                names[i] = Console.ReadLine();
            }
            for(int i = 0;i< names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
