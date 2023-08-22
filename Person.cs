using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
     public class Person
    {
        protected int id;
        protected string name;
        protected long aadharno;
        public Person(int id, string name, long aadharno) 
        {
            this.id = id;
            this.name = name;
            this.aadharno = aadharno;
            
        }

        public virtual string Display()
        {
            return $"{id} {name} {aadharno}";
        }
    }
    public class Patient : Person
    {
        private long pcontact;
       

        public Patient(long pcontact,int id, string name, long aadharno) : base(id,name,aadharno)
        {
            this.pcontact = pcontact;
           
        }

        public override string Display()
        {
            return $"{id} {name} {aadharno} {pcontact}";
        }
    }
} 
