using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    public class Date
    {
        private int day, year;
        private string month;


        public Date()
        {
            day = 4;
            year = 2025;
            month = "Sep";
        }

        public Date(int dd, string mm, int yy)
        {
            day = dd;
            month = mm;
            year = yy;

        }
        public string PrintDate()
        {
            return $"Date : {day} / {month} / {year}";
        }
    
}
}
