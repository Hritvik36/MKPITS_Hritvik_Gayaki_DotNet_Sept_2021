using System;
using System.Collections.Generic;
using System.Text;

namespace C_nov26_object_methods
{
    class Date
    {
        public int day, month, year;
        public Date() // default function
        {
            day = 10;
            month = 6;
            year = 1998;
                }
        public Date(int d,int m, int y) // parameterised constructor, value of d,m,y are coming from main function
        {
            day = d;
            month = m;
            year = y;

        }
        public void Display( )
        {
            Console.WriteLine(day+"-"+ month +"-"+ year);
        }
           
    
    }
}
