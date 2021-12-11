using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_NOV26_Class_Object_Employee
{
    class Employee
    {
        public int fieldid;
        public string name;
        public string desgn;
        public Date doj;
        public decimal salary;

        public Employee()
        {
            fieldid = 1;
            name = "Abhi Gayaki";
            desgn = "Manager";
            doj = new Date();
            salary = 20000;
        }

        public Employee(int fieldid, string name, string desgn, int day, int month, int year, decimal salary)
        {
           this.fieldid = fieldid;
            this.name = name;
           this.desgn = desgn;
            doj = new Date(day, month, year);
            this.salary = salary;
        }
        public void show()
            {
            Console.WriteLine("student id: "  +fieldid+" "+name+" "+desgn+" "+salary);
            Console.WriteLine("Date of Joining");
            doj.Display();
        }
         

    }
}
