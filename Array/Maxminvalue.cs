using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Array
{
    internal class Maxminvalue
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int m = array[0];
            for(int i = 0; i < array.Length;i++)
            {
                if (array[i] > m)
                {
                    m = array[i];
                }
            }
            Console.WriteLine(m);
            int n = array[0];
            for (int i = 0;i<array.Length;i++)
            {
                if (array[i] < n)
                {
                    n = array[i];
                }
            }
            Console.WriteLine(n);
        }
    }
}
