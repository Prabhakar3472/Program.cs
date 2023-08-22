using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Method
{
    abstract public class Shape
    {
        public Shape()
        {

        }

        public abstract string Draw(string name);

        public abstract void Area();
        public string Display()
        {
            return "this is shape class";
        }
    }
    public class Rectangle : Shape
    {
        private int w;
        private int l;
        private double area;

        public Rectangle(int w, int l) 
        {
           this.w = w;
            this.l = l;
        }

        public override void Area()
        {
            area = l * w;
        }

        public override string Draw(string name)
        {
            return name;
        }

        public string Print()
        {
            return $"area of rectangle is {area}";
        }
    }

}
