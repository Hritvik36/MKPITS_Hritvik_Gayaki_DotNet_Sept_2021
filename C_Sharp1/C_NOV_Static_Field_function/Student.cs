using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NOV_Static_Field_function
{
    class Student
    {// autoimplimated properties

        public int ID { get; set; }
        public string Name { get; set; }
        public int Marks { get; set;}
        public static int count { get; set;}
        public Student()
        {
            ID = 1;
            Name = "Hritvik";
            Marks = 85;
            count++; // shared field by all object 
        }
        public Student(int id, string name,int marks)
        {
            ID = id;
            Name = name;
            Marks = marks;
            count++;
        }
        // object method : it is called with object  s1.show()
        public void ShowResult()
        {
            if(Marks >=50)
                Console.WriteLine(Name+ " is  pass");
            else
                Console.WriteLine(Name +" is  fail");
        }
        // static method

        public static void ShowCount()
        {
            Console.WriteLine("Total number of student object ="+count);
        }
    }
}
