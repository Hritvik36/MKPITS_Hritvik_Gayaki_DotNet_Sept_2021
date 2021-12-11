using System;

namespace C_NOV29_EmployeeWithEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date();
            //d1.Day = 29; if set is not written the property is read only
            //and this statement is not allowed
           
            Console.WriteLine(d1.Day); // 15 day has been display

            Employee e1 = new Employee(101, "Hritvik", 500000, Department.IT, d1);
            Console.WriteLine(e1);
        }
    }
}
