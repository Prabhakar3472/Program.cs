using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    public class Student_grade
    {
        private int id;
        private string name,grade;
        private double eng, mar, pol, total, per;
        
        public void AcceptStudent(int id, string name, string grade, double eng, double mar, double pol, double total, double per)
        {
            this.id = id;
            this.name = name;
            this.eng = eng;
            this.mar = mar;
            this.pol = pol;
        }
        public void Calculate() 
        {
            total = eng + mar + pol;
            per = total / 3;

        }
        public void Grade()
        {
            if (per >= 90)
            {
                Console.WriteLine("Grade:A");
            }
            else if (per >=75 && per<=89)
            {
                Console.WriteLine("Grade:B");
            }
            else 
            {
                Console.WriteLine("Grade:C");
            }

           
        }
    } //  public string Print() 
      //  {
      //   return $"Student Id={id}, Name={name}, Grade={grade}, percentage={per};
       }
    