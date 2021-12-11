using System;

namespace C_NOV_Static_Field_function
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
          //  Console.WriteLine("count = " +Student.count);
            Student s2 = new Student(2, "Hritvik", 85);
            Student s3 = new Student(3, "Akash", 75);
            Student s4 = new Student(4, "Nilesh", 65);
            Student s5 = new Student(5, "Roshan", 55);
          //  s1.ShowResult();
          //  Student.ShowCount();
            Student[] students = new Student[5];
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;
            students[3] = s4;
            students[4] = s5;
            Console.WriteLine("result of students is as follows");
            for(int i=0;i<5;i++)
            {
                students[i].ShowResult();
            }
            
         
            
            

        }
    }
}
