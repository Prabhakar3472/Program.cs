using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Method
{
    public class Car2
    {
        private string companyname, modelname;
        private int cost;
        //defult parameter
        public Car2(string modelname, int cost, string companyname = "hundai")
        {
            this.modelname = modelname;
            this.cost = cost;
            this.companyname = companyname;
            
        }
        public string Print()
        {
            return $"{companyname}, {modelname},{cost}";

        }


    }
}
