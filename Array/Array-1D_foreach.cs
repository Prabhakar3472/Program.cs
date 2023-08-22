using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Array
{
    internal class Array_1D_foreach
    {
        static void Main(string[] args)
        {
            int[] arrr = { 1, 2, 3, 4, 5, };
            foreach (int i in arrr) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
