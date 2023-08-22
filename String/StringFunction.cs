using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.String
{
    internal class StringFunction
    {
        static void Main(string[] args)
        {
            string message = "  Hello Brother ";
            string message2 = " Good Day";
            Console.WriteLine(message);
            Console.WriteLine(message2);

            string str1 = string.Concat(message, " ", message2.TrimStart());
            Console.WriteLine(str1);
            Console.WriteLine(str1.Trim());

            Console.WriteLine(message2.ToUpper());
            Console.WriteLine(message2.ToLower());

            Console.WriteLine("index -"+message.IndexOf("a"));
            Console.WriteLine("Last index"+message2.LastIndexOf("a"));
        }   
    }
}
