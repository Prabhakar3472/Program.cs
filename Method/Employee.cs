using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Method
{
    public class Employee
    {
        protected int id;
        protected string name;
        protected double salary, hra, da, ta, pf, gross;
        private static int count;

        public Employee(int id, string name, double salary)
        {
            count++;
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public virtual void CalculateSalary()
        {
            hra = salary * 0.20;
            da = hra * 0.25;
            ta = da * 0.23;
            pf = ta * 0.12;
            gross = (salary + hra + da + ta) - pf;
        }
        public virtual string Print()
        {
            return $"Employee salary Gross={gross} {id} {name}";
        }

       
        
        
    }
    public class SalesEmployee : Employee
    {
        private double bonus;
        private int commision;

        public SalesEmployee(double bonus,int commission, int id, string name, double salary): base(id,name,salary)
        {
          this.bonus = bonus;
          this.commision = commision;

        }
        public override void CalculateSalary()
        {
            hra = salary *0.20;
            da = hra * 0.25;
            ta = da * 0.23;
            pf = ta * 0.12;
            gross = (salary + hra + da + ta) - pf;
        }
        public override string Print()
        {
            return $"SalesEmployee salary Gross={gross} {id} {name} {bonus} {commision}";
        }
    }
}
