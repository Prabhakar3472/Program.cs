﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Array
{
    internal class J_array
    {
        static void Main(string[] args)
        {
            int[][] jarray= new int[4][];

            jarray[0] = new int[4];
            jarray[1] = new int[3];
            jarray[2] = new int[2];
            jarray[3] = new int[1];

            for(int row = 0; row < jarray.Length; row++)
            {
                for(int col = 0; col < jarray[row].Length; col++)
                {
                    Console.WriteLine(" enter the element ");
                    jarray[row][col] = Convert.ToInt32(Console.ReadLine());
                }
                
            }
            for(int row = 0;row < jarray.Length; row++) 
            {
                for (int col = 0;col < jarray[row].Length;col++)
                {
                    Console.Write(jarray[row][col]+" ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
