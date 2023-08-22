using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Program.cs
{
    public class Student
    {
        private int rollno;
        private string name;
        private double percentage;

        public int RollNo
        {
            set { rollno = value; }
            get { return rollno; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }
        public string Print()
        {
            return $"Student {rollno} {name} {percentage}";
        }
    }
}