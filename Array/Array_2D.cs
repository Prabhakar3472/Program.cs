using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Array
{
    internal class Array_2D
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 5]
            {
                {10,20,30,40,50 },
                {60,70,80,90,100 },
                {110,120,130,140,150 },
                {160,170,180,190,200 }
            };
            for(int row = 0; row < arr.GetLength(0); row++)
            {
                for(int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.WriteLine($"arr[{row},{col}] = {arr[row,col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
