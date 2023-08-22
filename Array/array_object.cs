using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Array
{
    public class array_object
    {
        static void Main(string[] args)
        {
            object[] arrobj = new object[4];

            arrobj[0] = 254;
            arrobj[1] = "Sagar";
            arrobj[2] = 60.39;
            arrobj[3] = 94.3433434;

            foreach(object o in arrobj)
            {
                Console.WriteLine(o);
            }
            
        }
    }
}
