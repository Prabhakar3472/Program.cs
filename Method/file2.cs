using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Method
{
    public partial class Calc
    {
        public int Square(int a)
        {
            SquareRoot(a);
            return a * a;
        }
        partial void SquareRoot(int a)
        {
            Console.WriteLine(Math.Sqrt(a));
        }
    }
}
