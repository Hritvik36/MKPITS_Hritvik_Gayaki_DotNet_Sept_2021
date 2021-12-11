using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_NOV26_Class_Object_Medicine
{
 
        class Date
        {
            public int day, month, year;

            public Date()  // Default Constructor
            {
                day = 11;
                month = 11;
                year = 2011;
            }
            public Date(int d, int m, int y)
            {
                day = d;
                month = m;
                year = y;
            }
            //public void Display()
            //{
            //    Console.WriteLine(day + "/" + month + "/" + year);
            //}
        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }
    }
}
