using System;

namespace H_NOV26_Class_Object_Medicine
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine obj = new Medicine(1, "omee", "Schedule-H", 50, 10, 6, 2030);
            //  obj.show();
            Console.WriteLine(obj.ToString());
            Console.WriteLine(obj);
           
        }
    }
}
