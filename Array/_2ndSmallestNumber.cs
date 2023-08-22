using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Array
{
    internal class _2ndSmallestNumber
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int small = array[0];
            int small2 = array[0];
            for(int i = 0; i<array.Length; i++)
            {
                if (array[i] == small)
                {
                    small2 = small;
                    small = array[i];
                }
                if (array[i] > small && array[i] < small2)
                {
                    small2 = array[i];
                }
            }
            Console.WriteLine($"2nd Smallest number is{small2}");
        }
    }
}
