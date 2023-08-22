using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Method
{
    public class Program
    {
      static void Swap(ref int a ,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args) 
        {
          int a = 100, b = 200;
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
