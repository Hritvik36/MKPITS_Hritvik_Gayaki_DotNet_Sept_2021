using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NOV29_EmployeeWithEnum
{enum Department {HR,IT,ACCOUNT,CIVILE,PRODUCTION,ELECTRICAL};
    class Employee
    {
        int id;
        readonly string name;
        Department department;
        decimal salary;
        Date doj;

        public int Id { get => id; set => id = value; }
        public Department Department { get => department; set => department = value; }
        public decimal Salary { get => salary; set => salary = value; }
        internal Date Doj { get => doj; set => doj = value; } 

            public Employee ()
        {
            id = 1;
            name = "employee of MKPITS";
            salary =60000;
            department = Department.HR;
            doj = new Date();
        }
        public Employee(int id,string name,decimal salary,Department department,Date doj)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.department = department;
            this.doj = doj;

        }
        public override string ToString()
        {
            return "Employee Details;" + id + " " + name + "" + salary + "" + department + " " + doj;
        }

    }
}
