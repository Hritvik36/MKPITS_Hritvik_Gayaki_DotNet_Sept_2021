using System;

namespace C_Object_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj, obj1;
            int x, y; //primitive data type have single value
            x = 10;
            y = 50;
            Employee obj = new Employee();// user degined data type
            obj.ID = 1;          // Employee is U D data type
            obj.firstname = "Hritvik";   // obj and obj1 are it's variable
            obj.lastname = "Gayaki";
            obj.salary = 35000;
            Console.WriteLine(obj.firstname + " " + obj.lastname + " " + obj.salary);
            Console.WriteLine("id is" + obj.ID);
            obj1 = new Employee();
            obj1.ID = 1;
            obj.firstname = "Hritvik";
            obj1.lastname = "Gayaki";
            obj1.salary = 35000;
            Date birthday = new Date();
            birthday.day = 8;
            birthday.month = 7;
            birthday.year = 1987;
            Console.WriteLine("Nilesh's birth day is" + birthday.day + "/" + birthday.month + " " + birthday.year);
        }
}
        }
    }
}
