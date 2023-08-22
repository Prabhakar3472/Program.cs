using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Array
{
    internal class Array_2D_foreach
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4]
            {
               {10,20,30,40 },
                {50,60,70,80 },
               { 90,100,110,120}
                
            };
            foreach (var i in arr) 
            {
              Console.WriteLine(i);
            }  
        }
    }
}
