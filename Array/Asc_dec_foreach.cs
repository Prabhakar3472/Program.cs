using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Array
{
    internal class _Foreach
    {
        static void Main(string[] args)
        {
            int[] arr = { 45, 67, 12, 89, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp;
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }


            }
            Console.WriteLine("asc order");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            for(int i = 0;i < arr.Length;i++) 
            {
              for(int j = i+ 1;j < arr.Length;j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp; 
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("desc order");
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }



        }
    }
}
