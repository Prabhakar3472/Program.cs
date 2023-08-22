using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs.Array
{
    public class EEmploye
    {


        int id;
        string name;
        int salary;

        public EEmploye(int id, string name, int salarry)
        {
            this.id = id;
            this.name = name;
            this.salary = salarry;
        }
        public override string ToString()
        {
            return $" {id} {name} {salary}";
        }
        public class RunEEmp
        {
            static void Main(string[] args)
            {
                EEmploye[] emp = new EEmploye[3];
                for (int i = 0; i < emp.Length; i++)
                {
                    Console.WriteLine("Enter id");
                    int eid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Name");
                    string ename = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter salary");
                    int esalary = Convert.ToInt32(Console.ReadLine());
                    emp[i] = new EEmploye(eid, ename, esalary);
                    if (esalary > 6930)
                    {
                        Console.WriteLine(emp[1]);
                    }
                }
            }
        }
    }
}
