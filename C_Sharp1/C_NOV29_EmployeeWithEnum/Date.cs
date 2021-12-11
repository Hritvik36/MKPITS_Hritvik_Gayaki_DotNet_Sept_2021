using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NOV29_EmployeeWithEnum
{
    class Date
    {// this code is just for understanding of
        int day, month, year; // private field
        //get is special function to retrieve value
        //set is special function to set new value of field (day or month or year)

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        public Date()
        {
            day = 15;
            month = 8;
            year = 1947;
        }
        public Date(int day,int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;

        }
        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }

    }
}
